﻿namespace AoC2017;
/*
--- Day 1: Inverse Captcha ---
You're standing in a room with "digitization quarantine" written in LEDs along one wall. 
The only door is locked, but it includes a small interface. "Restricted Area - Strictly No Digitized Users Allowed."

It goes on to explain that you may only leave by solving a captcha to prove you're not a human. 
Apparently, you only get one millisecond to solve the captcha: too fast for a normal human, but it feels like hours to you.

The captcha requires you to review a sequence of digits (your puzzle input) and find the sum of all digits that match the next digit in the list. 
The list is circular, so the digit after the last digit is the first digit in the list.

For example:

1122 produces a sum of 3 (1 + 2) because the first digit (1) matches the second digit and the third digit (2) matches the fourth digit.
1111 produces 4 because each digit (all 1) matches the next.
1234 produces 0 because no digit matches the next.
91212129 produces 9 because the only digit that matches the next one is the last digit, 9.
What is the solution to your captcha?

--- Part Two ---
You notice a progress bar that jumps to 50% completion. Apparently, the door isn't yet satisfied, but it did emit a star as encouragement. 
The instructions change:

Now, instead of considering the next digit, it wants you to consider the digit halfway around the circular list. 
That is, if your list contains 10 items, only include a digit in your sum if the digit 10/2 = 5 steps forward matches it. 
Fortunately, your list has an even number of elements.

For example:

1212 produces 6: the list contains 4 items, and all four digits match the digit 2 items ahead.
1221 produces 0, because every comparison is between a 1 and a 2.
123425 produces 4, because both 2s match each other, but no other digit has a match.
123123 produces 12.
12131415 produces 4.
*/

public class Day1 : IDay
{
    public string Title => "2017 - Day 1";

    public void Run()
    {
        PartOne();
        PartTwo();
    }

    private static void PartOne()
    {
        Console.WriteLine("--- Day 1: Inverse Captcha ---");

        var numbers = Inputs.Day1.ToInts();
        var fakeCircular = numbers.First();
        numbers.Add(fakeCircular);

        var resultSet = new List<int>();
        var matchCounter = 0;
        var last = 0;
        foreach (var item in numbers)
        {
            if (item == last)
            {
                matchCounter++;
            }
            else
            {
                if (matchCounter > 0)
                {
                    resultSet.Add((int)last * matchCounter);
                }

                matchCounter = 0;
            }

            last = item;
        }

        if (matchCounter > 0)
        {
            resultSet.Add((int)last * matchCounter);
        }

        Console.WriteLine(resultSet.Sum());
    }

    private void PartTwo()
    {
        Console.WriteLine("--- Part Two ---");
        var originalInput = Inputs.Day1;
        var numbers = originalInput.ToInts();
        var half = numbers.Count / 2;
        var fakeCircular = numbers.Take(half).ToList();
        numbers.AddRange(fakeCircular);

        var resultSet = new List<int>();
        for (var i = 0; i < originalInput.Length; i++)
        {
            var el = numbers.ElementAt(i);
            if (el == numbers.ElementAt(i + half))
            {
                resultSet.Add(el);
            }
        }

        Console.WriteLine(resultSet.Sum());
    }
}