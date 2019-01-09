﻿using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC_2017
{
    /*
    --- Day 2: Corruption Checksum ---

    As you walk through the door, a glowing humanoid shape yells in your direction. "You there! Your state appears to be idle. Come help us repair the corruption in this spreadsheet - if we take another millisecond, we'll have to display an hourglass cursor!"

    The spreadsheet consists of rows of apparently-random numbers. To make sure the recovery process is on the right track, they need you to calculate the spreadsheet's checksum. For each row, determine the difference between the largest value and the smallest value; the checksum is the sum of all of these differences.

    For example, given the following spreadsheet:

    5 1 9 5
    7 5 3
    2 4 6 8
    The first row's largest and smallest values are 9 and 1, and their difference is 8.
    The second row's largest and smallest values are 7 and 3, and their difference is 4.
    The third row's difference is 6.
    In this example, the spreadsheet's checksum would be 8 + 4 + 6 = 18.

    --- Part Two ---

    "Great work; looks like we're on the right track after all. Here's a star for your effort." 
    However, the program seems a little worried. Can programs be worried?

    "Based on what we're seeing, it looks like all the User wanted is some information about the evenly divisible values in the spreadsheet.
    Unfortunately, none of us are equipped for that kind of calculation - most of us specialize in bitwise operations."

    It sounds like the goal is to find the only two numbers in each row where one evenly divides the other
    - that is, where the result of the division operation is a whole number. 
    They would like you to find those numbers on each line, divide them, and add up each line's result.

    For example, given the following spreadsheet:

    5 9 2 8
    9 4 7 3
    3 8 6 5
    In the first row, the only two numbers that evenly divide are 8 and 2; the result of this division is 4.
    In the second row, the two numbers are 9 and 3; the result is 3.
    In the third row, the result is 2.
    In this example, the sum of the results would be 4 + 3 + 2 = 9.
     */

    public class Day2 : IDay
    {
        public string Title => "2017 - Day 2";

        public void Run()
        {
            //PartOne();
            PartTwo();
        }

        private static void PartOne()
        {
            Console.WriteLine("--- Day 2: Corruption Checksum ---");

            var split = Inputs.Day2.Split('\r', '\n').Where(x => x != "").ToList();
            var checksum = 0;

            foreach (var row in split)
            {
                checksum += new SpreadRow(row).Diff;
            }

            Console.WriteLine(checksum);
        }

        private void PartTwo()
        {
            Console.WriteLine("--- Part Two ---");

            var rows = Inputs.Day2.Split('\r', '\n').Where(x => x != "").ToList();
            var checksum = 0;

            foreach (var row in rows)
            {
                checksum += new SpreadRow(row).GetDivisionResult();
            }

            Console.WriteLine(checksum);
        }
    }

    public class SpreadRow
    {
        private readonly List<int> _numbers;

        public SpreadRow(string inputRow)
        {
            _numbers = inputRow.Split('\t').Select(s => int.Parse(s)).ToList();
        }

        public int Biggest => _numbers.Max();

        public int Smallest => _numbers.Min();

        public int Diff => Biggest - Smallest;

        public int GetDivisionResult()
        {
            var orderedNumbers = _numbers.OrderByDescending(n => n).ToList();
            var sum = 0;

            for (int i = 0; i < orderedNumbers.Count - 1; i++)
            {
                var currentIndex = i;

                for (int j = currentIndex; j < orderedNumbers.Count - 1; j++)
                {
                    int remainder = 0;
                    var result = Math.DivRem(orderedNumbers[currentIndex], orderedNumbers[j + 1], out remainder);

                    if (remainder == 0)
                    {
                        sum += result;
                    }
                }
            }

            return sum;
        }
    }
}