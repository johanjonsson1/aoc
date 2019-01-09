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
    public class Day21 : Day
    {
        public override string Title => "2018 - Day 21";
        public static InstructionPointer InstructionPointer;

        public override void PartTwo()
        {
            base.PartTwo();
        }

        public override void PartOne()
        {
            base.PartOne();

var input = @"#ip 2
seti 123 0 5
bani 5 456 5
eqri 5 72 5
addr 5 2 2
seti 0 0 2
seti 0 9 5
bori 5 65536 3
seti 7586220 4 5
bani 3 255 1
addr 5 1 5
bani 5 16777215 5
muli 5 65899 5
bani 5 16777215 5
gtir 256 3 1
addr 1 2 2
addi 2 1 2
seti 27 9 2
seti 0 9 1
addi 1 1 4
muli 4 256 4
gtrr 4 3 4
addr 4 2 2
addi 2 1 2
seti 25 4 2
addi 1 1 1
seti 17 2 2
setr 1 6 3
seti 7 8 2
eqrr 5 0 1
addr 1 2 2
seti 5 0 2";

//            var input = @"#ip 0
//seti 5 0 1
//seti 6 0 2
//addi 0 1 0
//addr 1 2 3
//setr 1 0 0
//seti 8 0 4
//seti 9 0 5";
            var opCode = new OpCode2();
            var instructions = new List<Instruction2>();
            var index = 0;
            foreach (var line in input.ToStringList())
            {
                if (line.StartsWith("#ip"))
                {
                    InstructionPointer = new InstructionPointer { PointsToRegister = Convert.ToInt32(line.Replace("#ip ", "")) };
                    continue;
                }

                var splitInstr = line.Split();
                var instruction = new Instruction2 { Index = index, OpCode = splitInstr[0], A = Convert.ToInt32(splitInstr[1]), B = Convert.ToInt32(splitInstr[2]), Output = Convert.ToInt32(splitInstr[3]) };

                instructions.Add(instruction);
                index++;
            }

            var results = new List<Result>();

            for (int i = 7586220; i < int.MaxValue; i++)
            {
                var register = new Registers2 { A = i };
                var numberOfInstructions = 0;
                InstructionPointer.Value = register[InstructionPointer.PointsToRegister];

                var infiniteCounter = 0;

                while (true)
                {
                    try
                    {
                        //Console.Write("Pointer " + InstructionPointer.Value + ", ");
                        var instr = instructions[InstructionPointer.Value];

                        if (instr == null)
                        {
                            break;
                        }

                        //Console.Write(instr.OpCode + ", ");
                        register = opCode.OpCodes[instr.OpCode](register, instr);
                        numberOfInstructions++;
                        infiniteCounter++;

                        if (infiniteCounter == 100000)
                        {
                            break;
                        }
                    }
                    catch
                    {
                        break;
                    }
                }

                if (infiniteCounter == 100000)
                {
                    continue;
                }

                results.Add(new Result { Instructions = numberOfInstructions, RegisterValue = i });
            }

            results = results.OrderBy(o => o.Instructions).ThenBy(t => t.RegisterValue).ToList();

            if (results.Count > 0)
            {
                Console.WriteLine(results.First().Instructions + "," + results.First().RegisterValue);
            }
        }
    }

    public class Result
    {
        public int Instructions;
        public int RegisterValue;
    }

    public class InstructionPointer
    {
        public int PointsToRegister;
        public int Value;
    }

    public class Instruction2
    {
        public int Index;
        public string OpCode;
        public int A;
        public int B;
        public int Output;
    }

    public class Registers2
    {
        public int A;
        public int B;
        public int C;
        public int D;
        public int E;
        public int F;

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
                    case 4:
                        return E;
                    case 5:
                        return F;
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
                    case 4:
                        E = value;
                        break;
                    case 5:
                        F = value;
                        break;
                    default:
                        throw new ArgumentException("Index not allowed " + index);
                }
            }
        }
    }

    public static class RegisterExt2
    {
        public static Registers2 Copy(this Registers2 registers)
        {
            return new Registers2
            {
                A = registers.A,
                B = registers.B,
                C = registers.C,
                D = registers.D,
                E = registers.E,
                F = registers.F
            };
        }
    }

    public class OpCode2
    {
        public readonly Dictionary<string, Func<Registers2, Instruction2, Registers2>> OpCodes = new Dictionary<string, Func<Registers2, Instruction2, Registers2>>();

        public OpCode2()
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
        public Registers2 Addr(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a + b;

            //Console.WriteLine($"setting register {instruction.Output} to {output}");
            result[instruction.Output] = output;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //addi (add immediate) stores into register C the result of adding register A and value B.
        public Registers2 Addi(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a + b;

            //Console.WriteLine($"setting register {instruction.Output} to {output}");
            result[instruction.Output] = output;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Multiplication:
        //mulr(multiply register) stores into register C the result of multiplying register A and register B.
        public Registers2 Mulr(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a * b;

            //Console.WriteLine($"setting register {instruction.Output} to {output}");
            result[instruction.Output] = output;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //muli (multiply immediate) stores into register C the result of multiplying register A and value B.
        public Registers2 Muli(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a * b;

            //Console.WriteLine($"setting register {instruction.Output} to {output}");
            result[instruction.Output] = output;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Bitwise AND:
        //banr(bitwise AND register) stores into register C the result of the bitwise AND of register A and register B.
        public Registers2 Banr(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a & b;

            //Console.WriteLine($"checking register {instruction.A} & {instruction.B}");
            //Console.WriteLine($"setting register {instruction.Output} to {output}");
            result[instruction.Output] = output;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //bani(bitwise AND immediate) stores into register C the result of the bitwise AND of register A and value B.
        public Registers2 Bani(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a & b;

            //Console.WriteLine($"checking register {instruction.A} & {instruction.B}");
            //Console.WriteLine($"setting register {instruction.Output} to {output}");
            result[instruction.Output] = output;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Bitwise OR:
        //borr (bitwise OR register) stores into register C the result of the bitwise OR of register A and register B.
        public Registers2 Borr(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a | b;

            //Console.WriteLine($"checking register {instruction.A} & {instruction.B}");
            //Console.WriteLine($"setting register {instruction.Output} to {output}");
            result[instruction.Output] = output;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //bori(bitwise OR immediate) stores into register C the result of the bitwise OR of register A and value B.
        public Registers2 Bori(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a | b;

            //Console.WriteLine($"checking register {instruction.A} & {instruction.B}");
            //Console.WriteLine($"setting register {instruction.Output} to {output}");
            result[instruction.Output] = output;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Assignment:
        //setr (set register) copies the contents of register A into register C. (Input B is ignored.)
        public Registers2 Setr(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];

            //Console.WriteLine($"setting register {instruction.Output} to {a}");
            result[instruction.Output] = a;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //seti(set immediate) stores value A into register C. (Input B is ignored.)
        public Registers2 Seti(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = instruction.A;

            //Console.WriteLine($"setting register {instruction.Output} to {a}");
            result[instruction.Output] = a;
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Greater-than testing:
        //gtir(greater-than immediate/register) sets register C to 1 if value A is greater than register B.Otherwise, register C is set to 0.
        public Registers2 Gtir(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = instruction.A;
            var b = before[instruction.B];
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            //Console.WriteLine($"setting register {instruction.Output} to {result[instruction.Output]}");
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //gtri (greater-than register/immediate) sets register C to 1 if register A is greater than value B.Otherwise, register C is set to 0.
        public Registers2 Gtri(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            //Console.WriteLine($"setting register {instruction.Output} to {result[instruction.Output]}");
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //gtrr (greater-than register/register) sets register C to 1 if register A is greater than register B.Otherwise, register C is set to 0.
        public Registers2 Gtrr(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            //Console.WriteLine($"setting register {instruction.Output} to {result[instruction.Output]}");
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Equality testing:
        //eqir (equal immediate/register) sets register C to 1 if value A is equal to register B.Otherwise, register C is set to 0.
        public Registers2 Eqir(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = instruction.A;
            var b = before[instruction.B];
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            //Console.WriteLine($"setting register {instruction.Output} to {result[instruction.Output]}");
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //eqri (equal register/immediate) sets register C to 1 if register A is equal to value B.Otherwise, register C is set to 0.
        public Registers2 Eqri(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            //Console.WriteLine($"setting register {instruction.Output} to {result[instruction.Output]}");
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //eqrr (equal register/register) sets register C to 1 if register A is equal to register B.Otherwise, register C is set to 0.
        public Registers2 Eqrr(Registers2 before, Instruction2 instruction)
        {
            before[Day21.InstructionPointer.PointsToRegister] = Day21.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            //Console.WriteLine($"setting register {instruction.Output} to {result[instruction.Output]}");
            Day21.InstructionPointer.Value = result[Day21.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
    }
}
