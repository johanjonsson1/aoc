using System;
using AoC_Common;

namespace AoC_2015
{
    /*
    / --- Day 1: Not Quite Lisp ---
    / Santa is trying to deliver presents in a large apartment building, but he can't find the right floor - the directions he got are a little confusing. 
    / He starts on the ground floor(floor 0) and then follows the instructions one character at a time.
    / An opening parenthesis, (, means he should go up one floor, and a closing parenthesis, ), means he should go down one floor.
    / 
    / --- Part Two ---
    / Now, given the same instructions, find the position of the first character that causes him to enter the basement(floor -1). 
    / The first character in the instructions has position 1, the second character has position 2, and so on.
    / For example:
    / ) causes him to enter the basement at character position 1.
    / ()()) causes him to enter the basement at character position 5.
    / What is the position of the character that causes Santa to first enter the basement?
    */

    public class Day1 : IDay
    {
        public string Title => "Day 1";

        public void Run()
        {
            PartOne();
            PartTwo();
        }

        private static void PartOne()
        {
            Console.WriteLine("--- Day 1: Not Quite Lisp ---");
            var floor = 0;

            foreach (var @char in Inputs.Day1)
            {
                if (@char == '(')
                {
                    floor++;
                    continue;
                }

                floor--;
            }

            Console.WriteLine($"At floor {floor}");
        }

        private void PartTwo()
        {
            Console.WriteLine("--- Part Two ---");
            var floor = 0;
            var index = 0;

            foreach (var @char in Inputs.Day1)
            {
                if (floor == -1)
                {
                    break;
                }

                index++;

                if (@char == '(')
                {
                    floor++;
                    continue;
                }

                floor--;
            }

            Console.WriteLine($"Index when first basement {index}");
        }
    }
}
