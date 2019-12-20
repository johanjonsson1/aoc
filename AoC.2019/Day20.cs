using System;
using System.Collections.Generic;
using System.Linq;
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
            GetConnectedTo2(startPortal, targetPortal, startPortal, new List<Portal>() {startPortal},  0, ref ls);

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
            GetConnectedTo2(Portal from, Portal to, Portal last, List<Portal> visited, int count, ref int lowestSteps)
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
                    GetConnectedTo2(pD.Portal, to, from, visited2, count + pD.Distance, ref lowestSteps);
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
            input = @"             Z L X W       C                 
             Z P Q B       K                 
  ###########.#.#.#.#######.###############  
  #...#.......#.#.......#.#.......#.#.#...#  
  ###.#.#.#.#.#.#.#.###.#.#.#######.#.#.###  
  #.#...#.#.#...#.#.#...#...#...#.#.......#  
  #.###.#######.###.###.#.###.###.#.#######  
  #...#.......#.#...#...#.............#...#  
  #.#########.#######.#.#######.#######.###  
  #...#.#    F       R I       Z    #.#.#.#  
  #.###.#    D       E C       H    #.#.#.#  
  #.#...#                           #...#.#  
  #.###.#                           #.###.#  
  #.#....OA                       WB..#.#..ZH
  #.###.#                           #.#.#.#  
CJ......#                           #.....#  
  #######                           #######  
  #.#....CK                         #......IC
  #.###.#                           #.###.#  
  #.....#                           #...#.#  
  ###.###                           #.#.#.#  
XF....#.#                         RF..#.#.#  
  #####.#                           #######  
  #......CJ                       NM..#...#  
  ###.#.#                           #.###.#  
RE....#.#                           #......RF
  ###.###        X   X       L      #.#.#.#  
  #.....#        F   Q       P      #.#.#.#  
  ###.###########.###.#######.#########.###  
  #.....#...#.....#.......#...#.....#.#...#  
  #####.#.###.#######.#######.###.###.#.#.#  
  #.......#.......#.#.#.#.#...#...#...#.#.#  
  #####.###.#####.#.#.#.#.###.###.#.###.###  
  #.......#.....#.#...#...............#...#  
  #############.#.#.###.###################  
               A O F   N                     
               A A D   M                     ".ToStringList();

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

            var ls = int.MaxValue;
            GetConnectedTo2(startPortal, targetPortal, startPortal, new List<Portal>() { startPortal }, 0, ref ls);
            Console.WriteLine(ls);
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

        public override string ToString()
        {
            return Name;
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
}