using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;

namespace AoC2015
{
    /*
    --- Day 5: Doesn't He Have Intern-Elves For This? ---

    Santa needs help figuring out which strings in his text file are naughty or nice.

    A nice string is one with all of the following properties:

    It contains at least three vowels (aeiou only), like aei, xazegov, or aeiouaeiouaeiou.
    It contains at least one letter that appears twice in a row, like xx, abcdde (dd), or aabbccdd (aa, bb, cc, or dd).
    It does not contain the strings ab, cd, pq, or xy, even if they are part of one of the other requirements.
    For example:

    ugknbfddgicrmopn is nice because it has at least three vowels (u...i...o...), a double letter (...dd...), and none of the disallowed substrings.
    aaa is nice because it has at least three vowels and a double letter, even though the letters used by different rules overlap.
    jchzalrnumimnmhp is naughty because it has no double letter.
    haegwjzuvuyypxyu is naughty because it contains the string xy.
    dvszwmarrgswjxmb is naughty because it contains only one vowel.
    How many strings are nice?

    --- Part Two ---

    Realizing the error of his ways, Santa has switched to a better model of determining whether a string is naughty or nice. 
    None of the old rules apply, as they are all clearly ridiculous.

    Now, a nice string is one with all of the following properties:

    It contains a pair of any two letters that appears at least twice in the string without overlapping,
    like xyxy (xy) or aabcdefgaa (aa), but not like aaa (aa, but it overlaps).
    It contains at least one letter which repeats with exactly one letter between them, like xyx, abcdefeghi (efe), or even aaa.
    For example:

    qjhvhtzxzqqjkmpb is nice because is has a pair that appears twice (qj) 
    and a letter that repeats with exactly one letter between them (zxz).
    xxyxx is nice because it has a pair that appears twice and a letter that repeats with one between,
    even though the letters used by each rule overlap.
    uurcxstgmygtbstg is naughty because it has a pair (tg) but no repeat with a single letter between them.
    ieodomkazucvgmuy is naughty because it has a repeating letter with one between (odo), but no pair that appears twice.
    How many strings are nice under these new rules?
    */
    public class Day5 : IDay
    {
        public string Title => "Day5";

        public void Run()
        {
            PartOne();
        }

        private void PartOne()
        {
            var inputs = Inputs.Day5.Split('\n');
            var validator = new Validator();

            //var res = false;
            //res = validator.ValidatePartTwo("uurcxstgmygtbstg");
            //Console.WriteLine(res);
            //res = validator.ValidatePartTwo("uurcxstgygmtbsuu"); // uu uu gyg
            //Console.WriteLine(res);
            //res = validator.ValidatePartTwo("uuucxstgygmtbstg"); // gyg st st tg tg
            //Console.WriteLine(res);
            //res = validator.ValidatePartTwo("uurcxstgygmtbqtg"); // gyg tg tg 
            //Console.WriteLine(res);
            //res = validator.ValidatePartTwo("uurcxstgygmtbaaa"); // gyg
            //Console.WriteLine(res);

            foreach (var line in inputs)
            {
                validator.ValidatePartTwo(line.Trim(' ', '\r', '\t'));
            }

            Console.WriteLine($"Naughty: {validator.NaughtyCount}");
            Console.WriteLine($"Nice: {validator.NiceCount}");
        }
    }

    public class Validator
    {
        private static readonly List<string> Naughty = new List<string> { "ab", "cd", "pq", "xy" };
        public int NiceCount { get; private set; }
        public int NaughtyCount { get; private set; }

        public bool Validate(string input)
        {
            if (Naughty.Any(input.Contains))
            {
                NaughtyCount++;
                return false;
            }

            var result = false;
            var last = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                if (last == input[i])
                {
                    result = true;
                    break;
                }

                last = input[i];
            }

            if (!result)
            {
                NaughtyCount++;
                return result;
            }

            if (input.Where(x => x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u').ToList().Count >= 3)
            {
                NiceCount++;
                return true;
            }

            NaughtyCount++;
            return false;
        }

        public bool ValidatePartTwo(string input)
        {
            // check pairs
            var pairs = new List<string>();

            for (int i = 0; i < input.Length-1; i++)
            {
                pairs.Add(input.Substring(i, 2));
            }

            var distinctLeft = pairs.Distinct().ToList();

            if (pairs.Count == distinctLeft.Count)
            {
                NaughtyCount++;
                return false;
            }

            var numberofmatches = pairs.Count - distinctLeft.Count;

            for (int i = 0; i < pairs.Count; i++)
            {
                if (pairs[i].First() == pairs[i].Last() && i != pairs.Count-1)
                {
                    if (pairs[i].First() == pairs[i+1].Last())
                    {
                        numberofmatches--;
                    }
                }
            }

            if (numberofmatches == 0)
            {
                NaughtyCount++;
                return false;
            }

            // check letter between letters
            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length-2)
                {
                    break;
                }
                else if (input[i] == input[i+2])
                {
                    NiceCount++;
                    return true;
                }
            }

            NaughtyCount++;
            return false;
        }

        private void Reset()
        {
            NiceCount = 0;
            NaughtyCount = 0;
        }
    }
}
