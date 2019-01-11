using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC_2018
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

        public static int minX = int.MaxValue;
        public static int maxX = int.MinValue;
        public static int minY = 0;
        public static int maxY = 0;
        HashSet<Clay> _groundGrid = new HashSet<Clay>();
        List<Water> _water = new List<Water>();
        public static List<Coordinate> _all = new List<Coordinate>();
        public static int WaterIdCount = 0;
        public static bool Reached = false;

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

            PopulateClay(clayInput, _groundGrid);
            _all.AddRange(_groundGrid);

            var activeWater = new List<Water>(_water);

            //PrintConsole();
            while (true)
            {
                foreach (var w in activeWater)
                {
                    w.TryMove();

                    if(w.X == 500 && w.Y == 0)
                    {
                        Reached = true;
                        break;
                    }
                }

                if (!Drip())
                {
                    break;
                }

                activeWater = _water.Where(x => x.CanMove).ToList();
                //PrintConsole();
                if (_water.Count % 15000 == 0)
                {
                    //Print();
                }

                if (_water.Count % 3000 == 0)
                {
                    Console.Write('.');
                }
            }

            //PrintConsole();
            Print();
            Console.WriteLine();
            Console.WriteLine(_water.Count);
            var minY = _groundGrid.Min(g => g.Y);
            Console.WriteLine(_water.Count(x => x.Y >= minY)); // 35707.
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine("manual file count"); // 29293.
        }

        private void PrintConsole()
        {
            Console.WriteLine();
            for (int i = minY; i <= maxY; i++)
            {
                for (int j = minX - 1; j <= maxX + 1; j++)
                {
                    if (_groundGrid.Any(a => a.X == j && a.Y == i))
                    {
                        Console.Write('#');
                        continue;
                    }

                    var first = _water.FirstOrDefault(a => a.X == j && a.Y == i);
                    if (first != null)
                    {
                        if (first.X == 500 && first.Y == 0)
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
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"buckets_"+date+".txt", false))
            {
                file.WriteLine();
                for (int i = minY; i <= maxY; i++)
                {
                    for (int j = minX - 1; j <= maxX + 1; j++)
                    {
                        if (_groundGrid.Any(a => a.X == j && a.Y == i))
                        {
                            file.Write('#');
                            continue;
                        }

                        var first = _water.FirstOrDefault(a => a.X == j && a.Y == i);
                        if (first != null)
                        {
                            if (first.X == 500 && first.Y == 0)
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

            var newDrop = new Water(500, 0);
            _water.Add(newDrop);
            _all.Add(newDrop);

            return true;
        }

        private void PopulateClay(List<string> clayInput, HashSet<Clay> groundGrid)
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
                        groundGrid.Add(new Clay(x, y));
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
                        groundGrid.Add(new Clay(x, y));
                    }
                }
            }
        }

        public void MaybeSetY(params int[] ys)
        {
            foreach (var y in ys)
            {
                if (y > maxY)
                {
                    maxY = y;
                }
            }
        }

        public void MaybeSetX(params int[] xs)
        {
            foreach (var x in xs)
            {
                if (x > maxX)
                {
                    maxX = x;
                }

                if (x < minX)
                {
                    minX = x;
                }
            }
        }
    }

    public class Coordinate
    {
        public int X;
        public int Y;
        public bool CanMove;
        public bool Infinite;
        public bool Top;
        public bool IsWater;
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Coordinate coordinate &&
                   X == coordinate.X &&
                   Y == coordinate.Y;
        }

        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }
    }

    public class Clay : Coordinate
    {
        public Clay(int x, int y) : base(x, y)
        {
            IsWater = false;
        }
    }

    public class Water : Coordinate
    {
        public int Id;

        public Water(int x, int y) : base(x, y)
        {
            Id = ++Day17.WaterIdCount;
            IsWater = true;
            CanMove = true;
        }

        public void TryMove()
        {
            if (CanMove == false || Infinite)
            {
                return;
            }

            Coordinate below = null;
            Coordinate left = null;
            Coordinate right = null;
            Coordinate leftLeft = null;

            var count = 0;
            foreach (Coordinate a in Day17._all)
            {
                if (a.X == X && a.Y == Y + 1)
                {
                    below = a;
                    count++;
                }
                else if (a.X == X - 1 && a.Y == Y)
                {
                    left = a;
                    count++;
                }
                else if (a.X == X + 1 && a.Y == Y)
                {
                    right = a;
                    count++;
                }
                else if (a.X == X - 2 && a.Y == Y)
                {
                    leftLeft = a;
                    count++;
                }

                if (count == 4)
                {
                    break;
                }
            }

            if (below == null)
            {
                Y = Y + 1;
                Top = false;

                if (Y == Day17.maxY)
                {
                    CanMove = false;
                    Infinite = true;
                }

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
                X = X - 1;
                return;
            }
            else if (left.Infinite)
            {
                Top = true;
            }

            //left taken, try right
            if (right == null)
            {
                X = X + 1;

                if (left.IsWater && leftLeft != null && leftLeft.Infinite)
                {
                    Top = true;
                }
                return;
            }
            else if ((right.IsWater && right.Infinite) ||
                (left.IsWater && left.Infinite))
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
