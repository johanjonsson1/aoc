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

        public int lowestSteps;
        public List<Coordinate> visited;
        public object locker = new object();
        public List<Area> all;
        public List<Key> keys;

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day18.ToStringList();
            input = @"#################
#i.G..c...e..H.p#
########.########
#j.A..b...f..D.o#
########@########
#k.E..a...g..B.n#
########.########
#l.F..d...h..C.m#
#################".ToStringList();

            Grid = CreateAreas(input, out var start);
            all = Grid.GetAll();
            keys = all.Where(a => a is Key).Cast<Key>().ToList();

            foreach (var key in keys)
            {
                foreach (var otherKey in keys.Where(x => x.Id != key.Id))
                {
                    var lowestSteps = int.MaxValue;
                    var doors = new List<Door>();
                    var keysBetween = new List<Key>();
                    FindWithDoorsAndKeys(key.Coordinate, otherKey.Coordinate, new Coordinate(int.MinValue, int.MinValue), 0,
                        new List<Door>(), new List<Key>(),  ref lowestSteps, ref doors, ref keysBetween);

                    key.Distances.Add(new KeyDistance
                    {
                        Distance = lowestSteps,
                        DoorsBetween = doors,
                        KeysBetween = keysBetween,
                        Key = otherKey
                    });
                }
            }

            var reachableKeys = new List<Tuple<Key,int>>();

            foreach (var key in keys)
            {
                var lowestSteps = int.MaxValue;
                var doors = new List<Door>();
                var keysBetween = new List<Key>();
                FindWithDoorsAndKeys(start, key.Coordinate, new Coordinate(int.MinValue, int.MinValue), 0, new List<Door>(), new List<Key>(), 
                    ref lowestSteps, ref doors, ref keysBetween);

                if (doors.Count == 0)
                {
                    reachableKeys.Add(new Tuple<Key, int>(key, lowestSteps));
                }
            }

            var lowestOfTheLow = int.MaxValue;

            Parallel.ForEach(reachableKeys, reachableKey =>
            {
                var lowestSteps = int.MaxValue;
                NewFind(reachableKey.Item1, 0, new List<string> { reachableKey.Item1.Id }, ref lowestSteps);

                lock (locker)
                {
                    if (lowestSteps + reachableKey.Item2 < lowestOfTheLow)
                    {
                        lowestOfTheLow = lowestSteps + reachableKey.Item2;
                    }
                }
            });

            //foreach (var reachableKey in reachableKeys)
            //{
            //    var lowestSteps = int.MaxValue;
            //    NewFind(reachableKey.Item1, 0, new List<string> {reachableKey.Item1.Id}, ref lowestSteps );

            //    if (lowestSteps + reachableKey.Item2 < lowestOfTheLow)
            //    {
            //        lowestOfTheLow = lowestSteps + reachableKey.Item2;
            //    }
            //}

            Console.WriteLine(lowestOfTheLow);
        }

        private bool Allowed(Area area)
        {
            if (area.IsWall)
            {
                return false;
            }

            //var door = area as Door;
            //if (door != null && door.IsLocked)
            //{
            //    return false;
            //}

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
                        var key = new Key {Coordinate = newCoord, Id = input[y][x].ToString()};
                        grid.Add(newCoord, key);
                        continue;
                    }

                    if (abc.ToUpper().Contains(input[y][x]))
                    {
                        var key = new Door() {Coordinate = newCoord, Id = input[y][x].ToString()};
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

        public List<Coordinate> GetClosestPathTo(Coordinate from, Coordinate to)
        {
            var lowestSteps = int.MaxValue;
            var visited = new List<Coordinate>();
            var lastCoordinate = new Coordinate(int.MinValue, int.MinValue);
            Grid.TryGet(from, out var start);

            Find(from, to, lastCoordinate, 0, new List<Visited> {new Visited {Coordinate = start.Coordinate}},
                ref lowestSteps, ref visited);

            Console.WriteLine(lowestSteps);
            return visited;
        }

        private void
            FindWithDoorsAndKeys(Coordinate from, Coordinate to, Coordinate last, int count,
                List<Door> doorsBetween, List<Key> keysBetween, ref int lowestSteps, ref List<Door> doors, ref List<Key> keys)
        {
            var visitable = all.Where(g =>
                from.IsAdjacent(g.Coordinate) && Allowed(g) && !last.Equals(g.Coordinate)).ToList();
            //!currentVisited.Any(t => t.Coordinate.Equals(g.Coordinate))).ToList();

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

                    FindWithDoorsAndKeys(area.Coordinate, to, from, count + 1, myDoors, myKeys, ref lowestSteps, ref doors, ref keys);
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

        private void NewFind(Key from, int count, List<string> collectedKeys, ref int lowestSteps)
        {
            if (count > lowestSteps)
            {
                return;
            }

            var visitableKeys = from.Distances.Where(
                    d => (d.DoorsBetween.Count == 0 ||
                         d.DoorsBetween.All(a => collectedKeys.Contains(a.Id.ToLower()))) &&
                         !collectedKeys.Contains(d.Key.Id))
                .ToList();

            foreach (var keyDistance in visitableKeys)
            {
                var collected = new List<string>(collectedKeys);
                collected.Add(keyDistance.Key.Id);
                collected.AddRange(keyDistance.KeysBetween.Select(s => s.Id));

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


        private void
            Find(Coordinate from, Coordinate to, Coordinate last, int count,
                List<Visited> currentVisited, ref int lowestSteps, ref List<Coordinate> visited)
        {
            if (count > lowestSteps)
            {
                return;
            }

            var keysFound = keys.Where(x => currentVisited.Select(s => s.Coordinate).Contains(x.Coordinate))
                .Select(s => s.Id).ToArray();
            //all.Where(x => x is Key && currentVisited.Select(s => s.Coordinate).Contains(x.Coordinate))
            //.Cast<Key>()
            //.Select(s => s.Id).ToArray();
            //currentVisited.Where(c => c is Key).Cast<Key>().Select(s => s.Id).ToArray();

            var visitable = all.Where(g =>
                from.IsAdjacent(g.Coordinate) && Allowed(g) &&
                Unlocked(g) &&
                !last.Equals(g.Coordinate)).ToList();
            //!currentVisited.Any(t => t.Coordinate.Equals(g.Coordinate))).ToList();

            foreach (var area in visitable)
            {
                var isTarget = area.Coordinate.Equals(to);
                var k = area as Key;
                var found = new List<string>(keysFound);

                if (k != null)
                {
                    found.Add(k.Id);
                }

                //var thisVisited = new List<Area>(currentVisited);
                //thisVisited.Add(area);
                if (!isTarget)
                {
                    var thisVisited = new List<Visited>(currentVisited);
                    thisVisited.Add(new Visited {Coordinate = area.Coordinate});
                    Find(area.Coordinate, to, from, count + 1, thisVisited, ref lowestSteps, ref visited);
                }
                else if (keys.Any(w => !found.Contains(w.Id)))
                {
                    foreach (var key in keys.Where(w => !found.Contains(w.Id)))
                    {
                        var thisVisited = new List<Visited>(currentVisited);
                        thisVisited.Add(new Visited {Coordinate = area.Coordinate});
                        var last2 = new Coordinate(int.MinValue,
                            int.MinValue); // turn around ok when grabbed key.. if not already found...
                        Find(area.Coordinate, key.Coordinate, last2, count + 1,
                            thisVisited, ref lowestSteps, ref visited);
                    }
                }
                else
                {
                    var thisVisited = new List<Visited>(currentVisited);
                    thisVisited.Add(new Visited {Coordinate = area.Coordinate});
                    if (count + 1 < lowestSteps)
                    {
                        lowestSteps = count + 1;
                        visited = thisVisited.Select(s => s.Coordinate).ToList();
                    }

                    return;
                }
            }

            bool Unlocked(Area a)
            {
                var d = a as Door;
                if (d != null)
                {
                    if (keysFound.Contains(d.Id.ToLower()))
                    {
                        return true;
                    }

                    return false;
                }

                return true;
            }
        }
    }

    public struct Visited
    {
        public Coordinate Coordinate;
        public bool IsDeadEnd;
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
        public string Id;
        public bool IsLocked = true;

        public override string ToString()
        {
            return Id + ", " + base.ToString();
        }
    }

    public class Key : Area
    {
        public string Id;
        public bool IsFound;
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
        public List<Door> DoorsBetween = new List<Door>();
        public List<Key> KeysBetween = new List<Key>();

        public override string ToString()
        {
            return $"{Distance} steps to {Key.Id} with {DoorsBetween.Count} doors between and {KeysBetween.Count}";
        }
    }
}