namespace AoC2018;

/*
--- Day 3: No Matter How You Slice It ---
The Elves managed to locate the chimney-squeeze prototype fabric for Santa's suit (thanks to someone who helpfully wrote its box IDs on the wall of the warehouse in the middle of the night). 
Unfortunately, anomalies are still affecting them - nobody can even agree on how to cut the fabric.

The whole piece of fabric they're working on is a very large square - at least 1000 inches on each side.

Each Elf has made a claim about which area of fabric would be ideal for Santa's suit. All claims have an ID and consist of a single rectangle with edges parallel to the edges of the fabric. 
Each claim's rectangle is defined as follows:

The number of inches between the left edge of the fabric and the left edge of the rectangle.
The number of inches between the top edge of the fabric and the top edge of the rectangle.
The width of the rectangle in inches.
The height of the rectangle in inches.
A claim like #123 @ 3,2: 5x4 means that claim ID 123 specifies a rectangle 3 inches from the left edge, 2 inches from the top edge, 5 inches wide, and 4 inches tall. 
Visually, it claims the square inches of fabric represented by # (and ignores the square inches of fabric represented by .) in the diagram below:

...........
...........
...#####...
...#####...
...#####...
...#####...
...........
...........
...........
The problem is that many of the claims overlap, causing two or more claims to cover part of the same areas. For example, consider the following claims:

#1 @ 1,3: 4x4
#2 @ 3,1: 4x4
#3 @ 5,5: 2x2
Visually, these claim the following areas:

........
...2222.
...2222.
.11XX22.
.11XX22.
.111133.
.111133.
........
The four square inches marked with X are claimed by both 1 and 2. (Claim 3, while adjacent to the others, does not overlap either of them.)

If the Elves all proceed with their own plans, none of them will have enough fabric. How many square inches of fabric are within two or more claims?

Your puzzle answer was 107820.

--- Part Two ---
Amidst the chaos, you notice that exactly one claim doesn't overlap by even a single square inch of fabric with any other claim. 
If you can somehow draw attention to it, maybe the Elves will be able to make Santa's suit after all!

For example, in the claims above, only claim 3 is intact after all claims are made.

What is the ID of the only claim that doesn't overlap?
*/
public class Day3 : Day
{
    public override string Title => "2018 - Day 3: No Matter How You Slice It";

    private readonly List<string> _inputs = Inputs.Day3.ToStringList();
    private ConcurrentDictionary<SquareInch, SquareInch> _claimPoints = new ConcurrentDictionary<SquareInch, SquareInch>(new SquareInchEqualityComparer());
    private ConcurrentDictionary<string, byte> _allClaims = new ConcurrentDictionary<string, byte>();
    private ConcurrentDictionary<string, byte> _claimsWithMatches = new ConcurrentDictionary<string, byte>();

    public override void PartOne()
    {
        base.PartOne();

        Parallel.ForEach(_inputs, input =>
        {
            var claimValues = input.SplitByAs(s => s, '@', ',', ':');
            var id = claimValues[0];
            _allClaims.AddOrUpdate(id, default(byte), (k, v) =>
            {
                return default(byte);
            });

            var startLeftX = Convert.ToInt32(claimValues[1]);
            var startTopY = Convert.ToInt32(claimValues[2]);
            var area = claimValues[3];

            var timesX = Convert.ToInt32(area.Split('x')[0]);
            var timesY = Convert.ToInt32(area.Split('x')[1]);

            for (int i = 0; i < timesX; i++)
            {
                var newX = startLeftX + i;

                for (int j = 0; j < timesY; j++)
                {
                    var newY = startTopY + j;
                    var sqInch = new SquareInch
                    {
                        ClaimId = id,
                        Hits = 1,
                        X = newX,
                        Y = newY
                    };

                    _claimPoints.AddOrUpdate(sqInch, sqInch, (k, v) =>
                    {
                        v.Hits += 1;

                        _claimsWithMatches.AddOrUpdate(id, default(byte), (key, val) =>
                        {
                            return default(byte);
                        });

                        _claimsWithMatches.AddOrUpdate(v.ClaimId, default(byte), (key, val) =>
                        {
                            return default(byte);
                        });

                        return v;
                    });
                }
            }
        });

        var result = _claimPoints.Values.Where(a => a.Hits >= 2).ToList();
        Console.WriteLine(result.Count); // 107820
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var result = _allClaims.Keys.Except(_claimsWithMatches.Keys).ToList();

        foreach (var res in result)
        {
            Console.WriteLine(res); // #661
        }
    }
}

public class SquareInch
{
    public string ClaimId;
    public int X;
    public int Y;
    public int Hits;
}

public class SquareInchEqualityComparer : IEqualityComparer<SquareInch>
{
    public bool Equals(SquareInch b1, SquareInch b2)
    {
        if (b1.X == b2.X && b1.Y == b2.Y)
            return true;
        else
            return false;
    }

    public int GetHashCode(SquareInch bx)
    {
        int hCode = bx.X ^ bx.Y;
        return hCode.GetHashCode();
    }
}