﻿namespace AoC2019;
/*
--- Day 4: Secure Container ---
You arrive at the Venus fuel depot only to discover it's protected by a password. 
The Elves had written the password on a sticky note, but someone threw it out.

However, they do remember a few key facts about the password:

It is a six-digit number.
The value is within the range given in your puzzle input.
Two adjacent digits are the same (like 22 in 122345).
Going from left to right, the digits never decrease; they only ever increase or stay the same (like 111123 or 135679).
Other than the range rule, the following are true:

111111 meets these criteria (double 11, never decreases).
223450 does not meet these criteria (decreasing pair of digits 50).
123789 does not meet these criteria (no double).
How many different passwords within the range given in your puzzle input meet these criteria?

Your puzzle answer was 921.

--- Part Two ---
An Elf just remembered one more important detail: the two adjacent matching digits are not part of a larger group of matching digits.

Given this additional criterion, but still ignoring the range rule, the following are now true:

112233 meets these criteria because the digits never decrease and all repeated digits are exactly two digits long.
123444 no longer meets the criteria (the repeated 44 is part of a larger group of 444).
111122 meets the criteria (even though 1 is repeated more than twice, it still contains a double 22).
How many different passwords within the range given in your puzzle input meet all of the criteria?

Your puzzle answer was 603.
*/

public class Day4 : Day
{
    private static readonly string[] Trips = new[] { "111", "222", "333", "444", "555", "666", "777", "888", "999" };
    private static readonly string[] Dubs = new[] { "11", "22", "33", "44", "55", "66", "77", "88", "99" };

    public override string Title => "--- Day 4: Secure Container ---";

    public override void PartOne()
    {
        base.PartOne();
        var input = @"278384-824795".SplitAsIntsBy('-');
        var validInputs = new List<int>();

        for (var i = input[0]; i < input[1]; i++)
        {
            var inputAsString = i.ToString();
            if (IsIncreasing(inputAsString) && HasDouble(inputAsString))
            {
                validInputs.Add(i);
            }
        }

        Console.WriteLine(validInputs.Count);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = @"278384-824795".SplitAsIntsBy('-');
        var validInputs = new List<int>();

        for (var i = input[0]; i < input[1]; i++)
        {
            var inputAsString = i.ToString();
            if (IsIncreasing(inputAsString) && HasDoubleNotWithinLargerGroup(inputAsString))
            {
                validInputs.Add(i);
            }
        }

        Console.WriteLine(validInputs.Count);
    }

    private static bool IsIncreasing(string input)
    {
        var current = 0;
        var validInc = false;
        var valid = true;

        for (var j = 0; j < 6; j++)
        {
            var thisValue = (int)char.GetNumericValue(input[j]);
            if (j > 0 && thisValue >= current)
            {
                validInc = true;
            }
            else if (j > 0)
            {
                valid = false;
            }

            current = thisValue;
        }

        return valid && validInc;
    }

    private static bool HasDouble(string input)
    {
        return Dubs.Any(input.Contains);
    }

    private static bool HasDoubleNotWithinLargerGroup(string input)
    {
        var largerGroups = Trips.Where(input.Contains).ToList();
        var doubles = Dubs.Where(input.Contains).ToList();

        if (largerGroups.Count == 0 && doubles.Count > 0)
        {
            return true;
        }

        foreach (var d in doubles)
        {
            if (!largerGroups.Any(a => a.Contains(d)))
            {
                return true;
            }
        }

        return false;
    }
}