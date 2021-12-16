namespace AoC2020;

public class Day8 : Day
{
    public override string Title => "";

    public override void PartOne()
    {
        base.PartOne();

        var input1 = @"nop +0
acc +1
jmp +4
acc +3
jmp -3
acc -99
acc +1
jmp -4
acc +6";

        var input = Inputs.Day8.ToStringList().Select(s => new Instruction(s.Split(' ')[0], s.Split(' ')[1]));
        var circular = new CircularList<Instruction>(input);

        var accumulator = 0;

        var currentIndex = 0;
        while (true)
        {
            var currentInstruction = circular[currentIndex];
            if (currentInstruction.Visited > 0)
            {
                Console.WriteLine(accumulator);
                break;
            }

            currentInstruction.Visited++;

            if (currentInstruction.Operation == "nop")
            {
                currentIndex = circular.NextIndex(currentIndex);
            }
            else if (currentInstruction.Operation == "acc")
            {
                accumulator += currentInstruction.Argument;
                currentIndex = circular.NextIndex(currentIndex);
            }
            else if (currentInstruction.Operation == "jmp")
            {
                currentIndex = currentInstruction.Argument < 0
                    ? circular.GetPrevious(currentIndex, Math.Abs(currentInstruction.Argument))
                    : circular.GetNext(currentIndex, currentInstruction.Argument);
            }
        }
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input1 = @"nop +0
acc +1
jmp +4
acc +3
jmp -3
acc -99
acc +1
jmp -4
acc +6";

        var input = Inputs.Day8.ToStringList().Select(s => new Instruction(s.Split(' ')[0], s.Split(' ')[1])).ToList();
        var circular = new CircularList<Instruction>(input);

        for (var i = 0; i < input.Count; i++)
        {
            var changeInstruction = circular[i];

            if (changeInstruction.Operation == "nop")
            {
                changeInstruction.Operation = "jmp";
            }
            else if (changeInstruction.Operation == "jmp")
            {
                changeInstruction.Operation = "nop";
            }
            else
            {
                continue;
            }

            var accumulator = 0;
            var currentIndex = 0;

            while (true)
            {
                var currentInstruction = circular[currentIndex];
                if (currentIndex == input.Count - 1)
                {
                    if (currentInstruction.Operation == "acc")
                    {
                        accumulator += currentInstruction.Argument;
                    }

                    Console.WriteLine(accumulator);
                    return;
                }
                if (currentInstruction.Visited > 0)
                {
                    break;
                }

                currentInstruction.Visited++;

                if (currentInstruction.Operation == "nop")
                {
                    currentIndex = circular.NextIndex(currentIndex);
                }
                else if (currentInstruction.Operation == "acc")
                {
                    accumulator += currentInstruction.Argument;
                    currentIndex = circular.NextIndex(currentIndex);
                }
                else if (currentInstruction.Operation == "jmp")
                {
                    currentIndex = currentInstruction.Argument < 0
                        ? circular.GetPrevious(currentIndex, Math.Abs(currentInstruction.Argument))
                        : circular.GetNext(currentIndex, currentInstruction.Argument);
                }
            }

            // reset
            input.ForEach(x => x.Visited = 0);
            if (changeInstruction.Operation == "nop")
            {
                changeInstruction.Operation = "jmp";
            }
            else if (changeInstruction.Operation == "jmp")
            {
                changeInstruction.Operation = "nop";
            }
        }
    }

    public class Instruction
    {
        public string Operation;
        public int Argument;

        public int Visited { get; set; }

        public Instruction(string operation, string argument)
        {
            Operation = operation;
            Argument = int.Parse(argument);
        }

        public override string ToString()
        {
            return $"{Operation}, {Argument}, visited {Visited}";
        }
    }
}