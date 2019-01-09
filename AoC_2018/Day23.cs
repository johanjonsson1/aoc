using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
     * 
    */
    public class Day23 : Day
    {
        public override string Title => "2018 - Day 23";
        public static PositionEqualityComparer Comparer = new PositionEqualityComparer();
        public static object Lock = new object();

        public override void PartOne()
        {
            base.PartOne();
            return;
            //            var input = @"pos=<0,0,0>, r=4
            //pos=<1,0,0>, r=1
            //pos=<4,0,0>, r=3
            //pos=<0,2,0>, r=1
            //pos=<0,5,0>, r=3
            //pos=<0,0,3>, r=1
            //pos=<1,1,1>, r=1
            //pos=<1,1,2>, r=1
            //pos=<1,3,1>, r=1".RemoveAToZ().ToStringList();
            var input = Inputs.Day23.RemoveAToZ().ToStringList();
            var bots = new List<Nanobot>();
            // populate
            var idCounter = 0;
            foreach (var line in input)
            {
                var split = line.SplitAsIntsBy('=', '<', '>', ',');
                bots.Add(new Nanobot(idCounter, split[0], split[1], split[2], split[3]));
                idCounter++;
            }

            var strongest = bots.OrderByDescending(o => o.Signal).First();
            strongest.BotsInRange.AddRange(bots.Where(b => b.GetDistance(strongest.X, strongest.Y, strongest.Z) <= strongest.Signal).ToList());
            //foreach (var bot in bots)
            //{

            //}

            Console.WriteLine(strongest.BotsInRange.Count);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            //            var input = @"pos=<10,12,12>, r=2
            //pos=<12,14,12>, r=2
            //pos=<16,12,12>, r=4
            //pos=<14,14,14>, r=6
            //pos=<50,50,50>, r=200
            //pos=<10,10,10>, r=5".RemoveAToZ().ToStringList();
            var input = Inputs.Day23.RemoveAToZ().ToStringList();
            var bots = new List<Nanobot>();            

            var maxX = int.MinValue;
            var maxY = maxX;
            var maxZ = maxX;
            var minX = int.MaxValue;
            var minY = minX;
            var minZ = minX;

            var idCounter = 0;
            foreach (var line in input)
            {
                var split = line.SplitAsIntsBy('=', '<', '>', ',');
                bots.Add(new Nanobot(idCounter, split[0], split[1], split[2], split[3]));
                idCounter++;
            }

            

            int divider = 1000000;
            var simplifiedBots = GetSimpleBots(bots, divider, ref maxX, ref maxY, ref maxZ, ref minX, ref minY, ref minZ);
            while (divider > 1)
            {
                var result = new Handler();
                Parallel.For(minX, maxX, x =>
                {
                    for (int y = minY; y < maxY; y++)
                    {
                        for (int z = minZ; z < maxZ; z++)
                        {
                            var count = 0;
                            foreach (var bot in simplifiedBots)
                            {
                                if (bot.InRange(x, y, z))
                                {
                                    count++;
                                }
                            }

                            if (count > 1)
                            {
                                lock (Lock)
                                {
                                    result.TryAdd(new Position(x, y, z), count);
                                }
                            }
                        }
                    }
                });

                divider /= 10;
                simplifiedBots = GetSimpleBots(bots, divider, ref maxX, ref maxY, ref maxZ, ref minX, ref minY, ref minZ);

                var res = result.Positions.OrderBy(p => p.GetDistance(0, 0, 0)).First();
                minX = (res.X - 2) * 10;
                minY = (res.Y - 2) * 10;
                minZ = (res.Z - 2) * 10;
                maxX = (res.X + 2) * 10;
                maxY = (res.Y + 2) * 10;
                maxZ = (res.Z + 2) * 10;
            }

            var result2 = new Handler();
            Parallel.For(minX, maxX, x =>
            {
                for (int y = minY; y < maxY; y++)
                {
                    for (int z = minZ; z < maxZ; z++)
                    {
                        var count = 0;
                        foreach (var bot in bots)
                        {
                            if (bot.InRange(x, y, z))
                            {
                                count++;
                            }
                        }

                        if (count > 1)
                        {
                            lock (Lock)
                            {
                                result2.TryAdd(new Position(x, y, z), count);
                            }
                        }
                    }
                }
            });

            var res2 = result2.Positions.OrderBy(p => p.GetDistance(0, 0, 0));

            Console.WriteLine(res2.First().GetDistance(0, 0, 0));

            foreach (var pos in result2.Positions)
            {
                Console.WriteLine(pos.X + "," + pos.Y + "," + pos.Z);
                Console.Write(" - " + pos.GetDistance(0, 0, 0));
            }
        }

        private static List<Nanobot> GetSimpleBots(List<Nanobot> bots, int divider, ref int maxX, ref int maxY, ref int maxZ, ref int minX, ref int minY, ref int minZ)
        {
            var simplifiedBots = new List<Nanobot>();

            foreach (var b in bots)
            {
                var highX = (int)Math.Ceiling((double)b.X / divider);
                var lowX = (int)Math.Floor((double)b.X / divider);
                var highY = (int)Math.Ceiling((double)b.Y / divider);
                var lowY = (int)Math.Floor((double)b.Y / divider);
                var highZ = (int)Math.Ceiling((double)b.Z / divider);
                var lowZ = (int)Math.Floor((double)b.Z / divider);

                var sig = b.Signal / divider;

                if (highX > maxX)
                {
                    maxX = highX;
                }

                if (lowX < minX)
                {
                    minX = lowX;
                }

                if (highY> maxY)
                {
                    maxY = highY;
                }

                if (lowY < minY)
                {
                    minY = lowY;
                }

                if (highZ > maxZ)
                {
                    maxZ = highZ;
                }

                if (lowZ < minZ)
                {
                    minZ = lowZ;
                }

                simplifiedBots.Add(new Nanobot(b.Id, b.X / divider, b.Y / divider, b.Z / divider, sig));
            }

            return simplifiedBots;
        }

        private int Max(params int[] values)
        {
            var max = 0;

            foreach (var val in values)
            {
                max = Math.Max(max, Math.Abs(val));
            }

            return max;
        }
    }

    public class Handler
    {
        public int LargestCount = 0;
        public List<Position> Positions = new List<Position>();

        public void TryAdd(Position pos, int count)
        {
            if (count < LargestCount)
            {
                return;
            }

            if (count == LargestCount)
            {
                Positions.Add(pos);
            }
            else
            {
                LargestCount = count;
                Positions = new List<Position> { pos };
            }
        }
    }

    public class PositionInRangeOfBots
    {
        public int InRangeOf => Bots.Count;
        public Position Position;
        public List<Nanobot> Bots = new List<Nanobot>();
    }

    public class Position
    {
        public int X;
        public int Y;
        public int Z;

        public Position()
        {

        }

        public Position(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int GetDistance(int x, int y, int z)
        {
            return Math.Abs(X - x) + Math.Abs(Y - y) + Math.Abs(Z - z);
        }

        public override bool Equals(object obj)
        {
            var p = obj as Position;
            if (p == null) {
                return false;
            }

            return p.X == X && p.Y == Y && p.Z == Z;
        }
    }

    public class PositionEqualityComparer : IEqualityComparer<Position>
    {
        public bool Equals(Position b1, Position b2)
        {
            if (b2 == null && b1 == null)
                return true;
            else if (b1 == null || b2 == null)
                return false;
            else if (b1.X == b2.X && b1.Y == b2.Y
                                && b1.Z == b2.Z)
                return true;
            else
                return false;
        }

        public int GetHashCode(Position bx)
        {
            int hCode = bx.X ^ bx.Y ^ bx.Z;
            return hCode.GetHashCode();
        }
    }

    public class Nanobot : Position
    {
        public int Id;
        public int Signal;
        public List<Nanobot> BotsInRange = new List<Nanobot>();

        public Nanobot(int id, int x, int y, int z, int signal)
        {
            Id = id;
            X = x;
            Y = y;
            Z = z;
            Signal = signal;
        }

        public bool InRange(int x, int y, int z)
        {
            return Math.Abs(X - x) + Math.Abs(Y - y) + Math.Abs(Z - z) <= Signal;
        }

        public List<Position> PositionsInRange()
        {
            var positions = new List<Position>();
            for (int x = X - Signal; x < X + Signal; x++)
            {
                for (int y = Y - Signal; y < Y + Signal; y++)
                {
                    for (int z = Z - Signal; z < Z + Signal; z++)
                    {
                        positions.Add(new Position(x, y, z));
                    }
                }
            }

            return positions;
        }
    }
}
