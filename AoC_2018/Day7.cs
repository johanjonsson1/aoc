using AoC_Common;

using System;

using System.Collections.Generic;

using System.Data.SqlTypes;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using static AoC_Common.SantaHelper;



namespace AoC_2018

{

    /*

  

     */

    public class Day7 : Day

    {

        public override string Title => "2018 - Day 7";



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



            //var input = Inputs.Day7.ToStringList();



            //var stepList = new List<Step>();

            //PopulateStepList(input, stepList);

            //var result = string.Empty;

            //var elfPool = new ElfPool();

            //Step lastStep = null;



            //var secondsPassed = 0;



            //while (true)

            //{

            //    var lockedLetters = stepList.SelectMany(s => s.LockedSteps).Distinct().ToList();

            //    var next = stepList.Where(s => s.Used == false && !lockedLetters.Contains(s.CurrentStep))

            //        .OrderBy(o => o.CurrentStep).FirstOrDefault();



            //    if (elfPool.Elves > 0)

            //    {

            //        if (next != null)

            //        {

            //            result += next.CurrentStep;

            //            next.UseStep();

            //            lastStep = next;

            //        }

            //        else

            //        {

            //            if (lastStep != null)

            //            {

            //                result += lastStep.UnlockedSteps.First();

            //            }



            //            break;

            //        }

            //    }

            //}



            //Console.WriteLine(result);

        }



        public override void PartTwo()
        {
            base.PartTwo();
            var input = "".ToStringList();//Inputs.Day7.ToStringList();

            //            var input = @"Step C must be finished before step A can begin.
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
                        secondsPassed += n.SecondsToComplete+1;
                    }
                    break;
                }

                
            }

            Console.WriteLine(result); //1014
            Console.WriteLine();
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
        private int elves = 5;
        public int Elves => elves;

        public void GetElf()
        {
            elves--;
        }

        public void ReleaseElf()
        {
            elves++;
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
        private StringBuilder res;

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
                res.Append(CurrentStep);
            }
        }

        public void UseStep(ElfPool elfPool, StringBuilder result)
        {
            _elfPool = elfPool;
            _elfPool.GetElf();
            Used = true;
            res = result;
            WithdrawSecond();
        }

        public void Add(string next)
        {
            LockedSteps.Add(next);
            LockedSteps = LockedSteps.OrderBy(o => o).Distinct().ToList();
        }
    }
}