using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AoC.Common;

namespace AoC2018
{
    /*
    --- Day 23: Experimental Emergency Teleportation ---
    Using your torch to search the darkness of the rocky cavern, you finally locate the man's friend: a small reindeer.

    You're not sure how it got so far in this cave. 
    It looks sick - too sick to walk - and too heavy for you to carry all the way back. Sleighs won't be invented for another 1500 years, of course.

    The only option is experimental emergency teleportation.

    You hit the "experimental emergency teleportation" button on the device and push I accept the risk on no fewer than 18 different warning messages. 
    Immediately, the device deploys hundreds of tiny nanobots which fly around the cavern, apparently assembling themselves into a very specific formation. 
    The device lists the X,Y,Z position (pos) for each nanobot as well as its signal radius (r) on its tiny screen (your puzzle input).

    Each nanobot can transmit signals to any integer coordinate which is a distance away from it less than or equal to its signal radius (as measured by Manhattan distance). 
    Coordinates a distance away of less than or equal to a nanobot's signal radius are said to be in range of that nanobot.

    Before you start the teleportation process, you should determine which nanobot is the strongest (that is, which has the largest signal radius) and then, 
    for that nanobot, the total number of nanobots that are in range of it, including itself.

    For example, given the following nanobots:

    pos=<0,0,0>, r=4
    pos=<1,0,0>, r=1
    pos=<4,0,0>, r=3
    pos=<0,2,0>, r=1
    pos=<0,5,0>, r=3
    pos=<0,0,3>, r=1
    pos=<1,1,1>, r=1
    pos=<1,1,2>, r=1
    pos=<1,3,1>, r=1
    The strongest nanobot is the first one (position 0,0,0) because its signal radius, 4 is the largest. 
    Using that nanobot's location and signal radius, the following nanobots are in or out of range:

    The nanobot at 0,0,0 is distance 0 away, and so it is in range.
    The nanobot at 1,0,0 is distance 1 away, and so it is in range.
    The nanobot at 4,0,0 is distance 4 away, and so it is in range.
    The nanobot at 0,2,0 is distance 2 away, and so it is in range.
    The nanobot at 0,5,0 is distance 5 away, and so it is not in range.
    The nanobot at 0,0,3 is distance 3 away, and so it is in range.
    The nanobot at 1,1,1 is distance 3 away, and so it is in range.
    The nanobot at 1,1,2 is distance 4 away, and so it is in range.
    The nanobot at 1,3,1 is distance 5 away, and so it is not in range.
    In this example, in total, 7 nanobots are in range of the nanobot with the largest signal radius.

    Find the nanobot with the largest signal radius. How many nanobots are in range of its signals?

    --- Part Two ---
    Now, you just need to figure out where to position yourself so that you're actually teleported when the nanobots activate.

    To increase the probability of success, you need to find the coordinate which puts you in range of the largest number of nanobots. 
    If there are multiple, choose one closest to your position (0,0,0, measured by manhattan distance).

    For example, given the following nanobot formation:

    pos=<10,12,12>, r=2
    pos=<12,14,12>, r=2
    pos=<16,12,12>, r=4
    pos=<14,14,14>, r=6
    pos=<50,50,50>, r=200
    pos=<10,10,10>, r=5
    Many coordinates are in range of some of the nanobots in this formation. 
    However, only the coordinate 12,12,12 is in range of the most nanobots: it is in range of the first five, but is not in range of the nanobot at 10,10,10. 
    (All other coordinates are in range of fewer than five nanobots.) This coordinate's distance from 0,0,0 is 36.

    Find the coordinates that are in range of the largest number of nanobots. 
    What is the shortest manhattan distance between any of those points and 0,0,0?
    */

    public class Day23 : Day
    {
        public override string Title => "2018 - Day 23: Experimental Emergency Teleportation";
        public static object Lock = new object();

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day23.RemoveAToZ().ToStringList();
            var bots = GetNanobots(input);

            var strongest = bots.OrderByDescending(o => o.Signal).First();
            strongest.BotsInRange.AddRange(bots.Where(b => b.GetDistance(strongest.X, strongest.Y, strongest.Z) <= strongest.Signal).ToList());
            Console.WriteLine(strongest.BotsInRange.Count); // 408
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day23.RemoveAToZ().ToStringList();        
            var maxX = int.MinValue;
            var maxY = maxX;
            var maxZ = maxX;
            var minX = int.MaxValue;
            var minY = minX;
            var minZ = minX;
            var bots = GetNanobots(input);

            int divider = 1000000;
            var simplifiedBots = GetSimplifiedBots(bots, divider, ref maxX, ref maxY, ref maxZ, ref minX, ref minY, ref minZ);
            while (divider > 1)
            {
                var tempResult = new Handler();
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
                                    tempResult.TryAdd(new Position(x, y, z), count);
                                }
                            }
                        }
                    }
                });

                divider /= 10;
                simplifiedBots = GetSimplifiedBots(bots, divider, ref maxX, ref maxY, ref maxZ, ref minX, ref minY, ref minZ);

                var res = tempResult.Positions.OrderBy(p => p.GetDistance(0, 0, 0)).First();
                minX = (res.X - 2) * 10;
                minY = (res.Y - 2) * 10;
                minZ = (res.Z - 2) * 10;
                maxX = (res.X + 2) * 10;
                maxY = (res.Y + 2) * 10;
                maxZ = (res.Z + 2) * 10;
            }

            var result = new Handler();
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
                                result.TryAdd(new Position(x, y, z), count);
                            }
                        }
                    }
                }
            });

            var closest = result.Positions.OrderBy(p => p.GetDistance(0, 0, 0)).First();

            Console.WriteLine(closest.GetDistance(0, 0, 0)); // 121167568
            Console.WriteLine(closest.X + "," + closest.Y + "," + closest.Z);
        }

        private static List<Nanobot> GetNanobots(List<string> input)
        {
            var bots = new List<Nanobot>();
            var idCounter = 0;
            foreach (var line in input)
            {
                var split = line.SplitAsIntsBy('=', '<', '>', ',');
                bots.Add(new Nanobot(idCounter, split[0], split[1], split[2], split[3]));
                idCounter++;
            }

            return bots;
        }

        private static List<Nanobot> GetSimplifiedBots(List<Nanobot> bots, int divider, ref int maxX, ref int maxY, ref int maxZ, ref int minX, ref int minY, ref int minZ)
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

        public override int GetHashCode()
        {
            var hashCode = -307843816;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Z.GetHashCode();
            return hashCode;
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