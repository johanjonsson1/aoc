using System.Diagnostics;

namespace AoC.Common;

public abstract class Day : IDay
{
    public virtual string Title => "No title";

    public virtual void Run()
    {
        var sw = Stopwatch.StartNew();
        PartOne();
        sw.Stop();
        Console.WriteLine($"Elapsed Part 1 {sw.Elapsed}");

        sw.Restart();
        PartTwo();
        sw.Stop();
        Console.WriteLine($"Elapsed Part 2 {sw.Elapsed}");
    }

    public virtual void PartOne()
    {
        Console.WriteLine($"--- Part 1 {Title}");
    }

    public virtual void PartTwo()
    {
        Console.WriteLine($"--- Part 2 {Title}");
    }
}