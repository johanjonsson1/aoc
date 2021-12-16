namespace AoC2018;

/*
--- Day 6: Chronal Coordinates ---
The device on your wrist beeps several times, and once again you feel like you're falling.

"Situation critical," the device announces. "Destination indeterminate. 
Chronal interference detected. Please specify new target coordinates."

The device then produces a list of coordinates (your puzzle input). Are they places it thinks are safe or dangerous? 
It recommends you check manual page 729. The Elves did not give you a manual.

If they're dangerous, maybe you can minimize the danger by finding the coordinate that gives the largest distance from the other points.

Using only the Manhattan distance, determine the area around each coordinate by counting the number of integer X,Y locations that are closest to that coordinate (and aren't tied in distance to any other coordinate).

Your goal is to find the size of the largest area that isn't infinite.
For example, consider the following list of coordinates:

1, 1
1, 6
8, 3
3, 4
5, 5
8, 9
If we name these coordinates A through F, we can draw them on a grid, putting 0,0 at the top left:

..........
.A........
..........
........C.
...D......
.....E....
.B........
..........
..........
........F.
This view is partial - the actual grid extends infinitely in all directions. 
Using the Manhattan distance, each location's closest coordinate can be determined, shown here in lowercase:

aaaaa.cccc
aAaaa.cccc
aaaddecccc
aadddeccCc
..dDdeeccc
bb.deEeecc
bBb.eeee..
bbb.eeefff
bbb.eeffff
bbb.ffffFf
Locations shown as . are equally far from two or more coordinates, and so they don't count as being closest to any.

In this example, the areas of coordinates A, B, C, and F are infinite - while not shown here, their areas extend forever outside the visible grid. 
However, the areas of coordinates D and E are finite: D is closest to 9 locations, and E is closest to 17 (both including the coordinate's location itself). 
Therefore, in this example, the size of the largest area is 17.

What is the size of the largest area that isn't infinite?

Your puzzle answer was 3909.

--- Part Two ---
On the other hand, if the coordinates are safe, maybe the best you can do is try to find a region near as many coordinates as possible.

For example, suppose you want the sum of the Manhattan distance to all of the coordinates to be less than 32. 
For each location, add up the distances to all of the given coordinates; 
if the total of those distances is less than 32, that location is within the desired region. 
Using the same coordinates as above, the resulting region looks like this:

..........
.A........
..........
...###..C.
..#D###...
..###E#...
.B.###....
..........
..........
........F.
In particular, consider the highlighted location 4,3 located at the top middle of the region. 
Its calculation is as follows, where abs() is the absolute value function:

Distance to coordinate A: abs(4-1) + abs(3-1) =  5
Distance to coordinate B: abs(4-1) + abs(3-6) =  6
Distance to coordinate C: abs(4-8) + abs(3-3) =  4
Distance to coordinate D: abs(4-3) + abs(3-4) =  2
Distance to coordinate E: abs(4-5) + abs(3-5) =  3
Distance to coordinate F: abs(4-8) + abs(3-9) = 10
Total distance: 5 + 6 + 4 + 2 + 3 + 10 = 30
Because the total distance to all coordinates (30) is less than 32, the location is within the region.

This region, which also includes coordinates D and E, has a total size of 16.

Your actual region will need to be much larger than this example, though, instead including all locations with a total distance of less than 10000.

What is the size of the region containing all locations which have a total distance to all given coordinates of less than 10000?

Your puzzle answer was 36238.
 */
public class Day6 : Day
{
    public override string Title => "2018 - Day 6: Chronal Coordinates";

    public int MinX;
    public int MinY;
    public int MaxX;
    public int MaxY;
    public List<RealPoint> RealPoints = new List<RealPoint>();
    public List<RealPoint> PointsOrderedX = new List<RealPoint>();
    public List<RealPoint> PointsOrderedY = new List<RealPoint>();
    public List<Point> Grid = new List<Point>();
    public PointEqualityComparer Comparer = new PointEqualityComparer();
    public static object Lock = new object();
    public List<Point> PointsWithinDistance = new List<Point>();
    private const int Limit = 10000; //32

    public override void PartOne()
    {
        base.PartOne();
        return;
        PopulatePoints();

        foreach (var p in Grid)
        {
            var expandIndex = 0;
            while (true)
            {
                if (expandIndex == 0)
                {
                    var realPoint = RealPoints.FirstOrDefault(x => x.Equals(p));
                    if (realPoint == null)
                    {
                        expandIndex++;
                        continue;
                    }

                    AddToArea(realPoint, p);
                    break;
                }

                var borderPointsToCheck = new List<Point>();

                // upper right corner
                var yStart = p.Y - expandIndex;
                var xStart = p.X;
                while (yStart < p.Y)
                {
                    borderPointsToCheck.Add(new Point(xStart, yStart));
                    xStart++;
                    yStart++;
                }

                // lower right corner
                xStart = p.X + expandIndex;
                yStart = p.Y;
                while (xStart > p.X)
                {
                    borderPointsToCheck.Add(new Point(xStart, yStart));
                    xStart--;
                    yStart++;
                }

                // lower left corner
                yStart = p.Y + expandIndex;
                xStart = p.X;
                while (yStart > p.Y)
                {
                    borderPointsToCheck.Add(new Point(xStart, yStart));
                    xStart--;
                    yStart--;
                }

                // upper left corner
                xStart = p.X - expandIndex;
                yStart = p.Y;
                while (xStart < p.X)
                {
                    borderPointsToCheck.Add(new Point(xStart, yStart));
                    xStart++;
                    yStart--;
                }

                var matches = (from bp in borderPointsToCheck
                    join rp in RealPoints on new { bp.X, bp.Y } equals new { rp.X, rp.Y }
                    select rp).ToList();

                if (matches.Count == 1)
                {
                    AddToArea(matches.First(), p);
                    break;
                }
                else if (matches.Count > 1)
                {
                    foreach (var item in matches)
                    {
                        item.CollidingArea.Add(p);
                    }

                    break;
                }

                expandIndex++;
            }
        }

        var result = RealPoints.Where(x => x.Infinite == false).OrderByDescending(o => o.Area.Count).ToList();

        Console.WriteLine(result.First().Area.Count); // 3909
    }

    public override void PartTwo()
    {
        base.PartTwo();
        PopulatePoints();

        Parallel.ForEach(Grid, p =>
        {
            if (AllWithinDistance(p, RealPoints))
            {
                AddPoint(p);
            }
        });

        Console.WriteLine(PointsWithinDistance.Count); // 36238
    }

    private void AddToArea(RealPoint rp, Point p)
    {
        rp.Area.Add(p);

        if (p.X >= MaxX || p.X <= MinX || p.Y >= MaxY || p.Y <= MinY)
        {
            rp.Infinite = true;
        }
        else if (rp.X == MaxX || rp.X == MinX || rp.Y == MaxY || rp.Y == MinY)
        {
            rp.Infinite = true;
        }
    }

    private void PopulatePoints()
    {
        var counter = 0;
        foreach (var line in Inputs.Day6.ToStringList())
        {
            var arr = line.SplitAsIntsBy(',');
            var x = arr[0];
            var y = arr[1];
            RealPoints.Add(new RealPoint(++counter, x, y));
        }

        PointsOrderedX = RealPoints.OrderByDescending(o => o.X).ToList();
        PointsOrderedY = RealPoints.OrderByDescending(o => o.Y).ToList();
        MinX = PointsOrderedX.Last().X;
        MinY = PointsOrderedY.Last().Y;
        MaxX = PointsOrderedX.First().X;
        MaxY = PointsOrderedY.First().Y;

        for (var x = MinX; x < MaxX; x++)
        {
            for (var y = MinY; y < MaxY; y++)
            {
                Grid.Add(new Point(x, y));
            }
        }
    }

    private bool AllWithinDistance(Point p, List<RealPoint> realPoints)
    {
        var totalDistance = 0;

        foreach (var rp in realPoints)
        {
            totalDistance += Math.Abs(p.X - rp.X) + Math.Abs(p.Y - rp.Y);
            if (totalDistance >= Limit)
            {
                return false;
            }
        }

        return true;
    }

    public void AddPoint(Point point)
    {
        lock (Lock)
        {
            PointsWithinDistance.Add(point);
        }
    }
}

public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object obj)
    {
        var point = obj as Point;
        return point != null &&
               X == point.X &&
               Y == point.Y;
    }
}

public class RealPoint : Point
{
    public int Id;
    public HashSet<Point> Area = new HashSet<Point>(new PointEqualityComparer());
    public List<Point> CollidingArea = new List<Point>();
    public bool Infinite = false;

    public RealPoint(int id, int x, int y) : base(x, y)
    {
        Id = id;
        //Area.Add(new Point(x, y));
    }
}

public class PointEqualityComparer : IEqualityComparer<Point>
{
    public bool Equals(Point b1, Point b2)
    {
        if (b2 == null && b1 == null)
            return true;
        else if (b1 == null || b2 == null)
            return false;
        else if (b1.X == b2.X && b1.Y == b2.Y)
            return true;
        else
            return false;
    }

    public int GetHashCode(Point bx)
    {
        var hCode = bx.X ^ bx.Y;
        return hCode.GetHashCode();
    }
}