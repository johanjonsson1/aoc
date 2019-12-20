using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day19 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();

            var gridSize = 50;
            var grid = new List<BeamPoint>();
            for (int y = 0; y < gridSize; y++)
            {
                for (int x = 0; x < gridSize; x++)
                {
                    grid.Add(new BeamPoint { Coordinate = new Coordinate(x, y) }); ;
                }
            }

            var xyQueue = new Queue<BeamPoint>();
            grid.ForEach(g =>
            {
                xyQueue.Enqueue(g);
            });

            while (xyQueue.Count > 0)
            {

                var input = Inputs.Day19.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
                var machine = new IntCodeProgram(input);
                var point = xyQueue.Dequeue();
                var c = point.Coordinate;
                machine.AddInput(c.X);
                machine.AddInput(c.Y);
                machine.LoopUntilHalt(0);

                var output = machine.Output;
                //Console.Write(output);

                if (output == 1)
                {
                    point.Affected = true;
                }
            }

            Print(grid);
            Console.WriteLine(grid.Count(g => g.Affected));
        }

        public override void PartTwo()
        {
            base.PartTwo();

            var x = 854;
            var y = 1020;
            var target = 99;

            while (true)
            {
                var output = GetOutputForXY(x, y);

                if (output == 0)
                {
                    x++;
                }
                else if (output == 1)
                {
                    var upperLeftOutput = GetOutputForXY(x, y - target);
                    if (upperLeftOutput == 1)
                    {
                        var upperLeftRight = GetOutputForXY(x + target, y - target);
                        if (upperLeftRight == 1)
                        {
                            Console.WriteLine(x * 10000 + (y - target));
                            break;
                        }
                    }

                    y++;
                }

            }

            Console.WriteLine();
        }

        public long GetOutputForXY(long x, long y)
        {
            var input = Inputs.Day19.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            var machine = new IntCodeProgram(input);
            machine.AddInput(x);
            machine.AddInput(y);
            machine.LoopUntilHalt(0);

            return machine.Output;
        }

        private static void Print(List<BeamPoint> grid)
        {
            var maxY = grid.Max(x => x.Coordinate.Y);
            var maxX = grid.Max(x => x.Coordinate.X);

            Console.WriteLine();
            for (var i = 0; i <= maxY; i++)
            {
                for (var j = 0; j <= maxX; j++)
                {
                    var point = grid.First(g => g.Coordinate.X == j && g.Coordinate.Y == i);

                    var aa = point.Affected ? '#' : '.';
                    Console.Write(aa);
                }

                Console.WriteLine();
            }
        }
    }

    public class BeamPoint
    {
        public Coordinate Coordinate;
        public bool Affected;
    }
}