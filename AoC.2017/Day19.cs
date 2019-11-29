using System;
using System.Linq;
using AoC.Common;

namespace AoC2017
{
    /*
    --- Day 19: A Series of Tubes ---
    Somehow, a network packet got lost and ended up here. 
    It's trying to follow a routing diagram (your puzzle input), but it's confused about where to go.

    Its starting point is just off the top of the diagram. 
    Lines (drawn with |, -, and +) show the path it needs to take, starting by going down onto the only line connected to the top of the diagram. 
    It needs to follow this path until it reaches the end (located somewhere within the diagram) and stop there.

    Sometimes, the lines cross over each other; in these cases, it needs to continue going the same direction, and only turn left or right when there's no other option. 
    In addition, someone has left letters on the line; these also don't change its direction, but it can use them to keep track of where it's been. For example:

         |          
         |  +--+    
         A  |  C    
     F---|----E|--+ 
         |  |  |  D 
         +B-+  +--+ 

    Given this diagram, the packet needs to take the following path:

    Starting at the only line touching the top of the diagram, it must go down, pass through A, and continue onward to the first +.
    Travel right, up, and right, passing through B in the process.
    Continue down (collecting C), right, and up (collecting D).
    Finally, go all the way left through E and stopping at F.
    Following the path to the end, the letters it sees on its path are ABCDEF.

    The little packet looks up at you, hoping you can help it find the way. 
    What letters will it see (in the order it would see them) if it follows the path? (The routing diagram is very wide; make sure you view it without line wrapping.)

    Your puzzle answer was XYFDJNRCQA.

    --- Part Two ---
    The packet is curious how many steps it needs to go.

    For example, using the same routing diagram from the example above...

         |          
         |  +--+    
         A  |  C    
     F---|--|-E---+ 
         |  |  |  D 
         +B-+  +--+ 

    ...the packet would go:

    6 steps down (including the first line at the top of the diagram).
    3 steps right.
    4 steps up.
    3 steps right.
    4 steps down.
    3 steps right.
    2 steps up.
    13 steps left (including the F it stops on).
    This would result in a total of 38 steps.

    How many steps does the packet need to go?

    Your puzzle answer was 17450.
    */

    public class Day19 : Day
    {
        public override string Title => "--- Day 19: A Series of Tubes ---";
        public static int Steps;

        public override void PartOne()
        {
            base.PartOne();
            var input = @"     |          
     |  +--+    
     A  |  C    
 F---|----E|--+ 
     |  |  |  D 
     +B-+  +--+ 
".ToStringList();

            var pipes = new PipeGrid();
            pipes.Build(Inputs.Day19.ToStringList());

            pipes.Current = pipes.All.First(x => x.Coordinate.Y == 0);
            pipes.CurrentDirection = TrackGridBase.Direction.Down;
            Steps = 1;

            var next = pipes.MoveNext();
            var result = string.Empty;

            while (next != null)
            {
                if (next.TrackType == TrackGridBase.TrackType.Other)
                {
                    result += next.Symbol;
                }

                next = pipes.MoveNext();
            }

            Console.WriteLine("Result part 1");
            Console.WriteLine(result);

            Steps += pipes.Steps;
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine("Result part 2");
            Console.WriteLine(Steps);
        }
    }

    public class PipeGrid : TrackGridBase
    {
        public int Steps = 0;

        public override TrackItem MoveNext()
        {
            TrackItem next = null;
            if (Current.TrackType == TrackType.Intersection)
            {
                next = GetByFacing() ?? GetAdjacent(Current).FirstOrDefault(x => x.Id != Last.Id);
            }
            else
            {
                next = GetByFacing();
            }

            Current = next;
            SetNewDirection();

            if (Current != null)
            {
                Steps++;
            }

            return Current;
        }

        private TrackItem GetByFacing()
        {
            switch (CurrentDirection)
            {
                case Direction.Up:
                    return GetAdjacentUp(Current);
                case Direction.Down:
                    return GetAdjacentDown(Current);
                case Direction.Left:
                    return GetAdjacentLeft(Current);
                case Direction.Right:
                    return GetAdjacentRight(Current);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}