namespace AoC2019;
/*
--- Day 18: Many-Worlds Interpretation ---
As you approach Neptune, a planetary security system detects you and activates a giant tractor beam on Triton! You have no choice but to land.

A scan of the local area reveals only one interesting feature: a massive underground vault. You generate a map of the tunnels (your puzzle input). The tunnels are too narrow to move diagonally.

Only one entrance (marked @) is present among the open passages (marked .) and stone walls (#), but you also detect an assortment of keys (shown as lowercase letters) and doors (shown as uppercase letters). Keys of a given letter open the door of the same letter: a opens A, b opens B, and so on. You aren't sure which key you need to disable the tractor beam, so you'll need to collect all of them.

For example, suppose you have the following map:

#########
#b.A.@.a#
#########
Starting from the entrance (@), you can only access a large door (A) and a key (a). Moving toward the door doesn't help you, but you can move 2 steps to collect the key, unlocking A in the process:

#########
#b.....@#
#########
Then, you can move 6 steps to collect the only other key, b:

#########
#@......#
#########
So, collecting every key took a total of 8 steps.

Here is a larger example:

########################
#f.D.E.e.C.b.A.@.a.B.c.#
######################.#
#d.....................#
########################
The only reasonable move is to take key a and unlock door A:

########################
#f.D.E.e.C.b.....@.B.c.#
######################.#
#d.....................#
########################
Then, do the same with key b:

########################
#f.D.E.e.C.@.........c.#
######################.#
#d.....................#
########################
...and the same with key c:

########################
#f.D.E.e.............@.#
######################.#
#d.....................#
########################
Now, you have a choice between keys d and e. While key e is closer, collecting it now would be slower in the long run than collecting key d first, so that's the best choice:

########################
#f...E.e...............#
######################.#
#@.....................#
########################
Finally, collect key e to unlock door E, then collect key f, taking a grand total of 86 steps.

Here are a few more examples:

########################
#...............b.C.D.f#
#.######################
#.....@.a.B.c.d.A.e.F.g#
########################
Shortest path is 132 steps: b, a, c, d, f, e, g

#################
#i.G..c...e..H.p#
########.########
#j.A..b...f..D.o#
########@########
#k.E..a...g..B.n#
########.########
#l.F..d...h..C.m#
#################
Shortest paths are 136 steps;
one is: a, f, b, j, g, n, h, d, l, o, e, p, c, i, k, m

########################
#@..............ac.GI.b#
###d#e#f################
###A#B#C################
###g#h#i################
########################
Shortest paths are 81 steps; one is: a, c, f, i, d, g, b, e, h

How many steps is the shortest path that collects all of the keys?

Your puzzle answer was 7048.

--- Part Two ---
You arrive at the vault only to discover that there is not one vault, but four - each with its own entrance.

On your map, find the area in the middle that looks like this:

...
.@.
...
Update your map to instead use the correct data:

@#@
###
@#@
This change will split your map into four separate sections, each with its own entrance:

#######       #######
#a.#Cd#       #a.#Cd#
##...##       ##@#@##
##.@.##  -->  #######
##...##       ##@#@##
#cB#Ab#       #cB#Ab#
#######       #######
Because some of the keys are for doors in other vaults, it would take much too long to collect all of the keys by yourself. Instead, you deploy four remote-controlled robots. Each starts at one of the entrances (@).

Your goal is still to collect all of the keys in the fewest steps, but now, each robot has its own position and can move independently. You can only remotely control a single robot at a time. Collecting a key instantly unlocks any corresponding doors, regardless of the vault in which the key or door is found.

For example, in the map above, the top-left robot first collects key a, unlocking door A in the bottom-right vault:

#######
#@.#Cd#
##.#@##
#######
##@#@##
#cB#.b#
#######
Then, the bottom-right robot collects key b, unlocking door B in the bottom-left vault:

#######
#@.#Cd#
##.#@##
#######
##@#.##
#c.#.@#
#######
Then, the bottom-left robot collects key c:

#######
#@.#.d#
##.#@##
#######
##.#.##
#@.#.@#
#######
Finally, the top-right robot collects key d:

#######
#@.#.@#
##.#.##
#######
##.#.##
#@.#.@#
#######
In this example, it only took 8 steps to collect all of the keys.

Sometimes, multiple robots might have keys available, or a robot might have to wait for multiple keys to be collected:

###############
#d.ABC.#.....a#
######@#@######
###############
######@#@######
#b.....#.....c#
###############
First, the top-right, bottom-left, and bottom-right robots take turns collecting keys a, b, and c, a total of 6 + 6 + 6 = 18 steps. Then, the top-left robot can access key d, spending another 6 steps; collecting all of the keys here takes a minimum of 24 steps.

Here's a more complex example:

#############
#DcBa.#.GhKl#
#.###@#@#I###
#e#d#####j#k#
###C#@#@###J#
#fEbA.#.FgHi#
#############
Top-left robot collects key a.
Bottom-left robot collects key b.
Top-left robot collects key c.
Bottom-left robot collects key d.
Top-left robot collects key e.
Bottom-left robot collects key f.
Bottom-right robot collects key g.
Top-right robot collects key h.
Bottom-right robot collects key i.
Top-right robot collects key j.
Bottom-right robot collects key k.
Top-right robot collects key l.
In the above example, the fewest steps to collect all of the keys is 32.

Here's an example with more choices:

#############
#g#f.D#..h#l#
#F###e#E###.#
#dCba@#@BcIJ#
#############
#nK.L@#@G...#
#M###N#H###.#
#o#m..#i#jk.#
#############
One solution with the fewest steps is:

Top-left robot collects key e.
Top-right robot collects key h.
Bottom-right robot collects key i.
Top-left robot collects key a.
Top-left robot collects key b.
Top-right robot collects key c.
Top-left robot collects key d.
Top-left robot collects key f.
Top-left robot collects key g.
Bottom-right robot collects key k.
Bottom-right robot collects key j.
Top-right robot collects key l.
Bottom-left robot collects key n.
Bottom-left robot collects key m.
Bottom-left robot collects key o.
This example requires at least 72 steps to collect all keys.

After updating your map and using the remote-controlled robots, what is the fewest steps necessary to collect all of the keys?

Your puzzle answer was 1836.
*/

public class Day18 : Day
{
    public override string Title => "--- Day 18: Many-Worlds Interpretation ---";
    public Grid<Coordinate, Area> Grid = new Grid<Coordinate, Area>();
    public object locker = new object();
    public List<Area> all;
    public List<Key> keys;

    public override void PartOne()
    {
        base.PartOne();
        var input = Inputs.Day18.ToStringList();
        //            input = @"#################
        //#i.G..c...e..H.p#
        //########.########
        //#j.A..b...f..D.o#
        //########@########
        //#k.E..a...g..B.n#
        //########.########
        //#l.F..d...h..C.m#
        //#################".ToStringList();

        Grid = CreateAreas(input, out var start);
        all = Grid.GetAll();
        keys = all.Where(a => a is Key).Cast<Key>().ToList();

        foreach (var key in keys)
        {
            Console.WriteLine("Finding distances doors n keys between keys for key " + (char)key.Id);
            foreach (var otherKey in keys.Where(x => x.Id != key.Id))
            {
                var lowestSteps = int.MaxValue;
                var doors = new List<Door>();
                var keysBetween = new List<Key>();

                FindWithDoorsAndKeysNoOverflow(new DoorKeysQueueItem
                {
                    From = key.Coordinate,
                    To = otherKey.Coordinate,
                    Last = new Coordinate(int.MinValue, int.MinValue),
                    Count = 0,
                    DoorsBetween = new List<Door>(),
                    KeysBetween = new List<Key>()
                }, ref lowestSteps, ref doors, ref keysBetween);

                //FindWithDoorsAndKeys(key.Coordinate, otherKey.Coordinate,
                //    new Coordinate(int.MinValue, int.MinValue), 0,
                //    new List<Door>(), new List<Key>(), ref lowestSteps, ref doors, ref keysBetween);

                key.Distances.Add(new KeyDistance
                {
                    Distance = lowestSteps,
                    DoorsBetween = doors.Select(s => s.Id).ToArray(),
                    KeysBetween = keysBetween.Select(s => s.Id).ToArray(),
                    Key = otherKey
                });
            }

            key.Distances = key.Distances.OrderBy(o => o.Distance).ToList();
        }

        var reachableKeys = new List<Tuple<Key, int>>();

        foreach (var key in keys)
        {
            Console.WriteLine("Checking if reachable key " + (char)key.Id);
            var lowestSteps = int.MaxValue;
            var doors = new List<Door>();
            var keysBetween = new List<Key>();

            FindWithDoorsAndKeysNoOverflow(new DoorKeysQueueItem
            {
                From = start,
                To = key.Coordinate,
                Last = new Coordinate(int.MinValue, int.MinValue),
                Count = 0,
                DoorsBetween = new List<Door>(),
                KeysBetween = new List<Key>()
            }, ref lowestSteps, ref doors, ref keysBetween);

            //FindWithDoorsAndKeys(start, key.Coordinate, new Coordinate(int.MinValue, int.MinValue), 0,
            //    new List<Door>(), new List<Key>(),
            //    ref lowestSteps, ref doors, ref keysBetween);

            if (doors.Count == 0)
            {
                reachableKeys.Add(new Tuple<Key, int>(key, lowestSteps));
            }
        }

        var lowestOfTheLow = int.MaxValue;

        //Parallel.ForEach(reachableKeys, reachableKey =>
        //{
        //    var lowestSteps = int.MaxValue;
        //    NewFind(reachableKey.Item1, 0, new HashSet<int> {reachableKey.Item1.Id}, ref lowestSteps);

        //    lock (locker)
        //    {
        //        if (lowestSteps + reachableKey.Item2 < lowestOfTheLow)
        //        {
        //            lowestOfTheLow = lowestSteps + reachableKey.Item2;
        //        }
        //    }
        //});

        GC.Collect();

        var ordered = reachableKeys.OrderBy(o => o.Item2).ToList();

        foreach (var reachableKey in reachableKeys)
        {
            Console.WriteLine("Checking fewest steps starting from " + (char)reachableKey.Item1.Id);
            FindNewQueue(new AreaQueue
            {
                CollectedKeys = new Dictionary<int, int>(), //new HashSet<int>(),
                Count = reachableKey.Item2,
                Current = reachableKey.Item1
            }, ref lowestOfTheLow);

            GC.Collect();
        }

        //Parallel.ForEach(reachableKeys, new ParallelOptions { MaxDegreeOfParallelism = 4 }, reachableKey =>
        // {
        //     var lowestSteps = int.MaxValue;
        //     Console.WriteLine("Checking fewest steps starting from " + (char)reachableKey.Item1.Id);
        //     FindNewQueue(new AreaQueue
        //     {
        //         CollectedKeys = new Dictionary<int, int>(),
        //         Count = reachableKey.Item2,
        //         Current = reachableKey.Item1
        //     }, ref lowestSteps);

        //     lock (locker)
        //     {
        //         if (lowestSteps < lowestOfTheLow)
        //         {
        //             lowestOfTheLow = lowestSteps;
        //         }
        //     }

        //     GC.Collect();
        // });

        Console.WriteLine("Final: " + lowestOfTheLow); // 7084 too high -> 7048
    }

    private bool Allowed(Area area)
    {
        if (area.IsWall)
        {
            return false;
        }

        return true;
    }

    private static Grid<Coordinate, Area> CreateAreas2(List<string> input, out List<Coordinate> startPositions)
    {
        var abc = "abcdefghijklmnopqrstuvwxyz";
        var grid = new Grid<Coordinate, Area>();

        //########################
        //#f.D.E.e.C.b.A.@.a.B.c.#
        //######################.#
        //#d.....................#
        //########################
        startPositions = new List<Coordinate>();

        for (var y = 0; y < input.Count; y++)
        {
            for (var x = 0; x < input[0].Length; x++)
            {
                var newCoord = new Coordinate(x, y);

                if (input[y][x] == '#')
                {
                    var wall = new Area { Coordinate = newCoord, IsWall = true };
                    grid.Add(newCoord, wall);
                    continue;
                }

                if (input[y][x] == '.')
                {
                    var hallway = new Area { Coordinate = newCoord, IsWall = false };
                    grid.Add(newCoord, hallway);
                    continue;
                }

                if (input[y][x] == '@')
                {
                    startPositions.Add(newCoord);
                    var hallway = new Area { Coordinate = newCoord, IsWall = false };
                    grid.Add(newCoord, hallway);
                    continue;
                }

                if (abc.Contains(input[y][x]))
                {
                    var key = new Key { Coordinate = newCoord, Id = input[y][x] };
                    grid.Add(newCoord, key);
                    continue;
                }

                if (abc.ToUpper().Contains(input[y][x]))
                {
                    var key = new Door() { Coordinate = newCoord, Id = input[y][x].ToString().ToLower()[0] };
                    grid.Add(newCoord, key);
                    continue;
                }
            }
        }

        return grid;
    }

    private static Grid<Coordinate, Area> CreateAreas(List<string> input, out Coordinate startPosition)
    {
        var abc = "abcdefghijklmnopqrstuvwxyz";
        var grid = new Grid<Coordinate, Area>();

        //########################
        //#f.D.E.e.C.b.A.@.a.B.c.#
        //######################.#
        //#d.....................#
        //########################
        startPosition = new Coordinate(int.MinValue, int.MinValue);

        for (var y = 0; y < input.Count; y++)
        {
            for (var x = 0; x < input[0].Length; x++)
            {
                var newCoord = new Coordinate(x, y);

                if (input[y][x] == '#')
                {
                    var wall = new Area { Coordinate = newCoord, IsWall = true };
                    grid.Add(newCoord, wall);
                    continue;
                }

                if (input[y][x] == '.')
                {
                    var hallway = new Area { Coordinate = newCoord, IsWall = false };
                    grid.Add(newCoord, hallway);
                    continue;
                }

                if (input[y][x] == '@')
                {
                    startPosition = newCoord;
                    var hallway = new Area { Coordinate = newCoord, IsWall = false };
                    grid.Add(newCoord, hallway);
                    continue;
                }

                if (abc.Contains(input[y][x]))
                {
                    var key = new Key { Coordinate = newCoord, Id = input[y][x] };
                    grid.Add(newCoord, key);
                    continue;
                }

                if (abc.ToUpper().Contains(input[y][x]))
                {
                    var key = new Door() { Coordinate = newCoord, Id = input[y][x].ToString().ToLower()[0] };
                    grid.Add(newCoord, key);
                    continue;
                }
            }
        }

        return grid;
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Inputs.Day18_Part2.ToStringList();
        //            input = @"#############
        //#DcBa.#.GhKl#
        //#.###@#@#I###
        //#e#d#####j#k#
        //###C#@#@###J#
        //#fEbA.#.FgHi#
        //#############".ToStringList();

        Grid = CreateAreas2(input, out var startPositions);
        all = Grid.GetAll();
        keys = all.Where(a => a is Key).Cast<Key>().ToList();

        foreach (var key in keys)
        {
            Console.WriteLine("Finding distances doors n keys between keys for key " + (char)key.Id);
            foreach (var otherKey in keys.Where(x => x.Id != key.Id))
            {
                var lowestSteps = int.MaxValue;
                var doors = new List<Door>();
                var keysBetween = new List<Key>();

                FindWithDoorsAndKeysNoOverflow(new DoorKeysQueueItem
                {
                    From = key.Coordinate,
                    To = otherKey.Coordinate,
                    Last = new Coordinate(int.MinValue, int.MinValue),
                    Count = 0,
                    DoorsBetween = new List<Door>(),
                    KeysBetween = new List<Key>()
                }, ref lowestSteps, ref doors, ref keysBetween);

                if (lowestSteps == int.MaxValue)
                {
                    continue;
                }

                key.Distances.Add(new KeyDistance
                {
                    Distance = lowestSteps,
                    DoorsBetween = doors.Select(s => s.Id).ToArray(),
                    KeysBetween = keysBetween.Select(s => s.Id).ToArray(),
                    Key = otherKey
                });
            }

            key.Distances = key.Distances.OrderBy(o => o.Distance).ToList();
        }

        var subgrids = new List<SubGrid>();

        foreach (var startPosition in startPositions)
        {
            var reachableKeys = new List<Tuple<Key, int>>();
            foreach (var key in keys)
            {
                Console.WriteLine("Checking if reachable key " + (char)key.Id);
                var lowestSteps = int.MaxValue;
                var doors = new List<Door>();
                var keysBetween = new List<Key>();

                FindWithDoorsAndKeysNoOverflow(new DoorKeysQueueItem
                {
                    From = startPosition,
                    To = key.Coordinate,
                    Last = new Coordinate(int.MinValue, int.MinValue),
                    Count = 0,
                    DoorsBetween = new List<Door>(),
                    KeysBetween = new List<Key>()
                }, ref lowestSteps, ref doors, ref keysBetween);

                if (lowestSteps == int.MaxValue)
                {
                    continue;
                }

                //if (doors.Count == 0)
                //{
                reachableKeys.Add(new Tuple<Key, int>(key, lowestSteps));
                //}
            }

            subgrids.Add(new SubGrid { Start = startPosition, Reachable = reachableKeys });
        }

        GC.Collect();

        var sum = 0;

        foreach (var subgrid in subgrids)
        {
            var lowestOfTheLow = int.MaxValue;
            var allKeys = subgrid.Reachable.Select(s => s.Item1).ToList();
            foreach (var reachableKey in subgrid.Reachable)
            {
                Console.WriteLine("Checking fewest steps starting from " + (char)reachableKey.Item1.Id);
                FindNewQueue2(new AreaQueue
                {
                    CollectedKeys = new Dictionary<int, int>(), //new HashSet<int>(),
                    Count = reachableKey.Item2,
                    Current = reachableKey.Item1
                }, ref lowestOfTheLow, ref allKeys);

                GC.Collect();
            }

            if (lowestOfTheLow == int.MaxValue)
            {
                Console.WriteLine("FAILURE!");
            }
            else
            {
                sum += lowestOfTheLow;
            }
        }

        Console.WriteLine("Final: " + sum);
        Console.WriteLine();
    }

    public class SubGrid
    {
        public Coordinate Start;
        public List<Tuple<Key, int>> Reachable = new List<Tuple<Key, int>>();
    }

    public class AreaQueue
    {
        public Key From;
        public Key Current;
        public int Count;
        public Dictionary<int, int> CollectedKeys;

        public void Addkey(int key)
        {
            if (CollectedKeys.TryGetValue(key, out var visits))
            {
                CollectedKeys[key] += 1;
                return;
            }

            CollectedKeys[key] = 1;
        }

        public bool KeyVisitedTooManyTimes()
        {
            return CollectedKeys.Values.Any(a => a > 5);
        }

        public string GetKey()
        {
            var key = string.Join("", CollectedKeys.Keys.OrderBy(o => o));
            return Current.Id + "_" + key;
        }
    }

    //public int lowestSteps = int.MaxValue;
    public Dictionary<string, int> visited = new Dictionary<string, int>();

    private void
        FindNewQueue2(AreaQueue first, ref int lowestSteps, ref List<Key> allKeys)
    {
        var queue = new Queue<AreaQueue>();
        queue.Enqueue(first);
        var counter = 0;
        var filteredByTimes = 0;
        var filteredByVisited = 0;

        while (queue.Count > 0)
        {
            counter++;

            if (counter % 300000 == 0)
            {
                Console.WriteLine("q " + queue.Count);
                Console.WriteLine("times " + filteredByTimes);
                Console.WriteLine("visited " + filteredByVisited);
            }

            var qi = queue.Dequeue();

            if (qi.Count > lowestSteps)
            {
                continue;
            }

            var distances = qi.From?.Distances?.FirstOrDefault(f => f.Key.Id == qi.Current.Id);
            //if (distances != null)
            //{
            //    var doors = distances.DoorsBetween;
            //    if (doors.Except(qi.CollectedKeys.Keys).Any())
            //    {
            //        continue;
            //    }
            //    // unlocked
            //}

            qi.Addkey(qi.Current.Id);
            if (distances != null)
            {
                foreach (var ki in distances.KeysBetween)
                {
                    qi.Addkey(ki);
                }
            }

            if (qi.CollectedKeys.Count == allKeys.Count)
            {
                if (qi.Count < lowestSteps)
                {
                    lowestSteps = qi.Count;
                    Console.WriteLine(qi.Count);
                }

                continue;
            }

            if (qi.CollectedKeys.Any())
            {
                var key = qi.GetKey();
                if (visited.TryGetValue(key, out var count))
                {
                    if (qi.Count >= count)
                    {
                        filteredByVisited++;
                        continue;
                    }
                    else
                    {
                        visited[key] = qi.Count;
                    }
                }
                else
                {
                    visited.Add(key, qi.Count);
                }
            }

            var visitableKeys = qi.Current.Distances.Where(
                    d => !qi.CollectedKeys.Keys.Contains(d.Key.Id))
                .ToList();

            foreach (var k in visitableKeys)
            {
                var collected = new Dictionary<int, int>(qi.CollectedKeys);
                var queueItem = new AreaQueue
                {
                    CollectedKeys = collected,
                    Count = qi.Count + k.Distance,
                    Current = k.Key,
                    From = qi.Current
                };

                queue.Enqueue(queueItem);
            }
        }
    }


    private void
        FindNewQueue(AreaQueue first, ref int lowestSteps)
    {
        var queue = new Queue<AreaQueue>();
        queue.Enqueue(first);

        //var visited = new List<Tuple<Coordinate, int>>();
        //visited.Add(new Tuple<Coordinate, int>(first.Coordinate, first.Level));
        //var visited = new Dictionary<string, int>();
        var counter = 0;
        var filteredByTimes = 0;
        var filteredByVisited = 0;

        while (queue.Count > 0)
        {
            counter++;

            if (counter % 300000 == 0)
            {
                Console.WriteLine("q " + queue.Count);
                Console.WriteLine("times " + filteredByTimes);
                Console.WriteLine("visited " + filteredByVisited);
            }

            var qi = queue.Dequeue();

            if (qi.Count > lowestSteps || qi.Count > 7084)
            {
                continue;
            }

            var distances = qi.From?.Distances?.FirstOrDefault(f => f.Key.Id == qi.Current.Id);
            if (distances != null)
            {
                var doors = distances.DoorsBetween;
                if (doors.Except(qi.CollectedKeys.Keys).Any())
                {
                    continue;
                }

                // unlocked
            }

            qi.Addkey(qi.Current.Id);
            //qi.CollectedKeys.Add(qi.Current.Id);

            if (distances != null)
            {
                foreach (var ki in distances.KeysBetween)
                {
                    qi.Addkey(ki);
                    //qi.CollectedKeys.Add(ki);
                }
            }

            if (qi.CollectedKeys.Count == keys.Count)
            {
                if (qi.Count < lowestSteps)
                {
                    lowestSteps = qi.Count;
                    Console.WriteLine(qi.Count);
                }

                continue;
            }

            //if (qi.KeyVisitedTooManyTimes())
            //{
            //    filteredByTimes++;
            //    continue;
            //}

            if (qi.CollectedKeys.Any())
            {
                var key = qi.GetKey();
                if (visited.TryGetValue(key, out var count))
                {
                    if (qi.Count >= count)
                    {
                        filteredByVisited++;
                        continue;
                    }
                    else
                    {
                        visited[key] = qi.Count;
                    }
                }
                else
                {
                    visited.Add(key, qi.Count);
                }
            }

            var visitableKeys = qi.Current.Distances.Where(
                    d => !qi.CollectedKeys.Keys.Contains(d.Key.Id))
                .ToList();

            foreach (var k in visitableKeys)
            {
                var collected = new Dictionary<int, int>(qi.CollectedKeys);
                var queueItem = new AreaQueue
                {
                    CollectedKeys = collected,
                    Count = qi.Count + k.Distance,
                    Current = k.Key,
                    From = qi.Current
                };

                queue.Enqueue(queueItem);
            }
        }
    }

    public class DoorKeysQueueItem
    {
        public Coordinate From;
        public Coordinate To;
        public Coordinate Last;
        public int Count;
        public List<Door> DoorsBetween;
        public List<Key> KeysBetween;
    }

    private void
        FindWithDoorsAndKeysNoOverflow(DoorKeysQueueItem first, ref int lowestSteps, ref List<Door> doors,
            ref List<Key> keys)
    {
        var queue = new Queue<DoorKeysQueueItem>();
        queue.Enqueue(first);
        var visited = new List<Coordinate>();

        while (queue.Count > 0)
        {
            var qi = queue.Dequeue();

            if (qi.Count > lowestSteps)
            {
                continue;
            }

            if (visited.Any(a => a.Equals(qi.From)))
            {
                continue;
            }

            visited.Add(qi.From);

            var visitable = all.Where(g =>
                qi.From.IsAdjacent(g.Coordinate) && Allowed(g) && !qi.Last.Equals(g.Coordinate)).ToList();

            foreach (var area in visitable)
            {
                var isTarget = area.Coordinate.Equals(qi.To);
                var d = area as Door;
                var k = area as Key;
                var myDoors = new List<Door>(qi.DoorsBetween);
                var myKeys = new List<Key>(qi.KeysBetween);

                if (d != null)
                {
                    myDoors.Add(d);
                }

                if (!isTarget)
                {
                    if (k != null)
                    {
                        myKeys.Add(k);
                    }

                    queue.Enqueue(new DoorKeysQueueItem
                    {
                        From = area.Coordinate,
                        To = qi.To,
                        Last = qi.From,
                        Count = qi.Count + 1,
                        DoorsBetween = myDoors,
                        KeysBetween = myKeys
                    });
                }
                else
                {
                    if (qi.Count + 1 < lowestSteps)
                    {
                        lowestSteps = qi.Count + 1;
                        doors = myDoors;
                        keys = myKeys;
                    }

                    break;
                }
            }
        }
    }


    private void
        FindWithDoorsAndKeys(Coordinate from, Coordinate to, Coordinate last, int count,
            List<Door> doorsBetween, List<Key> keysBetween, ref int lowestSteps, ref List<Door> doors,
            ref List<Key> keys)
    {
        var visitable = all.Where(g =>
            from.IsAdjacent(g.Coordinate) && Allowed(g) && !last.Equals(g.Coordinate)).ToList();

        foreach (var area in visitable)
        {
            var isTarget = area.Coordinate.Equals(to);
            var d = area as Door;
            var k = area as Key;
            var myDoors = new List<Door>(doorsBetween);
            var myKeys = new List<Key>(keysBetween);

            if (d != null)
            {
                myDoors.Add(d);
            }

            if (!isTarget)
            {
                if (k != null)
                {
                    myKeys.Add(k);
                }

                FindWithDoorsAndKeys(area.Coordinate, to, from, count + 1, myDoors, myKeys, ref lowestSteps,
                    ref doors, ref keys);
            }
            else
            {
                if (count + 1 < lowestSteps)
                {
                    lowestSteps = count + 1;
                    doors = myDoors;
                    keys = myKeys;
                }

                return;
            }
        }
    }

    private void NewFind(Key from, int count, HashSet<int> collectedKeys, ref int lowestSteps)
    {
        if (count > lowestSteps)
        {
            return;
        }

        var visitableKeys = from.Distances.Where(
                d => !collectedKeys.Contains(d.Key.Id) &&
                     (d.DoorsBetween.Length == 0 ||
                      d.DoorsBetween.All(door => collectedKeys.Contains(door))))
            .ToList();

        foreach (var keyDistance in visitableKeys)
        {
            var collected = new HashSet<int>(collectedKeys);
            collected.Add(keyDistance.Key.Id);
            foreach (var k in keyDistance.KeysBetween)
            {
                collected.Add(k);
            }

            if (count + keyDistance.Distance > lowestSteps)
            {
                continue;
            }

            if (keys.Any(w => !collected.Contains(w.Id)))
            {
                NewFind(keyDistance.Key, count + keyDistance.Distance, collected, ref lowestSteps);
            }
            else
            {
                if (count + keyDistance.Distance < lowestSteps)
                {
                    lowestSteps = count + keyDistance.Distance;
                }

                return;
            }
        }
    }
}

public class Area
{
    public Coordinate Coordinate;
    public bool IsWall;

    public override string ToString()
    {
        return $"X {Coordinate.X}, Y {Coordinate.Y}";
    }
}

public class Door : Area
{
    public int Id;

    public override string ToString()
    {
        return Id + ", " + base.ToString();
    }
}

public class Key : Area
{
    public int Id;
    public List<KeyDistance> Distances = new List<KeyDistance>();

    public override string ToString()
    {
        return Id + ", " + base.ToString();
    }
}

public class KeyDistance
{
    public Key Key;
    public int Distance;
    public int[] DoorsBetween;
    public int[] KeysBetween;

    public override string ToString()
    {
        return $"{Distance} steps to {Key.Id} with {DoorsBetween.Length} doors between and {KeysBetween.Length}";
    }
}