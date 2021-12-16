namespace AoC2019;
/*
--- Day 20: Donut Maze ---
You notice a strange pattern on the surface of Pluto and land nearby to get a closer look. Upon closer inspection, you realize you've come across one of the famous space-warping mazes of the long-lost Pluto civilization!

Because there isn't much space on Pluto, the civilization that used to live here thrived by inventing a method for folding spacetime. Although the technology is no longer understood, mazes like this one provide a small glimpse into the daily life of an ancient Pluto citizen.

This maze is shaped like a donut. Portals along the inner and outer edge of the donut can instantly teleport you from one side to the other. For example:

         A           
         A           
  #######.#########  
  #######.........#  
  #######.#######.#  
  #######.#######.#  
  #######.#######.#  
  #####  B    ###.#  
BC...##  C    ###.#  
  ##.##       ###.#  
  ##...DE  F  ###.#  
  #####    G  ###.#  
  #########.#####.#  
DE..#######...###.#  
  #.#########.###.#  
FG..#########.....#  
  ###########.#####  
             Z       
             Z       
This map of the maze shows solid walls (#) and open passages (.). Every maze on Pluto has a start (the open tile next to AA) and an end (the open tile next to ZZ). Mazes on Pluto also have portals; this maze has three pairs of portals: BC, DE, and FG. When on an open tile next to one of these labels, a single step can take you to the other tile with the same label. (You can only walk on . tiles; labels and empty space are not traversable.)

One path through the maze doesn't require any portals. Starting at AA, you could go down 1, right 8, down 12, left 4, and down 1 to reach ZZ, a total of 26 steps.

However, there is a shorter path: You could walk from AA to the inner BC portal (4 steps), warp to the outer BC portal (1 step), walk to the inner DE (6 steps), warp to the outer DE (1 step), walk to the outer FG (4 steps), warp to the inner FG (1 step), and finally walk to ZZ (6 steps). In total, this is only 23 steps.

Here is a larger example:

                   A               
                   A               
  #################.#############  
  #.#...#...................#.#.#  
  #.#.#.###.###.###.#########.#.#  
  #.#.#.......#...#.....#.#.#...#  
  #.#########.###.#####.#.#.###.#  
  #.............#.#.....#.......#  
  ###.###########.###.#####.#.#.#  
  #.....#        A   C    #.#.#.#  
  #######        S   P    #####.#  
  #.#...#                 #......VT
  #.#.#.#                 #.#####  
  #...#.#               YN....#.#  
  #.###.#                 #####.#  
DI....#.#                 #.....#  
  #####.#                 #.###.#  
ZZ......#               QG....#..AS
  ###.###                 #######  
JO..#.#.#                 #.....#  
  #.#.#.#                 ###.#.#  
  #...#..DI             BU....#..LF
  #####.#                 #.#####  
YN......#               VT..#....QG
  #.###.#                 #.###.#  
  #.#...#                 #.....#  
  ###.###    J L     J    #.#.###  
  #.....#    O F     P    #.#...#  
  #.###.#####.#.#####.#####.###.#  
  #...#.#.#...#.....#.....#.#...#  
  #.#####.###.###.#.#.#########.#  
  #...#.#.....#...#.#.#.#.....#.#  
  #.###.#####.###.###.#.#.#######  
  #.#.........#...#.............#  
  #########.###.###.#############  
           B   J   C               
           U   P   P               
Here, AA has no direct path to ZZ, but it does connect to AS and CP. By passing through AS, QG, BU, and JO, you can reach ZZ in 58 steps.

In your maze, how many steps does it take to get from the open tile marked AA to the open tile marked ZZ?

Your puzzle answer was 422.

--- Part Two ---
Strangely, the exit isn't open when you reach it. Then, you remember: the ancient Plutonians were famous for building recursive spaces.

The marked connections in the maze aren't portals: they physically connect to a larger or smaller copy of the maze. Specifically, the labeled tiles around the inside edge actually connect to a smaller copy of the same maze, and the smaller copy's inner labeled tiles connect to yet a smaller copy, and so on.

When you enter the maze, you are at the outermost level; when at the outermost level, only the outer labels AA and ZZ function (as the start and end, respectively); all other outer labeled tiles are effectively walls. At any other level, AA and ZZ count as walls, but the other outer labeled tiles bring you one level outward.

Your goal is to find a path through the maze that brings you back to ZZ at the outermost level of the maze.

In the first example above, the shortest path is now the loop around the right side. If the starting level is 0, then taking the previously-shortest path would pass through BC (to level 1), DE (to level 2), and FG (back to level 1). Because this is not the outermost level, ZZ is a wall, and the only option is to go back around to BC, which would only send you even deeper into the recursive maze.

In the second example above, there is no path that brings you to ZZ at the outermost level.

Here is a more interesting example:

             Z L X W       C                 
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
               A A D   M                     
One shortest path through the maze is the following:

Walk from AA to XF (16 steps)
Recurse into level 1 through XF (1 step)
Walk from XF to CK (10 steps)
Recurse into level 2 through CK (1 step)
Walk from CK to ZH (14 steps)
Recurse into level 3 through ZH (1 step)
Walk from ZH to WB (10 steps)
Recurse into level 4 through WB (1 step)
Walk from WB to IC (10 steps)
Recurse into level 5 through IC (1 step)
Walk from IC to RF (10 steps)
Recurse into level 6 through RF (1 step)
Walk from RF to NM (8 steps)
Recurse into level 7 through NM (1 step)
Walk from NM to LP (12 steps)
Recurse into level 8 through LP (1 step)
Walk from LP to FD (24 steps)
Recurse into level 9 through FD (1 step)
Walk from FD to XQ (8 steps)
Recurse into level 10 through XQ (1 step)
Walk from XQ to WB (4 steps)
Return to level 9 through WB (1 step)
Walk from WB to ZH (10 steps)
Return to level 8 through ZH (1 step)
Walk from ZH to CK (14 steps)
Return to level 7 through CK (1 step)
Walk from CK to XF (10 steps)
Return to level 6 through XF (1 step)
Walk from XF to OA (14 steps)
Return to level 5 through OA (1 step)
Walk from OA to CJ (8 steps)
Return to level 4 through CJ (1 step)
Walk from CJ to RE (8 steps)
Return to level 3 through RE (1 step)
Walk from RE to IC (4 steps)
Recurse into level 4 through IC (1 step)
Walk from IC to RF (10 steps)
Recurse into level 5 through RF (1 step)
Walk from RF to NM (8 steps)
Recurse into level 6 through NM (1 step)
Walk from NM to LP (12 steps)
Recurse into level 7 through LP (1 step)
Walk from LP to FD (24 steps)
Recurse into level 8 through FD (1 step)
Walk from FD to XQ (8 steps)
Recurse into level 9 through XQ (1 step)
Walk from XQ to WB (4 steps)
Return to level 8 through WB (1 step)
Walk from WB to ZH (10 steps)
Return to level 7 through ZH (1 step)
Walk from ZH to CK (14 steps)
Return to level 6 through CK (1 step)
Walk from CK to XF (10 steps)
Return to level 5 through XF (1 step)
Walk from XF to OA (14 steps)
Return to level 4 through OA (1 step)
Walk from OA to CJ (8 steps)
Return to level 3 through CJ (1 step)
Walk from CJ to RE (8 steps)
Return to level 2 through RE (1 step)
Walk from RE to XQ (14 steps)
Return to level 1 through XQ (1 step)
Walk from XQ to FD (8 steps)
Return to level 0 through FD (1 step)
Walk from FD to ZZ (18 steps)
This path takes a total of 396 steps to move from AA at the outermost layer to ZZ at the outermost layer.

In your maze, when accounting for recursion, how many steps does it take to get from the open tile marked AA to the open tile marked ZZ, both at the outermost layer?

Your puzzle answer was 5040.
*/

public class Day20 : Day
{
    public override string Title => "--- Day 20: Donut Maze ---";
    private readonly string abc = "abcdefghijklmnopqrstuvwxyz".ToUpper();
    public List<DonutItem> all;

    public override void PartOne()
    {
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
        ClosestByPortal(startPortal, targetPortal, startPortal, new List<Portal>() { startPortal }, 0, ref ls);

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
                Console.WriteLine(string.Join(", ", visited2) + " in " + (count + pD.Distance));
                if (count + pD.Distance < lowestSteps)
                {
                    lowestSteps = count + pD.Distance;
                }
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
        Console.WriteLine("this " + lowestSteps);
    }

    private void SetInner(List<Portal> portals)
    {
        var maxY = portals.Max(m => m.Coordinate.Y);
        var maxX = portals.Max(m => m.Coordinate.X);
        foreach (var portal in portals)
        {
            if (portal.Coordinate.Y == 2 || portal.Coordinate.X == 2 || portal.Coordinate.Y == maxY ||
                portal.Coordinate.X == maxX)
            {
                portal.Inner = false;
                continue;
            }

            portal.Inner = true;
        }
    }

    public int lowestSteps = int.MaxValue;

    private void
        ClosestByLevelQueue(QueueItem first, Coordinate to)
    {
        var queue = new Queue<QueueItem>();
        queue.Enqueue(first);
        var visited = new List<Tuple<Coordinate, int>>();

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
            var visitablePortals = qi.From.ConnectedTo.Where(c => OnlyInner(c.Portal) && c.Portal != qi.From.Exit)
                .ToList();

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
            }
        }
    }

    private void
        ClosestByLevel(Portal from, Portal to, Portal last, List<string> visited, int count, int level,
            ref int lowestSteps)
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
        }

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
                    var item = new DonutItem { Coordinate = newCoord, Symbol = '.', Traversable = true };
                    grid.Add(newCoord, item);
                    continue;
                }

                if (abc.Any(a => a == input[y][x]))
                {
                    var item = new DonutItem { Coordinate = newCoord, Symbol = input[y][x], Traversable = false };
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