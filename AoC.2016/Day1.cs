using AoC.Common;
using System;
using System.Collections.Generic;

namespace AoC2016
{
    /*
    --- Day 1: No Time for a Taxicab ---
    Santa's sleigh uses a very high-precision clock to guide its movements, and the clock's oscillator is regulated by stars. 
    Unfortunately, the stars have been stolen... by the Easter Bunny. To save Christmas, Santa needs you to retrieve all fifty stars by December 25th.

    Collect stars by solving puzzles. 
    Two puzzles will be made available on each day in the advent calendar; the second puzzle is unlocked when you complete the first. 
    Each puzzle grants one star. Good luck!

    You're airdropped near Easter Bunny Headquarters in a city somewhere. 
    "Near", unfortunately, is as close as you can get - the instructions on the Easter Bunny Recruiting Document the Elves intercepted start here, and nobody had time to work them out further.

    The Document indicates that you should start at the given coordinates (where you just landed) and face North. 
    Then, follow the provided sequence: either turn left (L) or right (R) 90 degrees, then walk forward the given number of blocks, ending at a new intersection.

    There's no time to follow such ridiculous instructions on foot, though, so you take a moment and work out the destination. 
    Given that you can only walk on the street grid of the city, how far is the shortest path to the destination?

    For example:

    Following R2, L3 leaves you 2 blocks East and 3 blocks North, or 5 blocks away.
    R2, R2, R2 leaves you 2 blocks due South of your starting position, which is 2 blocks away.
    R5, L5, R5, R3 leaves you 12 blocks away.
    How many blocks away is Easter Bunny HQ?

    Your puzzle answer was 332.

    --- Part Two ---
    Then, you notice the instructions continue on the back of the Recruiting Document. Easter Bunny HQ is actually at the first location you visit twice.

    For example, if your instructions are R8, R4, R4, R8, the first location you visit twice is 4 blocks away, due East.

    How many blocks away is the first location you visit twice?

    Your puzzle answer was 166.
     */

    public class Day1 : Day
    {
        public override string Title => "--- Day 1: No Time for a Taxicab ---";

        public override void PartOne()
        {
            base.PartOne();
            //var input = "R5, L5, R5, R3".Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            var input = Inputs.Day1.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            var position = new Coordinate(0, 0);
            var navigator = new Navigator(position);

            foreach (var instr in input)
            {
                navigator.Move(instr);
            }

            Console.WriteLine($"X:{navigator.CurrentCoordinate.X}, Y:{navigator.CurrentCoordinate.Y}");
            Console.WriteLine(position.GetDistance(navigator.CurrentCoordinate));
        }

        public override void PartTwo()
        {
            base.PartTwo();
            //var input = "R8, R4, R4, R8".Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            var input = Inputs.Day1.Split(new[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);

            var position = new Coordinate(0, 0);
            var navigator = new Navigator(position);

            foreach (var instr in input)
            {
                navigator.Move(instr, track: true);
            }

            Console.WriteLine($"X:{navigator.CurrentCoordinate.X}, Y:{navigator.CurrentCoordinate.Y}");
            Console.WriteLine(position.GetDistance(navigator.TwiceVisitedCoordinate));
        }
    }

    public class Navigator
    {
        public Coordinate CurrentCoordinate { get; private set; }
        public Facing Facing { get; private set; } = Facing.North;
        private HashSet<Coordinate> VisitedCoordinates { get; } = new HashSet<Coordinate>();
        private bool _twiceFound;
        public Coordinate TwiceVisitedCoordinate { get; private set; }

        public Navigator(Coordinate startCoordinate)
        {
            CurrentCoordinate = startCoordinate;
            VisitedCoordinates.Add(startCoordinate);
        }

        public void Move(string instruction, bool track = false)
        {
            var direction = (Direction)Enum.Parse(typeof(Direction), instruction[0].ToString());
            var distance = int.Parse(instruction.Substring(1, instruction.Length-1));
            var oldPos = CurrentCoordinate;

            switch (Facing)
            {
                case Facing.North:
                    if (direction == Direction.L)
                    {
                        Facing = Facing.West;
                        CurrentCoordinate = new Coordinate(CurrentCoordinate.X - distance, CurrentCoordinate.Y);
                    } else
                    {
                        Facing = Facing.East;
                        CurrentCoordinate = new Coordinate(CurrentCoordinate.X + distance, CurrentCoordinate.Y);
                    }
                    break;
                case Facing.South:
                    if (direction == Direction.L)
                    {
                        Facing = Facing.East;
                        CurrentCoordinate = new Coordinate(CurrentCoordinate.X + distance, CurrentCoordinate.Y);
                    }
                    else
                    {
                        Facing = Facing.West;
                        CurrentCoordinate = new Coordinate(CurrentCoordinate.X - distance, CurrentCoordinate.Y);
                    }
                    break;
                case Facing.East:
                    if (direction == Direction.L)
                    {
                        Facing = Facing.North;
                        CurrentCoordinate = new Coordinate(CurrentCoordinate.X, CurrentCoordinate.Y + distance);
                    }
                    else
                    {
                        Facing = Facing.South;
                        CurrentCoordinate = new Coordinate(CurrentCoordinate.X, CurrentCoordinate.Y - distance);
                    }
                    break;
                case Facing.West:
                    if (direction == Direction.L)
                    {
                        Facing = Facing.South;
                        CurrentCoordinate = new Coordinate(CurrentCoordinate.X, CurrentCoordinate.Y - distance);
                    }
                    else
                    {
                        Facing = Facing.North;
                        CurrentCoordinate = new Coordinate(CurrentCoordinate.X, CurrentCoordinate.Y + distance);
                    }
                    break;
                default:
                    throw new ArgumentException(instruction);
            }

            if (!track || _twiceFound)
            {
                return;
            }

            int newX = oldPos.X;
            int newY = oldPos.Y;

            while(newX != CurrentCoordinate.X || newY != CurrentCoordinate.Y)
            {
                if (newX < CurrentCoordinate.X)
                {
                    newX++;
                }
                else if ( newX > CurrentCoordinate.X)
                {
                    newX--;
                }
                else if (newY < CurrentCoordinate.Y)
                {
                    newY++;
                }
                else if (newY > CurrentCoordinate.Y)
                {
                    newY--;
                }

                var newCoordinate = new Coordinate(newX, newY);

                if (!_twiceFound && VisitedCoordinates.Contains(newCoordinate))
                {
                    TwiceVisitedCoordinate = newCoordinate;
                    _twiceFound = true;
                    return;
                }

                VisitedCoordinates.Add(newCoordinate);
            }

            VisitedCoordinates.Add(CurrentCoordinate);
        }
    }

    public enum Facing
    {
        North,
        South,
        East,
        West
    }

    public enum Direction
    {
        L,
        R
    }
}
