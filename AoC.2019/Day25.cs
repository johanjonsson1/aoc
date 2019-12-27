using System;
using System.Collections.Generic;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day25 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day25.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            var droid = new SmallDroid(input);
            droid.ReceiveMovementRoutine(GetCommands(false));

            Console.WriteLine("Command list:");
            foreach (var droidCommand in droid.Commands)
            {
                Console.WriteLine(droidCommand);
            }
            Console.WriteLine();
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }

        private IEnumerable<int> GetCommands(bool run)
        {
            var command = "south\ntake mouse\nnorth\n";

                foreach (var c in command)
                {
                    yield return c;
                }
            
        }
    }

    public class SmallDroid
    {
        public readonly IntCodeProgram IntCodeProgram;
        public readonly List<string> Commands = new List<string>();

        public SmallDroid(long[] memory)
        {
            IntCodeProgram = new IntCodeProgram(memory);
        }

        public long ReceiveMovementRoutine(IEnumerable<int> routineAndFunctions)
        {
            //foreach (var routineAndFunction in routineAndFunctions)
            //{
            //    IntCodeProgram.AddInput(routineAndFunction);
            //}

            var inp = "";
            while (!IntCodeProgram.IsTerminated)
            {
                if (inp != "")
                {
                    Commands.Add(inp+'\n');

                    foreach (var c in inp)
                    {
                        IntCodeProgram.AddInput(c);
                    }
                    IntCodeProgram.AddInput('\n');

                    inp = "";
                }

                IntCodeProgram.LoopUntilHalt(0);
                var locationState = IntCodeProgram.Output;

                if (locationState > 127)
                {
                    Console.WriteLine(locationState);
                    break;
                }

                char asChar = (char)locationState;
                Console.Write(asChar);

                if (asChar == '?')
                {
                    inp = Console.ReadLine();
                }

                if (asChar == '\n')
                {
                    Console.WriteLine();
                    continue;
                }
            }

            return IntCodeProgram.Output;
        }
    }

}