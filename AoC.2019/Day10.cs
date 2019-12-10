using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day10 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day10.ToStringList();
            input = @".#..##.###...#######
##.############..##.
.#.######.########.#
.###.#######.####.#.
#####.##.#.##.###.##
..#####..#.#########
####################
#.####....###.#.#.##
##.#################
#####.##.###..####..
..######..##.#######
####.##.####...##..#
.#####..#.######.###
##...#.##########...
#.##########.#######
.####.#.###.###.#.##
....##.##.###..#####
.#.#.###########.###
#.#.#.#####.####.###
###.##.####.##.#..##".ToStringList();
            var grid = new Grid<Coordinate, Asteroid>();

            for (int y = 0; y < input[0].Length; y++)
            {
                for (int x = 0; x < input.Count; x++)
                {
                    if (input[y][x] == '#')
                    {
                        var newCoord = new Coordinate(x, y);
                        grid.Add(newCoord, new Asteroid(newCoord.X, newCoord.Y));
                    }
                }
            }

            var all = grid.GetAll();

            foreach (var asteroid in all)
            {
                foreach (var otherAsteroid in all)
                {
                    if (object.ReferenceEquals(asteroid, otherAsteroid))
                    {
                        continue;
                    }

                    var angle = asteroid.Coordinate.GetAngle(otherAsteroid.Coordinate);

                    if (asteroid.OccupiedAngles.Contains(angle))
                    {
                        continue;
                    }

                    asteroid.OtherAsteroids++;
                    asteroid.OccupiedAngles.Add(angle);
                }
            }

            var ordered = all.OrderByDescending(o => o.OtherAsteroids).ToList();

            Console.WriteLine(ordered.First().OtherAsteroids);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day10.ToStringList();
            input = @".#..##.###...#######
##.############..##.
.#.######.########.#
.###.#######.####.#.
#####.##.#.##.###.##
..#####..#.#########
####################
#.####....###.#.#.##
##.#################
#####.##.###..####..
..######..##.#######
####.##.####...##..#
.#####..#.######.###
##...#.##########...
#.##########.#######
.####.#.###.###.#.##
....##.##.###..#####
.#.#.###########.###
#.#.#.#####.####.###
###.##.####.##.#..##".ToStringList();
            var grid = new Grid<Coordinate, Asteroid>();

            for (int y = 0; y < input[0].Length; y++)
            {
                for (int x = 0; x < input.Count; x++)
                {
                    if (input[y][x] == '#')
                    {
                        var newCoord = new Coordinate(x, y);
                        grid.Add(newCoord, new Asteroid(newCoord.X, newCoord.Y));
                    }
                }
            }

            var all = grid.GetAll();

            foreach (var asteroid in all)
            {
                foreach (var otherAsteroid in all)
                {
                    if (object.ReferenceEquals(asteroid, otherAsteroid))
                    {
                        continue;
                    }

                    var angle = asteroid.Coordinate.GetAngle(otherAsteroid.Coordinate);

                    if (asteroid.OccupiedAngles.Contains(angle))
                    {
                        continue;
                    }

                    asteroid.OtherAsteroids++;
                    asteroid.OccupiedAngles.Add(angle);
                }
            }

            var ordered = all.OrderByDescending(o => o.OtherAsteroids).ToList();
            var station = ordered.First();
            var currentAsteroids = all.Where(x => !x.Equals(station))
                //.OrderBy(t2 => t2.Coordinate.GetDistance(station.Coordinate))
                //.ThenBy(t3 => t3.Coordinate.GetAngle(station.Coordinate))
                .OrderBy(o => o.Coordinate.Y)
                .ThenBy(t1 => t1.Coordinate.X)
                .ToList();

            var counter = 0;
            while (currentAsteroids.Any(a=> a.Vaporized == false))
            {
                station.OccupiedAngles.Clear();
                foreach (var otherAsteroid in currentAsteroids.Where(x => x.Vaporized == false))
                {
                    var angle = station.Coordinate.GetAngle(otherAsteroid.Coordinate);

                    if (station.OccupiedAngles.Contains(angle))
                    {
                        continue;
                    }

                    var matchingAsteroids = currentAsteroids
                        .Where(x => x.Vaporized == false && station.Coordinate.GetAngle(x.Coordinate) == angle)
                        .OrderBy(o => o.Coordinate.GetDistance(station.Coordinate)).ToList();

                    var closest = matchingAsteroids.First();

                    if (counter == 199 || counter == 200)
                    {
                        var result = 100 * closest.Coordinate.X + closest.Coordinate.Y;
                        Console.WriteLine(result);
                    }

                    counter++;
                    closest.Vaporized = true;
                }
            }
        }
    }

    public class Asteroid
    {
        public List<double> OccupiedAngles = new List<double>();
        public int OtherAsteroids;
        public Coordinate Coordinate { get; private set; }
        public bool Vaporized = false;

        public Asteroid(int x, int y)
        {
            Coordinate = new Coordinate(x, y);
        }
    }
}