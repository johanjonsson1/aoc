namespace AoC2017;
/*
--- Day 18: Duet ---
You discover a tablet containing some strange assembly code labeled simply "Duet". 
Rather than bother the sound card with it, you decide to run the code yourself. 
Unfortunately, you don't see any documentation, so you're left to figure out what the instructions mean on your own.

It seems like the assembly is meant to operate on a set of registers that are each named with a single letter and that can each hold a single integer. 
You suppose each register should start with a value of 0.

There aren't that many instructions, so it shouldn't be hard to figure out what they do. Here's what you determine:

snd X plays a sound with a frequency equal to the value of X.
set X Y sets register X to the value of Y.
add X Y increases register X by the value of Y.
mul X Y sets register X to the result of multiplying the value contained in register X by the value of Y.
mod X Y sets register X to the remainder of dividing the value contained in register X by the value of Y (that is, it sets X to the result of X modulo Y).
rcv X recovers the frequency of the last sound played, but only when the value of X is not zero. (If it is zero, the command does nothing.)
jgz X Y jumps with an offset of the value of Y, but only if the value of X is greater than zero. 
(An offset of 2 skips the next instruction, an offset of -1 jumps to the previous instruction, and so on.)
Many of the instructions can take either a register (a single letter) or a number. The value of a register is the integer it contains; the value of a number is that number.

After each jump instruction, the program continues with the instruction to which the jump jumped. 
After any other instruction, the program continues with the next instruction. 
Continuing (or jumping) off either end of the program terminates it.

For example:

set a 1
add a 2
mul a a
mod a 5
snd a
set a 0
rcv a
jgz a -1
set a 1
jgz a -2
The first four instructions set a to 1, add 2 to it, square it, and then set it to itself modulo 5, resulting in a value of 4.
Then, a sound with frequency 4 (the value of a) is played.
After that, a is set to 0, causing the subsequent rcv and jgz instructions to both be skipped (rcv because a is 0, and jgz because a is not greater than 0).
Finally, a is set to 1, causing the next jgz instruction to activate, jumping back two instructions to another jump, 
which jumps again to the rcv, which ultimately triggers the recover operation.
At the time the recover operation is executed, the frequency of the last sound played is 4.

What is the value of the recovered frequency (the value of the most recently played sound) the first time a rcv instruction is executed with a non-zero value?

Your puzzle answer was 9423.

--- Part Two ---
As you congratulate yourself for a job well done, you notice that the documentation has been on the back of the tablet this entire time. 
While you actually got most of the instructions correct, there are a few key differences. 
This assembly code isn't about sound at all - it's meant to be run twice at the same time.

Each running copy of the program has its own set of registers and follows the code independently - in fact, the programs don't even necessarily run at the same speed. 
To coordinate, they use the send (snd) and receive (rcv) instructions:

snd X sends the value of X to the other program. These values wait in a queue until that program is ready to receive them. 
Each program has its own message queue, so a program can never receive a message it sent.
rcv X receives the next value and stores it in register X. If no values are in the queue, the program waits for a value to be sent to it. 
Programs do not continue to the next instruction until they have received a value. Values are received in the order they are sent.
Each program also has its own program ID (one 0 and the other 1); the register p should begin with this value.

For example:

snd 1
snd 2
snd p
rcv a
rcv b
rcv c
rcv d
Both programs begin by sending three values to the other. Program 0 sends 1, 2, 0; program 1 sends 1, 2, 1. 
Then, each program receives a value (both 1) and stores it in a, receives another value (both 2) and stores it in b, 
and then each receives the program ID of the other program (program 0 receives 1; program 1 receives 0) and stores it in c. 
Each program now sees a different value in its own copy of register c.

Finally, both programs try to rcv a fourth time, but no data is waiting for either of them, and they reach a deadlock. 
When this happens, both programs terminate.

It should be noted that it would be equally valid for the programs to run at different speeds; 
for example, program 0 might have sent all three values and then stopped at the first rcv before program 1 executed even its first instruction.

Once both of your programs have terminated (regardless of what caused them to do so), how many times did program 1 send a value?

Your puzzle answer was 7620.
*/

public class Day18 : Day
{
    public override string Title => "--- Day 18: Duet ---";

    public override void PartOne()
    {
        base.PartOne();
        //            var input = @"set a 1
        //add a 2
        //mul a a
        //mod a 5
        //snd a
        //set a 0
        //rcv a
        //jgz a -1
        //set a 1
        //jgz a -2".ToStringList();

        var input = Inputs.Day18.ToStringList();
        var dict = input.Select(s => s[4]).Where(x => char.IsLetter(x)).Distinct().ToDictionary(c => c, c => (long)0);
        var parser = new InstructionParser(dict);
        var currentIndex = 0;
        var counter = 0;
        while (currentIndex >= 0 && currentIndex < input.Count)
        {
            currentIndex = parser.PerformInstruction(currentIndex, input[currentIndex]);
            counter++;

            if (parser.RecoverValue != 0)
            {
                currentIndex = -1;
            }
        }

        Console.WriteLine("Result part 1");
        Console.WriteLine(parser.RecoverValue);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Inputs.Day18.ToStringList();
        var dict0 = input.Select(s => s[4]).Where(x => char.IsLetter(x)).Distinct().ToDictionary(c => c, c => (long)0);
        dict0['p'] = 0;
        var dict1 = input.Select(s => s[4]).Where(x => char.IsLetter(x)).Distinct().ToDictionary(c => c, c => (long)0);
        dict1['p'] = 1;
        var parser0 = new SendReceivingParser(dict0);
        var parser1 = new SendReceivingParser(dict1);
        parser0.AddFriend(parser1);
        parser1.AddFriend(parser0);

        var currentIndex0 = 0;
        var currentIndex1 = 0;

        while ((currentIndex0 >= 0 && currentIndex0 < input.Count) &&
               (currentIndex1 >= 0 && currentIndex1 < input.Count))
        {
            currentIndex0 = parser0.PerformInstruction(currentIndex0, input[currentIndex0]);
            currentIndex1 = parser1.PerformInstruction(currentIndex1, input[currentIndex1]);

            if (parser0.Locked && parser1.Locked)
            {
                break;
            }
        }

        Console.WriteLine("Result part 2");
        Console.WriteLine(parser1.SentMessages);
    }
}

public class SendReceivingParser : InstructionParser
{
    private SendReceivingParser _friendParser;
    private readonly Queue<long> _rcvQueue = new Queue<long>();
    private readonly long[] _sendArgs;
    public bool Locked { get; private set; }
    public int SentMessages { get; private set; }

    public SendReceivingParser(Dictionary<char, long> registers, params long[] sendArgs) : base(registers)
    {
        _sendArgs = sendArgs;
    }

    public SendReceivingParser AddFriend(SendReceivingParser friendParser)
    {
        _friendParser = friendParser;
        foreach (var i in _sendArgs)
        {
            _friendParser.Enqueue(i);
        }

        return this;
    }

    public void Enqueue(long value)
    {
        _rcvQueue.Enqueue(value);
    }

    protected override int Snd(int currentIndex, string instruction)
    {
        SentMessages++;
        var x = instruction.AsChar();
        LastPlayed = Registers[x];
        _friendParser.Enqueue(LastPlayed);

        return currentIndex + 1;
    }

    protected override int Rcv(int currentIndex, string instruction)
    {
        if (_rcvQueue.Count == 0)
        {
            Locked = true;
            return currentIndex;
        }

        Locked = false;
        var value = _rcvQueue.Dequeue();

        Registers[instruction.AsChar()] = value;

        return currentIndex + 1;
    }
}

public class InstructionParser
{
    protected Dictionary<char, long> Registers = new Dictionary<char, long>();
    protected readonly Dictionary<string, Func<int, string, int>> Operation =
        new Dictionary<string, Func<int, string, int>>();

    protected long LastPlayed;

    public long RecoverValue { get; private set; }

    public InstructionParser()
    {
        Operation.Add("snd", Snd);
        Operation.Add("set", Set);
        Operation.Add("add", Add);
        Operation.Add("mul", Mul);
        Operation.Add("mod", Mod);
        Operation.Add("rcv", Rcv);
        Operation.Add("jgz", Jgz);
    }

    public InstructionParser(Dictionary<char, long> registers) : this()
    {
        Registers = registers;
    }

    public int PerformInstruction(int currentIndex, string instruction)
    {
        return Operation[instruction.Substring(0, 3)]
            .Invoke(currentIndex, instruction.Substring(4, instruction.Length - 4));
    }

    protected virtual int Snd(int currentIndex, string instruction)
    {
        //snd X plays a sound with a frequency equal to the value of X.
        //_registersLastPlayed[instruction.AsChar()] = _registers[instruction.AsChar()];
        var x = instruction.AsChar();
        LastPlayed = Registers[x];

        return currentIndex + 1;
    }

    private int Set(int currentIndex, string instruction)
    {
        var split = instruction.Split();
        var x = split[0].AsChar();
        var y = split[1];
        //set X Y sets register X to the value of Y.
        if (int.TryParse(y, out var value))
        {
            Registers[x] = value;
        }
        else
        {
            Registers[x] = Registers[y.AsChar()];
        }

        return currentIndex + 1;
    }

    private int Add(int currentIndex, string instruction)
    {
        var split = instruction.Split();
        var x = split[0].AsChar();
        var y = split[1];
        //add X Y increases register X by the value of Y.
        if (long.TryParse(y, out var value))
        {
            Registers[x] += value;
        }
        else
        {
            Registers[x] += Registers[y.AsChar()];
        }

        return currentIndex + 1;
    }

    private int Mul(int currentIndex, string instruction)
    {
        var split = instruction.Split();
        var x = split[0].AsChar();
        var y = split[1];
        //mul X Y sets register X to the result of multiplying the value contained in register X by the value of Y.
        if (long.TryParse(y, out var value))
        {
            Registers[x] *= value;
        }
        else
        {
            Registers[x] *= Registers[y.AsChar()];
        }

        return currentIndex + 1;
    }

    private int Mod(int currentIndex, string instruction)
    {
        var split = instruction.Split();
        var x = split[0].AsChar();
        var y = split[1];
        //mod X Y sets register X to the remainder of dividing the value contained in register X by the value of Y (that is, it sets X to the result of X modulo Y).
        if (long.TryParse(y, out var value))
        {
            Registers[x] %= value;
        }
        else
        {
            Registers[x] %= Registers[y.AsChar()];
        }

        return currentIndex + 1;
    }

    protected virtual int Rcv(int currentIndex, string instruction)
    {
        //rcv X recovers the frequency of the last sound played, but only when the value of X is not zero. (If it is zero, the command does nothing.)

        if (Registers[instruction.AsChar()] != 0)
        {
            RecoverValue = LastPlayed;
        }

        return currentIndex + 1;
    }

    private int Jgz(int currentIndex, string instruction)
    {
        var split = instruction.Split();
        var x = split[0];
        var y = split[1];
        //jgz X Y jumps with an offset of the value of Y, but only if the value of X is greater than zero.
        //(An offset of 2 skips the next instruction, an offset of -1 jumps to the previous instruction, and so on.)
        long gtZero = 0;
        if (long.TryParse(x, out var value))
        {
            gtZero = value;
        }
        else
        {
            gtZero = Registers[x.AsChar()];
        }

        if (gtZero > 0)
        {
            if (int.TryParse(y, out var ind))
            {
                return currentIndex + ind;
            }
            else
            {
                //gtZero = _registers[x.AsChar()];
                return currentIndex + (int)Registers[x.AsChar()];
            }

            //return currentIndex + int.Parse(y);
        }

        return currentIndex + 1;
    }
}