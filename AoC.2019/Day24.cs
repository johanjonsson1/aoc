namespace AoC2019;
/*
--- Day 24: Planet of Discord ---
You land on Eris, your last stop before reaching Santa. As soon as you do, your sensors start picking up strange life forms moving around: Eris is infested with bugs! With an over 24-hour roundtrip for messages between you and Earth, you'll have to deal with this problem on your own.

Eris isn't a very large place; a scan of the entire area fits into a 5x5 grid (your puzzle input). The scan shows bugs (#) and empty spaces (.).

Each minute, The bugs live and die based on the number of bugs in the four adjacent tiles:

A bug dies (becoming an empty space) unless there is exactly one bug adjacent to it.
An empty space becomes infested with a bug if exactly one or two bugs are adjacent to it.
Otherwise, a bug or empty space remains the same. (Tiles on the edges of the grid have fewer than four adjacent tiles; the missing tiles count as empty space.) This process happens in every location simultaneously; that is, within the same minute, the number of adjacent bugs is counted for every tile first, and then the tiles are updated.

Here are the first few minutes of an example scenario:

Initial state:
....#
#..#.
#..##
..#..
#....

After 1 minute:
#..#.
####.
###.#
##.##
.##..

After 2 minutes:
#####
....#
....#
...#.
#.###

After 3 minutes:
#....
####.
...##
#.##.
.##.#

After 4 minutes:
####.
....#
##..#
.....
##...
To understand the nature of the bugs, watch for the first time a layout of bugs and empty spaces matches any previous layout. In the example above, the first layout to appear twice is:

.....
.....
.....
#....
.#...
To calculate the biodiversity rating for this layout, consider each tile left-to-right in the top row, then left-to-right in the second row, and so on. Each of these tiles is worth biodiversity points equal to increasing powers of two: 1, 2, 4, 8, 16, 32, and so on. Add up the biodiversity points for tiles with bugs; in this example, the 16th tile (32768 points) and 22nd tile (2097152 points) have bugs, a total biodiversity rating of 2129920.

What is the biodiversity rating for the first layout that appears twice?

Your puzzle answer was 17863741.

--- Part Two ---
After careful analysis, one thing is certain: you have no idea where all these bugs are coming from.

Then, you remember: Eris is an old Plutonian settlement! Clearly, the bugs are coming from recursively-folded space.

This 5x5 grid is only one level in an infinite number of recursion levels. The tile in the middle of the grid is actually another 5x5 grid, the grid in your scan is contained as the middle tile of a larger 5x5 grid, and so on. Two levels of grids look like this:

     |     |         |     |     
     |     |         |     |     
     |     |         |     |     
-----+-----+---------+-----+-----
     |     |         |     |     
     |     |         |     |     
     |     |         |     |     
-----+-----+---------+-----+-----
     |     | | | | | |     |     
     |     |-+-+-+-+-|     |     
     |     | | | | | |     |     
     |     |-+-+-+-+-|     |     
     |     | | |?| | |     |     
     |     |-+-+-+-+-|     |     
     |     | | | | | |     |     
     |     |-+-+-+-+-|     |     
     |     | | | | | |     |     
-----+-----+---------+-----+-----
     |     |         |     |     
     |     |         |     |     
     |     |         |     |     
-----+-----+---------+-----+-----
     |     |         |     |     
     |     |         |     |     
     |     |         |     |     
(To save space, some of the tiles are not drawn to scale.) Remember, this is only a small part of the infinitely recursive grid; there is a 5x5 grid that contains this diagram, and a 5x5 grid that contains that one, and so on. Also, the ? in the diagram contains another 5x5 grid, which itself contains another 5x5 grid, and so on.

The scan you took (your puzzle input) shows where the bugs are on a single level of this structure. The middle tile of your scan is empty to accommodate the recursive grids within it. Initially, no other levels contain bugs.

Tiles still count as adjacent if they are directly up, down, left, or right of a given tile. Some tiles have adjacent tiles at a recursion level above or below its own level. For example:

     |     |         |     |     
  1  |  2  |    3    |  4  |  5  
     |     |         |     |     
-----+-----+---------+-----+-----
     |     |         |     |     
  6  |  7  |    8    |  9  |  10 
     |     |         |     |     
-----+-----+---------+-----+-----
     |     |A|B|C|D|E|     |     
     |     |-+-+-+-+-|     |     
     |     |F|G|H|I|J|     |     
     |     |-+-+-+-+-|     |     
 11  | 12  |K|L|?|N|O|  14 |  15 
     |     |-+-+-+-+-|     |     
     |     |P|Q|R|S|T|     |     
     |     |-+-+-+-+-|     |     
     |     |U|V|W|X|Y|     |     
-----+-----+---------+-----+-----
     |     |         |     |     
 16  | 17  |    18   |  19 |  20 
     |     |         |     |     
-----+-----+---------+-----+-----
     |     |         |     |     
 21  | 22  |    23   |  24 |  25 
     |     |         |     |     
Tile 19 has four adjacent tiles: 14, 18, 20, and 24.
Tile G has four adjacent tiles: B, F, H, and L.
Tile D has four adjacent tiles: 8, C, E, and I.
Tile E has four adjacent tiles: 8, D, 14, and J.
Tile 14 has eight adjacent tiles: 9, E, J, O, T, Y, 15, and 19.
Tile N has eight adjacent tiles: I, O, S, and five tiles within the sub-grid marked ?.
The rules about bugs living and dying are the same as before.

For example, consider the same initial state as above:

....#
#..#.
#.?##
..#..
#....
The center tile is drawn as ? to indicate the next recursive grid. Call this level 0; the grid within this one is level 1, and the grid that contains this one is level -1. Then, after ten minutes, the grid at each level would look like this:

Depth -5:
..#..
.#.#.
..?.#
.#.#.
..#..

Depth -4:
...#.
...##
..?..
...##
...#.

Depth -3:
#.#..
.#...
..?..
.#...
#.#..

Depth -2:
.#.##
....#
..?.#
...##
.###.

Depth -1:
#..##
...##
..?..
...#.
.####

Depth 0:
.#...
.#.##
.#?..
.....
.....

Depth 1:
.##..
#..##
..?.#
##.##
#####

Depth 2:
###..
##.#.
#.?..
.#.##
#.#..

Depth 3:
..###
.....
#.?..
#....
#...#

Depth 4:
.###.
#..#.
#.?..
##.#.
.....

Depth 5:
####.
#..#.
#.?#.
####.
.....
In this example, after 10 minutes, a total of 99 bugs are present.

Starting with your scan, how many bugs are present after 200 minutes?

Your puzzle answer was 2029.
*/

public class Day24 : Day
{
    public override string Title => "--- Day 24: Planet of Discord ---";

    public override void PartOne()
    {
        base.PartOne();
        var input = Inputs.Day24.ToStringList();
        //            input = @"....#
        //#..#.
        //#..##
        //..#..
        //#....".ToStringList();

        var grid = new List<Bug>();
        var states = new List<long>();

        for (var y = 0; y < input.Count; y++)
        {
            for (var x = 0; x < input[0].Length; x++)
            {
                if (input[y][x] == '#')
                {
                    grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = true });
                    continue;
                }

                grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = false });
            }
        }

        Print(grid);

        for (var minute = 0; minute < 1000; minute++)
        {
            grid.ForEach(g => g.Explore(grid));
            grid.ForEach(g => g.Act());

            var currentState = CalculateBiodiversityRating(grid);

            if (states.Contains(currentState))
            {
                Console.WriteLine("Minute " + minute + ", Found match " + currentState);
                break;
            }

            states.Add(currentState);
        }

        Console.WriteLine();
    }

    private long CalculateBiodiversityRating(List<Bug> bugs)
    {
        var sum = 0;
        var ratingEnumerator = GetPowersOfTwo().GetEnumerator();

        foreach (var bug in bugs)
        {
            ratingEnumerator.MoveNext();
            var currentRating = ratingEnumerator.Current;

            if (bug.IsAlive)
            {
                sum += currentRating;
            }
        }

        return sum;
    }

    private IEnumerable<int> GetPowersOfTwo()
    {
        var start = 1;
        yield return start;

        while (true)
        {
            yield return start *= 2;
        }
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Inputs.Day24.ToStringList();
        input = @"..#.#
.#.##
..?#.
...##
#.###".ToStringList();

        var masterGrid = new List<Bug>();

        for (var y = 0; y < input.Count; y++)
        {
            for (var x = 0; x < input[0].Length; x++)
            {
                if (input[y][x] == '#')
                {
                    masterGrid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = true });
                    continue;
                }
                else if (input[y][x] == '?')
                {
                    masterGrid.Add(new Bug { Coordinate = new Coordinate(x, y), IsRecursionLevel = true });
                    continue;
                }

                masterGrid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = false });
            }
        }

        var master = new Bugs(masterGrid);
        master.Id = 0;
        var layersBelow = new List<Bugs>();
        var layersAbove = new List<Bugs>();

        //below hack
        var id = -1;
        for (var i = 0; i < 100; i++)
        {
            var currentLayer = new Bugs(Day24.CreateEmptyLayer());
            currentLayer.Id = id;
            Bugs layerAbove;
            if (i == 0)
            {
                layerAbove = master;
            }
            else
            {
                layerAbove = layersBelow[i - 1];
            }

            currentLayer.Above = layerAbove;
            layerAbove.Below = currentLayer;

            layersBelow.Add(currentLayer);
            id--;
        }

        //above hack
        id = 1;
        for (var i = 0; i < 100; i++)
        {
            var currentLayer = new Bugs(Day24.CreateEmptyLayer());
            currentLayer.Id = id;
            Bugs layerBelow;
            if (i == 0)
            {
                layerBelow = master;
            }
            else
            {
                layerBelow = layersAbove[i - 1];
            }

            currentLayer.Below = layerBelow;
            layerBelow.Above = currentLayer;

            layersAbove.Add(currentLayer);
            id++;
        }

        var all = new List<Bugs>();
        all.Add(master);
        all.AddRange(layersBelow);
        all.AddRange(layersAbove);

        for (var minute = 0; minute < 200; minute++)
        {
            all.ForEach(a => a.ExploreDeep());
            all.ForEach(a => a.ActDeep());

            var res = all.Sum(s => s.PresentBugs);
            Console.WriteLine(res);
        }

        Console.WriteLine();
    }

    public static void Print(List<Bug> bugs)
    {
        var locations = bugs;
        var maxY = locations.Max(x => x.Coordinate.Y);
        var maxX = locations.Max(x => x.Coordinate.X);

        Console.WriteLine();
        for (var i = 0; i <= maxY; i++)
        {
            for (var j = 0; j <= maxX; j++)
            {
                var bug = bugs.First(f => f.Coordinate.Y == i && f.Coordinate.X == j);

                if (bug.IsAlive)
                {
                    Console.Write('#');
                    continue;
                }

                Console.Write('.');
            }

            Console.WriteLine();
        }
    }

    public static List<Bug> CreateEmptyLayer()
    {
        var cheatInput = @".....
.....
..?..
.....
.....".ToStringList();

        var grid = new List<Bug>();

        for (var y = 0; y < cheatInput.Count; y++)
        {
            for (var x = 0; x < cheatInput[0].Length; x++)
            {
                if (cheatInput[y][x] == '#')
                {
                    grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = true });
                    continue;
                }

                if (cheatInput[y][x] == '?')
                {
                    grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsRecursionLevel = true });
                    continue;
                }

                grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = false });
            }
        }

        return grid;
    }
}

public class Bugs
{
    public int Id;
    public List<Bug> MyBugs;
    public Bugs Above;
    public Bugs Below;

    public int PresentBugs => MyBugs.Count(b => b.IsAlive);

    public Bugs(List<Bug> bugs)
    {
        MyBugs = bugs;
    }

    public void ExploreDeep()
    {
        MyBugs.ForEach(g => g.ExploreDeep(MyBugs, Below?.MyBugs, Above?.MyBugs));
    }

    public void ActDeep()
    {
        MyBugs.ForEach(g => g.Act());
    }

    public override string ToString()
    {
        return Id.ToString();
    }
}

public class Bug
{
    public Coordinate Coordinate;
    public bool IsAlive = false;
    public int CurrentAdjacent;
    public bool IsRecursionLevel = false;

    public void Explore(List<Bug> bugs)
    {
        CurrentAdjacent = bugs.Count(x => Coordinate.IsAdjacent(x.Coordinate) && x.IsAlive);
    }

    public void ExploreDeep(List<Bug> bugs, List<Bug> below, List<Bug> above)
    {
        if (IsRecursionLevel)
        {
            return;
        }

        var adjacent = bugs.Where(x => Coordinate.IsAdjacent(x.Coordinate)).ToList();
        var belowCount = CountBelow(below, adjacent);
        var aboveCount = CountAbove(above);

        CurrentAdjacent = adjacent.Count(x => x.IsAlive) + belowCount + aboveCount;
    }


    private int CountAbove(List<Bug> above)
    {
        if (above == null)
        {
            return 0;
        }

        var nextAdjacent = 0;

        // corners..
        if (Coordinate.X == 0 && Coordinate.Y == 0) // upper left
        {
            nextAdjacent = above.Count(x =>
                ((x.Coordinate.X == 1 && x.Coordinate.Y == 2) ||
                 (x.Coordinate.X == 2 && x.Coordinate.Y == 1))
                && x.IsAlive);
        }
        else if (Coordinate.X == 4 && Coordinate.Y == 0) // upper right
        {
            nextAdjacent = above.Count(x =>
                ((x.Coordinate.X == 3 && x.Coordinate.Y == 2) ||
                 (x.Coordinate.X == 2 && x.Coordinate.Y == 1))
                && x.IsAlive);
        }
        else if (Coordinate.X == 0 && Coordinate.Y == 4) // lower left
        {
            nextAdjacent = above.Count(x =>
                ((x.Coordinate.X == 1 && x.Coordinate.Y == 2) ||
                 (x.Coordinate.X == 2 && x.Coordinate.Y == 3))
                && x.IsAlive);
        }
        else if (Coordinate.X == 4 && Coordinate.Y == 4) // lower right
        {
            nextAdjacent = above.Count(x =>
                ((x.Coordinate.X == 3 && x.Coordinate.Y == 2) ||
                 (x.Coordinate.X == 2 && x.Coordinate.Y == 3))
                && x.IsAlive);
        }
        //others
        else if (Coordinate.X == 0)
        {
            nextAdjacent = above.Count(x => x.Coordinate.X == 1 && x.Coordinate.Y == 2 && x.IsAlive);
        }
        else if (Coordinate.X == 4)
        {
            nextAdjacent = above.Count(x => x.Coordinate.X == 3 && x.Coordinate.Y == 2 && x.IsAlive);
        }
        else if (Coordinate.Y == 0)
        {
            nextAdjacent = above.Count(x => x.Coordinate.X == 2 && x.Coordinate.Y == 1 && x.IsAlive);
        }
        else if (Coordinate.Y == 4)
        {
            nextAdjacent = above.Count(x => x.Coordinate.X == 2 && x.Coordinate.Y == 3 && x.IsAlive);
        }

        return nextAdjacent;
    }

    private int CountBelow(List<Bug> below, List<Bug> adjacent)
    {
        var recursionLevel = adjacent.FirstOrDefault(f => f.IsRecursionLevel);

        if (recursionLevel == null || below == null)
        {
            return 0;
        }

        var nextAdjacent = 0;

        if (recursionLevel.Coordinate.X > Coordinate.X)
        {
            nextAdjacent = below.Count(x => x.Coordinate.X == 0 && x.IsAlive);
        }
        else if (recursionLevel.Coordinate.X < Coordinate.X)
        {
            nextAdjacent = below.Count(x => x.Coordinate.X == 4 && x.IsAlive);
        }
        else if (recursionLevel.Coordinate.Y > Coordinate.Y)
        {
            nextAdjacent = below.Count(x => x.Coordinate.Y == 0 && x.IsAlive);
        }
        else if (recursionLevel.Coordinate.Y < Coordinate.Y)
        {
            nextAdjacent = below.Count(x => x.Coordinate.Y == 4 && x.IsAlive);
        }

        return nextAdjacent;
    }

    public void Act()
    {
        if (IsAlive == true && CurrentAdjacent != 1)
        {
            IsAlive = false;
        }
        else if (IsAlive == false && CurrentAdjacent == 1 || CurrentAdjacent == 2)
        {
            IsAlive = true;
        }
    }
}