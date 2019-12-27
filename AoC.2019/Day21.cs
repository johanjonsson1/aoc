using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day21 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            return;
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

            /// 1142986901 !
            ///
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
            var command = JumpIfEmpty(1) + HoldIfEmpty(3) + Or('T', 'J') + And('D','J') + "WALK\n";
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
            var notCommands = shortCommands.Where(x => x.StartsWith("NOT")).ToList();
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
                var oneLine = "NOT A J\nNOT C T\nOR J T\nOR D J\nAND T J\nAND I T\nAND D T\nOR J J\nNOT B T\nOR T J\n";//"AND D J\n";//"AND E T\n";
                for (int j = 0; j < 3; j++) // 7, 8, 9?
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

            foreach (var cmdtype in new []{"NOT,ABCDEFGHIJ,JT","AND,ABCDEFGHIT,TJ","OR,ABCDEFGHIJT,JT"})
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

        /*
        Register E indicates whether there is ground five tiles away.
        Register F indicates whether there is ground six tiles away.
        Register G indicates whether there is ground seven tiles away.
        Register H indicates whether there is ground eight tiles away.
        Register I indicates whether there is ground nine tiles away.
         */

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

                char asChar = (char)locationState;
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
}