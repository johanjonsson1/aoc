using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC_2018
{
    /*
    --- Day 18: Settlers of The North Pole ---
    On the outskirts of the North Pole base construction project, many Elves are collecting lumber.

    The lumber collection area is 50 acres by 50 acres; each acre can be either open ground (.), trees (|), or a lumberyard (#). 
    You take a scan of the area (your puzzle input).

    Strange magic is at work here: each minute, the landscape looks entirely different. 
    In exactly one minute, an open acre can fill with trees, a wooded acre can be converted to a lumberyard,
    or a lumberyard can be cleared to open ground (the lumber having been sent to other projects).

    The change to each acre is based entirely on the contents of that acre as well as the number of open, wooded, 
    or lumberyard acres adjacent to it at the start of each minute. Here, "adjacent" means any of the eight acres surrounding that acre. 
    (Acres on the edges of the lumber collection area might have fewer than eight adjacent acres; the missing acres aren't counted.)

    In particular:

    An open acre will become filled with trees if three or more adjacent acres contained trees. Otherwise, nothing happens.
    An acre filled with trees will become a lumberyard if three or more adjacent acres were lumberyards. Otherwise, nothing happens.
    An acre containing a lumberyard will remain a lumberyard if it was adjacent to at least one other lumberyard and at least one acre containing trees. 
    Otherwise, it becomes open.
    These changes happen across all acres simultaneously, each of them using the state of all acres at the beginning of the minute and changing to their new form by the end of that same minute. 
    Changes that happen during the minute don't affect each other.

    For example, suppose the lumber collection area is instead only 10 by 10 acres with this initial configuration:

    Initial state:
    .#.#...|#.
    .....#|##|
    .|..|...#.
    ..|#.....#
    #.#|||#|#|
    ...#.||...
    .|....|...
    ||...#|.#|
    |.||||..|.
    ...#.|..|.

    After 1 minute:
    .......##.
    ......|###
    .|..|...#.
    ..|#||...#
    ..##||.|#|
    ...#||||..
    ||...|||..
    |||||.||.|
    ||||||||||
    ....||..|.

    After 2 minutes:
    .......#..
    ......|#..
    .|.|||....
    ..##|||..#
    ..###|||#|
    ...#|||||.
    |||||||||.
    ||||||||||
    ||||||||||
    .|||||||||

    After 3 minutes:
    .......#..
    ....|||#..
    .|.||||...
    ..###|||.#
    ...##|||#|
    .||##|||||
    ||||||||||
    ||||||||||
    ||||||||||
    ||||||||||

    After 4 minutes:
    .....|.#..
    ...||||#..
    .|.#||||..
    ..###||||#
    ...###||#|
    |||##|||||
    ||||||||||
    ||||||||||
    ||||||||||
    ||||||||||

    After 5 minutes:
    ....|||#..
    ...||||#..
    .|.##||||.
    ..####|||#
    .|.###||#|
    |||###||||
    ||||||||||
    ||||||||||
    ||||||||||
    ||||||||||

    After 6 minutes:
    ...||||#..
    ...||||#..
    .|.###|||.
    ..#.##|||#
    |||#.##|#|
    |||###||||
    ||||#|||||
    ||||||||||
    ||||||||||
    ||||||||||

    After 7 minutes:
    ...||||#..
    ..||#|##..
    .|.####||.
    ||#..##||#
    ||##.##|#|
    |||####|||
    |||###||||
    ||||||||||
    ||||||||||
    ||||||||||

    After 8 minutes:
    ..||||##..
    ..|#####..
    |||#####|.
    ||#...##|#
    ||##..###|
    ||##.###||
    |||####|||
    ||||#|||||
    ||||||||||
    ||||||||||

    After 9 minutes:
    ..||###...
    .||#####..
    ||##...##.
    ||#....###
    |##....##|
    ||##..###|
    ||######||
    |||###||||
    ||||||||||
    ||||||||||

    After 10 minutes:
    .||##.....
    ||###.....
    ||##......
    |##.....##
    |##.....##
    |##....##|
    ||##.####|
    ||#####|||
    ||||#|||||
    ||||||||||
    After 10 minutes, there are 37 wooded acres and 31 lumberyards. 
    Multiplying the number of wooded acres by the number of lumberyards gives the total resource value after ten minutes: 37 * 31 = 1147.

    What will the total resource value of the lumber collection area be after 10 minutes?

    --- Part Two ---
    This important natural resource will need to last for at least thousands of years. Are the Elves collecting this lumber sustainably?

    What will the total resource value of the lumber collection area be after 1000000000 minutes?
    */
    public class Day18 : Day
    {
        public override string Title => "2018 - Day 18: Settlers of The North Pole";
        public object _lock = new object();

        public override void PartOne()
        {
            base.PartOne();
            List<Acre> initialAcres = CreateInitialAcres();
            var next = initialAcres;

            for (int i = 0; i < 10; i++)
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

                //Print(next);
            }

            Console.WriteLine();
            var wooded2 = next.Where(a => a.Type == AcreType.Trees).Count();
            var lumber2 = next.Where(a => a.Type == AcreType.LumberYard).Count();
            Console.WriteLine(wooded2 * lumber2); // 678529
        }

        public override void PartTwo()
        {
            base.PartTwo();
            List<Acre> initialAcres = CreateInitialAcres();
            var next = initialAcres;
            var values2 = new List<Tuple<int, int>>();
            var firstResult = 0;

            for (int i = 0; i < 500; i++)
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

                if (i > 450)
                {
                    var wooded = next.Where(a => a.Type == AcreType.Trees).Count();
                    var lumber = next.Where(a => a.Type == AcreType.LumberYard).Count();
                    var currentResult = wooded * lumber;

                    if (currentResult != firstResult)
                    {
                        values2.Add(new Tuple<int, int>(i, currentResult));
                    }
                    else
                    {
                        break;
                    }

                    if (firstResult == 0)
                    {
                        firstResult = currentResult;
                    }
                }
            }

            var start = values2.First().Item1;
            var target = 1000000000;
            var diff = target - start;
            var rest = diff % values2.Count;

            Console.WriteLine(values2[rest - 1].Item2); // 224005.

            //var values = @"10001 wood:568, lumber:303
            //10002 wood:580, lumber:305
            //10003 wood:586, lumber:314
            //10004 wood:592, lumber:320
            //10005 wood:599, lumber:321
            //10006 wood:606, lumber:326
            //10007 wood:610, lumber:335
            //10008 wood:611, lumber:344
            //10009 wood:615, lumber:344
            //10010 wood:624, lumber:342
            //10011 wood:630, lumber:342
            //10012 wood:636, lumber:348
            //10013 wood:642, lumber:348
            //10014 wood:637, lumber:357
            //10015 wood:631, lumber:355
            //10016 wood:621, lumber:367
            //10017 wood:612, lumber:364
            //10018 wood:600, lumber:359
            //10019 wood:585, lumber:356
            //10020 wood:571, lumber:350
            //10021 wood:559, lumber:342
            //10022 wood:551, lumber:331
            //10023 wood:544, lumber:322
            //10024 wood:545, lumber:304
            //10025 wood:546, lumber:302
            //10026 wood:549, lumber:298
            //10027 wood:554, lumber:295
            //10028 wood:561, lumber:299".ToStringList();


            //var start = 10001;
            //var target = 1000000000;
            //var diff = target - start;
            //var rest = diff % values.Count;

            //Console.WriteLine(values[rest - 1]);
        }

        private List<Acre> CreateInitialAcres()
        {
            var initialAcres = new List<Acre>();
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
            return initialAcres;
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
