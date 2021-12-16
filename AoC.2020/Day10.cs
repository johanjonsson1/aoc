namespace AoC2020;

public class Day10 : Day
{
    public override string Title => "day 10"; // TODO!

    public override void PartOne()
    {
        base.PartOne();
        var ordered = Inputs.Day10.ToStringList().Select(s => int.Parse((string)s)).OrderBy(o => o).ToList();
        var deviceAdapter = ordered.Last() + 3;
        ordered.Add(deviceAdapter);

        var ones = 0;
        var threes = 0;

        var last = ordered.Aggregate(0, (current, next) =>
        {
            var diff = next - current;
            switch (diff)
            {
                case 1:
                    ones++;
                    break;
                case 2:
                    break;
                case 3:
                    threes++;
                    break;
                default:
                    throw new ArgumentException(diff.ToString());
            }

            return next;
        });

        var result = ones * threes;
        Console.WriteLine(result);
    }

    public override void PartTwo()
    {
        base.PartTwo();

        var input1 = @"16
10
15
5
1
11
7
19
6
12
4";

        var ordered = input1.ToStringList().Select(s => int.Parse(s)).OrderBy(o => o).ToList();
        var deviceAdapter = ordered.Last() + 3;
        ordered.Add(deviceAdapter);
        var adapters = ordered.Prepend(0).ToArray();

        var waysToArrange = Enumerable.Repeat((long)0, adapters.Length).ToArray();
        waysToArrange[0] = 1;
        for (var i = 0; i < adapters.Length; i++)
        {
            var current = adapters[i];
            for (var j = i + 1; j < adapters.Length; j++)
            {
                if (adapters[j] - current > 3)
                {
                    break;
                }

                waysToArrange[j] += waysToArrange[i];
            }
        }

        Console.WriteLine(waysToArrange.Last());
    }
}