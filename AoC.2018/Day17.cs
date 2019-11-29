using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AoC.Common;

namespace AoC2018
{
    /*
    --- Day 17: Reservoir Research ---
    You arrive in the year 18. If it weren't for the coat you got in 1018, 
    you would be very cold: the North Pole base hasn't even been constructed.

    Rather, it hasn't been constructed yet. The Elves are making a little progress, 
    but there's not a lot of liquid water in this climate, so they're getting very dehydrated. 
    Maybe there's more underground?

    You scan a two-dimensional vertical slice of the ground nearby and discover that it is mostly sand with veins of clay. 
    The scan only provides data with a granularity of square meters, but it should be good enough to determine how much water is trapped there. 
    In the scan, x represents the distance to the right, and y represents the distance down. 
    There is also a spring of water near the surface at x=500, y=0. 
    The scan identifies which square meters are clay (your puzzle input).

    For example, suppose your scan shows the following veins of clay:

    x=495, y=2..7
    y=7, x=495..501
    x=501, y=3..7
    x=498, y=2..4
    x=506, y=1..2
    x=498, y=10..13
    x=504, y=10..13
    y=13, x=498..504
    Rendering clay as #, sand as ., and the water spring as +, and with x increasing to the right and y increasing downward, this becomes:

       44444455555555
       99999900000000
       45678901234567
     0 ......+.......
     1 ............#.
     2 .#..#.......#.
     3 .#..#..#......
     4 .#..#..#......
     5 .#.....#......
     6 .#.....#......
     7 .#######......
     8 ..............
     9 ..............
    10 ....#.....#...
    11 ....#.....#...
    12 ....#.....#...
    13 ....#######...

    The spring of water will produce water forever. 
    Water can move through sand, but is blocked by clay. 
    Water always moves down when possible, and spreads to the left and right otherwise, filling space that has clay on both sides and falling out otherwise.

    For example, if five squares of water are created, they will flow downward until they reach the clay and settle there. 
    Water that has come to rest is shown here as ~, while sand through which water has passed (but which is now dry again) is shown as |:

    ......+.......
    ......|.....#.
    .#..#.|.....#.
    .#..#.|#......
    .#..#.|#......
    .#....|#......
    .#~~~~~#......
    .#######......
    ..............
    ..............
    ....#.....#...
    ....#.....#...
    ....#.....#...
    ....#######...
    Two squares of water can't occupy the same location. 
    If another five squares of water are created, they will settle on the first five, filling the clay reservoir a little more:

    ......+.......
    ......|.....#.
    .#..#.|.....#.
    .#..#.|#......
    .#..#.|#......
    .#~~~~~#......
    .#~~~~~#......
    .#######......
    ..............
    ..............
    ....#.....#...
    ....#.....#...
    ....#.....#...
    ....#######...
    Water pressure does not apply in this scenario. 
    If another four squares of water are created, they will stay on the right side of the barrier, and no water will reach the left side:

    ......+.......
    ......|.....#.
    .#..#.|.....#.
    .#..#~~#......
    .#..#~~#......
    .#~~~~~#......
    .#~~~~~#......
    .#######......
    ..............
    ..............
    ....#.....#...
    ....#.....#...
    ....#.....#...
    ....#######...
    At this point, the top reservoir overflows. 
    While water can reach the tiles above the surface of the water, it cannot settle there, and so the next five squares of water settle like this:

    ......+.......
    ......|.....#.
    .#..#||||...#.
    .#..#~~#|.....
    .#..#~~#|.....
    .#~~~~~#|.....
    .#~~~~~#|.....
    .#######|.....
    ........|.....
    ........|.....
    ....#...|.#...
    ....#...|.#...
    ....#~~~~~#...
    ....#######...
    Note especially the leftmost |: the new squares of water can reach this tile, but cannot stop there. Instead, eventually, they all fall to the right and settle in the reservoir below.

    After 10 more squares of water, the bottom reservoir is also full:

    ......+.......
    ......|.....#.
    .#..#||||...#.
    .#..#~~#|.....
    .#..#~~#|.....
    .#~~~~~#|.....
    .#~~~~~#|.....
    .#######|.....
    ........|.....
    ........|.....
    ....#~~~~~#...
    ....#~~~~~#...
    ....#~~~~~#...
    ....#######...
    Finally, while there is nowhere left for the water to settle, it can reach a few more tiles before overflowing beyond the bottom of the scanned data:

    ......+.......    (line not counted: above minimum y value)
    ......|.....#.
    .#..#||||...#.
    .#..#~~#|.....
    .#..#~~#|.....
    .#~~~~~#|.....
    .#~~~~~#|.....
    .#######|.....
    ........|.....
    ...|||||||||..
    ...|#~~~~~#|..
    ...|#~~~~~#|..
    ...|#~~~~~#|..
    ...|#######|..
    ...|.......|..    (line not counted: below maximum y value)
    ...|.......|..    (line not counted: below maximum y value)
    ...|.......|..    (line not counted: below maximum y value)
    How many tiles can be reached by the water? To prevent counting forever, ignore tiles with a y coordinate smaller than the smallest y coordinate in your scan data or larger than the largest one. 
    Any x coordinate is valid. In this example, the lowest y coordinate given is 1, and the highest is 13, causing the water spring (in row 0) and the water falling off the bottom of the render (in rows 14 through infinity) to be ignored.

    So, in the example above, counting both water at rest (~) and other sand tiles the water can hypothetically reach (|), the total number of tiles the water can reach is 57.

    How many tiles can the water reach within the range of y values in your scan?

    --- Part Two ---
    After a very long time, the water spring will run dry. 
    How much water will be retained?

    In the example above, water that won't eventually drain out is shown as ~, a total of 29 tiles.

    How many water tiles are left after the water spring stops producing water and all remaining water not at rest has drained?
    */

    public class Day17 : Day
    {
        public override string Title => "2018 - Day 17: Reservoir Research";

        public static int MinX = int.MaxValue;
        public static int MaxX = int.MinValue;
        public static int MinY = 0;
        public static int MaxY = 0;
        public static Dictionary<Coordinate, GroundProperty> All = new Dictionary<Coordinate, GroundProperty>();
        public static bool Reached;

        public override void PartOne()
        {
            base.PartOne();
            Console.WriteLine();
            //var clayInput = @"x=495, y=2..7
            //y=7, x=495..501
            //x=501, y=3..7
            //x=498, y=2..4
            //x=506, y=1..2
            //x=498, y=10..13
            //x=504, y=10..13
            //y=13, x=498..504".ToStringList();

            var clayInput = Inputs.Day17.ToStringList();
            //var clayInput = @"x=0, y=8..11
            //y=11, x=0..4
            //x=4, y=9..11
            //x=2, y=2..4
            //x=6, y=2..4
            //y=4, x=2..6
            //x=7, y=8..11
            //y=11, x=7..8
            //y=12, x=8..14
            //x=15, y=10..12
            //y=10, x=15..19
            //x=19, y=7..10
            //x=5, y=16..17
            //y=17, x=5..17
            //x=17, y=15..17".ToStringList(); // TEST
            var sw = new Stopwatch();
            sw.Start();
            PopulateClay(clayInput, All);

            var activeWater = new List<GroundProperty>();

            //PrintConsole();
            while (true)
            {
                int i = 0;
                var max = activeWater.Count;
                while (i < max)
                {
                    var currentWater = activeWater[i];
                    currentWater.TryMove();

                    if (currentWater.Coordinate.X == 500 && currentWater.Coordinate.Y == 0)
                    {
                        Reached = true;
                        break;
                    }
                    i++;
                }

                if (!Drip())
                {
                    break;
                }

                activeWater = GetActiveWater();

                //PrintConsole();
                //if (_water.Count % 15000 == 0)
                //{
                //    //Print();
                //}

                //if (_water.Count % 3000 == 0)
                //{
                //    Console.Write('.');
                //}
            }

            //PrintConsole();
            //Print();
            Console.WriteLine();
            //Console.WriteLine(_all.Count(x => x.Value.IsWater));
            var minY = All.Values.Where(x => x.IsClay).Min(g => g.Coordinate.Y);
            Console.WriteLine("Result:");
            Console.WriteLine(All.Values.Count(x => x.IsWater && x.Coordinate.Y >= minY)); // 35707.
            sw.Stop();
            Console.WriteLine($"Completed in {sw.Elapsed}");
        }

        private List<GroundProperty> GetActiveWater()
        {
            return All.Values.Where(x => x.IsWater && x.CanMove).Select(s => s).ToList();
        }

        public override void PartTwo()
        {
            base.PartTwo();

            var sw = new Stopwatch();
            sw.Start();

            var water = All.Values.Where(x => x.IsWater && x.Infinite).ToList();

            int i = 0;
            var count = water.Count;

            while(i < count)
            {
                var currentWater = water[i];
                RecursiveSetLeftToInfinite(currentWater.Coordinate);
                i++;
            }

            //PrintConsole();

            var allWater = All.Values.Where(x => x.IsWater).ToList();
            var infiniteWater = allWater.Count(x => x.Infinite); //ergo will dry up

            Console.WriteLine("Result:");
            Console.WriteLine(allWater.Count - infiniteWater); // 29293.
            sw.Stop();
            Console.WriteLine($"Completed in {sw.Elapsed}");
        }

        private void RecursiveSetLeftToInfinite(Coordinate coordinate)
        {
            if (Day17.All.TryGetValue(new Coordinate(coordinate.X - 1, coordinate.Y), out var left) && left.IsWater && !left.Infinite)
            {
                left.Infinite = true;
                RecursiveSetLeftToInfinite(left.Coordinate);
            }
        }

        private void PrintConsole()
        {
            Console.WriteLine();
            var water = All.Values.Where(x => x.IsWater).ToList();
            for (int i = MinY; i <= MaxY; i++)
            {
                for (int j = MinX - 1; j <= MaxX + 1; j++)
                {
                    if (All.Values.Any(a => a.IsClay && a.Coordinate.X == j && a.Coordinate.Y == i))
                    {
                        Console.Write('#');
                        continue;
                    }

                    var first = water.FirstOrDefault(a => a.Coordinate.X == j && a.Coordinate.Y == i);
                    if (first != null)
                    {
                        if (first.Coordinate.X == 500 && first.Coordinate.Y == 0)
                        {
                            Console.Write('+');
                        }
                        else if (first.Infinite)
                        {
                            Console.Write('i');
                        }
                        else if (first.CanMove == false)
                        {
                            Console.Write('c');
                        }
                        else
                        {
                            Console.Write('~');
                        }
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }

        private void Print()
        {
            var date = DateTime.UtcNow.Ticks;
            var water = All.Values.Where(x => x.IsWater).ToList();
            var clay = All.Values.Where(x => x.IsClay).ToList();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"buckets_" + date + ".txt", false))
            {
                file.WriteLine();
                for (int i = MinY; i <= MaxY; i++)
                {
                    for (int j = MinX - 1; j <= MaxX + 1; j++)
                    {
                        if (clay.Any(a => a.Coordinate.X == j && a.Coordinate.Y == i))
                        {
                            file.Write('#');
                            continue;
                        }

                        var first = water.FirstOrDefault(a => a.Coordinate.X == j && a.Coordinate.Y == i);
                        if (first != null)
                        {
                            if (first.Coordinate.X == 500 && first.Coordinate.Y == 0)
                            {
                                file.Write('+');
                            }
                            else if (first.Infinite)
                            {
                                file.Write('i');
                            }
                            else if (first.CanMove == false)
                            {
                                file.Write('~');
                            }
                            else
                            {
                                file.Write('|');
                            }
                        }
                        else
                        {
                            file.Write('.');
                        }
                    }

                    file.Write(Environment.NewLine);
                }
            }
        }

        private bool Drip()
        {
            if (Reached)
            {
                return false;
            }

            var newDrop = new GroundProperty(500, 0, true, false);
            All.Add(newDrop.Coordinate, newDrop);

            return true;
        }

        private void PopulateClay(List<string> clayInput, Dictionary<Coordinate, GroundProperty> groundGrid)
        {
            foreach (var line in clayInput)
            {
                var split = line.SplitByAs<string>(s => s, ' ', ',', '.').ToList();

                if (split[0].StartsWith("x"))
                {
                    var x = Convert.ToInt32(split[0].RemoveNonNumeric());
                    var yStart = Convert.ToInt32(split[1].RemoveNonNumeric());
                    var yEnd = Convert.ToInt32(split[2]);

                    MaybeSetX(x);
                    MaybeSetY(yStart, yEnd);

                    for (int y = yStart; y <= yEnd; y++)
                    {
                        var ground = new GroundProperty(x, y, false, true);
                        if (!groundGrid.ContainsKey(ground.Coordinate))
                        {
                            groundGrid.Add(ground.Coordinate, ground);
                        }
                    }
                }
                else
                {
                    var y = Convert.ToInt32(split[0].RemoveNonNumeric());
                    var xStart = Convert.ToInt32(split[1].RemoveNonNumeric());
                    var xEnd = Convert.ToInt32(split[2]);

                    MaybeSetX(xStart, xEnd);
                    MaybeSetY(y);

                    for (int x = xStart; x <= xEnd; x++)
                    {
                        var ground = new GroundProperty(x, y, false, true);
                        if (!groundGrid.ContainsKey(ground.Coordinate))
                        {
                            groundGrid.Add(ground.Coordinate, ground);
                        }
                    }
                }
            }
        }

        public void MaybeSetY(params int[] ys)
        {
            foreach (var y in ys)
            {
                if (y > MaxY)
                {
                    MaxY = y;
                }
            }
        }

        public void MaybeSetX(params int[] xs)
        {
            foreach (var x in xs)
            {
                if (x > MaxX)
                {
                    MaxX = x;
                }

                if (x < MinX)
                {
                    MinX = x;
                }
            }
        }
    }

    public class GroundProperty : IEquatable<GroundProperty>
    {
        public Coordinate Coordinate;
        public bool CanMove;
        public bool Infinite;
        public bool Top;
        public bool IsWater;
        public bool IsClay;

        public GroundProperty(int x, int y, bool isWater, bool isClay)
        {
            Coordinate.X = x;
            Coordinate.Y = y;
            CanMove = !isClay;
            Infinite = false;
            Top = false;
            IsWater = isWater;
            IsClay = isClay;
        }

        public override bool Equals(object obj)
        {
            return obj is GroundProperty ground &&
                   Coordinate.X == ground.Coordinate.X &&
                   Coordinate.Y == ground.Coordinate.Y;
        }

        public bool Equals(GroundProperty other)
        {
            return Coordinate.X == other.Coordinate.X &&
                   Coordinate.Y == other.Coordinate.Y;
        }

        public override int GetHashCode()
        {
            return Coordinate.GetHashCode();
        }

        public void TryMove()
        {
            if (CanMove == false || Infinite)
            {
                return;
            }

            Day17.All.TryGetValue(new Coordinate(Coordinate.X, Coordinate.Y + 1), out var below);
            Day17.All.TryGetValue(new Coordinate(Coordinate.X - 1, Coordinate.Y), out var left);
            Day17.All.TryGetValue(new Coordinate(Coordinate.X + 1, Coordinate.Y), out var right);
            Day17.All.TryGetValue(new Coordinate(Coordinate.X - 2, Coordinate.Y), out var leftLeft);

            if (below == null)
            {
                Day17.All.Remove(Coordinate);
                Coordinate.Y++;
                Top = false;

                if (Coordinate.Y == Day17.MaxY)
                {
                    CanMove = false;
                    Infinite = true;
                }
                
                Day17.All.Add(Coordinate, this);
                return;
            }
            else
            {
                if (below.IsWater && below.Infinite)
                {
                    CanMove = false;
                    Infinite = true;
                    return;
                }
            }

            if (left != null && right != null &&
                left.IsWater && right.IsWater &&
                left.Infinite && right.Infinite)
            {
                CanMove = false;
                Infinite = true;
                return;
            }

            //down taken, try left
            if (left == null)
            {
                Day17.All.Remove(Coordinate);
                Coordinate.X--;
                Day17.All.Add(Coordinate, this);
                return;
            }
            else if (left.Infinite)
            {
                Top = true;
            }

            //left taken, try right
            if (right == null)
            {
                Day17.All.Remove(Coordinate);
                Coordinate.X++;

                if (left.IsWater && leftLeft == null && leftLeft.Infinite)
                {
                    Top = true;
                }

                Day17.All.Add(Coordinate, this);
                return;
            }
            else if ((right.IsWater && right.Infinite)
                || (left.IsWater && left.Infinite))
            {
                CanMove = false;
                Infinite = true;
                Top = true;
                return;
            }
            else if (Top && !right.IsWater)
            {
                CanMove = false;
                Infinite = true;
                return;
            }

            CanMove = false;
        }
    }
}