using System;
using System.Collections.Generic;
using System.Text;

namespace AoC.Common
{
    public class IntCodeProgram
    {
        private readonly int _amplifier;
        private long[] _input;
        private bool IsHalted = false;
        public bool IsHalted2 = false;
        public bool IsTerminated = false;
        private long _index = 0;
        public long Output = -1;
        private bool OneInputUsed;
        long _relativeModeVal = 0;
        private Queue<long> _inputsQueue = new Queue<long>();

        public IntCodeProgram(int amplifier, long[] inputs)
        {
            _amplifier = amplifier;
            _input = inputs;
        }

        public IntCodeProgram(long[] inputs)
        {
            _input = inputs;
            OneInputUsed = true;
        }

        public void AddInput(long input)
        {
            _inputsQueue.Enqueue(input);
        }

        public void LoopUntilHalt(long input)
        {
            IsHalted = false;
            IsHalted2 = false;
            IntCodeProgramInstruction instr = null;
            var inputCounter = 0;

            while (!IsHalted && !IsTerminated && !IsHalted2)
            {
                instr = new IntCodeProgramInstruction(_input[_index]);
                if (instr.OpCode == 99)
                {
                    IsTerminated = true;
                    break;
                }

                if (instr.OpCode == 1)
                {
                    _input[GetPointer3(instr)] = _input[GetPointer1(instr)] + _input[GetPointer2(instr)];
                }
                else if (instr.OpCode == 2)
                {
                    _input[GetPointer3(instr)] = _input[GetPointer1(instr)] * _input[GetPointer2(instr)];
                }
                else if (instr.OpCode == 3)
                {
                    if (_inputsQueue.Count > 0)
                    {
                        _input[GetPointer1(instr)] = _inputsQueue.Dequeue();
                    }
                    else if (OneInputUsed)
                    {
                        _input[GetPointer1(instr)] = input; // INPUT
                        inputCounter++;
                        if (inputCounter > 3)
                        {
                            IsHalted2 = true;
                        }
                    }
                    else
                    {
                        _input[GetPointer1(instr)] = _amplifier; // INPUT
                        OneInputUsed = true;
                    }
                }
                else if (instr.OpCode == 4)
                {
                    Output = _input[GetPointer1(instr)];
                    IsHalted = true;
                    //Console.WriteLine(Output);
                }
                else if (instr.OpCode == 9)
                {
                    //Opcode 9 adjusts the relative base by the value of its only parameter. The relative base increases (or decreases, if the value is negative) by the value of the parameter.
                    _relativeModeVal += _input[GetPointer1(instr)];
                }
                else if (instr.OpCode == 5)
                {
                    //Opcode 5 is jump-if-true: if the first parameter is non-zero, it sets the instruction pointer to the value from the second parameter. Otherwise, it does nothing.
                    if (_input[GetPointer1(instr)] != 0)
                    {
                        _index = _input[GetPointer2(instr)];
                    }
                    else
                    {
                        _index += 3;
                    }

                    continue;
                }
                else if (instr.OpCode == 6)
                {
                    //Opcode 6 is jump-if-false: if the first parameter is zero, it sets the instruction pointer to the value from the second parameter. Otherwise, it does nothing.
                    if (_input[GetPointer1(instr)] == 0)
                    {
                        _index = _input[GetPointer2(instr)];
                    }
                    else
                    {
                        _index += 3;
                    }

                    continue;
                }
                else if (instr.OpCode == 7)
                {
                    var storageIndex = GetPointer3(instr);
                    //Opcode 7 is less than: if the first parameter is less than the second parameter, it stores 1 in the position given by the third parameter. Otherwise, it stores 0.
                    if (_input[GetPointer1(instr)] < _input[GetPointer2(instr)])
                    {
                        _input[storageIndex] = 1;
                    }
                    else
                    {
                        _input[storageIndex] = 0;
                    }
                }
                else if (instr.OpCode == 8)
                {
                    var storageIndex = GetPointer3(instr);
                    //Opcode 8 is equals: if the first parameter is equal to the second parameter, it stores 1 in the position given by the third parameter. Otherwise, it stores 0.
                    if (_input[GetPointer1(instr)] == _input[GetPointer2(instr)])
                    {
                        _input[storageIndex] = 1;
                    }
                    else
                    {
                        _input[storageIndex] = 0;
                    }
                }
                else
                {
                    throw new ArgumentException();
                }

                _index += instr.HasTwoValues ? 4 : 2;
            }

            long GetPointer1(IntCodeProgramInstruction i)
            {
                if (i.ModeValue1 == IntCodeMode.Imidiate)
                    return _index + 1;
                if (i.ModeValue1 == IntCodeMode.Relative)
                    return _relativeModeVal + _input[_index + 1];

                return _input[_index + 1];
            }

            long GetPointer2(IntCodeProgramInstruction i)
            {
                if (i.ModeValue2 == IntCodeMode.Imidiate)
                    return _index + 2;
                if (i.ModeValue2 == IntCodeMode.Relative)
                    return _relativeModeVal + _input[_index + 2];

                return _input[_index + 2];
            }

            long GetPointer3(IntCodeProgramInstruction i)
            {
                if (i.ModeValue3 == IntCodeMode.Imidiate)
                    return _index + 3;
                if (i.ModeValue3 == IntCodeMode.Relative)
                    return _relativeModeVal + _input[_index + 3];

                return _input[_index + 3];
            }
        }
    }

    public class IntCodeProgramInstruction
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

        public IntCodeProgramInstruction(long input)
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
