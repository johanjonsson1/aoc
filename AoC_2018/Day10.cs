using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
     * 
    */
    public class Day10 : Day
    {
        public override string Title => "2018 - Day 10";

        public static int? MinimumY;
        public static int? MinimumX;
        public static int? MaximumY;
        public static int? MaximumX;
        //public static bool Aligned => MaximumY - 7 == MinimumY;
        //public static bool Aligned => MaximumY - 8 == MinimumY;
        public static bool Aligned => MaximumY - 9 == MinimumY;

        public override void PartOne()
        {
            base.PartOne();
            var allPoints = new List<MessagePoint>();
            PopulatePoints(allPoints);

            var secondsPassed = 0;
            while (true)
            {
                ResetEdges();
                allPoints.ForEach(p => p.Move());
                secondsPassed++;

                if (Aligned)
                {
                    break;
                }
            }

            PrintMessage(allPoints);
            Console.WriteLine(secondsPassed);
        }

        private static void PopulatePoints(List<MessagePoint> allPoints)
        {
            var input = "".ToStringList();// Inputs.Day10.RemoveAToZ().ToStringList();

            foreach (var line in input)
            {
                var split = line.SplitAsIntsBy('=', '<', '>', ',');
                allPoints.Add(new MessagePoint(split[0], split[1], split[2], split[3]));
            }
        }

        private static void PrintMessage(List<MessagePoint> allPoints)
        {
            for (int y = (int)MinimumY; y <= MaximumY; y++)
            {
                Console.WriteLine();
                for (int x = (int)MinimumX; x <= MaximumX; x++)
                {
                    if (allPoints.Any(a => a.Y == y && a.X == x))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }

        public static void ResetEdges()
        {
            Day10.MaximumX = null;
            Day10.MinimumX = null;
            Day10.MaximumY = null;
            Day10.MinimumY = null;
        }
    }

    public class MessagePoint
    {
        public int StartingX;
        public int StartingY;
        public int X;
        public int Y;
        public int VelocityX;
        public int VelocityY;

        public MessagePoint(int startX, int startY, int velocityX, int velocityY)
        {
            StartingX = startX;
            StartingY = startY;
            X = startX;
            Y = startY;
            VelocityX = velocityX;
            VelocityY = velocityY;
        }

        public void Move()
        {
            X += VelocityX;
            Y += VelocityY;

            if (Day10.MaximumX == null || X > Day10.MaximumX)
            {
                Day10.MaximumX = X;
            }

            if (Day10.MinimumX == null || X < Day10.MinimumX)
            {
                Day10.MinimumX = X;
            }

            if (Day10.MaximumY == null || Y > Day10.MaximumY)
            {
                Day10.MaximumY = Y;
            }

            if (Day10.MinimumY == null || Y < Day10.MinimumY)
            {
                Day10.MinimumY = Y;
            }
        }
    }
}