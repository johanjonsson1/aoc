using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day18 : Day
    {
        public override string Title => "";
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
                Console.WriteLine("Finding distances doors n keys between keys for key "+(char)key.Id);
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

            //foreach (var reachableKey in reachableKeys)
            //{
            //    Console.WriteLine("Checking fewest steps starting from " + (char)reachableKey.Item1.Id);
            //    FindNewQueue(new AreaQueue
            //    {
            //        CollectedKeys = new HashSet<int>(),
            //        Count = reachableKey.Item2,
            //        Current = reachableKey.Item1
            //    });
            //}

            Parallel.ForEach(reachableKeys, new ParallelOptions { MaxDegreeOfParallelism = 4 },reachableKey =>
            {
                var lowestSteps = int.MaxValue;
                Console.WriteLine("Checking fewest steps starting from " + (char)reachableKey.Item1.Id);
                FindNewQueue(new AreaQueue
                {
                    CollectedKeys = new HashSet<int>(),
                    Count = reachableKey.Item2,
                    Current = reachableKey.Item1
                }, ref lowestSteps);

                lock (locker)
                {
                    if (lowestSteps < lowestOfTheLow)
                    {
                        lowestOfTheLow = lowestSteps;
                    }
                }

                GC.Collect();
            });

            Console.WriteLine("Final: " + lowestOfTheLow); // 7084 too high
        }

        private bool Allowed(Area area)
        {
            if (area.IsWall)
            {
                return false;
            }

            return true;
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
                        var wall = new Area {Coordinate = newCoord, IsWall = true};
                        grid.Add(newCoord, wall);
                        continue;
                    }

                    if (input[y][x] == '.')
                    {
                        var hallway = new Area {Coordinate = newCoord, IsWall = false};
                        grid.Add(newCoord, hallway);
                        continue;
                    }

                    if (input[y][x] == '@')
                    {
                        startPosition = newCoord;
                        var hallway = new Area {Coordinate = newCoord, IsWall = false};
                        grid.Add(newCoord, hallway);
                        continue;
                    }

                    if (abc.Contains(input[y][x]))
                    {
                        var key = new Key {Coordinate = newCoord, Id = input[y][x]};
                        grid.Add(newCoord, key);
                        continue;
                    }

                    if (abc.ToUpper().Contains(input[y][x]))
                    {
                        var key = new Door() {Coordinate = newCoord, Id = input[y][x].ToString().ToLower()[0]};
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
            Console.WriteLine();
        }

        public class AreaQueue
        {
            public Key From;
            public Key Current;
            public int Count;
            public HashSet<int> CollectedKeys;
        }

        //public int lowestSteps = int.MaxValue;

        private void
    FindNewQueue(AreaQueue first, ref int lowestSteps)
        {
            var queue = new Queue<AreaQueue>();
            queue.Enqueue(first);

            //var visited = new List<Tuple<Coordinate, int>>();
            //visited.Add(new Tuple<Coordinate, int>(first.Coordinate, first.Level));
            var visited = new Dictionary<string, int>();

            while (queue.Count > 0)
            {
                var qi = queue.Dequeue();

                if (qi.Count > lowestSteps)
                {
                    continue;
                }

                var distances = qi.From?.Distances?.FirstOrDefault(f => f.Key.Id == qi.Current.Id);
                if (distances != null)
                {
                    var doors = distances.DoorsBetween;
                    if (doors.Except(qi.CollectedKeys).Any())
                    {
                        continue;
                    }
                    // unlocked
                }

                qi.CollectedKeys.Add(qi.Current.Id);

                if (distances != null)
                {
                    foreach (var ki in distances.KeysBetween)
                    {
                        qi.CollectedKeys.Add(ki);
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

                if (qi.CollectedKeys.Count >= 12)
                {
                    var key = string.Join("", qi.CollectedKeys.OrderBy(o => o));
                    if (visited.TryGetValue(key, out var count))
                    {
                        if (qi.Count >= count)
                        {
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
                        d => !qi.CollectedKeys.Contains(d.Key.Id))
                    .ToList();

                foreach (var k in visitableKeys)
                {
                    var collected = new HashSet<int>(qi.CollectedKeys);
                    queue.Enqueue(new AreaQueue
                    {
                        CollectedKeys = collected,
                        Count = qi.Count + k.Distance,
                        Current = k.Key,
                        From = qi.Current
                    });
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
}