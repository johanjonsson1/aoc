namespace AoC2021;

public class Day1 : Day
{
    public override string Title => "--- Day 1: Sonar Sweep ---";

    public override void PartOne()
    {
        base.PartOne();
        var inputs = Inputs.Day1.SplitAsIntsBy(NewlineCarriageReturn);

        var increased = 0;
        for (var i = 1; i < inputs.Count; i++)
        {
            if (inputs[i] > inputs[i - 1])
            {
                increased++;
            }
        }

        Console.WriteLine(increased); // 1711
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var inputs = Inputs.Day1.SplitAsIntsBy(NewlineCarriageReturn);

        var increased = 0;
        for (var i = 3; i < inputs.Count; i++)
        {
            var previousSum = inputs[i - 1] + inputs[i - 2] + inputs[i - 3];
            var currentSum = inputs[i] + inputs[i - 1] + inputs[i - 2];
            if (currentSum > previousSum)
            {
                increased++;
            }
        }

        Console.WriteLine(increased); // 1743
    }
}