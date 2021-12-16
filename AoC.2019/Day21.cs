namespace AoC2019;
/*
--- Day 21: Springdroid Adventure ---
You lift off from Pluto and start flying in the direction of Santa.

While experimenting further with the tractor beam, you accidentally pull an asteroid directly into your ship! It deals significant damage to your hull and causes your ship to begin tumbling violently.

You can send a droid out to investigate, but the tumbling is causing enough artificial gravity that one wrong step could send the droid through a hole in the hull and flying out into space.

The clear choice for this mission is a droid that can jump over the holes in the hull - a springdroid.

You can use an Intcode program (your puzzle input) running on an ASCII-capable computer to program the springdroid. However, springdroids don't run Intcode; instead, they run a simplified assembly language called springscript.

While a springdroid is certainly capable of navigating the artificial gravity and giant holes, it has one downside: it can only remember at most 15 springscript instructions.

The springdroid will move forward automatically, constantly thinking about whether to jump. The springscript program defines the logic for this decision.

Springscript programs only use Boolean values, not numbers or strings. Two registers are available: T, the temporary value register, and J, the jump register. If the jump register is true at the end of the springscript program, the springdroid will try to jump. Both of these registers start with the value false.

Springdroids have a sensor that can detect whether there is ground at various distances in the direction it is facing; these values are provided in read-only registers. Your springdroid can detect ground at four distances: one tile away (A), two tiles away (B), three tiles away (C), and four tiles away (D). If there is ground at the given distance, the register will be true; if there is a hole, the register will be false.

There are only three instructions available in springscript:

AND X Y sets Y to true if both X and Y are true; otherwise, it sets Y to false.
OR X Y sets Y to true if at least one of X or Y is true; otherwise, it sets Y to false.
NOT X Y sets Y to true if X is false; otherwise, it sets Y to false.
In all three instructions, the second argument (Y) needs to be a writable register (either T or J). The first argument (X) can be any register (including A, B, C, or D).

For example, the one-instruction program NOT A J means "if the tile immediately in front of me is not ground, jump".

Or, here is a program that jumps if a three-tile-wide hole (with ground on the other side of the hole) is detected:

NOT A J
NOT B T
AND T J
NOT C T
AND T J
AND D J
The Intcode program expects ASCII inputs and outputs. It will begin by displaying a prompt; then, input the desired instructions one per line. End each line with a newline (ASCII code 10). When you have finished entering your program, provide the command WALK followed by a newline to instruct the springdroid to begin surveying the hull.

If the springdroid falls into space, an ASCII rendering of the last moments of its life will be produced. In these, @ is the springdroid, # is hull, and . is empty space. For example, suppose you program the springdroid like this:

NOT D J
WALK
This one-instruction program sets J to true if and only if there is no ground four tiles away. In other words, it attempts to jump into any hole it finds:

.................
.................
@................
#####.###########

.................
.................
.@...............
#####.###########

.................
..@..............
.................
#####.###########

...@.............
.................
.................
#####.###########

.................
....@............
.................
#####.###########

.................
.................
.....@...........
#####.###########

.................
.................
.................
#####@###########
However, if the springdroid successfully makes it across, it will use an output instruction to indicate the amount of damage to the hull as a single giant integer outside the normal ASCII range.

Program the springdroid with logic that allows it to survey the hull without falling into space. What amount of hull damage does it report?

Your puzzle answer was 19350938.

--- Part Two ---
There are many areas the springdroid can't reach. You flip through the manual and discover a way to increase its sensor range.

Instead of ending your springcode program with WALK, use RUN. Doing this will enable extended sensor mode, capable of sensing ground up to nine tiles away. This data is available in five new read-only registers:

Register E indicates whether there is ground five tiles away.
Register F indicates whether there is ground six tiles away.
Register G indicates whether there is ground seven tiles away.
Register H indicates whether there is ground eight tiles away.
Register I indicates whether there is ground nine tiles away.
All other functions remain the same.

Successfully survey the rest of the hull by ending your program with RUN. What amount of hull damage does the springdroid now report?

Your puzzle answer was 1142986901.
*/

public class Day21 : Day
{
    public override string Title => "--- Day 21: Springdroid Adventure ---";

    public override void PartOne()
    {
        base.PartOne();
        var input = Inputs.Day21.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
        var droid = new SpringDroid(input);
        droid.ReceiveMovementRoutine(GetCommands(false));

        Console.WriteLine();
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var counter = 0;
        var cmds = GenerateLongCommands(150000);

        Parallel.ForEach(cmds, (c) =>
        {
            var input = Inputs.Day21.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            var droid = new SpringDroid(input);
            droid.ReceiveMovementRoutine(GetCommandFrom(c));

            if (droid.Found)
            {
                Console.WriteLine("FOUND!");
                Console.WriteLine(c);
            }

            Interlocked.Increment(ref counter);

            if (counter % 1000 == 0)
            {
                Console.Write('.');
            }
        });

        /*
         * ............1142986901
        NEW PATTERN after 706202 iterations
        tions:

        Running...


        FOUND!
        NOT A J
        NOT C T
        OR J T
        OR D J
        AND T J
        AND I T
        AND D T
        OR J J
        NOT B T
        OR T J
        AND H J
        OR E J
        AND D J
        RUN
         */


        //var patterns = new List<SpringDroid.Pattern>();

        //foreach (var c in cmds)
        //{
        //    var input = Inputs.Day21.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
        //    var droid = new SpringDroid(input);
        //    var res = droid.ReceiveMovementRoutine(GetCommandFrom(c));
        //    //Console.WriteLine(c);

        //    if (droid.Found)
        //    {
        //        //Console.WriteLine(c.Replace('\n','_'));
        //        //Console.WriteLine("FOUND!");
        //        res.Command = c;
        //        patterns.Add(res);
        //    }

        //    Interlocked.Increment(ref counter);

        //    if (counter % 10000 == 0)
        //    {
        //        Console.Write('.');
        //    }
        //}

        //var input = Inputs.Day21.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
        //var droid = new SpringDroid(input);
        //droid.ReceiveMovementRoutine(GetCommands(true));
        //var ordered = patterns.OrderByDescending(o => o.AfterIterations);
        Console.WriteLine();
    }

    private IEnumerable<int> GetCommandFrom(string command)
    {
        foreach (var c in command)
        {
            yield return c;
        }
    }

    private IEnumerable<int> GetCommands(bool run)
    {
        var command = JumpIfEmpty(1) + HoldIfEmpty(3) + Or('T', 'J') + And('D', 'J') + "WALK\n";
        //var commandRun = JumpIfEmpty(1) + HoldIfEmpty(3) + JumpIfEmpty(1) + HoldIfEmpty(4) + "RUN\n";
        //var commandRun = JumpIfEmpty(1) + HoldIfEmpty(3) + JumpIfEmpty(2) + "NOT E T\n" + Run();
        var commandRun = "NOT A J\nNOT C T\nOR J T\nOR D J\nAND T J\nAND I T\nAND D T\nOR J J\nAND E T\nRUN\n";
        //#####.###########_#####...#########_#####.##.########_?#####.#..########?#####.#.#.#...###?

        // bäst so far
        //            NOT A J
        //                NOT C T
        //            OR J T
        //                OR D J
        //            AND T J
        //                AND I T
        //            AND D T
        //                OR J J
        //            NOT B T
        //                OR T J
        //            AND D J
        //                NOT H T
        //            RUN
        //
        // NEW PATTERN after 220308 iterations
        //#####.#@#...#.###


        //                FOUND!
        //                NOT A J
        //            NOT C T
        //                OR J T
        //            OR D J
        //                AND T J
        //            AND I T
        //                AND D T
        //            OR J J
        //                NOT B T
        //            OR T J
        //                AND D J
        //            OR F T
        //                RUN

        if (run)
        {
            foreach (var c in commandRun)
            {
                yield return c;
            }
        }
        else
        {
            foreach (var c in command)
            {
                yield return c;
            }
        }
    }

    private static List<string> GenerateLongCommands(int number)
    {
        var commandLines = new HashSet<string>();
        var shortCommands = GenerateShortCommands();
        var random = new Random();

        while (commandLines.Count < number)
        {
            //var rnd1 = random.Next(0, notCommands.Count - 1);
            //var oneLine = notCommands[rnd1];
            //var oneLine = "NOT A J\nNOT C T\n";
            //            NOT A J
            //                NOT C T
            //            OR J T
            //                OR D J
            //            AND T J
            //                AND I T
            //            AND D T
            //                OR J J
            //            NOT B T
            //                OR T J
            //            AND D J
            var oneLine =
                "NOT A J\nNOT C T\nOR J T\nOR D J\nAND T J\nAND I T\nAND D T\nOR J J\nNOT B T\nOR T J\n"; //"AND D J\n";//"AND E T\n";
            for (var j = 0; j < 3; j++) // 7, 8, 9?
            {
                string srt;
                do
                {
                    var rnd = random.Next(0, shortCommands.Count - 1);
                    srt = shortCommands[rnd];
                } while (!srt.StartsWith("OR") && oneLine.Contains(srt));

                oneLine += srt;
            }

            oneLine += "RUN\n";
            commandLines.Add(oneLine);
        }

        return commandLines.ToList();
    }

    private static List<string> GenerateShortCommands()
    {
        var cmds = new List<string>();

        foreach (var cmdtype in new[] { "NOT,ABCDEFGHIJ,JT", "AND,ABCDEFGHIT,TJ", "OR,ABCDEFGHIJT,JT" })
        {
            var split = cmdtype.Split(',');
            var word = split[0];

            foreach (var first in split[1])
            {
                foreach (var second in split[2])
                {
                    var cmd = $"{word} {first} {second}\n";
                    cmds.Add(cmd);
                }
            }
        }

        return cmds;
    }

    private static string Run()
    {
        return "RUN\n";
    }

    private static string JumpIfEmpty(int n)
    {
        if (n == 1)
            return "NOT A J\n";
        if (n == 2)
            return "NOT B J\n";
        if (n == 3)
            return "NOT C J\n";
        if (n == 4)
            return "NOT D J\n";

        throw new ArgumentException();
    }

    private static string And(char x, char y)
    {
        return "AND " + x + " " + y + "\n";
    }

    private static string Or(char x, char y)
    {
        return "OR " + x + " " + y + "\n";
    }

    private static string HoldIfEmpty(int n)
    {
        if (n == 1)
            return "NOT A T\n";
        if (n == 2)
            return "NOT B T\n";
        if (n == 3)
            return "NOT C T\n";
        if (n == 4)
            return "NOT D T\n";

        throw new ArgumentException();
    }
}

public class SpringDroid
{
    public readonly IntCodeProgram IntCodeProgram;
    public bool Found;
    public string output = string.Empty;

    public SpringDroid(long[] memory)
    {
        IntCodeProgram = new IntCodeProgram(memory);
    }

    public Pattern ReceiveMovementRoutine(IEnumerable<int> routineAndFunctions)
    {
        foreach (var routineAndFunction in routineAndFunctions)
        {
            IntCodeProgram.AddInput(routineAndFunction);
        }

        while (!IntCodeProgram.IsTerminated)
        {
            IntCodeProgram.LoopUntilHalt(0);
            var locationState = IntCodeProgram.Output;

            if (locationState > 127)
            {
                Console.WriteLine(locationState);
                Found = true;
                break;
            }

            var asChar = (char)locationState;
            //Console.Write(asChar);

            output += asChar;

            if (output.Length > 20)
            {
                output = output.Remove(0, 1);
            }

            if (asChar == '\n')
            {
                //Console.WriteLine();
                continue;
            }
        }

        var unchanged = output;
        output = output.Replace('@', '.');
        if (!KnownStates.Any(a => output.StartsWith(a)))
        {
            Found = true;
            Console.WriteLine("NEW PATTERN after " + IntCodeProgram.Iterations + " iterations");
            Console.WriteLine(unchanged);
            return new Pattern { AfterIterations = IntCodeProgram.Iterations, ReachedPattern = unchanged };
        }

        return null;
    }

    public class Pattern
    {
        public string ReachedPattern;
        public int AfterIterations;
        public string Command;
    }

    public static List<string> KnownStates = new List<string>
    {
        "#####.###########",
        "#####...#########",
        "#####.##.########",
        "#####.#..########",
        "#####.#.#.#...###",
        "#####..###.#..###",
        "#####..#.########",
        "#####..##.##.####",
        "#####...#..##.###",
        "#####.##.#.#..###",
        "#####..###..#.###",
        "#####.##..#..####",
        "#####..##..######",
        "#####...####..###",
        "#####.#.#...#.###"
    };
}