﻿namespace AoC2017;
/*
 --- Day 13: Packet Scanners ---
You need to cross a vast firewall. The firewall consists of several layers, each with a security scanner that moves back and forth across the layer. 
To succeed, you must not be detected by a scanner.

By studying the firewall briefly, you are able to record (in your puzzle input) 
the depth of each layer and the range of the scanning area for the scanner within it, written as depth: range. Each layer has a thickness of exactly 1. 
A layer at depth 0 begins immediately inside the firewall; a layer at depth 1 would start immediately after that.

For example, suppose you've recorded the following:

0: 3
1: 2
4: 4
6: 4
This means that there is a layer immediately inside the firewall (with range 3), a second layer immediately after that (with range 2), 
a third layer which begins at depth 4 (with range 4), and a fourth layer which begins at depth 6 (also with range 4). Visually, it might look like this:

 0   1   2   3   4   5   6
[ ] [ ] ... ... [ ] ... [ ]
[ ] [ ]         [ ]     [ ]
[ ]             [ ]     [ ]
                [ ]     [ ]
Within each layer, a security scanner moves back and forth within its range. 
Each security scanner starts at the top and moves down until it reaches the bottom, then moves up until it reaches the top, and repeats. 
A security scanner takes one picosecond to move one step. Drawing scanners as S, the first few picoseconds look like this:

Picosecond 0:
 0   1   2   3   4   5   6
[S] [S] ... ... [S] ... [S]
[ ] [ ]         [ ]     [ ]
[ ]             [ ]     [ ]
                [ ]     [ ]

Picosecond 1:
 0   1   2   3   4   5   6
[ ] [ ] ... ... [ ] ... [ ]
[S] [S]         [S]     [S]
[ ]             [ ]     [ ]
                [ ]     [ ]

Picosecond 2:
 0   1   2   3   4   5   6
[ ] [S] ... ... [ ] ... [ ]
[ ] [ ]         [ ]     [ ]
[S]             [S]     [S]
                [ ]     [ ]

Picosecond 3:
 0   1   2   3   4   5   6
[ ] [ ] ... ... [ ] ... [ ]
[S] [S]         [ ]     [ ]
[ ]             [ ]     [ ]
                [S]     [S]
Your plan is to hitch a ride on a packet about to move through the firewall. 
The packet will travel along the top of each layer, and it moves at one layer per picosecond. 
Each picosecond, the packet moves one layer forward (its first move takes it into layer 0), and then the scanners move one step. 
If there is a scanner at the top of the layer as your packet enters it, you are caught. 
(If a scanner moves into the top of its layer while you are there, you are not caught: it doesn't have time to notice you before you leave.) 
If you were to do this in the configuration above, marking your current position with parentheses, your passage through the firewall would look like this:

...

In this situation, you are caught in layers 0 and 6, because your packet entered the layer when its scanner was at the top when you entered it. You are not caught in layer 1, since the scanner moved into the top of the layer once you were already there.

The severity of getting caught on a layer is equal to its depth multiplied by its range. (Ignore layers in which you do not get caught.) The severity of the whole trip is the sum of these values. In the example above, the trip severity is 0*3 + 6*4 = 24.

Given the details of the firewall you've recorded, if you leave immediately, what is the severity of your whole trip?

Your puzzle answer was 3184.

--- Part Two ---
Now, you need to pass through the firewall without being caught - easier said than done.

You can't control the speed of the packet, but you can delay it any number of picoseconds. 
For each picosecond you delay the packet before beginning your trip, all security scanners move one step. 
You're not in the firewall during this time; you don't enter layer 0 until you stop delaying the packet.

In the example above, if you delay 10 picoseconds (picoseconds 0 - 9), you won't get caught:

...

Because all smaller delays would get you caught, the fewest number of picoseconds you would need to delay to get through safely is 10.

What is the fewest number of picoseconds that you need to delay the packet to pass through the firewall without being caught?

Your puzzle answer was 3878062.
*/

public class Day13 : Day
{
    public override string Title => "--- Day 13: Packet Scanners ---";

    public override void PartOne()
    {
        base.PartOne();

        var input = @"0: 3
1: 2
4: 4
6: 4".ToStringList();

        var firewall = new List<Scanner>();
        var counter = 0;
        foreach (var line in Inputs.Day13.ToStringList())
        {
            var values = line.SplitAsIntsBy(':');
            firewall.Add(new Scanner(counter, values[0], values[1]));
            counter++;
        }

        var maxDepth = firewall.Max(m => m.Depth);
        var accumulatedSeverity = 0;

        for (var layer = 0; layer <= maxDepth; layer++)
        {
            var catchingScanner = firewall.FirstOrDefault(x => x.Depth == layer && x.IsOnTop);
            if (catchingScanner != null)
            {
                accumulatedSeverity += catchingScanner.Severity;
            }

            firewall.ForEach(s => s.MoveStep());
        }

        Console.WriteLine("Result part 1");
        Console.WriteLine(accumulatedSeverity);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = @"0: 3
1: 2
4: 4
6: 4".ToStringList();
        //populateFirewall
        var firewall = new List<Scanner>();
        var counter = 0;
        foreach (var line in Inputs.Day13.ToStringList())
        {
            var values = line.SplitAsIntsBy(':');
            firewall.Add(new Scanner(counter, values[0], values[1]));
            counter++;
        }

        //var maxDepth = firewall.Max(m => m.Depth);
        var resultDelay = 0;

        for (var picoSecondDelay = 1; picoSecondDelay < int.MaxValue; picoSecondDelay++)
        {
            //firewall.ForEach(s => s.Reset());
            //for (var steps = 0; steps < picoSecondDelay; steps++)
            //{
            //    firewall.ForEach(s => s.MoveStep());
            //}

            //var accumulatedSeverity = 0;
            var caught = false;

            foreach (var scanner in firewall)
            {
                if ((scanner.Depth + picoSecondDelay) % scanner.CaughtAt == 0)
                {
                    caught = true;
                    break;
                }
            }

            //for (var layer = 0; layer <= maxDepth; layer++)
            //{
            //    var catchingScanner = firewall.FirstOrDefault(x => x.Depth == layer && x.IsOnTop);
            //    if (catchingScanner != null)
            //    {
            //        caught = true;
            //        accumulatedSeverity += catchingScanner.Severity;
            //    }

            //    firewall.ForEach(s => s.MoveStep());
            //}

            if (caught == false)
            {
                resultDelay = picoSecondDelay;
                break;
            }
        }

        Console.WriteLine("Result part 2");
        Console.WriteLine(resultDelay);
    }
}

public class Scanner
{
    public int Id { get; }
    public int Depth { get; }
    public int Range { get; }
    public bool IsOnTop => CurrentRangeIndex == MinRange;
    public int Severity => Depth * Range;
    public int CaughtAt => MaxRange * 2;
    private int CurrentRangeIndex { get; set; } = 0;
    private Direction CurrentDirection { get; set; } = Direction.Down;

    private static int MinRange => 0;
    private int MaxRange => (Range - 1);

    public Scanner(int id, int depth, int range)
    {
        Id = id;
        Depth = depth;
        Range = range;
    }

    public void MoveStep()
    {
        if (CurrentDirection == Direction.Up && CurrentRangeIndex == MinRange)
        {
            CurrentDirection = Direction.Down;
        }

        if (CurrentDirection == Direction.Down && CurrentRangeIndex == MaxRange)
        {
            CurrentDirection = Direction.Up;
        }

        if (CurrentDirection == Direction.Down)
        {
            CurrentRangeIndex++;
        }
        else
        {
            CurrentRangeIndex--;
        }
    }

    public void Reset()
    {
        CurrentRangeIndex = MinRange;
        CurrentDirection = Direction.Down;
    }

    private enum Direction
    {
        Up,
        Down
    }
}