namespace AoC2017;

/*
--- Day 12: Digital Plumber ---
Walking along the memory banks of the stream, you find a small village that is experiencing a little confusion: some programs can't communicate with each other.

Programs in this village communicate using a fixed system of pipes. 
Messages are passed between programs using these pipes, but most programs aren't connected to each other directly.
Instead, programs pass messages between each other until the message reaches the intended recipient.

For some reason, though, some of these messages aren't ever reaching their intended recipient, and the programs suspect that some pipes are missing. 
They would like you to investigate.

You walk through the village and record the ID of each program and the IDs with which it can communicate directly (your puzzle input). 
Each program has one or more programs with which it can communicate, and these pipes are bidirectional; if 8 says it can communicate with 11, then 11 will say it can communicate with 8.

You need to figure out how many programs are in the group that contains program ID 0.

For example, suppose you go door-to-door like a travelling salesman and record the following list:

0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5
In this example, the following programs are in the group that contains program ID 0:

Program 0 by definition.
Program 2, directly connected to program 0.
Program 3 via program 2.
Program 4 via program 2.
Program 5 via programs 6, then 4, then 2.
Program 6 via programs 4, then 2.
Therefore, a total of 6 programs are in this group; all but program 1, which has a pipe that connects it to itself.

How many programs are in the group that contains program ID 0?

Your puzzle answer was 175.

--- Part Two ---
There are more programs than just the ones in the group containing program ID 0. 
The rest of them have no way of reaching that group, and still might have no way of reaching each other.

A group is a collection of programs that can all communicate via pipes either directly or indirectly. 
The programs you identified just a moment ago are all part of the same group. Now, they would like you to determine the total number of groups.

In the example above, there were 2 groups: one consisting of programs 0,2,3,4,5,6, and the other consisting solely of program 1.

How many groups are there in total?

Your puzzle answer was 213.
*/
public class Day12 : Day
{
    public override string Title => "2017 12";

    public override void PartOne()
    {
        base.PartOne();
        var input = @"0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5".ToStringList();

        var dict = new Dictionary<int, PipeProgram>();
        foreach (var line in Inputs.Day12.ToStringList())
        {
            var pid = int.Parse(line.Split().First());
            if (dict.TryGetValue(pid, out var pipeProgram))
            {
                pipeProgram.AddConnected(line);
            }
            else
            {
                var p = new PipeProgram(pid, line, dict);
            }
        }

        var all = dict.Values.ToList();

        var result = all.Where(x => x.IsConnected(0, new List<int>())).ToList();

        Console.WriteLine("Result part 1");
        Console.WriteLine(result.Count);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = @"0 <-> 2
1 <-> 1
2 <-> 0, 3, 4
3 <-> 2, 4
4 <-> 2, 3, 6
5 <-> 6
6 <-> 4, 5".ToStringList();

        var dict = new Dictionary<int, PipeProgram>();
        foreach (var line in Inputs.Day12.ToStringList())
        {
            var pid = int.Parse(line.Split().First());
            if (dict.TryGetValue(pid, out var pipeProgram))
            {
                pipeProgram.AddConnected(line);
            }
            else
            {
                var p = new PipeProgram(pid, line, dict);
            }
        }

        var all = dict.Values.ToList();
        var groupId = 0;
        foreach (var pipeProgram in all)
        {
            if (pipeProgram.GroupId != null)
            {
                continue;
            }

            pipeProgram.SetGroupId(groupId);
            groupId++;
        }

        var result = all.Select(s => s.GroupId).Distinct().Count();

        Console.WriteLine("Result part 2");
        Console.WriteLine(result);
    }
}

public class PipeProgram
{
    public int ProgramId { get; }
    public int? GroupId { get; set; }

    public List<PipeProgram> DirectlyConnected = new List<PipeProgram>();
    private readonly Dictionary<int, PipeProgram> _allPipePrograms;

    public PipeProgram(int id, Dictionary<int, PipeProgram> allPipePrograms)
    {
        ProgramId = id;
        _allPipePrograms = allPipePrograms;
        _allPipePrograms.Add(ProgramId, this);
    }

    public PipeProgram(int id, string input, Dictionary<int, PipeProgram> allPipePrograms)
    {
        _allPipePrograms = allPipePrograms;
        ProgramId = id;
        _allPipePrograms.Add(ProgramId, this);
        AddConnected(input);
    }

    public void AddConnected(string input)
    {
        var pids = input.Split('>').Last().SplitAsIntsBy(',');

        foreach (var pid in pids)
        {
            if (_allPipePrograms.TryGetValue(pid, out var pipeProgram))
            {
                DirectlyConnected.Add(pipeProgram);
            }
            else
            {
                var emptyProgram = new PipeProgram(pid, _allPipePrograms);
                DirectlyConnected.Add(emptyProgram);
            }
        }
    }

    public bool IsConnected(int pid, List<int> checkedPrograms)
    {
        if (pid == ProgramId)
        {
            return true;
        }

        checkedPrograms.Add(ProgramId);
        return DirectlyConnected.Any(a => a.ProgramId == pid) || DirectlyConnected.Any(a =>
            !checkedPrograms.Contains(a.ProgramId) && a.IsConnected(pid, checkedPrograms));
    }

    public void SetGroupId(int gid)
    {
        if (GroupId != null)
        {
            return;
        }

        GroupId = gid;

        DirectlyConnected.ForEach(x =>
        {
            if (x.ProgramId != ProgramId)
            {
                x.SetGroupId(gid);
            }
        });
    }
}