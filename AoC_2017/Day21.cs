using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC_2017
{
    /*
    --- Day 21: Fractal Art ---
    You find a program trying to generate some art. It uses a strange process that involves repeatedly enhancing the detail of an image through a set of rules.

    The image consists of a two-dimensional square grid of pixels that are either on (#) or off (.). The program always begins with this pattern:

    .#.
    ..#
    ###
    Because the pattern is both 3 pixels wide and 3 pixels tall, it is said to have a size of 3.

    Then, the program repeats the following process:

    If the size is evenly divisible by 2, break the pixels up into 2x2 squares, and convert each 2x2 square into a 3x3 square by following the corresponding enhancement rule.
    Otherwise, the size is evenly divisible by 3; break the pixels up into 3x3 squares, and convert each 3x3 square into a 4x4 square by following the corresponding enhancement rule.
    Because each square of pixels is replaced by a larger one, the image gains pixels and so its size increases.

    The artist's book of enhancement rules is nearby (your puzzle input); however, it seems to be missing rules. 
    The artist explains that sometimes, one must rotate or flip the input pattern to find a match. (Never rotate or flip the output pattern, though.) 
    Each pattern is written concisely: rows are listed as single units, ordered top-down, and separated by slashes. For example, the following rules correspond to the adjacent patterns:

    ../.#  =  ..
              .#

                    .#.
    .#./..#/###  =  ..#
                    ###

                            #..#
    #..#/..../#..#/.##.  =  ....
                            #..#
                            .##.
    When searching for a rule to use, rotate and flip the pattern as necessary. For example, all of the following patterns match the same rule:

    .#.   .#.   #..   ###
    ..#   #..   #.#   ..#
    ###   ###   ##.   .#.
    Suppose the book contained the following two rules:

    ../.# => ##./#../...
    .#./..#/### => #..#/..../..../#..#
    As before, the program begins with this pattern:

    .#.
    ..#
    ###
    The size of the grid (3) is not divisible by 2, but it is divisible by 3. It divides evenly into a single square; the square matches the second rule, which produces:

    #..#
    ....
    ....
    #..#
    The size of this enhanced grid (4) is evenly divisible by 2, so that rule is used. It divides evenly into four squares:

    #.|.#
    ..|..
    --+--
    ..|..
    #.|.#
    Each of these squares matches the same rule (../.# => ##./#../...), three of which require some flipping and rotation to line up with the rule. 
    The output for the rule is the same in all four cases:

    ##.|##.
    #..|#..
    ...|...
    ---+---
    ##.|##.
    #..|#..
    ...|...
    Finally, the squares are joined into a new grid:

    ##.##.
    #..#..
    ......
    ##.##.
    #..#..
    ......
    Thus, after 2 iterations, the grid contains 12 pixels that are on.

    How many pixels stay on after 5 iterations?

    Your puzzle answer was 117.

    --- Part Two ---
    How many pixels stay on after 18 iterations?

    Your puzzle answer was 2026963.
    */

    public class Day21 : Day
    {
        public override string Title => "--- Day 21: Fractal Art ---";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day21.ToStringList();

            var rules = new List<Rule>();
            for (var i = 0; i < input.Count; i++)
            {
                rules.Add(new Rule(i, input[i]));
            }

            var grids = new List<Grid>
            {
                new Grid(".#./..#/###")
            };

            for (var i = 0; i < 18; i++) // 5 or 18
            {
                Console.WriteLine($"Iteration {i + 1}");
                var tempGrids = new List<Grid>();

                foreach (var grid in grids)
                {
                    var currentTempGrids = grid.DivideIntoGrids();
                    var newGrids = currentTempGrids.Select(s => s.GetNewGridByPattern(rules)).ToList();

                    if (newGrids.Count == 1)
                    {
                        tempGrids.AddRange(newGrids);
                        continue;
                    }

                    var size = newGrids.First().Size;
                    var gridsPerSide = (int) Math.Sqrt((double) newGrids.Count);
                    var megaPattern = string.Empty;
                    var splits = newGrids.Select(s => s.ToString().Split('/')).ToList();

                    var limiter = 0;
                    var skip = 0;
                    while (limiter < gridsPerSide)
                    {
                        var currentGrids = splits.Skip(skip).Take(gridsPerSide).ToList();
                        for (var j = 0; j < size; j++)
                        {
                            foreach (var currentGrid in currentGrids)
                            {
                                megaPattern += currentGrid[j];
                            }

                            megaPattern += "/";
                        }

                        skip += gridsPerSide;
                        limiter++;
                    }

                    tempGrids.Add(new Grid(megaPattern.TrimEnd('/')));
                }

                grids = tempGrids;
            }

            Console.WriteLine($"Result = {grids.Sum(s => s.PixelsOn)}");
        }

        public override void PartTwo()
        {
            base.PartTwo();
            // See part 1
            Console.WriteLine();
        }
    }

    public class Grid
    {
        private readonly char[,] grid;
        public char[,] Values => grid;
        public int Size { get; }
        public int PixelsOn => this.ToString().Count(c => c == '#');

        public Grid(string pattern)
        {
            var rows = pattern.Split('/');
            grid = new char[rows.Length, rows.Length];

            for (var row = 0; row < rows.Length; row++)
            {
                for (var col = 0; col < rows.Length; col++)
                {
                    grid[row, col] = rows[row][col];
                }
            }

            Size = grid.GetUpperBound(0) + 1;
        }

        public override string ToString()
        {
            return Grid.ToPatternString(grid);
        }

        public List<Grid> DivideIntoGrids()
        {
            if (Size <= 3)
            {
                return new List<Grid> {this};
            }

            if (Size % 2 == 0)
            {
                return BreakInto2By2s();
            }

            return BreakInto3By3s();
        }

        private List<Grid> BreakInto2By2s()
        {
            var split = this.ToString().Split('/');

            var currentRow = 0;
            var currentCol = 0;

            var grids = new List<Grid>();

            while (currentRow < this.Size)
            {
                while (currentCol < this.Size)
                {
                    var pattern = "";
                    pattern += split[currentRow][currentCol];
                    pattern += split[currentRow][currentCol + 1];
                    pattern += "/";
                    pattern += split[currentRow + 1][currentCol];
                    pattern += split[currentRow + 1][currentCol + 1];
                    grids.Add(new Grid(pattern));
                    currentCol += 2;
                }

                currentCol = 0;
                currentRow += 2;
            }

            return grids;
        }

        private List<Grid> BreakInto3By3s()
        {
            var split = this.ToString().Split('/');

            var currentRow = 0;
            var currentCol = 0;

            var grids = new List<Grid>();

            while (currentRow < this.Size)
            {
                while (currentCol < this.Size)
                {
                    var pattern = "";
                    pattern += split[currentRow][currentCol];
                    pattern += split[currentRow][currentCol + 1];
                    pattern += split[currentRow][currentCol + 2];
                    pattern += "/";
                    pattern += split[currentRow + 1][currentCol];
                    pattern += split[currentRow + 1][currentCol + 1];
                    pattern += split[currentRow + 1][currentCol + 2];
                    pattern += "/";
                    pattern += split[currentRow + 2][currentCol];
                    pattern += split[currentRow + 2][currentCol + 1];
                    pattern += split[currentRow + 2][currentCol + 2];
                    grids.Add(new Grid(pattern));
                    currentCol += 3;
                }

                currentCol = 0;
                currentRow += 3;
            }

            return grids;
        }

        public Grid GetNewGridByPattern(List<Rule> rules)
        {
            foreach (var pattern in GetFlippedAndRotatedPatterns())
            {
                var matchingRule = rules.FirstOrDefault(x => x.InputPattern == pattern);

                if (matchingRule != null)
                {
                    return new Grid(matchingRule.OutputPattern);
                }
            }


            throw new Exception("FAIL, should not happen?");
        }

        private IEnumerable<string> GetFlippedAndRotatedPatterns()
        {
            var original = this.Values;
            yield return Grid.ToPatternString(original);
            var r1 = RotateOnce(original);
            yield return Grid.ToPatternString(r1);
            var r2 = RotateOnce(r1);
            yield return Grid.ToPatternString(r2);
            var r3 = RotateOnce(r2);
            yield return Grid.ToPatternString(r3);
            var swapped = FlipLeft(original);
            yield return Grid.ToPatternString(swapped);
            var r4 = RotateOnce(swapped);
            yield return Grid.ToPatternString(r4);
            var r5 = RotateOnce(r4);
            yield return Grid.ToPatternString(r5);
            var r6 = RotateOnce(r5);
            yield return Grid.ToPatternString(r6);
        }

        private char[,] FlipLeft(char[,] current)
        {
            var flipped = new char[this.Size, this.Size];

            for (var i = 0; i < this.Size; i++)
            {
                var x = 0;
                for (var j = this.Size - 1; j >= 0; j--, x++)
                {
                    flipped[i, x] = current[i, j];
                }
            }

            return flipped;
        }

        private char[,] RotateOnce(char[,] current)
        {
            var rotated = new char[this.Size, this.Size];

            for (var i = 0; i < this.Size; ++i)
            {
                for (var j = 0; j < this.Size; ++j)
                {
                    rotated[i, j] = current[this.Size - j - 1, i];
                }
            }

            return rotated;
        }

        public static string ToPatternString(char[,] gridValues)
        {
            var sb = new StringBuilder();

            for (var row = 0; row <= gridValues.GetUpperBound(0); row++)
            {
                if (row > 0)
                {
                    sb.Append('/');
                }

                for (var col = 0; col <= gridValues.GetUpperBound(1); col++)
                {
                    sb.Append(gridValues[row, col]);
                }
            }

            return sb.ToString();
        }

        public static string ToPrintableString(char[,] gridValues)
        {
            return Grid.ToPatternString(gridValues).Replace("/", Environment.NewLine);
        }
    }

    public class Rule
    {
        public readonly int Id;
        public readonly string InputPattern;
        public readonly string OutputPattern;

        public Rule(int id, string line)
        {
            Id = id;
            var split = line.Replace(" => ", ",").Split(',');
            InputPattern = split[0];
            OutputPattern = split[1];
        }
    }
}