using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day20 : Day
    {
        public override string Title => "";
        private readonly string abc = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        public List<DonutItem> all;

        public override void PartOne()
        {
            return;
            base.PartOne();
            var input = Inputs.Day20.ToStringList();
//            input = @"                   A               
//                   A               
//  #################.#############  
//  #.#...#...................#.#.#  
//  #.#.#.###.###.###.#########.#.#  
//  #.#.#.......#...#.....#.#.#...#  
//  #.#########.###.#####.#.#.###.#  
//  #.............#.#.....#.......#  
//  ###.###########.###.#####.#.#.#  
//  #.....#        A   C    #.#.#.#  
//  #######        S   P    #####.#  
//  #.#...#                 #......VT
//  #.#.#.#                 #.#####  
//  #...#.#               YN....#.#  
//  #.###.#                 #####.#  
//DI....#.#                 #.....#  
//  #####.#                 #.###.#  
//ZZ......#               QG....#..AS
//  ###.###                 #######  
//JO..#.#.#                 #.....#  
//  #.#.#.#                 ###.#.#  
//  #...#..DI             BU....#..LF
//  #####.#                 #.#####  
//YN......#               VT..#....QG
//  #.###.#                 #.###.#  
//  #.#...#                 #.....#  
//  ###.###    J L     J    #.#.###  
//  #.....#    O F     P    #.#...#  
//  #.###.#####.#.#####.#####.###.#  
//  #...#.#.#...#.....#.....#.#...#  
//  #.#####.###.###.#.#.#########.#  
//  #...#.#.....#...#.#.#.#.....#.#  
//  #.###.#####.###.###.#.#.#######  
//  #.#.........#...#.............#  
//  #########.###.###.#############  
//           B   J   C               
//           U   P   P               ".ToStringList();

            var grid = CreateGrid(input);
            all = grid.GetAll();

            // create portals
            var eligableForPortal = all.Where(i => abc.Any(a => a == i.Symbol)).ToList();
            var portals = new List<Portal>();

            foreach (var donutItem in eligableForPortal)
            {
                var adjacent = all.Where(a => donutItem.Coordinate.IsAdjacent(a.Coordinate)).ToList();
                var traversable = adjacent.FirstOrDefault(a => a.Traversable);
                var otherChar = adjacent.FirstOrDefault(a => eligableForPortal.Contains(a));

                if (traversable != null)
                {
                    if (otherChar.Coordinate.X < donutItem.Coordinate.X)
                    {
                        portals.Add(new Portal
                            {Coordinate = traversable.Coordinate, Name = "" + otherChar.Symbol + donutItem.Symbol});
                        continue;
                    }

                    if (otherChar.Coordinate.X > donutItem.Coordinate.X)
                    {
                        portals.Add(new Portal
                            {Coordinate = traversable.Coordinate, Name = "" + donutItem.Symbol + otherChar.Symbol});
                        continue;
                    }

                    if (otherChar.Coordinate.Y > donutItem.Coordinate.Y)
                    {
                        portals.Add(new Portal
                            {Coordinate = traversable.Coordinate, Name = "" + donutItem.Symbol + otherChar.Symbol});
                        continue;
                    }

                    if (otherChar.Coordinate.Y < donutItem.Coordinate.Y)
                    {
                        portals.Add(new Portal
                            {Coordinate = traversable.Coordinate, Name = "" + otherChar.Symbol + donutItem.Symbol});
                        continue;
                    }
                }
            }

            // connect portals
            var portalGroups = portals.GroupBy(g => g.Name).ToList();

            foreach (var portalGroup in portalGroups)
            {
                if (portalGroup.Count() == 1)
                {
                    continue;
                }

                var first = portalGroup.First();
                var second = portalGroup.Last();

                first.Exit = second;
                second.Exit = first;
            }

            // find connected to with steps
            foreach (var portal in portals)
            {
                foreach (var otherPortal in portals.Where(x => !x.Coordinate.Equals(portal.Coordinate)))
                {
                    var lowestSteps = int.MaxValue;

                    GetConnectedTo(portal.Coordinate, otherPortal.Coordinate,
                        new Coordinate(int.MinValue, int.MinValue), 0, ref lowestSteps);

                    if (lowestSteps == int.MaxValue)
                    {
                        continue;
                    }

                    portal.ConnectedTo.Add(new PortalDistance
                    {
                        Distance = lowestSteps,
                        Portal = otherPortal
                    });
                }

                if (portal.Exit != null)
                {
                    portal.ConnectedTo.Add(new PortalDistance
                    {
                        Distance = 1,
                        Portal = portal.Exit
                    });
                }
            }

            var startPortal = portals.First(f => f.Name == "AA");
            var targetPortal = portals.First(f => f.Name == "ZZ");
            
            var ls = int.MaxValue;
            ClosestByPortal(startPortal, targetPortal, startPortal, new List<Portal>() {startPortal},  0, ref ls);

            Console.WriteLine(ls);
        }

        private void
            GetConnectedTo(Coordinate from, Coordinate to, Coordinate last, int count, ref int lowestSteps)
        {
            var visitable = all.Where(g =>
                from.IsAdjacent(g.Coordinate) && g.Traversable && !last.Equals(g.Coordinate)).ToList();

            foreach (var point in visitable)
            {
                var isTarget = point.Coordinate.Equals(to);

                if (!isTarget)
                {
                    GetConnectedTo(point.Coordinate, to, from, count + 1, ref lowestSteps);
                }
                else
                {
                    if (count + 1 < lowestSteps)
                    {
                        lowestSteps = count + 1;
                    }

                    return;
                }
            }
        }

        private void
            ClosestByPortal(Portal from, Portal to, Portal last, List<Portal> visited, int count, ref int lowestSteps)
        {
            if (count > lowestSteps)
            {
                return;
            }

            var visitablePortals = from.ConnectedTo.Where(c => !ReferenceEquals(c.Portal, last) &&
                                                               !visited.Contains(c.Portal)).ToList();

            foreach (var pD in visitablePortals)
            {
                var isTarget = object.ReferenceEquals(pD.Portal, to);
                if (!isTarget)
                {
                    var visited2 = new List<Portal>(visited);
                    visited2.Add(pD.Portal);
                    ClosestByPortal(pD.Portal, to, from, visited2, count + pD.Distance, ref lowestSteps);
                }
                else
                {
                    var visited2 = new List<Portal>(visited);
                    visited2.Add(pD.Portal);
                    Console.WriteLine(string.Join(", ", visited2) + " in " + (count+pD.Distance));
                    if (count + pD.Distance < lowestSteps)
                    {
                        lowestSteps = count + pD.Distance;
                    }

                    //return;
                }
            }
        }


        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day20.ToStringList();
//            input = @"             Z L X W       C                 
//             Z P Q B       K                 
//  ###########.#.#.#.#######.###############  
//  #...#.......#.#.......#.#.......#.#.#...#  
//  ###.#.#.#.#.#.#.#.###.#.#.#######.#.#.###  
//  #.#...#.#.#...#.#.#...#...#...#.#.......#  
//  #.###.#######.###.###.#.###.###.#.#######  
//  #...#.......#.#...#...#.............#...#  
//  #.#########.#######.#.#######.#######.###  
//  #...#.#    F       R I       Z    #.#.#.#  
//  #.###.#    D       E C       H    #.#.#.#  
//  #.#...#                           #...#.#  
//  #.###.#                           #.###.#  
//  #.#....OA                       WB..#.#..ZH
//  #.###.#                           #.#.#.#  
//CJ......#                           #.....#  
//  #######                           #######  
//  #.#....CK                         #......IC
//  #.###.#                           #.###.#  
//  #.....#                           #...#.#  
//  ###.###                           #.#.#.#  
//XF....#.#                         RF..#.#.#  
//  #####.#                           #######  
//  #......CJ                       NM..#...#  
//  ###.#.#                           #.###.#  
//RE....#.#                           #......RF
//  ###.###        X   X       L      #.#.#.#  
//  #.....#        F   Q       P      #.#.#.#  
//  ###.###########.###.#######.#########.###  
//  #.....#...#.....#.......#...#.....#.#...#  
//  #####.#.###.#######.#######.###.###.#.#.#  
//  #.......#.......#.#.#.#.#...#...#...#.#.#  
//  #####.###.#####.#.#.#.#.###.###.#.###.###  
//  #.......#.....#.#...#...............#...#  
//  #############.#.#.###.###################  
//               A O F   N                     
//               A A D   M                     ".ToStringList();

            var grid = CreateGrid(input);
            all = grid.GetAll();

            // create portals
            var eligableForPortal = all.Where(i => abc.Any(a => a == i.Symbol)).ToList();
            var portals = new List<Portal>();

            foreach (var donutItem in eligableForPortal)
            {
                var adjacent = all.Where(a => donutItem.Coordinate.IsAdjacent(a.Coordinate)).ToList();
                var traversable = adjacent.FirstOrDefault(a => a.Traversable);
                var otherChar = adjacent.FirstOrDefault(a => eligableForPortal.Contains(a));

                if (traversable != null)
                {
                    if (otherChar.Coordinate.X < donutItem.Coordinate.X)
                    {
                        portals.Add(new Portal
                        { Coordinate = traversable.Coordinate, Name = "" + otherChar.Symbol + donutItem.Symbol });
                        continue;
                    }

                    if (otherChar.Coordinate.X > donutItem.Coordinate.X)
                    {
                        portals.Add(new Portal
                        { Coordinate = traversable.Coordinate, Name = "" + donutItem.Symbol + otherChar.Symbol });
                        continue;
                    }

                    if (otherChar.Coordinate.Y > donutItem.Coordinate.Y)
                    {
                        portals.Add(new Portal
                        { Coordinate = traversable.Coordinate, Name = "" + donutItem.Symbol + otherChar.Symbol });
                        continue;
                    }

                    if (otherChar.Coordinate.Y < donutItem.Coordinate.Y)
                    {
                        portals.Add(new Portal
                        { Coordinate = traversable.Coordinate, Name = "" + otherChar.Symbol + donutItem.Symbol });
                        continue;
                    }
                }
            }

            // connect portals
            var portalGroups = portals.GroupBy(g => g.Name).ToList();

            foreach (var portalGroup in portalGroups)
            {
                if (portalGroup.Count() == 1)
                {
                    continue;
                }

                var first = portalGroup.First();
                var second = portalGroup.Last();

                first.Exit = second;
                second.Exit = first;
            }

            // find connected to with steps
            foreach (var portal in portals)
            {
                foreach (var otherPortal in portals.Where(x => !x.Coordinate.Equals(portal.Coordinate)))
                {
                    var lowestSteps = int.MaxValue;

                    GetConnectedTo(portal.Coordinate, otherPortal.Coordinate,
                        new Coordinate(int.MinValue, int.MinValue), 0, ref lowestSteps);

                    if (lowestSteps == int.MaxValue)
                    {
                        continue;
                    }

                    portal.ConnectedTo.Add(new PortalDistance
                    {
                        Distance = lowestSteps,
                        Portal = otherPortal
                    });
                }

                if (portal.Exit != null)
                {
                    portal.ConnectedTo.Add(new PortalDistance
                    {
                        Distance = 1,
                        Portal = portal.Exit
                    });
                }
            }

            var startPortal = portals.First(f => f.Name == "AA");
            var targetPortal = portals.First(f => f.Name == "ZZ"); 
            SetInner(portals);

            var f1 = new QueueItem
            {
                From = startPortal,
                Coordinate = startPortal.Coordinate,
                Count = 0,
                Level = 0,
                Steps = "AA0"
            };

            ClosestByLevelQueue(f1, targetPortal.Coordinate);

            //var ls = int.MaxValue;
            //ClosestByLevel(startPortal, targetPortal, startPortal, new List<string>() { startPortal.GetLevelKey(0) }, 0, 0, ref ls);

            Console.WriteLine("this " + lowestSteps);
        }

        private void SetInner(List<Portal> portals)
        {
            var maxY = portals.Max(m => m.Coordinate.Y);
            var maxX = portals.Max(m => m.Coordinate.X);
            foreach (var portal in portals)
            {
                if (portal.Coordinate.Y == 2 || portal.Coordinate.X == 2 || portal.Coordinate.Y == maxY || portal.Coordinate.X == maxX)
                {
                    portal.Inner = false;
                    continue;
                }

                portal.Inner = true;
            }
        }

        private static List<string> test = new List<string>() {"AA0",
            "XF0",
            "XF1",
            "CK1",
            "CK2",
            "ZH2",
            "ZH3",
            "WB3",
            "WB4",
            "IC4",
            "IC5",
            "RF5",
            "RF6",
            "NM6",
            "NM7",
            "LP7",
            "LP8",
            "FD8",
            "FD9",
            "XQ9",
            "XQ10",
            "WB10",
            "WB9",
            "ZH9",
            "ZH8",
            "CK8",
            "CK7",
            "XF7",
            "XF6",
            "OA6",
            "OA5",
            "CJ5",
            "CJ4",
            "RE4",
            "RE3",
            "IC3",
            "IC4",
            "RF4",
            "RF5",
            "NM5",
            "NM6",
            "LP6",
            "LP7",
            "FD7",
            "FD8",
            "XQ8",
            "XQ9",
            "WB9",
            "WB8",
            "ZH8",
            "ZH7",
            "CK7",
            "CK6",
            "XF6",
            "XF5",
            "OA5",
            "OA4",
            "CJ4",
            "CJ3",
            "RE3",
            "RE2",
            "XQ2",
            "XQ1",
            "FD1",
            "FD0"
        };

        public int lowestSteps = int.MaxValue;
        public int started = 0;
        public object locker = new object();

        public IEnumerable<bool> QueueGet()
        {
            if (started < 8)
            {
                yield return true;
            }
        }

        private void
            ClosestByLevelQueue(QueueItem first, Coordinate to)
        {
            var queue = new Queue<QueueItem>();
            queue.Enqueue(first);

            var visited = new List<Tuple<Coordinate, int>>();
            //visited.Add(new Tuple<Coordinate, int>(first.Coordinate, first.Level));

            while (queue.Count > 0)
            {
                var qi = queue.Dequeue();

                if (qi.Count > lowestSteps || qi.Level < 0 || qi.Level > 45 || qi.Count > 8500)
                {
                    continue;
                }

                bool OnlyInner(Portal p)
                {
                    if (p.GetLevel(qi.Level, qi.From) > 0 || (p.Inner || p.Name == "ZZ"))
                    {
                        return true;
                    }

                    return false;
                }

                if (qi.Coordinate.Equals(to) && qi.Level == 0)
                {
                    lowestSteps = qi.Count;
                    Console.WriteLine(qi.Steps);
                    break;
                }

                if (visited.Any(a => a.Item1.Equals(qi.Coordinate) && a.Item2 == qi.Level))
                {
                    continue;
                }

                visited.Add(new Tuple<Coordinate, int>(qi.Coordinate, qi.Level));
                //Console.WriteLine(qi.From.Name + ", dist ("+qi.Count+"), lvl ("+qi.Level+")");

                var visitablePortals = qi.From.ConnectedTo.Where(c => OnlyInner(c.Portal) && c.Portal != qi.From.Exit).ToList();

                foreach (var pD in visitablePortals)
                {
                    var llevel = pD.Portal.Inner ? qi.Level + 1 : qi.Level - 1;
                    var steps = qi.Steps;

                    if (qi.Level == 0 && pD.Portal.Name == "ZZ")
                    {
                        steps += "," + pD.Portal.Name + llevel;
                        queue.Enqueue(new QueueItem
                        {
                            From = pD.Portal,
                            Coordinate = pD.Portal.Coordinate,
                            Count = qi.Count + pD.Distance,
                            Level = qi.Level,
                            Steps = steps
                        });
                        continue;
                    }

                    if (pD.Portal.Exit == null)
                    {
                        continue;
                    }

                    steps += "," + pD.Portal.Name + llevel;
                    queue.Enqueue(new QueueItem
                    {
                        From = pD.Portal.Exit,
                        Coordinate = pD.Portal.Exit.Coordinate,
                        Count = qi.Count + pD.Distance + 1,
                        Level = llevel,
                        Steps = steps
                    });
                    //var level2 = qi.Level;

                    //queue.Enqueue(new QueueItem
                    //{
                    //    From = pD.Portal, Coordinate = pD.Portal.Coordinate, Count = count + pD.Distance, Level = level2
                    //});
                    //ClosestByLevel(pD.Portal, to, from, visited2, count + pD.Distance, llevel, ref lowestSteps);
                }

                //if (from.Exit != null)
                //{
                //    var llevel = qi.From.Inner ? qi.Level + 1 : qi.Level - 1;
                //    queue.Enqueue(new QueueItem
                //    {
                //        From = from.Exit,
                //        Coordinate = from.Exit.Coordinate,
                //        Count = count + 1,
                //        Level = llevel
                //    });
                //}
            }
        }


        private void
            ClosestByLevel(Portal from, Portal to, Portal last, List<string> visited, int count, int level, ref int lowestSteps)
        {
            if (count > lowestSteps || level < 0 || level > 35 || count > 500)
            {
                return;
            }

            bool OnlyInner(Portal p)
            {

                if (p.GetLevel(level, @from) > 0 || (p.Inner || p.Name == "ZZ"))
                {
                    return true;
                }

                return false;
            };

            var visitablePortals = from.ConnectedTo.Where(c => !ReferenceEquals(c.Portal, last) &&
                                                               OnlyInner(c.Portal)).Reverse().ToList();

            foreach (var pD in visitablePortals)
            {
                var isTarget = object.ReferenceEquals(pD.Portal, to);
                var level2 = level;

                if (isTarget && level2 != 0)
                {
                    continue;
                }

                if (!isTarget)
                {
                    var visited2 = new List<string>(visited);
                    var sameLevel = from.Name != pD.Portal.Name;
                    var llevel = -1;
                    var key = "";
                    if (sameLevel)
                    {
                        llevel = level2;
                        key = pD.Portal.GetLevelKey(level2);
                    }
                    else
                    {
                        llevel = from.Inner ? level2 + 1 : level2 - 1;
                        key = pD.Portal.GetLevelKey(llevel);
                    }
                    visited2.Add(key);

                    if (visited2.Count(s => s == key) > 2)
                    {
                        continue;
                    }

                    ClosestByLevel(pD.Portal, to, from, visited2, count + pD.Distance, llevel, ref lowestSteps);
                }
                else
                {
                    var visited2 = new List<string>(visited);
                    visited2.Add(pD.Portal.GetLevelKey(level2));
                    //Console.WriteLine(string.Join(", ", visited2) + " in " + (count + pD.Distance));
                    if (count + pD.Distance < lowestSteps)
                    {
                        lowestSteps = count + pD.Distance;
                        Console.WriteLine(lowestSteps);
                    }
                }
            }
        }

        private Grid<Coordinate, DonutItem> CreateGrid(List<string> input)
        {
            var grid = new Grid<Coordinate, DonutItem>();

            for (var y = 0; y < input.Count; y++)
            {
                for (var x = 0; x < input[0].Length; x++)
                {
                    var newCoord = new Coordinate(x, y);

                    //if (input[y][x] == '#')
                    //{
                    //    var item = new DonutItem {Coordinate = newCoord, Symbol = '#', Traversable = false};
                    //    grid.Add(newCoord, item);
                    //    continue;
                    //}

                    if (input[y][x] == '.')
                    {
                        var item = new DonutItem {Coordinate = newCoord, Symbol = '.', Traversable = true};
                        grid.Add(newCoord, item);
                        continue;
                    }

                    if (abc.Any(a => a == input[y][x]))
                    {
                        var item = new DonutItem {Coordinate = newCoord, Symbol = input[y][x], Traversable = false};
                        grid.Add(newCoord, item);
                        continue;
                    }
                }
            }

            return grid;
        }
    }

    public class QueueItem
    {
        //Portal from, Portal to, Portal last, List<string> visited, int count, int level
        public Portal From;
        public Coordinate Coordinate;
        public int Count;
        public int Level;
        public string Steps;
    }

    public class DonutItem
    {
        public Coordinate Coordinate;
        public char Symbol;
        public bool Traversable;
    }

    public class Portal
    {
        public string Name;
        public Coordinate Coordinate;
        public List<PortalDistance> ConnectedTo = new List<PortalDistance>();
        public Portal Exit;
        public int Level = -1;
        public bool Inner;

        public override string ToString()
        {
            return Name;
        }

        public string GetLevelKey(int level, Portal p)
        {
            if (p.Exit == this)
            {
                var llevel = p.Inner ? level + 1 : level - 1;
                return Name + llevel;
            }

            return Name + level;
        }

        public int GetLevel(int level, Portal p)
        {
            if (p.Exit == this)
            {
                var llevel = p.Inner ? level + 1 : level - 1;
                return llevel;
            }

            return level;
        }

        public string GetLevelKey(int level)
        {
            return Name + level;
        }

        public string GetCompoundKey(int level, Portal from)
        {
            if (Name == "ZZ" || Name == "AA")
            {
                return Name + level;
            }

            var key = GetLevelKey(level, from);

            if (Name == from.Name)
            {
                key = Name + level + key;
            }

            if (Name != from.Name)
            {
                key = key + Exit.GetLevelKey(level, this);
            }

            return key;
        }
    }

    public class PortalDistance
    {
        public Portal Portal;
        public int Distance;

        public override string ToString()
        {
            return $"{Distance} steps to {Portal.Name}";
        }
    }

    public class PortalLevel
    {
        public int Level;
        public Portal Portal;
    }

}