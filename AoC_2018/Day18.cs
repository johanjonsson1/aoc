using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
    */
    public class Day18 : Day
    {
        public override string Title => "2018 - Day 18";
        public object _lock = new object();

        public override void PartOne()
        {
            base.PartOne();
            return;
            var initialAcres = new List<Acre>();
            //bygg alla initiala acres
            //            var input = @".#.#...|#.
            //.....#|##|
            //.|..|...#.
            //..|#.....#
            //#.#|||#|#|
            //...#.||...
            //.|....|...
            //||...#|.#|
            //|.||||..|.
            //...#.|..|.".ToStringList();

            var input = Inputs.Day18.ToStringList();

            for (int y = 0; y < input.Count; y++)
            {
                for (int x = 0; x < input[y].Length; x++)
                {
                    initialAcres.Add(new Acre(x, y, GetAcreType(input[y][x])));
                }
            }


            //Print(initialAcres);

            var next = initialAcres;

            for (int i = 0; i < 30; i++) // 1000 = 224005
            {
                var current = next;
                next = new List<Acre>();

                Parallel.ForEach(current, acre =>
                {
                    var acreCopy = ConvertAcre(acre, current);
                    lock (_lock)
                    { 
                        next.Add(acreCopy);
                    }
                });

                //foreach (var acre in current)
                //{
                //    next.Add(ConvertAcre(acre, current));
                //}

                //Print(next);
                if (i > 0)
                {
                    var wooded = next.Where(a => a.Type == AcreType.Trees).Count();
                    var lumber = next.Where(a => a.Type == AcreType.LumberYard).Count();

                    Console.Write(i);
                    Console.Write(" wood:" + wooded);
                    Console.Write(", lumber:" + lumber);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            var wooded2 = next.Where(a => a.Type == AcreType.Trees).Count();
            var lumber2 = next.Where(a => a.Type == AcreType.LumberYard).Count();
            Console.WriteLine(wooded2 * lumber2);
        }

        public override void PartTwo()
        {
            
                var values = @"10001 wood:568, lumber:303
                10002 wood:580, lumber:305
                10003 wood:586, lumber:314
                10004 wood:592, lumber:320
                10005 wood:599, lumber:321
                10006 wood:606, lumber:326
                10007 wood:610, lumber:335
                10008 wood:611, lumber:344
                10009 wood:615, lumber:344
                10010 wood:624, lumber:342
                10011 wood:630, lumber:342
                10012 wood:636, lumber:348
                10013 wood:642, lumber:348
                10014 wood:637, lumber:357
                10015 wood:631, lumber:355
                10016 wood:621, lumber:367
                10017 wood:612, lumber:364
                10018 wood:600, lumber:359
                10019 wood:585, lumber:356
                10020 wood:571, lumber:350
                10021 wood:559, lumber:342
                10022 wood:551, lumber:331
                10023 wood:544, lumber:322
                10024 wood:545, lumber:304
                10025 wood:546, lumber:302
                10026 wood:549, lumber:298
                10027 wood:554, lumber:295
                10028 wood:561, lumber:299".ToStringList();
            
            base.PartTwo();
            var current = 10001;
            var target = 1000000000;
            var diff = target - current;
            var rest = diff % values.Count;
                                               
            Console.WriteLine(values[rest-1]);
        }

        public AcreType GetAcreType(char symbol)
        {
            if (symbol == '|')
            {
                return AcreType.Trees;
            }

            if (symbol == '#')
            {
                return AcreType.LumberYard;
            }

            return AcreType.OpenGround;
        }

        public Acre ConvertAcre(Acre acre, List<Acre> allAcres)
        {
            var adjacent = GetAdjacentAcres(acre, allAcres);
            var copy = acre.Copy();
            if (acre.Type == AcreType.OpenGround && adjacent.Count(a => a.Type == AcreType.Trees) >= 3)
            {
                copy.Type = AcreType.Trees;
                return copy;
            }

            if (acre.Type == AcreType.Trees && adjacent.Count(a => a.Type == AcreType.LumberYard) >= 3)
            {
                copy.Type = AcreType.LumberYard;
                return copy;
            }

            if (acre.Type == AcreType.LumberYard)
            {
                if (adjacent.Count(a => a.Type == AcreType.LumberYard) >= 1 && adjacent.Count(a => a.Type == AcreType.Trees) >= 1)
                {
                    copy.Type = AcreType.LumberYard;
                    return copy;
                }

                copy.Type = AcreType.OpenGround;
                return copy;
            }

            return copy;
        }

        public List<Acre> GetAdjacentAcres(Acre acre, List<Acre> acres)
        {
            var x = acre.X;
            var y = acre.Y;

            return acres.Where(a =>
                (a.X == x - 1 && a.Y == y - 1) ||
                (a.X == x && a.Y == y - 1) ||
                (a.X == x + 1 && a.Y == y - 1) ||
                (a.X == x + 1 && a.Y == y) ||
                (a.X == x - 1 && a.Y == y) ||
                (a.X == x - 1 && a.Y == y + 1) ||
                (a.X == x && a.Y == y + 1) ||
                (a.X == x + 1 && a.Y == y + 1)).ToList();
        }

        private void Print(List<Acre> acres)
        {
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    var first = acres.First(a => a.X == j && a.Y == i);

                    if (first.Type == AcreType.LumberYard)
                    {
                        Console.Write('#');
                    }
                    else if (first.Type == AcreType.Trees)
                    {
                        Console.Write('|');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }

    public class Acre
    {
        public AcreType Type;
        public int X;
        public int Y;

        public Acre(int x, int y, AcreType type)
        {
            X = x;
            Y = y;
            Type = type;
        }

        public Acre Copy()
        {
            return new Acre(X, Y, Type);
        }
    }

    public enum AcreType
    {
        OpenGround,
        LumberYard,
        Trees
    }
}
