namespace AoC2018;
/*
--- Day 21: Chronal Conversion ---
You should have been watching where you were going, because as you wander the new North Pole base, you trip and fall into a very deep hole!

Just kidding. You're falling through time again.

If you keep up your current pace, you should have resolved all of the temporal anomalies by the next time the device activates. 
Since you have very little interest in browsing history in 500-year increments for the rest of your life, you need to find a way to get back to your present time.

After a little research, you discover two important facts about the behavior of the device:

First, you discover that the device is hard-wired to always send you back in time in 500-year increments. 
Changing this is probably not feasible.

Second, you discover the activation system (your puzzle input) for the time travel module. 
Currently, it appears to run forever without halting.

If you can cause the activation system to halt at a specific moment,
maybe you can make the device send you so far back in time that you cause an integer underflow in time itself and wrap around back to your current time!

The device executes the program as specified in manual section one and manual section two.

Your goal is to figure out how the program works and cause it to halt. 
You can only control register 0; every other register begins at 0 as usual.

Because time travel is a dangerous activity, 
the activation system begins with a few instructions which verify that bitwise AND (via bani) does a numeric operation and not an operation as if the inputs were interpreted as strings. 
If the test fails, it enters an infinite loop re-running the test instead of allowing the program to execute normally. 
If the test passes, the program continues, and assumes that all other bitwise operations (banr, bori, and borr) also interpret their inputs as numbers. 
(Clearly, the Elves who wrote this system were worried that someone might introduce a bug while trying to emulate this system with a scripting language.)

What is the lowest non-negative integer value for register 0 that causes the program to halt after executing the fewest instructions? 
(Executing the same instruction multiple times counts as multiple instructions executed.)
*/

public class Day21 : Day
{
    public override string Title => "2018 - Day 21: Chronal Conversion";
    public static InstructionPointer InstructionPointer;

    public override void PartOne()
    {
        base.PartOne();
        // UNSOLVED
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

        var opCode = new BigRegisterOpCodeHandler(); // TODO bool for logging
        var instructions = new List<InstructionWithIdentifier>();
        var index = 0;
        foreach (var line in input.ToStringList())
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

        var results = new List<Result>();

        for (int i = 7586220; i < int.MaxValue; i++)
        {
            var register = new BigRegister { A = i };
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

    public override void PartTwo()
    {
        base.PartTwo();
    }
}

public class Result
{
    public int Instructions;
    public int RegisterValue;
}