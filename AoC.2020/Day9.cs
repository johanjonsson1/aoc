namespace AoC2020;

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

        var input = Inputs.Day9.ToStringList().Select(s => long.Parse((string)s)).ToArray();
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

        for (var i = 0; i < input.Length; i++)
        {
            var sum = input[i];

            if (sum >= expected)
            {
                continue;
            }

            var currentList = new List<long>();
            currentList.Add(sum);

            for (var j = i + 1; j < input.Length; j++)
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