using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day21 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day21.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            var droid = new SpringDroid(input);
            droid.ReceiveMovementRoutine(GetCommands());

            Console.WriteLine();
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }

        private IEnumerable<int> GetCommands()
        {
            var command = JumpIfEmpty(1) + HoldIfEmpty(3) + Or('T', 'J') + And('D','J') + "WALK\n";

            foreach (var c in command)
            {
                yield return c;
            }
        }

        private static string JumpIfEmpty(int n)
        {
            if (n == 1)
                return "NOT A J\n";
            if (n == 2)
                return "NOT B J\n";
            if (n == 3)
                return "NOT C J\n";
            if (n == 4)
                return "NOT D J\n";

            throw new ArgumentException();
        }

        private static string And(char x, char y)
        {
            return "AND " + x + " " + y + "\n";
        }
        private static string Or(char x, char y)
        {
            return "OR " + x + " " + y + "\n";
        }

        private static string HoldIfEmpty(int n)
        {
            if (n == 1)
                return "NOT A T\n";
            if (n == 2)
                return "NOT B T\n";
            if (n == 3)
                return "NOT C T\n";
            if (n == 4)
                return "NOT D T\n";

            throw new ArgumentException();
        }


    }

    public class SpringDroid
    {
        public readonly IntCodeProgram IntCodeProgram;

        public SpringDroid(long[] memory)
        {
            IntCodeProgram = new IntCodeProgram(memory);
        }

        public long ReceiveMovementRoutine(IEnumerable<int> routineAndFunctions)
        {
            foreach (var routineAndFunction in routineAndFunctions)
            {
                IntCodeProgram.AddInput(routineAndFunction);
            }

            while (!IntCodeProgram.IsTerminated)
            {
                IntCodeProgram.LoopUntilHalt(0);
                var locationState = IntCodeProgram.Output;

                if (locationState > 127)
                {
                    Console.WriteLine(locationState);
                    break;
                }

                char asChar = (char)locationState;
                Console.Write(asChar);

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