namespace AoC2022;

public class Day7 : Day
{
    public override string Title => "--- Day 7: No Space Left On Device ---";

    public override void PartOne()
    {
        base.PartOne();
        var input = Input;

        Console.WriteLine(""); //
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Input;

        Console.WriteLine(""); //
    }

    private static string Input = @"";
}

file class Directory
{
    public string Id { get; set; }
    public List<Directory> SubDirectories { get; set; } = new();
    public List<File> Files { get; set; } = new();

    public int TotalSize => Files.Sum(s => s.Size) + SubDirectories.Sum(s => s.TotalSize);
}

file class File
{
    public string Id { get; set; }
    public int Size { get; set; }
}