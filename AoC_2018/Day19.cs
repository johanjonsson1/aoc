using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC_2018
{
    /*
    --- Day 19: Go With The Flow ---
    With the Elves well on their way constructing the North Pole base, you turn your attention back to understanding the inner workings of programming the device.

    You can't help but notice that the device's opcodes don't contain any flow control like jump instructions. 
    The device's manual goes on to explain:

    "In programs where flow control is required, the instruction pointer can be bound to a register so that it can be manipulated directly. 
    This way, setr/seti can function as absolute jumps, addr/addi can function as relative jumps, and other opcodes can cause truly fascinating effects."

    This mechanism is achieved through a declaration like #ip 1, which would modify register 1 so that accesses to it let the program indirectly access the instruction pointer itself. 
    To compensate for this kind of binding, there are now six registers (numbered 0 through 5); the five not bound to the instruction pointer behave as normal. 
    Otherwise, the same rules apply as the last time you worked with this device.

    When the instruction pointer is bound to a register, its value is written to that register just before each instruction is executed, 
    and the value of that register is written back to the instruction pointer immediately after each instruction finishes execution. 
    Afterward, move to the next instruction by adding one to the instruction pointer, even if the value in the instruction pointer was just updated by an instruction. 
    (Because of this, instructions must effectively set the instruction pointer to the instruction before the one they want executed next.)

    The instruction pointer is 0 during the first instruction, 1 during the second, and so on.
    If the instruction pointer ever causes the device to attempt to load an instruction outside the instructions defined in the program,
    the program instead immediately halts.The instruction pointer starts at 0.


    It turns out that this new information is already proving useful: the CPU in the device is not very powerful,
    and a background process is occupying most of its time.You dump the background process' declarations and instructions to a file (your puzzle input),
    making sure to use the names of the opcodes rather than the numbers.

    For example, suppose you have the following program:

    #ip 0
    seti 5 0 1
    seti 6 0 2
    addi 0 1 0
    addr 1 2 3
    setr 1 0 0
    seti 8 0 4
    seti 9 0 5
    When executed, the following instructions are executed.Each line contains the value of the instruction pointer at the time the instruction started,
    the values of the six registers before executing the instructions (in square brackets), the instruction itself,
    and the values of the six registers after executing the instruction(also in square brackets).

    ip=0 [0, 0, 0, 0, 0, 0] seti 5 0 1 [0, 5, 0, 0, 0, 0]
    ip=1 [1, 5, 0, 0, 0, 0] seti 6 0 2 [1, 5, 6, 0, 0, 0]
    ip=2 [2, 5, 6, 0, 0, 0] addi 0 1 0 [3, 5, 6, 0, 0, 0]
    ip=4 [4, 5, 6, 0, 0, 0] setr 1 0 0 [5, 5, 6, 0, 0, 0]
    ip=6 [6, 5, 6, 0, 0, 0] seti 9 0 5 [6, 5, 6, 0, 0, 9]
    In detail, when running this program, the following events occur:

    The first line (#ip 0) indicates that the instruction pointer should be bound to register 0 in this program.
    This is not an instruction, and so the value of the instruction pointer does not change during the processing of this line.

    The instruction pointer contains 0, and so the first instruction is executed (seti 5 0 1). 
    It updates register 0 to the current instruction pointer value (0), sets register 1 to 5, sets the instruction pointer to the value of register 0 (which has no effect, as the instruction did not modify register 0), 
    and then adds one to the instruction pointer.
    The instruction pointer contains 1, and so the second instruction, seti 6 0 2, is executed.
    This is very similar to the instruction before it: 6 is stored in register 2, and the instruction pointer is left with the value 2.
    The instruction pointer is 2, which points at the instruction addi 0 1 0. This is like a relative jump: the value of the instruction pointer, 2, is loaded into register 0. 
    Then, addi finds the result of adding the value in register 0 and the value 1, storing the result, 3, back in register 0. Register 0 is then copied back to the instruction pointer,
    which will cause it to end up 1 larger than it would have otherwise and skip the next instruction (addr 1 2 3) entirely. Finally, 1 is added to the instruction pointer.
    The instruction pointer is 4, so the instruction setr 1 0 0 is run. This is like an absolute jump: it copies the value contained in register 1, 5, into register 0, which causes it to end up in the instruction pointer. 
    The instruction pointer is then incremented, leaving it at 6.
    The instruction pointer is 6, so the instruction seti 9 0 5 stores 9 into register 5.
    The instruction pointer is incremented, causing it to point outside the program, and so the program ends.
    What value is left in register 0 when the background process halts?

    The first half of this puzzle is complete! It provides one gold star: *

    --- Part Two ---
    A new background process immediately spins up in its place.
    It appears identical, but on closer inspection, you notice that this time, register 0 started with the value 1.

    What value is left in register 0 when this new background process halts?
    */

    public class Day19 : Day
    {
        public override string Title => "2018 - Day 19: Go With The Flow";
        public static InstructionPointer InstructionPointer;
        public static string Input = @"#ip 4
addi 4 16 4
seti 1 5 1
seti 1 2 2
mulr 1 2 3
eqrr 3 5 3
addr 3 4 4
addi 4 1 4
addr 1 0 0
addi 2 1 2
gtrr 2 5 3
addr 4 3 4
seti 2 7 4
addi 1 1 1
gtrr 1 5 3
addr 3 4 4
seti 1 9 4
mulr 4 4 4
addi 5 2 5
mulr 5 5 5
mulr 4 5 5
muli 5 11 5
addi 3 1 3
mulr 3 4 3
addi 3 18 3
addr 5 3 5
addr 4 0 4
seti 0 3 4
setr 4 2 3
mulr 3 4 3
addr 4 3 3
mulr 4 3 3
muli 3 14 3
mulr 3 4 3
addr 5 3 5
seti 0 4 0
seti 0 5 4";

        public override void PartOne()
        {
            base.PartOne();
            var opCode = new BigRegisterOpCodeHandler();
            var instructions = new List<InstructionWithIdentifier>();
            CreateInstructions(instructions);

            var register = new BigRegister();
            InstructionPointer.Value = register[InstructionPointer.PointsToRegister];

            while (true)
            {
                var instr = instructions.ElementAtOrDefault(InstructionPointer.Value);
                if (instr == null)
                {
                    break;
                }

                register = opCode.OpCodes[instr.OpCode](register, instr);
            }

            Console.WriteLine(register.A); // 2072
        }

        public override void PartTwo()
        {
            // UNSOLVED
            base.PartTwo();
            var opCode = new BigRegisterOpCodeHandler();
            var instructions = new List<InstructionWithIdentifier>();
            CreateInstructions(instructions);

            var register = new BigRegister();
            InstructionPointer.Value = register[InstructionPointer.PointsToRegister];
            register.A = 1;

            while (true) //  < "infinite loop"
            {
                var instr = instructions.ElementAtOrDefault(InstructionPointer.Value);
                if (instr == null)
                {
                    break;
                }

                register = opCode.OpCodes[instr.OpCode](register, instr);
            }

            Console.WriteLine(register.A);
        }

        private static void CreateInstructions(List<InstructionWithIdentifier> instructions)
        {
            var index = 0;
            foreach (var line in Input.ToStringList())
            {
                if (line.StartsWith("#ip"))
                {
                    InstructionPointer = new InstructionPointer { PointsToRegister = Convert.ToInt32(line.Replace("#ip ", "")) };
                    continue;
                }

                var splitInstr = line.Split();
                var instruction = new InstructionWithIdentifier { Index = index, OpCode = splitInstr[0], A = Convert.ToInt32(splitInstr[1]), B = Convert.ToInt32(splitInstr[2]), Output = Convert.ToInt32(splitInstr[3]) };

                instructions.Add(instruction);
                index++;
            }
        }
    }

    public class InstructionPointer
    {
        public int PointsToRegister;
        public int Value;
    }

    public class InstructionWithIdentifier
    {
        public int Index;
        public string OpCode;
        public int A;
        public int B;
        public int Output;
    }

    public class BigRegister
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

    public static class BigRegisterExt
    {
        public static BigRegister Copy(this BigRegister registers)
        {
            return new BigRegister
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

    public class BigRegisterOpCodeHandler
    {
        public readonly Dictionary<string, Func<BigRegister, InstructionWithIdentifier, BigRegister>> OpCodes = new Dictionary<string, Func<BigRegister, InstructionWithIdentifier, BigRegister>>();

        public BigRegisterOpCodeHandler()
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
        public BigRegister Addr(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a + b;

            result[instruction.Output] = output;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //addi (add immediate) stores into register C the result of adding register A and value B.
        public BigRegister Addi(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a + b;

            result[instruction.Output] = output;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Multiplication:
        //mulr(multiply register) stores into register C the result of multiplying register A and register B.
        public BigRegister Mulr(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a * b;

            result[instruction.Output] = output;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //muli (multiply immediate) stores into register C the result of multiplying register A and value B.
        public BigRegister Muli(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a * b;

            result[instruction.Output] = output;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Bitwise AND:
        //banr(bitwise AND register) stores into register C the result of the bitwise AND of register A and register B.
        public BigRegister Banr(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a & b;

            result[instruction.Output] = output;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //bani(bitwise AND immediate) stores into register C the result of the bitwise AND of register A and value B.
        public BigRegister Bani(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a & b;

            result[instruction.Output] = output;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Bitwise OR:
        //borr (bitwise OR register) stores into register C the result of the bitwise OR of register A and register B.
        public BigRegister Borr(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a | b;

            result[instruction.Output] = output;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //bori(bitwise OR immediate) stores into register C the result of the bitwise OR of register A and value B.
        public BigRegister Bori(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a | b;

            result[instruction.Output] = output;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Assignment:
        //setr (set register) copies the contents of register A into register C. (Input B is ignored.)
        public BigRegister Setr(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];

            result[instruction.Output] = a;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //seti(set immediate) stores value A into register C. (Input B is ignored.)
        public BigRegister Seti(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = instruction.A;

            result[instruction.Output] = a;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Greater-than testing:
        //gtir(greater-than immediate/register) sets register C to 1 if value A is greater than register B.Otherwise, register C is set to 0.
        public BigRegister Gtir(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = instruction.A;
            var b = before[instruction.B];
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //gtri (greater-than register/immediate) sets register C to 1 if register A is greater than value B.Otherwise, register C is set to 0.
        public BigRegister Gtri(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //gtrr (greater-than register/register) sets register C to 1 if register A is greater than register B.Otherwise, register C is set to 0.
        public BigRegister Gtrr(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a > b;

            result[instruction.Output] = output ? 1 : 0;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }

        //Equality testing:
        //eqir (equal immediate/register) sets register C to 1 if value A is equal to register B.Otherwise, register C is set to 0.
        public BigRegister Eqir(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = instruction.A;
            var b = before[instruction.B];
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //eqri (equal register/immediate) sets register C to 1 if register A is equal to value B.Otherwise, register C is set to 0.
        public BigRegister Eqri(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = instruction.B;
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
        //eqrr (equal register/register) sets register C to 1 if register A is equal to register B.Otherwise, register C is set to 0.
        public BigRegister Eqrr(BigRegister before, InstructionWithIdentifier instruction)
        {
            before[Day19.InstructionPointer.PointsToRegister] = Day19.InstructionPointer.Value;
            var result = before.Copy();
            var a = before[instruction.A];
            var b = before[instruction.B];
            var output = a == b;

            result[instruction.Output] = output ? 1 : 0;
            Day19.InstructionPointer.Value = result[Day19.InstructionPointer.PointsToRegister] + 1;
            return result;
        }
    }
}