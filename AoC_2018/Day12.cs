using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /* 
    */

    public class Day12 : Day
    {
        public override string Title => "2018 - Day 12";

        public const string Patterns = @"##.## => .
#.#.. => .
..... => .
##..# => #
###.. => #
.##.# => .
..#.. => #
##.#. => #
.##.. => .
#..#. => .
###.# => #
.#### => #
.#.## => .
#.##. => #
.###. => #
##### => .
..##. => .
#.#.# => .
...#. => #
..### => .
.#.#. => #
.#... => #
##... => #
.#..# => #
#.### => #
#..## => #
....# => .
####. => .
#...# => #
#.... => .
...## => .
..#.# => #";

        public const string InitialState = "#.#####.#.#.####.####.#.#...#.......##..##.#.#.#.###..#.....#.####..#.#######.#....####.#....##....#";
        public static Dictionary<string, bool> PlantPatterns = new Dictionary<string, bool>();

        public override void PartOne()
        {
            base.PartOne();
            return;
            var patterns = Patterns.ToStringList();
            foreach (var pattern in patterns)
            {
                var split = pattern.SplitByAs<string>(s => s, '=', '>');
                PlantPatterns.Add(split[0], split[1] == "#");
            }

            var currentGeneration = new PlantGeneration();
            var counter = 0;           
            foreach (var p in InitialState)
            {
                if (p == '#')
                {
                    currentGeneration.AddPot(new Pot(counter, true, currentGeneration));
                }
                else
                {
                    currentGeneration.AddPot(new Pot(counter, false, currentGeneration));
                }

                counter++;
            }

            var sums = new List<int>();
            long last = 0;

            for (int gen = 0; gen < 1000; gen++)
            {
                var currentGenPots = currentGeneration.GetGeneration();
                //Console.WriteLine(currentGeneration.ToString());
                var nextGeneration = new PlantGeneration();

                foreach (var pot in currentGenPots)
                {
                    if (!pot.PatternMatchingPossible)
                    {
                        continue;
                    }

                    if (PlantPatterns.TryGetValue(pot.CenteredPattern, out var plant))
                    {
                        nextGeneration.AddPot(new Pot(pot.Position, plant, nextGeneration));
                    }
                    else
                    {
                        nextGeneration.AddPot(new Pot(pot.Position, false, nextGeneration));
                    }
                }
                               
                if (gen > 997)
                {
                    Console.WriteLine(currentGeneration.ToString());
                    //Console.WriteLine(currentGeneration.Pots.First().Position);
                    var current = currentGeneration.Pots.Where(x => x.HasPlant).Sum(s => Convert.ToInt64(s.Position));
                    Console.WriteLine(current - last);
                    last = current;
                    //sums.Add(currentGeneration.Pots.Where(x => x.HasPlant).Sum(s => s.Position));
                }

                //sums.Add(currentGeneration.Pots.Where(x => x.HasPlant).Sum(s => s.Position));

                currentGeneration = nextGeneration;
            }
            //sums.Add(currentGeneration.Pots.Where(x => x.HasPlant).Sum(s => s.Position));

            //Console.WriteLine(Convert.ToDecimal(sums[0]) / sums[49]);
            //Console.WriteLine(Convert.ToDecimal(sums[0]) / sums[499]);
            //Console.WriteLine(Convert.ToDecimal(sums[0]) / sums[4999]);
            Console.WriteLine(currentGeneration.ToString());
            var current2 = currentGeneration.Pots.Where(x => x.HasPlant).Sum(s => Convert.ToInt64(s.Position));
            Console.WriteLine(current2);
            Console.WriteLine(current2 - last);
            last = current2;
            //Console.WriteLine(currentGeneration.Pots.Where(x => x.HasPlant).Sum(s => Convert.ToInt64(s.Position))); // 57 - 43
        }

        public override void PartTwo()
        {
            base.PartTwo();

            var a = 59454 + (49999999000 * 57);

            Console.WriteLine(a);
        }       
    }

    public class PlantGeneration
    {
        private List<Pot> _pots = new List<Pot>();
        public List<Pot> Pots => _pots;
        public void AddPot(Pot pot)
        {
            _pots.Add(pot);
        }

        public List<Pot> GetGeneration()
        {
            _pots = _pots.OrderBy(o => o.Position).ToList();

            var stay = true;
            while (stay)
            {
                stay = false;

                if (!_pots[0].HasPlant)
                {
                    stay = true;
                    _pots.RemoveAt(0);
                }

                if (!_pots[_pots.Count-1].HasPlant)
                {
                    stay = true;
                    _pots.RemoveAt(_pots.Count - 1);
                }
            }

            var leftMost = _pots.First().Position;
            var rightMost = _pots.Last().Position;

            for (int i = 0; i < 4; i++)
            {
                leftMost--;
                rightMost++;
                _pots.Insert(0, new Pot(leftMost, false, this));
                _pots.Add(new Pot(rightMost, false, this));
            }

            _pots[0].PatternMatchingPossible = false;
            _pots[1].PatternMatchingPossible = false;
            _pots[_pots.Count-1].PatternMatchingPossible = false;
            _pots[_pots.Count-2].PatternMatchingPossible = false;

            return _pots;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var pot in _pots)
            {
                if (pot.HasPlant)
                {
                    sb.Append('#');
                }
                else
                {
                    sb.Append('.');
                }
            }
            
            return sb.ToString();
        }
    }

    public class Pot
    {
        public int Position;
        public bool HasPlant = false;
        private readonly PlantGeneration myGeneration;
        public bool PatternMatchingPossible = true;
        public string CenteredPattern => GetPattern();

        public Pot(int position, bool hasPlant, PlantGeneration myGeneration)
        {
            Position = position;
            HasPlant = hasPlant;
            this.myGeneration = myGeneration;
        }

        private string GetPattern()
        {
            var myIndex = myGeneration.Pots.IndexOf(this);
            var pattern = string.Empty;

            pattern += myGeneration.Pots[myIndex - 2].HasPlant == true ? "#" : ".";
            pattern += myGeneration.Pots[myIndex - 1].HasPlant == true ? "#" : ".";
            pattern += HasPlant == true ? "#" : ".";
            pattern += myGeneration.Pots[myIndex + 1].HasPlant == true ? "#" : ".";
            pattern += myGeneration.Pots[myIndex + 2].HasPlant == true ? "#" : ".";

            return pattern;
        }
    }
}