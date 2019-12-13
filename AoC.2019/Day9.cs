using System;
using System.Collections.Generic;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*
    --- Day 9: Sensor Boost ---
    You've just said goodbye to the rebooted rover and left Mars when you receive a faint distress signal coming from the asteroid belt. 
    It must be the Ceres monitoring station!

    In order to lock on to the signal, you'll need to boost your sensors. The Elves send up the latest BOOST program - Basic Operation Of System Test.

    While BOOST (your puzzle input) is capable of boosting your sensors, for tenuous safety reasons, 
    it refuses to do so until the computer it runs on passes some checks to demonstrate it is a complete Intcode computer.

    Your existing Intcode computer is missing one key feature: it needs support for parameters in relative mode.

    Parameters in mode 2, relative mode, behave very similarly to parameters in position mode: the parameter is interpreted as a position. 
    Like position mode, parameters in relative mode can be read from or written to.

    The important difference is that relative mode parameters don't count from address 0. 
    Instead, they count from a value called the relative base. The relative base starts at 0.

    The address a relative mode parameter refers to is itself plus the current relative base. 
    When the relative base is 0, relative mode parameters and position mode parameters with the same value refer to the same address.

    For example, given a relative base of 50, a relative mode parameter of -7 refers to memory address 50 + -7 = 43.

    The relative base is modified with the relative base offset instruction:

    Opcode 9 adjusts the relative base by the value of its only parameter. 
    The relative base increases (or decreases, if the value is negative) by the value of the parameter.
    For example, if the relative base is 2000, then after the instruction 109,19, the relative base would be 2019. 
    If the next instruction were 204,-34, then the value at address 1985 would be output.

    Your Intcode computer will also need a few other capabilities:

    The computer's available memory should be much larger than the initial program. 
    Memory beyond the initial program starts with the value 0 and can be read or written like any other memory. 
    (It is invalid to try to access memory at a negative address, though.)
    The computer should have support for large numbers. Some instructions near the beginning of the BOOST program will verify this capability.
    Here are some example programs that use these features:

    109,1,204,-1,1001,100,1,100,1008,100,16,101,1006,101,0,99 takes no input and produces a copy of itself as output.
    1102,34915192,34915192,7,4,7,99,0 should output a 16-digit number.
    104,1125899906842624,99 should output the large number in the middle.
    The BOOST program will ask for a single input; run it in test mode by providing it the value 1. 
    It will perform a series of checks on each opcode, output any opcodes (and the associated parameter modes) that seem to be functioning incorrectly, and finally output a BOOST keycode.

    Once your Intcode computer is fully functional, the BOOST program should report no malfunctioning opcodes when run in test mode; it should only output a single value, the BOOST keycode. 
    What BOOST keycode does it produce?

    Your puzzle answer was 2453265701.

    --- Part Two ---
    You now have a complete Intcode computer.

    Finally, you can lock on to the Ceres distress signal! You just need to boost your sensors using the BOOST program.

    The program runs in sensor boost mode by providing the input instruction the value 2. 
    Once run, it will boost the sensors automatically, but it might take a few seconds to complete the operation on slower hardware. 
    In sensor boost mode, the program will output a single value: the coordinates of the distress signal.

    Run the BOOST program in sensor boost mode. What are the coordinates of the distress signal?

    Your puzzle answer was 80805.
    */

    public class Day9 : Day
    {
        public override string Title => "--- Day 9: Sensor Boost ---";
        private static long _input;

        public override void PartOne()
        {
            base.PartOne();
            _input = 1;
            var input = Inputs.Day9.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            //input = @"109,19,204,-34".SplitAsLongsBy(',');
            LoopUntilHaltDay9(input);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            _input = 2;
            var input = Inputs.Day9.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            //input = @"109,19,204,-34".SplitAsLongsBy(',');
            LoopUntilHaltDay9(input);
        }

        public static void LoopUntilHaltDay9(long[] input)
        {
            long index = 0;
            IntCodeInstruction2 instr = null;
            long relativeModeVal = 0;

            while (instr == null || instr.OpCode != 99)
            {
                instr = new IntCodeInstruction2(input[index]);
                if (instr.OpCode == 99)
                {
                    break;
                }

                if (instr.OpCode == 1)
                {
                    input[GetPointer3(instr)] = input[GetPointer1(instr)] + input[GetPointer2(instr)];
                }
                else if (instr.OpCode == 2)
                {
                    input[GetPointer3(instr)] = input[GetPointer1(instr)] * input[GetPointer2(instr)];
                }
                else if (instr.OpCode == 3)
                {
                    input[GetPointer1(instr)] = _input; // INPUT
                }
                else if (instr.OpCode == 4)
                {
                    Console.WriteLine(input[GetPointer1(instr)]);
                }
                else if (instr.OpCode == 9)
                {
                    //Opcode 9 adjusts the relative base by the value of its only parameter. The relative base increases (or decreases, if the value is negative) by the value of the parameter.
                    relativeModeVal += input[GetPointer1(instr)];
                }
                else if (instr.OpCode == 5)
                {
                    //Opcode 5 is jump-if-true: if the first parameter is non-zero, it sets the instruction pointer to the value from the second parameter. Otherwise, it does nothing.
                    if (input[GetPointer1(instr)] != 0)
                    {
                        index = input[GetPointer2(instr)];
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
                    if (input[GetPointer1(instr)] == 0)
                    {
                        index = input[GetPointer2(instr)];
                    }
                    else
                    {
                        index += 3;
                    }

                    continue;
                }
                else if (instr.OpCode == 7)
                {
                    var storageIndex = GetPointer3(instr);
                    //Opcode 7 is less than: if the first parameter is less than the second parameter, it stores 1 in the position given by the third parameter. Otherwise, it stores 0.
                    if (input[GetPointer1(instr)] < input[GetPointer2(instr)])
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
                    var storageIndex = GetPointer3(instr);
                    //Opcode 8 is equals: if the first parameter is equal to the second parameter, it stores 1 in the position given by the third parameter. Otherwise, it stores 0.
                    if (input[GetPointer1(instr)] == input[GetPointer2(instr)])
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

            long GetPointer1(IntCodeInstruction2 i)
            {
                if (i.ModeValue1 == IntCodeMode.Imidiate)
                    return index + 1;
                if (i.ModeValue1 == IntCodeMode.Relative)
                    return relativeModeVal + input[index + 1];

                return input[index + 1];
            }

            long GetPointer2(IntCodeInstruction2 i)
            {
                if (i.ModeValue2 == IntCodeMode.Imidiate)
                    return index + 2;
                if (i.ModeValue2 == IntCodeMode.Relative)
                    return relativeModeVal + input[index + 2];

                return input[index + 2];
            }

            long GetPointer3(IntCodeInstruction2 i)
            {
                if (i.ModeValue3 == IntCodeMode.Imidiate)
                    return index + 3;
                if (i.ModeValue3 == IntCodeMode.Relative)
                    return relativeModeVal + input[index + 3];

                return input[index + 3];
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
                var current = (int) char.GetNumericValue(Stringified[i]);
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