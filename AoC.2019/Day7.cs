using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day7 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var amplifiersSeries = new List<AmplifierSeries>();
            var bag = new ConcurrentBag<ThrusterResult>();
            CreateAllSeries(amplifiersSeries);

            Parallel.ForEach(amplifiersSeries, s =>
            {
                var currentOutput = 0;
                foreach (var amplifier in s.NextAmplifierValue)
                {
                    //var thisInput = "3,15,3,16,1002,16,10,16,1,16,15,15,4,15,99,0,0".SplitAsIntsBy(',');
                    var thisInput = Inputs.Day7.SplitAsIntsBy(',');
                    var output = LoopUntilHaltDay7(thisInput, amplifier, currentOutput);
                    currentOutput = output;
                }

                var result = new ThrusterResult {Series = s, ThrusterSignal = currentOutput};
                bag.Add(result);
            });

            var thrusterInput = bag.ToList().OrderByDescending(o => o.ThrusterSignal).FirstOrDefault();
            Console.WriteLine(thrusterInput.ThrusterSignal);
        }

        private void CreateAllSeries(List<AmplifierSeries> amplifiersSeries)
        {
            for (var i = 0; i <= 44444; i++)
            {
                var amp = new AmplifierSeries(i);

                if (!amp.BelowFour || !amp.IsDifferent)
                {
                    continue;
                }

                amplifiersSeries.Add(amp);
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }

        public static int LoopUntilHaltDay7(List<int> input, int inputFor3, int secondInputFor3)
        {
            var index = 0;
            IntCodeInstruction instr = null;
            var output = -1;
            var oneInputUsed = false;

            while (instr == null || instr.OpCode != 99)
            {
                instr = new IntCodeInstruction(input[index]);
                if (instr.OpCode == 99)
                {
                    break;
                }

                var value1 = instr.ImidiateModeValue1 ? input[index + 1] : input[input[index + 1]];
                var storageIndex = input[index + 3];

                if (instr.OpCode == 1)
                {
                    input[storageIndex] =
                        value1 + (instr.ImidiateModeValue2 ? input[index + 2] : input[input[index + 2]]);
                }
                else if (instr.OpCode == 2)
                {
                    input[storageIndex] =
                        value1 * (instr.ImidiateModeValue2 ? input[index + 2] : input[input[index + 2]]);
                }
                else if (instr.OpCode == 3)
                {
                    value1 = input[index + 1];
                    if (oneInputUsed == true)
                    {
                        input[value1] = secondInputFor3; // INPUT
                    }
                    else
                    {
                        input[value1] = inputFor3; // INPUT
                        oneInputUsed = true;
                    }
                }
                else if (instr.OpCode == 4)
                {
                    value1 = input[index + 1];
                    //Console.WriteLine(input[value1]);
                    output = input[value1];
                }
                else if (instr.OpCode == 5)
                {
                    //Opcode 5 is jump-if-true: if the first parameter is non-zero, it sets the instruction pointer to the value from the second parameter. Otherwise, it does nothing.
                    if (value1 != 0)
                    {
                        index = instr.ImidiateModeValue2 ? input[index + 2] : input[input[index + 2]];
                    }
                    else
                    {
                        index += 3;
                    }

                    continue;
                }
                else if (instr.OpCode == 6)
                {
                    //Opcode 6 is jump-if-false: if the first parameter is zero, it sets the instruction pointer to the value from the second parameter. Otherwise, it does nothing.
                    if (value1 == 0)
                    {
                        index = instr.ImidiateModeValue2 ? input[index + 2] : input[input[index + 2]];
                    }
                    else
                    {
                        index += 3;
                    }

                    continue;
                }
                else if (instr.OpCode == 7)
                {
                    //Opcode 7 is less than: if the first parameter is less than the second parameter, it stores 1 in the position given by the third parameter. Otherwise, it stores 0.
                    if (value1 < (instr.ImidiateModeValue2 ? input[index + 2] : input[input[index + 2]]))
                    {
                        input[storageIndex] = 1;
                    }
                    else
                    {
                        input[storageIndex] = 0;
                    }
                }
                else if (instr.OpCode == 8)
                {
                    //Opcode 8 is equals: if the first parameter is equal to the second parameter, it stores 1 in the position given by the third parameter. Otherwise, it stores 0.
                    if (value1 == (instr.ImidiateModeValue2 ? input[index + 2] : input[input[index + 2]]))
                    {
                        input[storageIndex] = 1;
                    }
                    else
                    {
                        input[storageIndex] = 0;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }

                index += instr.HasTwoValues ? 4 : 2;
            }

            return output;
        }

    }

    public class ThrusterResult
    {
        public AmplifierSeries Series { get; set; }
        public int ThrusterSignal { get; set; }
    }

    public class AmplifierSeries
    {
        public readonly int A;
        public readonly int B;
        public readonly int C;
        public readonly int D;
        public readonly int E;

        public bool BelowFour => A <= 4 &&
                                 B <= 4 &&
                                 C <= 4 &&
                                 D <= 4 &&
                                 E <= 4;

        public bool IsDifferent => B != A &&
                                   C != A && C != B && 
                                   D != A && D != B && D != C &&
                                   E != A && E != B && E != C && E != D;

        public AmplifierSeries(int input)
        {
            var asString = input.ToString().PadLeft(5, '0');
            A = (int)char.GetNumericValue(asString[0]);
            B = (int)char.GetNumericValue(asString[1]);
            C = (int)char.GetNumericValue(asString[2]);
            D = (int)char.GetNumericValue(asString[3]);
            E = (int)char.GetNumericValue(asString[4]);
        }

        public override string ToString()
        {
            return $"{A},{B},{C},{D},{E}";
        }

        public IEnumerable<int> NextAmplifierValue
        {
            get
            {
                yield return A;
                yield return B;
                yield return C;
                yield return D;
                yield return E;
            }
        }
    }
}