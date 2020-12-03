using AoC.Common;
using System;
using System.Collections.Generic;
using static AoC.Common.SantaHelper;

namespace AoC2020
{
    public class Day1 : Day
    {
        public override string Title => "--- Day 1: Report Repair ---";

        public override void PartOne()
        {
            base.PartOne();

            var inputs = Inputs.Day1.SplitAsIntsBy(NewlineCarriageReturn);
            var result = GetFirst2020(inputs);

            Console.WriteLine(result);
        }

        private static int GetFirst2020(List<int> inputs)
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                var currentInput = inputs[i];
                for (var j = 0; j < inputs.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (currentInput + inputs[j] == 2020)
                    {
                        return currentInput * inputs[j];
                    }
                }
            }

            return 0;
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var inputs = Inputs.Day1.SplitAsIntsBy(NewlineCarriageReturn);
            var result = Get2020ByThree(inputs);

            Console.WriteLine(result);
        }

        private static int Get2020ByThree(List<int> inputs)
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                var currentInput1 = inputs[i];
                for (var j = 0; j < inputs.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    var currentInput2 = inputs[j];
                    for (var k = 0; k < inputs.Count; k++)
                    {
                        if (i == k || j == k)
                        {
                            continue;
                        }

                        if (currentInput1 + currentInput2 + inputs[k] == 2020)
                        {
                            return currentInput1 * currentInput2 * inputs[k];
                        }
                    }
                }
            }

            return 0;
        }
    }
}
