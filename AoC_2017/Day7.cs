using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2017
{
    public class Day7 : IDay
    {
        public string Title => "2017 Day7";

        public void Run()
        {
            PartOne();
        }

        private void PartOne()
        {
            Console.WriteLine("");

            var test = @"pbga (66)
xhth (57)
ebii (61)
havc (66)
ktlj (57)
fwft (72) -> ktlj, cntj, xhth
qoyq (66)
padx (45) -> pbga, havc, qoyq
tknk (41) -> ugml, padx, fwft
jptl (61)
ugml (68) -> gyxo, ebii, jptl
gyxo (61)
cntj (57)";

            var input = Inputs.Day7.ToStringList();
            var allDiscPrograms = new List<DiscProgram>();

            foreach (var entry in input)
            {
                allDiscPrograms.Add(ParseIntoDiscProgram(entry));
            }

            SortAsTree(allDiscPrograms);
            var lastRemainging = allDiscPrograms.SingleOrDefault();

            var diff = 0;
            int[] oldWeights = new int[2];
            var currentFaulty = lastRemainging;
            for (int i = 0; i < lastRemainging.Levels; i++)
            {
                bool thisWeightFaulty;
                var weights = currentFaulty.SubDiscPrograms.Select(s => s.TotalWeight).Distinct().ToArray();
                currentFaulty = GetFaultyWeight(currentFaulty, out thisWeightFaulty);

                if (thisWeightFaulty)
                {
                    var otherValue = oldWeights.Where(x => x != currentFaulty.TotalWeight).First();
                    Console.WriteLine($"Other: {otherValue}, Wrong: {currentFaulty.TotalWeight}, This: {currentFaulty.Weight}");
                    diff = Math.Max(otherValue, currentFaulty.TotalWeight) - Math.Min(otherValue, currentFaulty.TotalWeight);
                    if (otherValue < currentFaulty.TotalWeight)
                    {
                        Console.WriteLine($"should be: {currentFaulty.Weight - diff}");
                    }
                    else
                    {
                        Console.WriteLine($"should be: {currentFaulty.Weight + diff}");
                    }

                    break;
                }

                oldWeights = weights;
            }

            Console.WriteLine($"Diff: {diff}");
            Console.WriteLine($"Id: {lastRemainging.Name}, Levels: {lastRemainging.Levels}");
        }

        private DiscProgram GetFaultyWeight(DiscProgram discProgram, out bool thisWeight)
        {
            var faultyValue = discProgram.SubDiscPrograms.GroupBy(g => g.TotalWeight);

            if (faultyValue.Count() == 1)
            {
                thisWeight = true;
                return discProgram;
            }

            thisWeight = false;
            
            return faultyValue.OrderBy(o => o.Count()).SelectMany(s => s).First();
        }

        private static void SortAsTree(List<DiscProgram> allDiscPrograms)
        {
            while (allDiscPrograms.Count > 1)
            {
                for (int i = allDiscPrograms.Count - 1; i >= 0; i--)
                {
                    var current = allDiscPrograms[i];
                    if (current.IsFilled)
                    {
                        DiscProgram matchingParent = null;
                        DiscProgram matchingDummy = null;

                        foreach (var item in allDiscPrograms)
                        {
                            var matchingSub = item.SubDiscPrograms.FirstOrDefault(x => x.Name == current.Name);
                            if (matchingSub != null)
                            {
                                matchingDummy = matchingSub;
                                matchingParent = item;
                                break;
                            }
                        }

                        if (matchingDummy == null)
                        {
                            break;
                        }

                        matchingParent.SubDiscPrograms.Add(current);
                        matchingParent.SubDiscPrograms.Remove(matchingDummy);
                        allDiscPrograms.Remove(current);
                    }
                }
            }
        }

        private DiscProgram ParseIntoDiscProgram(string input)
        {
            var strippedInput = input.RemoveSomeSpecialCharacters();
            string[] split;
            if (!input.Contains(">"))
            {
                split = strippedInput.Split(' ');
                return new DiscProgram(split[0]) { Weight = int.Parse(split[1]) };
            }

            split = strippedInput.Split('-');
            var partOne = split[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var partTwo = split[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var discName = partOne[0];
            var discWeight = int.Parse(partOne[1]);

            var superDiscProgram = new DiscProgram(discName);
            superDiscProgram.Weight = discWeight;

            foreach (var programName in partTwo)
            {
                superDiscProgram.SubDiscPrograms.Add(new DiscProgram(programName) { IsDummy = true });
            }

            return superDiscProgram;
        }
    }

    public class DiscProgram
    {
        public string Name { get; private set; }
        public int Weight { get; set; }
        public List<DiscProgram> SubDiscPrograms { get; set; } = new List<DiscProgram>();
        public bool IsDummy { get; set; } = false;

        public int TotalWeight
        {
            get { return this.Weight + SubDiscPrograms.Sum(x => x.TotalWeight); }
        }

        public bool EvenWeight
        {
            get { return SubDiscPrograms.All(x => x.TotalWeight == (SubDiscPrograms.FirstOrDefault()?.TotalWeight ?? 0)); }
        }

        public int Levels
        {
            get
            {
                return 1 + SubDiscPrograms.Max(i => (int?)i.Levels) ?? 0;
            }
        }

        public bool IsFilled
        {
            get
            {
                return !SubDiscPrograms.Any(s => s.IsDummy == true);
            }
        }

        public DiscProgram(string name)
        {
            Name = name;
        }
    }
}
