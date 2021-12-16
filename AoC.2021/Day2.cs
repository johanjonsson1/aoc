using System.Collections;

namespace AoC2021;

public class Day2 : Day
{
    public override string Title => "--- Day 2: Dive! ---";

    public override void PartOne()
    {
        base.PartOne();
        var inputs = Inputs.Day2.ToStringList();

        var horizontalPosition = 0;
        var depth = 0;
        foreach (var instruction in inputs)
        {
            var span = instruction.AsSpan();
            var index = span.LastIndexOf(' ');
            var value = int.Parse(span[index..]);

            switch (span[0])
            {
                case 'f':
                    horizontalPosition += value;
                    break;
                case 'u':
                    depth -= value;
                    break;
                case 'd':
                    depth += value;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        var result = horizontalPosition * depth;
        Console.WriteLine(result); // 1698735
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var inputs = Inputs.Day2.ToStringList();

        var horizontalPosition = 0;
        var depth = 0;
        var aim = 0;
        foreach (var instruction in inputs)
        {
            var span = instruction.AsSpan();
            var index = span.LastIndexOf(' ');
            var value = int.Parse(span[index..]);

            switch (span[0])
            {
                case 'f':
                    horizontalPosition += value;
                    depth += aim * value;
                    break;
                case 'u':
                    aim -= value;
                    break;
                case 'd':
                    aim += value;
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        var result = horizontalPosition * depth;
        Console.WriteLine(result); // 1594785890
    }
}