using System;
using System.Collections.Generic;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day9 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day9.SplitAsLongsBy(',');
            //input = @"109,19,204,-34".SplitAsLongsBy(',');
            var newList = new List<long>(100000);
            newList.AddRange(input);

            for (int i = 0; i < 100000; i++)
            {
                newList.Add(0);
            }

            LoopUntilHaltDay9(newList);

            Console.WriteLine();
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }

        public static void LoopUntilHaltDay9(List<long> input)
        {
            int index = 0;
            IntCodeInstruction2 instr = null;
            long relativeModeVal = 0;

            long GetValue1(IntCodeInstruction2 i)
            {
                if (i.ModeValue1 == IntCodeMode.Imidiate)
                    return input[index + 1];
                if (i.ModeValue1 == IntCodeMode.Relative)
                    return input[(int)(relativeModeVal + input[index + 1])];
                
                return input[(int)input[index + 1]];
            }

            long GetValue2(IntCodeInstruction2 i)
            {
                if (i.ModeValue2 == IntCodeMode.Imidiate)
                    return input[index + 2];
                if (i.ModeValue2 == IntCodeMode.Relative)
                    return input[(int)(relativeModeVal + input[index + 2])];

                return input[(int)input[index + 2]];
            }

            long GetValue3(IntCodeInstruction2 i)
            {
                if (i.ModeValue2 == IntCodeMode.Imidiate)
                    return input[index + 3];
                if (i.ModeValue2 == IntCodeMode.Relative)
                    return input[(int)(relativeModeVal + input[index + 3])];

                return input[(int)input[index + 3]];
            }

            while (instr == null || instr.OpCode != 99)
            {
                instr = new IntCodeInstruction2(input[index]);
                if (instr.OpCode == 99)
                {
                    break;
                }

                var value1 = GetValue1(instr);

                if (instr.OpCode == 1)
                {
                    input[(int)GetValue3(instr)] = value1 + GetValue2(instr);
                }
                else if (instr.OpCode == 2)
                {
                    input[(int)GetValue3(instr)] = value1 * GetValue2(instr);
                }
                else if (instr.OpCode == 3)
                {
                    value1 = GetValue1(instr);
                    input[(int)value1] = 1; // INPUT
                }
                else if (instr.OpCode == 4)
                {
                    value1 = GetValue1(instr);
                    Console.WriteLine(value1);
                }
                else if (instr.OpCode == 9)
                {
                    //Opcode 9 adjusts the relative base by the value of its only parameter. The relative base increases (or decreases, if the value is negative) by the value of the parameter.
                    value1 = input[index + 1];
                    relativeModeVal += value1;
                }
                else if (instr.OpCode == 5)
                {
                    //Opcode 5 is jump-if-true: if the first parameter is non-zero, it sets the instruction pointer to the value from the second parameter. Otherwise, it does nothing.
                    if (value1 != 0)
                    {
                        index = (int)GetValue2(instr);
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
                        index = (int)GetValue2(instr);
                    }
                    else
                    {
                        index += 3;
                    }

                    continue;
                }
                else if (instr.OpCode == 7)
                {
                    var storageIndex = GetValue3(instr);
                    //Opcode 7 is less than: if the first parameter is less than the second parameter, it stores 1 in the position given by the third parameter. Otherwise, it stores 0.
                    if (value1 < GetValue2(instr))
                    {
                        input[(int)storageIndex] = 1;
                    }
                    else
                    {
                        input[(int)storageIndex] = 0;
                    }
                }
                else if (instr.OpCode == 8)
                {
                    var storageIndex = GetValue3(instr);
                    //Opcode 8 is equals: if the first parameter is equal to the second parameter, it stores 1 in the position given by the third parameter. Otherwise, it stores 0.
                    if (value1 == GetValue2(instr))
                    {
                        input[(int)storageIndex] = 1;
                    }
                    else
                    {
                        input[(int)storageIndex] = 0;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }

                index += instr.HasTwoValues ? 4 : 2;
            }
        }

    }

    public class IntCodeInstruction2
    {
        public readonly int OpCode;
        private readonly string Stringified;
        public IntCodeMode ModeValue1 = IntCodeMode.Position;
        public IntCodeMode ModeValue2 = IntCodeMode.Position;
        public IntCodeMode ModeValue3 = IntCodeMode.Position;

        public bool HasTwoValues => OpCode == 1
                                    || OpCode == 2
                                    || OpCode == 7
                                    || OpCode == 8;

        public IntCodeInstruction2(long input)
        {
            Stringified = input.ToString();

            for (var i = Stringified.Length - 1; i >= 0; i--)
            {
                var current = (int)char.GetNumericValue(Stringified[i]);
                if (i == Stringified.Length - 1)
                {
                    if (input.ToString().EndsWith("99"))
                    {
                        OpCode = 99;
                    }
                    else
                    {
                        OpCode = current;
                    }
                }
                else if (i == Stringified.Length - 3)
                {
                    if (current == 1)
                        ModeValue1 = IntCodeMode.Imidiate;
                    else if (current == 2)
                        ModeValue1 = IntCodeMode.Relative;
                }
                else if (i == Stringified.Length - 4)
                {
                    if (current == 1)
                        ModeValue2 = IntCodeMode.Imidiate;
                    else if (current == 2)
                        ModeValue2 = IntCodeMode.Relative;
                }
                else if (i == Stringified.Length - 5)
                {
                    if (current == 1)
                        ModeValue3 = IntCodeMode.Imidiate;
                    else if (current == 2)
                        ModeValue3 = IntCodeMode.Relative;
                }
            }
        }
    }

    public enum IntCodeMode
    {
        Position,
        Imidiate,
        Relative
    }

}