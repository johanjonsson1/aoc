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
            Console.WriteLine();
        }
    }

    public class Asteroid
    {
        public List<double> OccupiedAngles = new List<double>();
        public int OtherAsteroids;
        public Coordinate Coordinate { get; private set; }

        public Asteroid(int x, int y)
        {
            Coordinate = new Coordinate(x, y);
        }
    }
}