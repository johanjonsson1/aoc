﻿using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
    --- Day 16: Chronal Classification ---
    As you see the Elves defend their hot chocolate successfully, you go back to falling through time. 
    This is going to become a problem.

    If you're ever going to return to your own time, you need to understand how this device on your wrist works. 
    You have a little while before you reach your next destination, and with a bit of trial and error, you manage to pull up a programming manual on the device's tiny screen.

    According to the manual, the device has four registers (numbered 0 through 3) that can be manipulated by instructions containing one of 16 opcodes. 
    The registers start with the value 0.

    Every instruction consists of four values: an opcode, two inputs (named A and B), and an output (named C), in that order. 
    The opcode specifies the behavior of the instruction and how the inputs are interpreted. 
    The output, C, is always treated as a register.

    In the opcode descriptions below, if something says "value A", it means to take the number given as A literally. 
    (This is also called an "immediate" value.) 
    If something says "register A", it means to use the number given as A to read from (or write to) the register with that number. 

    So, if the opcode addi adds register A and value B, storing the result in register C, and the instruction addi 0 7 3 is encountered, 
    it would add 7 to the value contained by register 0 and store the sum in register 3, never modifying registers 0, 1, or 2 in the process.

    Many opcodes are similar except for how they interpret their arguments. 
    
    The opcodes fall into seven general categories:

    Addition:

    addr (add register) stores into register C the result of adding register A and register B.
    addi (add immediate) stores into register C the result of adding register A and value B.
    Multiplication:

    mulr (multiply register) stores into register C the result of multiplying register A and register B.
    muli (multiply immediate) stores into register C the result of multiplying register A and value B.
    Bitwise AND:

    banr (bitwise AND register) stores into register C the result of the bitwise AND of register A and register B.
    bani (bitwise AND immediate) stores into register C the result of the bitwise AND of register A and value B.
    Bitwise OR:

    borr (bitwise OR register) stores into register C the result of the bitwise OR of register A and register B.
    bori (bitwise OR immediate) stores into register C the result of the bitwise OR of register A and value B.
    Assignment:

    setr (set register) copies the contents of register A into register C. (Input B is ignored.)
    seti (set immediate) stores value A into register C. (Input B is ignored.)
    Greater-than testing:

    gtir (greater-than immediate/register) sets register C to 1 if value A is greater than register B. Otherwise, register C is set to 0.
    gtri (greater-than register/immediate) sets register C to 1 if register A is greater than value B. Otherwise, register C is set to 0.
    gtrr (greater-than register/register) sets register C to 1 if register A is greater than register B. Otherwise, register C is set to 0.
    Equality testing:

    eqir (equal immediate/register) sets register C to 1 if value A is equal to register B. Otherwise, register C is set to 0.
    eqri (equal register/immediate) sets register C to 1 if register A is equal to value B. Otherwise, register C is set to 0.
    eqrr (equal register/register) sets register C to 1 if register A is equal to register B. Otherwise, register C is set to 0.

    Unfortunately, while the manual gives the name of each opcode, it doesn't seem to indicate the number. 
    However, you can monitor the CPU to see the contents of the registers before and after instructions are executed to try to work them out. 
    Each opcode has a number from 0 through 15, but the manual doesn't say which is which. For example, suppose you capture the following sample:

    Before: [3, 2, 1, 1]
    9 2 1 2
    After:  [3, 2, 2, 1]
    This sample shows the effect of the instruction 9 2 1 2 on the registers. 
    Before the instruction is executed, register 0 has value 3, register 1 has value 2, and registers 2 and 3 have value 1. 
    After the instruction is executed, register 2's value becomes 2.

    The instruction itself, 9 2 1 2, means that opcode 9 was executed with A=2, B=1, and C=2. 
    Opcode 9 could be any of the 16 opcodes listed above, but only three of them behave in a way that would cause the result shown in the sample:

    Opcode 9 could be mulr: register 2 (which has a value of 1) times register 1 (which has a value of 2) produces 2, which matches the value stored in the output register, register 2.
    Opcode 9 could be addi: register 2 (which has a value of 1) plus value 1 produces 2, which matches the value stored in the output register, register 2.
    Opcode 9 could be seti: value 2 matches the value stored in the output register, register 2; the number given for B is irrelevant.
    None of the other opcodes produce the result captured in the sample. Because of this, the sample above behaves like three opcodes.

    You collect many of these samples (the first section of your puzzle input). 
    The manual also includes a small test program (the second section of your puzzle input) - you can ignore it for now.

    Ignoring the opcode numbers, how many samples in your puzzle input behave like three or more opcodes?

    --- Part Two ---
    Using the samples you collected, work out the number of each opcode and execute the test program (the second section of your puzzle input).

    What value is contained in register 0 after executing the test program?
    */
    public class Day16 : Day
    {
        public override string Title => "2018 - Day 16: Chronal Classification";

        public override void PartOne()
        {
            base.PartOne();
            //            var input = @"Before: [3, 2, 1, 1]
            //9 2 1 2
            //After:  [3, 2, 2, 1]".ToStringList();
            var input = Inputs.Day16.ToStringList();
            var samples = new List<Sample>();
            PopulateSamples(input, samples);
            var opCode = new OpCode();
            FindMatches(samples, opCode);

            var result = samples.Where(x => x.MatchingOpCodes.Count >= 3).ToList();
            Console.WriteLine(result.Count); // 596
        }

        private static void FindMatches(List<Sample> samples, OpCode opCode)
        {
            foreach (var sample in samples)
            {
                foreach (var op in opCode.OpCodes)
                {
                    if (sample.After.IsSameAs(op.Value(sample.Before, sample.Instruction)))
                    {
                        sample.MatchingOpCodes.Add(op.Key);
                    }
                }
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day16.ToStringList();
            var samples = new List<Sample>();
            PopulateSamples(input, samples);
            var opCode = new OpCode();
            FindMatches(samples, opCode);
            var opCodeDict = new Dictionary<int, string>();
            var foundOpCodes = opCodeDict.Values.ToList();

            var result = samples.Where(x => x.MatchingOpCodes.Count == 1).ToList();

            while (result.Count > 0)
            {
                foreach (var sample in result)
                {
                    foreach (var op in opCode.OpCodes)
                    {
                        if (sample.After.IsSameAs(op.Value(sample.Before, sample.Instruction)))
                        {
                            if (!opCodeDict.ContainsValue(op.Key))
                            {
                                opCodeDict.Add(sample.Instruction.OpCode, op.Key);
                            }
                        }
                    }
                }

                foundOpCodes = opCodeDict.Values.ToList();
                result = samples.Where(x => x.MatchingOpCodes.Except(foundOpCodes).Count() == 1).ToList();
            }

            var instructions = new List<Instruction>();
            foreach (var line in Inputs.Day16_2.ToStringList())
            {
                var splitInstr = line.SplitAsIntsBy();
                var instruction = new Instruction { OpCode = splitInstr[0], A = splitInstr[1], B = splitInstr[2], Output = splitInstr[3] };

                instructions.Add(instruction);
            }

            var register = new Registers();

            foreach (var instr in instructions)
            {
                register = opCode.OpCodes[opCodeDict[instr.OpCode]](register, instr);
            }

            Console.WriteLine(register.A); // 554
        }

        private static void PopulateSamples(List<string> input, List<Sample> samples)
        {
            for (int i = 0; i < input.Count; i += 3)
            {
                var sample = new Sample();
                var splitBefore = input[i].RemoveAToZ().SplitAsIntsBy(':', '[', ']', ',');
                var before = new Registers { A = splitBefore[0], B = splitBefore[1], C = splitBefore[2], D = splitBefore[3] };

                var splitInstr = input[i + 1].SplitAsIntsBy();
                var instruction = new Instruction { OpCode = splitInstr[0], A = splitInstr[1], B = splitInstr[2], Output = splitInstr[3] };

                var splitAfter = input[i + 2].RemoveAToZ().SplitAsIntsBy(':', '[', ']', ',');
                var after = new Registers { A = splitAfter[0], B = splitAfter[1], C = splitAfter[2], D = splitAfter[3] };

                sample.Before = before;
                sample.Instruction = instruction;
                sample.After = after;

                samples.Add(sample);
            }
        }
    }

    public class Sample
    {
        public Registers Before;
        public Registers After;
        public Instruction Instruction;
        public List<string> MatchingOpCodes = new List<string>();
    }

    public class Instruction
    {
        public int OpCode;
        public int A;
        public int B;
        public int Output;
    }

    public class Registers
    {
        public int A;
        public int B;
        public int C;
        public int D;

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return A;
                    case 1:
                        return B;
                    case 2:
                        return C;
                    case 3:
                        return D;
                    default:
                        throw new ArgumentException("Index not allowed " + index);
                }
            }

            set
            {
                switch (index)
                {
                    case 0:
                        A = value;
                        break;
                    case 1:
                        B = value;
                        break;
                    case 2:
                        C = value;
                        break;
                    case 3:
                        D = value;
                        break;
                    default:
                        throw new ArgumentException("Index not allowed " + index);
                }
            }
        }
    }

    public static class RegisterExt
    {
        public static bool IsSameAs(this Registers thisRegisters, Registers otherRegisters)
        {
            return thisRegisters.A == otherRegisters.A &&
                thisRegisters.B == otherRegisters.B &&
                thisRegisters.C == otherRegisters.C &&
                thisRegisters.D == otherRegisters.D;
        }

        public static Registers Copy(this Registers registers)
        {
            return new Registers
            {
                A = registers.A,
                B = registers.B,
                C = registers.C,
                D = registers.D
            };
        }
    }

    public class OpCode
    {
        public readonly Dictionary<string, Func<Registers, Instruction, Registers>> OpCodes = new Dictionary<string, Func<Registers, Instruction, Registers>>();

        public OpCode()
        {
            OpCodes.Add("addr", Addr);
            OpCodes.Add("addi", Addi);
            OpCodes.Add("mulr", Mulr);
            OpCodes.Add("muli", Muli);
            OpCodes.Add("banr", Banr);
            OpCodes.Add("bani", Bani);
            OpCodes.Add("borr", Borr);
            OpCodes.Add("bori", Bori);
            OpCodes.Add("setr", Setr);
            OpCodes.Add("seti", Seti);
            OpCodes.Add("gtir", Gtir);
            OpCodes.Add("gtri", Gtri);
            OpCodes.Add("gtrr", Gtrr);
            OpCodes.Add("eqir", Eqir);
            OpCodes.Add("eqri", Eqri);
            OpCodes.Add("eqrr", Eqrr);
        }

        //        Addition:
        //addr(add register) stores into register C the result of adding register A and register B.
        public Registers Addr(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a + b;

            result[instruction.Output] = output;
            return result;
        }
        //addi (add immediate) stores into register C the result of adding register A and value B.
        public Registers Addi(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a + b;

            result[instruction.Output] = output;
            return result;
        }

        //Multiplication:
        //mulr(multiply register) stores into register C the result of multiplying register A and register B.
        public Registers Mulr(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a * b;

            result[instruction.Output] = output;
            return result;
        }
        //muli (multiply immediate) stores into register C the result of multiplying register A and value B.
        public Registers Muli(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a * b;

            result[instruction.Output] = output;
            return result;
        }

        //Bitwise AND:
        //banr(bitwise AND register) stores into register C the result of the bitwise AND of register A and register B.
        public Registers Banr(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a & b;

            result[instruction.Output] = output;
            return result;
        }
        //bani(bitwise AND immediate) stores into register C the result of the bitwise AND of register A and value B.
        public Registers Bani(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a & b;

            result[instruction.Output] = output;
            return result;
        }

        //Bitwise OR:
        //borr (bitwise OR register) stores into register C the result of the bitwise OR of register A and register B.
        public Registers Borr(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a | b;

            result[instruction.Output] = output;
            return result;
        }
        //bori(bitwise OR immediate) stores into register C the result of the bitwise OR of register A and value B.
        public Registers Bori(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a | b;

            result[instruction.Output] = output;
            return result;
        }

        //Assignment:
        //setr (set register) copies the contents of register A into register C. (Input B is ignored.)
        public Registers Setr(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];

            result[instruction.Output] = a;
            return result;
        }
        //seti(set immediate) stores value A into register C. (Input B is ignored.)
        public Registers Seti(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = instruction.A;

            result[instruction.Output] = a;
            return result;
        }

        //Greater-than testing:
        //gtir(greater-than immediate/register) sets register C to 1 if value A is greater than register B.Otherwise, register C is set to 0.
        public Registers Gtir(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = instruction.A;
            var b = before[instruction.B];
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            return result;
        }
        //gtri (greater-than register/immediate) sets register C to 1 if register A is greater than value B.Otherwise, register C is set to 0.
        public Registers Gtri(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            return result;
        }
        //gtrr (greater-than register/register) sets register C to 1 if register A is greater than register B.Otherwise, register C is set to 0.
        public Registers Gtrr(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            return result;
        }

        //Equality testing:
        //eqir (equal immediate/register) sets register C to 1 if value A is equal to register B.Otherwise, register C is set to 0.
        public Registers Eqir(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = instruction.A;
            var b = before[instruction.B];
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            return result;
        }
        //eqri (equal register/immediate) sets register C to 1 if register A is equal to value B.Otherwise, register C is set to 0.
        public Registers Eqri(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            return result;
        }
        //eqrr (equal register/register) sets register C to 1 if register A is equal to register B.Otherwise, register C is set to 0.
        public Registers Eqrr(Registers before, Instruction instruction)
        {
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            return result;
        }
    }
}