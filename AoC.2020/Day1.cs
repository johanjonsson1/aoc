using AoC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using static AoC.Common.SantaHelper;

namespace AoC2020
{
    public class Day9 : Day
    {
        public override string Title => "day 9";

        public override void PartOne()
        {
            base.PartOne();

            var input1 = @"35
20
15
25
47
40
62
55
65
95
102
117
150
182
127
219
299
277
309
576";

            var input = Inputs.Day9.ToStringList().Select(s => long.Parse(s)).ToArray();
            //var preamble = 25;
            //for (var i = preamble; i < input.Length; i++)
            //{
            //    Range rangeToCheck = (i - preamble)..i;
            //    var range = input[rangeToCheck];

            //    var currentNumber = input[i];

            //    var foundMatch = false;
            //    for (int j = 0; j < range.Length; j++)
            //    {
            //        var currentInRange = range[j];
            //        for (int k = 0; k < range.Length; k++)
            //        {
            //            var otherInRange = range[k];
            //            if (currentInRange == otherInRange)
            //            {
            //                continue;
            //            }

            //            if ((currentInRange + otherInRange) == currentNumber)
            //            {
            //                // valid
            //                foundMatch = true;
            //                Console.WriteLine($"{currentNumber} is valid ({currentInRange}+{otherInRange})");
            //            }
            //        }
            //    }

            //    if (!foundMatch)
            //    {
            //        Console.WriteLine(currentNumber + " is invalid");
            //        return;
            //    }
            //}


            // part2 
            long expected = 90433990;

            for (int i = 0; i < input.Length; i++)
            {
                var sum = input[i];

                if (sum >= expected)
                {
                    continue;
                }

                var currentList = new List<long>();
                currentList.Add(sum);

                for (int j = i+1; j < input.Length; j++)
                {
                    sum += input[j];
                    currentList.Add(input[j]);

                    if (sum > expected)
                    {
                        break;
                    }

                    if (sum == expected)
                    {
                        Console.WriteLine("Found");
                        var min = currentList.Min();
                        var max = currentList.Max();
                        var result = min + max;
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }

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

    public class Day7 : Day
    {
        public override string Title => "day 7";

        public override void PartOne()
        {
            base.PartOne();
            var input1 = @"light red bags contain 1 bright white bag, 2 muted yellow bags.
dark orange bags contain 3 bright white bags, 4 muted yellow bags.
bright white bags contain 1 shiny gold bag.
muted yellow bags contain 2 shiny gold bags, 9 faded blue bags.
shiny gold bags contain 1 dark olive bag, 2 vibrant plum bags.
dark olive bags contain 3 faded blue bags, 4 dotted black bags.
vibrant plum bags contain 5 faded blue bags, 6 dotted black bags.
faded blue bags contain no other bags.
dotted black bags contain no other bags.";

            var input = Inputs.Day7.ToStringList();

            var allBags = new List<ColoredBag>();

            foreach (var line in input)
            {
                var line2 = line.Replace("bags", "").Replace("bag", "").Replace(".", "").Trim();
                var split = line2.Split("contain", StringSplitOptions.RemoveEmptyEntries);
                allBags.Add(new ColoredBag(split[0], split[1]));
            }

            while (allBags.Any(b => !b.Fulfilled))
            {
                foreach (var coloredBag in allBags.Where(b => !b.Fulfilled))
                {
                    for (var i = coloredBag.Target.Count - 1; i >= 0; i--)
                    {
                        var (id, quantity) = coloredBag.Target[i];
                        var matchingFulfilledBag = allBags.FirstOrDefault(x => x.Id == id && x.Fulfilled);

                        if (matchingFulfilledBag == null)
                        {
                            continue;
                        }

                        coloredBag.Target.RemoveAt(i);
                        for (var q = 0; q < quantity; q++)
                        {
                            coloredBag.Bags.Add(matchingFulfilledBag);
                        }

                        if (matchingFulfilledBag.ContainsGold)
                        {
                            coloredBag.ContainsGold = true;
                        }
                    }
                }
            }

            var result = allBags.Where(b => b.ContainsGold).ToList();

            Console.WriteLine(result.Count);

            var result2 = allBags.Single(s => s.Id == "shiny gold");

            Console.WriteLine(result2.TotalBags);
        }

        public override void PartTwo()
        {
            base.PartTwo();
        }

        public class ColoredBag
        {
            public string Id;
            public string Color;
            public string ColorProperty;
            public bool ContainsGold { get; set; }
            public int TotalBags => Bags.Sum(x => x.TotalBags) + Bags.Count;

            public List<ColoredBag> Bags = new List<ColoredBag>();
            public List<(string id, int quantity)> Target = new List<(string id, int quantity)>();

            public bool Fulfilled => Target.Count == 0;

            public ColoredBag(string id, string containsBags)
            {
                Id = id.Trim();
                var strings = id.Split(' ');
                ColorProperty = strings[0];
                Color = strings.Length > 1 ? strings[1] : null;

                if (containsBags.Contains("no other"))
                {
                    return;
                }

                var bagsAndQuantity = containsBags.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach (var s in bagsAndQuantity)
                {
                    var quantity = int.Parse(s.RemoveNonNumeric());
                    var bagId = s.Remove0To9().Trim();

                    Target.Add((bagId, quantity));

                    if (bagId == "shiny gold")
                    {
                        ContainsGold = true;
                    }
                }
            }

            public override string ToString()
            {
                return $"{Id}, bags ({Bags.Count}), fulfilled {Fulfilled}";
            }
        }
    }

    public class Day1 : Day
    {
        public override string Title => "--- Day 1: Report Repair ---";

        public override void PartOne()
        {
            base.PartOne();

            var inputs = Inputs.Day1.SplitAsIntsBy(NewlineCarriageReturn);
            var result = GetFirst2020(inputs);

            Console.WriteLine(result);
        }

        private static int GetFirst2020(List<int> inputs)
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                var currentInput = inputs[i];
                for (var j = 0; j < inputs.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (currentInput + inputs[j] == 2020)
                    {
                        return currentInput * inputs[j];
                    }
                }
            }

            return 0;
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var inputs = Inputs.Day1.SplitAsIntsBy(NewlineCarriageReturn);
            var result = Get2020ByThree(inputs);

            Console.WriteLine(result);
        }

        private static int Get2020ByThree(List<int> inputs)
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                var currentInput1 = inputs[i];
                for (var j = 0; j < inputs.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    var currentInput2 = inputs[j];
                    for (var k = 0; k < inputs.Count; k++)
                    {
                        if (i == k || j == k)
                        {
                            continue;
                        }

                        if (currentInput1 + currentInput2 + inputs[k] == 2020)
                        {
                            return currentInput1 * currentInput2 * inputs[k];
                        }
                    }
                }
            }

            return 0;
        }
    }
}
