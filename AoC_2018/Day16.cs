using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
    */
    public class Day16 : Day
    {
        public override string Title => "2018 - Day 16";

        public override void PartOne()
        {
            base.PartOne();
            return;
            //            var input = @"Before: [3, 2, 1, 1]
            //9 2 1 2
            //After:  [3, 2, 2, 1]".ToStringList();

            var input = "".ToStringList();// Inputs.Day16.ToStringList();
            var samples = new List<Sample>();
            PopulateSamples(input, samples);
            var opCode = new OpCode();

            foreach (var sample in samples)
            {
                foreach (var op in opCode.OpCodes)
                {
                    if(sample.After.IsSameAs(op.Value(sample.Before, sample.Instruction)))
                    {
                        //Console.WriteLine("sample matching " + op.Key);
                        sample.MatchingOpCodes.Add(op.Key);
                    }
                }
            }

            var result = samples.Where(x => x.MatchingOpCodes.Count >= 3).ToList();
            Console.WriteLine(result.Count);
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

        public override void PartTwo()
        {
            base.PartTwo();

            var input = "".ToStringList();//Inputs.Day16.ToStringList();
            var samples = new List<Sample>();
            PopulateSamples(input, samples);
            var opCode = new OpCode();

            foreach (var sample in samples)
            {
                foreach (var op in opCode.OpCodes)
                {
                    if (sample.After.IsSameAs(op.Value(sample.Before, sample.Instruction)))
                    {
                        //Console.WriteLine("sample matching " + op.Key);
                        sample.MatchingOpCodes.Add(op.Key);
                    }
                }
            }

            var opCodeDict = new Dictionary<int, string>();
            var foundOpCodes = opCodeDict.Values.ToList();

            var result = samples.Where(x => x.MatchingOpCodes.Count == 1).ToList();

            while(result.Count > 0)
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

                            //break;
                        }
                    }
                }

                foundOpCodes = opCodeDict.Values.ToList();
                result = samples.Where(x => x.MatchingOpCodes.Except(foundOpCodes).Count() == 1).ToList();
            }

            var instructions = new List<Instruction>();
            foreach (var line in "".ToStringList()/*Inputs.Day16_2.ToStringList()*/)
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

            Console.WriteLine(register.A);
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
