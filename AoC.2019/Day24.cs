using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day24 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            return;
            base.PartOne();
            var input = Inputs.Day24.ToStringList();
//            input = @"....#
//#..#.
//#..##
//..#..
//#....".ToStringList();

            var grid = new List<Bug>();
            var states = new List<long>();

            var state = CalculateBiodiversityRating(grid);

            for (int y = 0; y < input.Count; y++)
            {
                for (int x = 0; x < input[0].Length; x++)
                {
                    if (input[y][x] == '#')
                    {
                        grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = true});
                        continue;
                    }

                    grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = false });
                }
            }

            Print(grid);

            for (int minute = 0; minute < 1000; minute++)
            {
                grid.ForEach(g => g.Explore(grid));
                grid.ForEach(g => g.Act());

                var currentState = CalculateBiodiversityRating(grid);

                if (states.Contains(currentState))
                {
                    Console.WriteLine("Minute "+minute+", Found match " + currentState);
                    break;
                }

                states.Add(currentState);

                //Print(grid);
            }

            Console.WriteLine();
        }

        public long CalculateBiodiversityRating(List<Bug> bugs)
        {
            var sum = 0;
            var ratingEnumerator = GetPowersOfTwo().GetEnumerator();

            foreach (var bug in bugs)
            {
                ratingEnumerator.MoveNext();
                var currentRating = ratingEnumerator.Current;

                if (bug.IsAlive)
                {
                    sum += currentRating;
                }
            }

            return sum;
        }

        public IEnumerable<int> GetPowersOfTwo()
        {
            var start = 1;
            yield return start;

            while (true)
            {
                yield return start *= 2;
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day24.ToStringList();
            input = @"..#.#
.#.##
..?#.
...##
#.###".ToStringList();

            var masterGrid = new List<Bug>();

            for (int y = 0; y < input.Count; y++)
            {
                for (int x = 0; x < input[0].Length; x++)
                {
                    if (input[y][x] == '#')
                    {
                        masterGrid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = true });
                        continue;
                    }
                    else if (input[y][x] == '?')
                    {
                        masterGrid.Add(new Bug { Coordinate = new Coordinate(x, y), IsRecursionLevel = true });
                        continue;
                    }

                    masterGrid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = false });
                }
            }

            //Print(masterGrid);
            var master = new Bugs(masterGrid);
            master.Id = 0;
            var layersBelow = new List<Bugs>();
            var layersAbove = new List<Bugs>();

            //below hack
            var id = -1;
            for (int i = 0; i < 100; i++)
            {
                var currentLayer = new Bugs(Day24.CreateEmptyLayer());
                currentLayer.Id = id;
                Bugs layerAbove;
                if (i == 0)
                {
                    layerAbove = master;
                }
                else
                {
                    layerAbove = layersBelow[i - 1];
                }

                currentLayer.Above = layerAbove;
                layerAbove.Below = currentLayer;

                layersBelow.Add(currentLayer);
                id--;
            }

            //above hack
            id = 1;
            for (int i = 0; i < 100; i++)
            {
                var currentLayer = new Bugs(Day24.CreateEmptyLayer());
                currentLayer.Id = id;
                Bugs layerBelow;
                if (i == 0)
                {
                    layerBelow = master;
                }
                else
                {
                    layerBelow = layersAbove[i - 1];
                }

                currentLayer.Below = layerBelow;
                layerBelow.Above = currentLayer;

                layersAbove.Add(currentLayer);
                id++;
            }

            var all = new List<Bugs>();
            all.Add(master);
            all.AddRange(layersBelow);
            all.AddRange(layersAbove);

            for (int minute = 0; minute < 200; minute++)
            {
                all.ForEach(a => a.ExploreDeep());
                all.ForEach(a => a.ActDeep());

                var res = all.Sum(s => s.PresentBugs);
                Console.WriteLine(res);
                //Print(grid);
            }

            //Print(all.FirstOrDefault(x => x.Id == -101).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == -100).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == -4).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == -3).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == -2).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == -1).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == 0).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == 1).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == 2).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == 3).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == 4).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == 100).MyBugs);
            //Print(all.FirstOrDefault(x => x.Id == 101).MyBugs);
            //var res = all.Sum(s => s.PresentBugs);

            Console.WriteLine();
        }

        public static void Print(List<Bug> bugs)
        {
            var locations = bugs;
            var maxY = locations.Max(x => x.Coordinate.Y);
            var maxX = locations.Max(x => x.Coordinate.X);

            Console.WriteLine();
            for (var i = 0; i <= maxY; i++)
            {
                for (var j = 0; j <= maxX; j++)
                {
                    var bug = bugs.First(f => f.Coordinate.Y == i && f.Coordinate.X == j);

                    if (bug.IsAlive)
                    {
                        Console.Write('#');
                        continue;
                    }

                    Console.Write('.');
                }

                Console.WriteLine();
            }
        }

        public static List<Bug> CreateEmptyLayer()
        {
            var cheatInput = @".....
.....
..?..
.....
.....".ToStringList();

            var grid = new List<Bug>();

            for (int y = 0; y < cheatInput.Count; y++)
            {
                for (int x = 0; x < cheatInput[0].Length; x++)
                {
                    if (cheatInput[y][x] == '#')
                    {
                        grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = true });
                        continue;
                    } 
                    
                    if (cheatInput[y][x] == '?')
                    {
                        grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsRecursionLevel = true });
                        continue;
                    }

                    grid.Add(new Bug { Coordinate = new Coordinate(x, y), IsAlive = false });
                }
            }

            return grid;
        }
    }

    public class Bugs
    {
        public int Id;
        public List<Bug> MyBugs;
        public Bugs Above;
        public Bugs Below;

        public int PresentBugs => MyBugs.Count(b => b.IsAlive);

        public Bugs(List<Bug> bugs)
        {
            MyBugs = bugs;
        }

        public void ExploreDeep()
        {
            MyBugs.ForEach(g => g.ExploreDeep(MyBugs, Below?.MyBugs, Above?.MyBugs));
        }

        public void ActDeep()
        {
            MyBugs.ForEach(g => g.Act());
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }

    public class Bug
    {
        public Coordinate Coordinate;
        public bool IsAlive = false;
        public int CurrentAdjacent;
        public bool IsRecursionLevel = false;

        public void Explore(List<Bug> bugs)
        {
            CurrentAdjacent = bugs.Count(x => Coordinate.IsAdjacent(x.Coordinate) && x.IsAlive);
        }

        public void ExploreDeep(List<Bug> bugs, List<Bug> below, List<Bug> above)
        {
            if (IsRecursionLevel)
            {
                return;
            }

            var adjacent = bugs.Where(x => Coordinate.IsAdjacent(x.Coordinate)).ToList();
            var belowCount = CountBelow(below, adjacent);
            var aboveCount = CountAbove(above);

            CurrentAdjacent = adjacent.Count(x => x.IsAlive) + belowCount + aboveCount;
        }


        private int CountAbove(List<Bug> above)
        {
            if (above == null)
            {
                return 0;
            }

            int nextAdjacent = 0;

            // corners..
            if (Coordinate.X == 0 && Coordinate.Y == 0) // upper left
            {
                nextAdjacent = above.Count(x =>
                    ((x.Coordinate.X == 1 && x.Coordinate.Y == 2) ||
                     (x.Coordinate.X == 2 && x.Coordinate.Y == 1))
                    && x.IsAlive);
            }
            else if (Coordinate.X == 4 && Coordinate.Y == 0) // upper right
            {
                nextAdjacent = above.Count(x =>
                    ((x.Coordinate.X == 3 && x.Coordinate.Y == 2) ||
                     (x.Coordinate.X == 2 && x.Coordinate.Y == 1))
                    && x.IsAlive);
            }
            else if (Coordinate.X == 0 && Coordinate.Y == 4) // lower left
            {
                nextAdjacent = above.Count(x =>
                    ((x.Coordinate.X == 1 && x.Coordinate.Y == 2) ||
                     (x.Coordinate.X == 2 && x.Coordinate.Y == 3))
                    && x.IsAlive);
            }
            else if (Coordinate.X == 4 && Coordinate.Y == 4) // lower right
            {
                nextAdjacent = above.Count(x =>
                    ((x.Coordinate.X == 3 && x.Coordinate.Y == 2) ||
                     (x.Coordinate.X == 2 && x.Coordinate.Y == 3))
                    && x.IsAlive);
            }
            //others
            else if (Coordinate.X == 0)
            {
                nextAdjacent = above.Count(x => x.Coordinate.X == 1 && x.Coordinate.Y == 2 && x.IsAlive);
            }
            else if (Coordinate.X == 4)
            {
                nextAdjacent = above.Count(x => x.Coordinate.X == 3 && x.Coordinate.Y == 2 && x.IsAlive);
            }
            else if (Coordinate.Y == 0)
            {
                nextAdjacent = above.Count(x => x.Coordinate.X == 2 && x.Coordinate.Y == 1 && x.IsAlive);
            }
            else if (Coordinate.Y == 4)
            {
                nextAdjacent = above.Count(x => x.Coordinate.X == 2 && x.Coordinate.Y == 3 && x.IsAlive);
            }

            return nextAdjacent;
        }

        private int CountBelow(List<Bug> below, List<Bug> adjacent)
        {
            var recursionLevel = adjacent.FirstOrDefault(f => f.IsRecursionLevel);

            if (recursionLevel == null || below == null)
            {
                return 0;
            }

            int nextAdjacent = 0;

            if (recursionLevel.Coordinate.X > Coordinate.X)
            {
                nextAdjacent = below.Count(x => x.Coordinate.X == 0 && x.IsAlive);
            }
            else if (recursionLevel.Coordinate.X < Coordinate.X)
            {
                nextAdjacent = below.Count(x => x.Coordinate.X == 4 && x.IsAlive);
            }
            else if (recursionLevel.Coordinate.Y > Coordinate.Y)
            {
                nextAdjacent = below.Count(x => x.Coordinate.Y == 0 && x.IsAlive);
            }
            else if (recursionLevel.Coordinate.Y < Coordinate.Y)
            {
                nextAdjacent = below.Count(x => x.Coordinate.Y == 4 && x.IsAlive);
            }

            return nextAdjacent;
        }

        public void Act()
        {
            if (IsAlive == true && CurrentAdjacent != 1)
            {
                IsAlive = false;
            }
            else if (IsAlive == false && CurrentAdjacent == 1 || CurrentAdjacent == 2)
            {
                IsAlive = true;
            }
        }
    }
}