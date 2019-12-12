using AoC.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2019
{
    /*

    */

    public class Day12 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = @"<x=-14, y=-4, z=-11>
<x=-9, y=6, z=-7>
<x=4, y=1, z=4>
<x=2, y=-14, z=-9>";

//            input = @"<x=-1, y=0, z=2>
//<x=2, y=-10, z=-7>
//<x=4, y=-8, z=8>
//<x=3, y=5, z=-1>";

            var moons = CreateMoons(input.ToStringList());

            for (int timestep = 0; timestep < 1000; timestep++)
            {
                moons.ForEach(m => m.ApplyGravity(moons));
                moons.ForEach(m => m.ApplyVelocity());
            }

            var result = moons.Sum(s => s.TotalEnergy);
            Console.WriteLine(result);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = @"<x=-14, y=-4, z=-11>
<x=-9, y=6, z=-7>
<x=4, y=1, z=4>
<x=2, y=-14, z=-9>";

//            input = @"<x=-1, y=0, z=2>
//            <x=2, y=-10, z=-7>
//            <x=4, y=-8, z=8>
//            <x=3, y=5, z=-1>";

//            input = @"<x=-8, y=-10, z=0>
//<x=5, y=5, z=10>
//<x=2, y=-7, z=3>
//<x=9, y=-8, z=-3>";

            var moons = CreateMoons(input.ToStringList());
            long x = 0;
            long y = 0;
            long z = 0;

            var xs = new Dictionary<string, long>();
            xs.Add(string.Join(",", moons.Select(s => s.XV)), 0);
            var ys = new Dictionary<string, long>();
            ys.Add(string.Join(",", moons.Select(s => s.YV)), 0);
            var zs = new Dictionary<string, long>();
            zs.Add(string.Join(",", moons.Select(s => s.ZV)), 0);

            for (var timestep = 1; timestep < int.MaxValue; timestep++)
            {
                moons.ForEach(m => m.ApplyGravity(moons));
                moons.ForEach(m => m.ApplyVelocity());

                var xKey = string.Join(",", moons.Select(s => s.XV));
                if (x == 0 && xs.ContainsKey(xKey))
                {
                    x = timestep;
                }
                else if (x == 0)
                {
                    xs.Add(xKey, timestep);
                }


                var yKey = string.Join(",", moons.Select(s => s.YV));
                if (y == 0 && ys.ContainsKey(yKey))
                {
                    y = timestep;
                }
                else if (y == 0)
                {
                    ys.Add(yKey, timestep);
                }

                var zKey = string.Join(",", moons.Select(s => s.ZV));
                if (z == 0 && zs.ContainsKey(zKey))
                {
                    z = timestep;
                }
                else if (z == 0)
                {
                    zs.Add(zKey, timestep);
                }

                if (x != 0 && y != 0 && z != 0)
                {
                    var firstLeastCommonMul = Lcm(x, y);
                    var secondLeastCommonMul = Lcm(y, z);
                    var third = Lcm(firstLeastCommonMul, secondLeastCommonMul);
                    Console.WriteLine(third);
                    break;
                }

                long Lcm(long first, long second)
                {
                    var largest = Math.Max(first, second);
                    var currentLcm = largest;
                    var smallest = Math.Min(first, second);

                    while (currentLcm % smallest != 0)
                    {
                        currentLcm += largest;
                    }

                    return currentLcm;
                }
            }
        }

        private static List<Moon> CreateMoons(List<string> input)
        {
            var allPoints = new List<Moon>();

            var nameCounter = 0;
            foreach (var line in input)
            {
                var parts = line.RemoveAToZ()
                    .Replace("<", "")
                    .Replace(">", "")
                    .Replace("=", "")
                    .Replace(" ", "")
                    .SplitAsIntsBy(',');

                allPoints.Add(new Moon(nameCounter, new Coordinate3D(parts[0], parts[1], parts[2])));

                nameCounter++;
            }

            return allPoints;
        }
    }

    public class Moon
    {
        public int Id { get; }
        public int[] VelocityXyz { get; }
        public Coordinate3D Coordinate3D { get; private set; }
        public int PotentialEnergy => Math.Abs(Coordinate3D.X) + Math.Abs(Coordinate3D.Y) + Math.Abs(Coordinate3D.Z);
        public int KineticEnergy => Math.Abs(VelocityXyz[0]) + Math.Abs(VelocityXyz[1]) + Math.Abs(VelocityXyz[2]);
        public int TotalEnergy => PotentialEnergy * KineticEnergy;

        public Moon(int id, Coordinate3D coordinate3D)
        {
            Id = id;
            Coordinate3D = coordinate3D;
            VelocityXyz = new []{0,0,0};
        }

        public void ApplyGravity(List<Moon> moons)
        {
            foreach (var moon in moons.Where(m => m.Id != Id))
            {
                var x = moon.Coordinate3D.X > Coordinate3D.X ? 1 : moon.Coordinate3D.X < Coordinate3D.X ? -1 : 0;
                var y = moon.Coordinate3D.Y > Coordinate3D.Y ? 1 : moon.Coordinate3D.Y < Coordinate3D.Y ? -1 : 0;
                var z = moon.Coordinate3D.Z > Coordinate3D.Z ? 1 : moon.Coordinate3D.Z < Coordinate3D.Z ? -1 : 0;
                VelocityXyz[0] += x;
                VelocityXyz[1] += y;
                VelocityXyz[2] += z;
            }
        }

        public void ApplyVelocity()
        {
            Coordinate3D = new Coordinate3D(
                Coordinate3D.X + VelocityXyz[0],
                Coordinate3D.Y + VelocityXyz[1],
                Coordinate3D.Z + VelocityXyz[2]);
        }

        public override string ToString()
        {
            return $"{Coordinate3D.X},{Coordinate3D.Y},{Coordinate3D.Z},{VelocityXyz[0]},{VelocityXyz[1]},{VelocityXyz[2]}";
        }

        public string XV =>
            $"{Coordinate3D.X},{VelocityXyz[0]}";
        public string YV =>
            $"{Coordinate3D.Y},{VelocityXyz[1]}";
        public string ZV =>
            $"{Coordinate3D.Z},{VelocityXyz[2]}";
    }
}