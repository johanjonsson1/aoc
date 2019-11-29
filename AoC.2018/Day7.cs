using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AoC.Common;

namespace AoC2018
{
    /*
    --- Day 7: The Sum of Its Parts ---
    You find yourself standing on a snow-covered coastline; apparently, you landed a little off course. 
    The region is too hilly to see the North Pole from here, but you do spot some Elves that seem to be trying to unpack something that washed ashore. 
    It's quite cold out, so you decide to risk creating a paradox by asking them for directions.

    "Oh, are you the search party?" Somehow, you can understand whatever Elves from the year 1018 speak; you assume it's Ancient Nordic Elvish. 
    Could the device on your wrist also be a translator? "Those clothes don't look very warm; take this." They hand you a heavy coat.

    "We do need to find our way back to the North Pole, but we have higher priorities at the moment. 
    You see, believe it or not, this box contains something that will solve all of Santa's transportation problems - at least, that's what it looks like from the pictures in the instructions."
    It doesn't seem like they can read whatever language it's in, but you can: "Sleigh kit. Some assembly required."

    "'Sleigh'? What a wonderful name! You must help us assemble this 'sleigh' at once!" They start excitedly pulling more parts out of the box.

    The instructions specify a series of steps and requirements about which steps must be finished before others can begin (your puzzle input). 
    Each step is designated by a single letter. For example, suppose you have the following instructions:

    Step C must be finished before step A can begin.
    Step C must be finished before step F can begin.
    Step A must be finished before step B can begin.
    Step A must be finished before step D can begin.
    Step B must be finished before step E can begin.
    Step D must be finished before step E can begin.
    Step F must be finished before step E can begin.
    Visually, these requirements look like this:

      -->A--->B--
     /    \      \
    C      -->D----->E
     \           /
      ---->F-----
    Your first goal is to determine the order in which the steps should be completed. If more than one step is ready, choose the step which is first alphabetically. 
    In this example, the steps would be completed as follows:

    Only C is available, and so it is done first.
    Next, both A and F are available. A is first alphabetically, so it is done next.
    Then, even though F was available earlier, steps B and D are now also available, and B is the first alphabetically of the three.
    After that, only D and F are available. E is not available because only some of its prerequisites are complete. Therefore, D is completed next.
    F is the only choice, so it is done next.
    Finally, E is completed.
    So, in this example, the correct order is CABDFE.

    In what order should the steps in your instructions be completed?

    --- Part Two ---
    As you're about to begin construction, four of the Elves offer to help. 
    "The sun will set soon; it'll go faster if we work together." 
    Now, you need to account for multiple people working on steps simultaneously. 
    If multiple steps are available, workers should still begin them in alphabetical order.

    Each step takes 60 seconds plus an amount corresponding to its letter: A=1, B=2, C=3, and so on. 
    So, step A takes 60+1=61 seconds, while step Z takes 60+26=86 seconds. No time is required between steps.

    To simplify things for the example, however, suppose you only have help from one Elf (a total of two workers) and that each step takes 60 fewer seconds (so that step A takes 1 second and step Z takes 26 seconds). 
    Then, using the same instructions as above, this is how each second would be spent:

    Second   Worker 1   Worker 2   Done
       0        C          .        
       1        C          .        
       2        C          .        
       3        A          F       C
       4        B          F       CA
       5        B          F       CA
       6        D          F       CAB
       7        D          F       CAB
       8        D          F       CAB
       9        D          .       CABF
      10        E          .       CABFD
      11        E          .       CABFD
      12        E          .       CABFD
      13        E          .       CABFD
      14        E          .       CABFD
      15        .          .       CABFDE
    Each row represents one second of time. The Second column identifies how many seconds have passed as of the beginning of that second. 
    Each worker column shows the step that worker is currently doing (or . if they are idle). The Done column shows completed steps.

    Note that the order of the steps has changed; this is because steps now take time to finish and multiple workers can begin multiple steps simultaneously.

    In this example, it would take 15 seconds for two workers to complete these steps.

    With 5 workers and the 60+ second step durations described above, how long will it take to complete all of the steps?
     */

    public class Day7 : Day
    {
        public override string Title => "2018 - Day 7: The Sum of Its Parts";

        public override void PartOne()
        {
            base.PartOne();

            //var input = @"Step C must be finished before step A can begin.
            //Step C must be finished before step F can begin.
            //Step A must be finished before step B can begin.
            //Step A must be finished before step D can begin.
            //Step B must be finished before step E can begin.
            //Step D must be finished before step E can begin.
            //Step F must be finished before step E can begin.".ToStringList();

            var input = Inputs.Day7.ToStringList();
            var stepList = new List<Step>();
            PopulateStepList(input, stepList);
            var result = string.Empty;
            var elfPool = new ElfPool();
            Step lastStep = null;
            var secondsPassed = 0;

            while (true)
            {
                var lockedLetters = stepList.SelectMany(s => s.LockedSteps).Distinct().ToList();
                var next = stepList.Where(s => s.Used == false && !lockedLetters.Contains(s.CurrentStep))
                    .OrderBy(o => o.CurrentStep).FirstOrDefault();

                if (elfPool.Elves > 0)
                {
                    if (next != null)
                    {
                        result += next.CurrentStep;
                        next.UseStep();
                        lastStep = next;
                    }
                    else
                    {
                        if (lastStep != null)
                        {
                            result += lastStep.UnlockedSteps.First();
                        }
                        break;
                    }
                }
            }

            Console.WriteLine(result); // EUGJKYFQSCLTWXNIZMAPVORDBH
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day7.ToStringList();

            //var input = @"Step C must be finished before step A can begin.
            //Step C must be finished before step F can begin.
            //Step A must be finished before step B can begin.
            //Step A must be finished before step D can begin.
            //Step B must be finished before step E can begin.
            //Step D must be finished before step E can begin.
            //Step F must be finished before step E can begin.".ToStringList();

            var stepList = new List<Step>();
            PopulateStepList(input, stepList);
            var result = new StringBuilder();
            var elfPool = new ElfPool();
            Step lastStep = null;
            var secondsPassed = 0;
            var breakAll = false;

            while (breakAll == false)
            {
                var lockedLetters = stepList.SelectMany(s => s.LockedSteps).Distinct().ToList();
                var allUnlocked = stepList.Where(s => s.Used == false && !lockedLetters.Contains(s.CurrentStep))
                    .OrderBy(o => o.CurrentStep).ToList();

                secondsPassed++;

                stepList.ForEach(s =>
                {
                    if (s.Used)
                    {
                        s.WithdrawSecond();
                    }
                });

                foreach (var unlocked in allUnlocked)
                {
                    if (elfPool.Elves > 0)
                    {
                        unlocked.UseStep(elfPool, result);
                        lastStep = unlocked;
                    }
                }

                if (stepList.All(a => a.Used && a.SecondsToComplete == 0))
                {
                    if (lastStep != null)
                    {
                        var last = lastStep.UnlockedSteps.First();
                        result.Append(last);
                        var n = new Step(last, "");
                        secondsPassed += n.SecondsToComplete;
                    }
                    break;
                }

                
            }

            Console.WriteLine(result); //1014
            Console.WriteLine(secondsPassed);
        }


        private static void PopulateStepList(List<string> input, List<Step> stepList)
        {
            foreach (var item in input)
            {
                var split = item.Split();
                var letter = split[1];
                var next = split[7];
                var existing = stepList.FirstOrDefault(f => f.CurrentStep == letter);
                
                if (existing != null)
                {
                    existing.Add(next);
                }
                else
                {
                    var step = new Step(letter, next);
                    stepList.Add(step);
                }
            }
        }
    }

    public class ElfPool
    {
        private int _elves = 5;
        public int Elves => _elves;

        public void GetElf()
        {
            _elves--;
        }

        public void ReleaseElf()
        {
            _elves++;
        }
    }

    public class Step
    {
        public string CurrentStep;
        public List<string> LockedSteps = new List<string>();
        public List<string> UnlockedSteps = new List<string>();
        public bool Used = false;
        public int SecondsToComplete;
        private ElfPool _elfPool;
        private static readonly string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private StringBuilder _res;

        public Step(string current, string next)
        {
            CurrentStep = current;
            Add(next);
            SecondsToComplete = 60 + Letters.IndexOf(Convert.ToChar(current)) + 1;
        }
        
        public void WithdrawSecond()
        {
            if (SecondsToComplete > 1)
            {
                SecondsToComplete--;
            }
            else if (SecondsToComplete == 1)
            { 
                SecondsToComplete--;
                _elfPool.ReleaseElf();
                UnlockedSteps = new List<string>(LockedSteps);
                LockedSteps = new List<string>();
                _res.Append(CurrentStep);
            }
        }

        public void UseStep(ElfPool elfPool, StringBuilder result)
        {
            _elfPool = elfPool;
            _elfPool.GetElf();
            Used = true;
            _res = result;
            WithdrawSecond();
        }

        public void UseStep()
        {
            Used = true;
            UnlockedSteps = new List<string>(LockedSteps);
            LockedSteps = new List<string>();
        }

        public void Add(string next)
        {
            LockedSteps.Add(next);
            LockedSteps = LockedSteps.OrderBy(o => o).Distinct().ToList();
        }
    }
}