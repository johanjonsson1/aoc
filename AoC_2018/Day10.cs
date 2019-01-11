using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC_2018
{
    /*
    --- Day 10: The Stars Align ---
    It's no use; your navigation system simply isn't capable of providing walking directions in the arctic circle, and certainly not in 1018.

    The Elves suggest an alternative. In times like these, North Pole rescue operations will arrange points of light in the sky to guide missing Elves back to base. 
    Unfortunately, the message is easy to miss: the points move slowly enough that it takes hours to align them, but have so much momentum that they only stay aligned for a second. 
    If you blink at the wrong time, it might be hours before another message appears.

    You can see these points of light floating in the distance, and record their position in the sky and their velocity, the relative change in position per second (your puzzle input).
    The coordinates are all given from your perspective; given enough time, those positions and velocities will move the points into a cohesive message!

    Rather than wait, you decide to fast-forward the process and calculate what the points will eventually spell.

    For example, suppose you note the following points:

    position=< 9,  1> velocity=< 0,  2>
    position=< 7,  0> velocity=<-1,  0>
    position=< 3, -2> velocity=<-1,  1>
    position=< 6, 10> velocity=<-2, -1>
    position=< 2, -4> velocity=< 2,  2>
    position=<-6, 10> velocity=< 2, -2>
    position=< 1,  8> velocity=< 1, -1>
    position=< 1,  7> velocity=< 1,  0>
    position=<-3, 11> velocity=< 1, -2>
    position=< 7,  6> velocity=<-1, -1>
    position=<-2,  3> velocity=< 1,  0>
    position=<-4,  3> velocity=< 2,  0>
    position=<10, -3> velocity=<-1,  1>
    position=< 5, 11> velocity=< 1, -2>
    position=< 4,  7> velocity=< 0, -1>
    position=< 8, -2> velocity=< 0,  1>
    position=<15,  0> velocity=<-2,  0>
    position=< 1,  6> velocity=< 1,  0>
    position=< 8,  9> velocity=< 0, -1>
    position=< 3,  3> velocity=<-1,  1>
    position=< 0,  5> velocity=< 0, -1>
    position=<-2,  2> velocity=< 2,  0>
    position=< 5, -2> velocity=< 1,  2>
    position=< 1,  4> velocity=< 2,  1>
    position=<-2,  7> velocity=< 2, -2>
    position=< 3,  6> velocity=<-1, -1>
    position=< 5,  0> velocity=< 1,  0>
    position=<-6,  0> velocity=< 2,  0>
    position=< 5,  9> velocity=< 1, -2>
    position=<14,  7> velocity=<-2,  0>
    position=<-3,  6> velocity=< 2, -1>
    Each line represents one point. Positions are given as <X, Y> pairs: 
    X represents how far left (negative) or right (positive) the point appears, 
    while Y represents how far up (negative) or down (positive) the point appears.

    At 0 seconds, each point has the position given. Each second, each point's velocity is added to its position. 
    So, a point with velocity <1, -2> is moving to the right, but is moving upward twice as quickly. 
    If this point's initial position were <3, 9>, after 3 seconds, its position would become <6, 3>.

    Over time, the points listed above would move like this:

    Initially:
    ........#.............
    ................#.....
    .........#.#..#.......
    ......................
    #..........#.#.......#
    ...............#......
    ....#.................
    ..#.#....#............
    .......#..............
    ......#...............
    ...#...#.#...#........
    ....#..#..#.........#.
    .......#..............
    ...........#..#.......
    #...........#.........
    ...#.......#..........

    After 1 second:
    ......................
    ......................
    ..........#....#......
    ........#.....#.......
    ..#.........#......#..
    ......................
    ......#...............
    ....##.........#......
    ......#.#.............
    .....##.##..#.........
    ........#.#...........
    ........#...#.....#...
    ..#...........#.......
    ....#.....#.#.........
    ......................
    ......................

    After 2 seconds:
    ......................
    ......................
    ......................
    ..............#.......
    ....#..#...####..#....
    ......................
    ........#....#........
    ......#.#.............
    .......#...#..........
    .......#..#..#.#......
    ....#....#.#..........
    .....#...#...##.#.....
    ........#.............
    ......................
    ......................
    ......................

    After 3 seconds:
    ......................
    ......................
    ......................
    ......................
    ......#...#..###......
    ......#...#...#.......
    ......#...#...#.......
    ......#####...#.......
    ......#...#...#.......
    ......#...#...#.......
    ......#...#...#.......
    ......#...#..###......
    ......................
    ......................
    ......................
    ......................

    After 4 seconds:
    ......................
    ......................
    ......................
    ............#.........
    ........##...#.#......
    ......#.....#..#......
    .....#..##.##.#.......
    .......##.#....#......
    ...........#....#.....
    ..............#.......
    ....#......#...#......
    .....#.....##.........
    ...............#......
    ...............#......
    ......................
    ......................
    After 3 seconds, the message appeared briefly: HI. Of course, your message will be much longer and will take many more seconds to appear.

    What message will eventually appear in the sky?

    --- Part Two ---
    Good thing you didn't have to wait, because that would have taken a long time - much longer than the 3 seconds in the example above.

    Impressed by your sub-hour communication capabilities, the Elves are curious: exactly how many seconds would they have needed to wait for that message to appear?

    Your puzzle answer was 10105.
    */
    public class Day10 : Day
    {
        public override string Title => "2018 - Day 10: The Stars Align";

        public static int? MinimumY;
        public static int? MinimumX;
        public static int? MaximumY;
        public static int? MaximumX;
        //public static bool Aligned => MaximumY - 7 == MinimumY;
        //public static bool Aligned => MaximumY - 8 == MinimumY;
        public static bool Aligned => MaximumY - 9 == MinimumY;
        public static int SecondsPassed = 0;

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

            PrintMessage(allPoints); // ZAEZRLZG
            SecondsPassed = secondsPassed;
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine(SecondsPassed); // 10105
        }

        private static void PopulatePoints(List<MessagePoint> allPoints)
        {
            var input = Inputs.Day10.RemoveAToZ().ToStringList();

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
        public int X;
        public int Y;
        public int VelocityX;
        public int VelocityY;

        public MessagePoint(int startX, int startY, int velocityX, int velocityY)
        {
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