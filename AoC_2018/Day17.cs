using AoC_Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
    */
    public class Day17 : Day
    {
        public override string Title => "2018 - Day 17";

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
            var clayInput = @"x=495, y=2..7
            y=7, x=495..501
            x=501, y=3..7
            x=498, y=2..4
            x=506, y=1..2
            x=498, y=10..13
            x=504, y=10..13
            y=13, x=498..504".ToStringList();

            //var clayInput = Inputs.Day17.ToStringList();
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
                    //if (w.CanMove)
                    //{
                    w.TryMove();

                    if(w.X == 500 && w.Y == 0)
                    {
                        Reached = true;
                        break;
                    }
                    //}
                }

                if (!Drip())
                {
                    break;
                }

                activeWater = _water.Where(x => x.CanMove).ToList();
                //PrintConsole();
                if (_water.Count % 15000 == 0)
                {
                    Print();
                }

                if (_water.Count % 3000 == 0)
                {
                    Console.Write('.');
                }
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"buckets_result3.txt", false))
            {
                file.WriteLine(_water.Count);
                file.WriteLine(_water.Count(x => x.Y > 0));
            }

            PrintConsole();
            //Print();
            Console.WriteLine();
            Console.WriteLine(_water.Count);
            Console.WriteLine(_water.Count(x => x.Y > 0));
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
                //Console.WriteLine();
                file.WriteLine();
                for (int i = minY; i <= maxY; i++)
                {
                    for (int j = minX - 1; j <= maxX + 1; j++)
                    {
                        if (_groundGrid.Any(a => a.X == j && a.Y == i))
                        {
                            file.Write('#');
                            continue;
                            //Console.Write('#');
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
                                //Console.Write('i');
                            }
                            else if (first.CanMove == false)
                            {
                                file.Write('~');
                                //Console.Write('c');
                            }
                            else
                            {
                                file.Write('|');
                                //Console.Write('~');
                            }                       
                        }
                        else
                        {
                            file.Write('.');
                            //Console.Write('.');
                        }
                    }
                    //Console.WriteLine();
                    file.Write(Environment.NewLine);
                }
            }
        }

        private bool Drip()
        {
            if (Reached)//(_water.Any(w => w.X == 500 && w.Y == 1))
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

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine("manual file count");
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
            var coordinate = obj as Coordinate;
            return coordinate != null &&
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
                //else if (below.Top)
                //{
                //    CanMove = false;
                //    if (left == null)
                //    {
                //        Top = true;
                //    }                    
                //    //Infinite = true;

                //    return;
                //}
            }

            //var leftAndRight = new List<Coordinate>();// Day17._all.Where(a => (a.X == X-1 || a.X == X+1) && a.Y == Y).ToList();
            //var right = Day17._all.FirstOrDefault(a => a.X == X+1 && a.Y == Y);

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

            // cannot move
            CanMove = false;
        }
    }
}
