using System;
using System.Collections.Generic;
using System.Linq;
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

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day18.ToStringList();
            input = @"########################
#f.D.E.e.C.b.A.@.a.B.c.#
######################.#
#d.....................#
########################".ToStringList();

            Grid = CreateAreas(input, out var start);
            VisitAllowed = Allowed;

            var keys = Grid.GetAll().Where(a => a is Key).Cast<Key>().ToList();
            var doors = Grid.GetAll().Where(a => a is Door).Cast<Door>().ToList();
            var currentPosition = start;
            var sum = 0;
            while (keys.Any(a => a.IsFound == false))
            {
                Key closest = null;
                var distance = int.MaxValue;

                foreach (var key in keys.Where(k => k.IsFound == false))
                {
                    var dist = GetClosestPathTo(currentPosition, key.Coordinate).Count - 1;

                    if (dist != -1 && dist < distance)
                    {
                        closest = key;
                        distance = dist;
                    }
                }

                if (closest != null)
                {
                    Console.WriteLine($"Going for key {closest.Id} with {distance} steps");
                    sum += distance;
                    closest.IsFound = true;
                    currentPosition = closest.Coordinate;
                    var d = doors.FirstOrDefault(f => f.Id == closest.Id.ToUpper());
                    if (d != null)
                    {
                        d.IsLocked = false;
                    }
                }
                else
                {
                    Console.WriteLine("FAIL");
                }
            }

            Console.WriteLine(sum);
        }

        private bool Allowed(Area area)
        {
            if (area.IsWall)
            {
                return false;
            }

            var door = area as Door;
            if (door != null && door.IsLocked)
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
                        var key = new Key {Coordinate = newCoord, Id = input[y][x].ToString()};
                        grid.Add(newCoord, key);
                        continue;
                    }

                    if (abc.ToUpper().Contains(input[y][x]))
                    {
                        var key = new Door() { Coordinate = newCoord, Id = input[y][x].ToString() };
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

        public List<Area> GetClosestPathTo(Coordinate from, Coordinate to)
        {
            VisitAllowed = Allowed;
            var lowestSteps = int.MaxValue;
            var visited = new List<Area>();
            var lastCoordinate = new Coordinate(int.MinValue, int.MinValue);
            Grid.TryGet(from, out var start);

            Find(from, to, 0, new List<Area> {start},  ref lowestSteps, ref visited);

            Console.WriteLine(lowestSteps);
            return visited;
        }

        private void Find(Coordinate from, Coordinate to, int count, List<Area> currentVisited, ref int lowestSteps, ref List<Area> visited)
        {
            var visitable = Grid.GetAll().Where(g =>
                from.IsAdjacent(g.Coordinate) && VisitAllowed(g) &&
                !currentVisited.Any(t => t.Coordinate.Equals(g.Coordinate))).ToList();

            foreach (var area in visitable)
            {
                var isTarget = area.Coordinate.Equals(to);
                var thisVisited = new List<Area>(currentVisited);
                thisVisited.Add(area);
                if (!isTarget)
                {
                    Find(area.Coordinate, to, count+1, thisVisited, ref lowestSteps, ref visited);
                }
                else
                {
                    // End point.
                    // ... Could print the optimal maze solution here.
                    if (count + 1 < lowestSteps)
                    {
                        lowestSteps = count + 1;
                        visited = thisVisited;
                    }

                    return;
                }
            }
        }

        private static Func<Area, bool> VisitAllowed;
    }

    public class Area
    {
        public Coordinate Coordinate;
        public bool IsWall;
    }

    public class Door : Area
    {
        public string Id;
        public bool IsLocked = true;
    }

    public class Key : Area
    {
        public string Id;
        public bool IsFound;
    }
}