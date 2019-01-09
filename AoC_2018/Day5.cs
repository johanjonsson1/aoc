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
    public class Day5 : Day
    {
        public override string Title => "2018 - Day 5: Alchemical Reduction";

        public override void PartOne()
        {
            base.PartOne();

            var charArray = Inputs.Day5.ToList();

            var continueWhile = true;

            while (continueWhile)
            {
                continueWhile = false;
                for (int i = charArray.Count - 1; i >= 0; i--)
                {
                    if (i > 0)
                    {
                        if (Char.ToLower(charArray[i]) == Char.ToLower(charArray[i - 1]) &&
                            charArray[i] != charArray[i - 1])
                        {
                            continueWhile = true;
                            charArray.RemoveAt(i);
                            charArray.RemoveAt(i - 1);

                            i = i - 2;
                        }
                    }
                }
            }

            Console.WriteLine(charArray.Count); // 10638
        }

        public override void PartTwo()
        {
            base.PartTwo();

            var dict = new Dictionary<char, int>();

            foreach (var letter in "abcdefghijklmnopqrstuvwxyz")
            {
                var charArray = Inputs.Day5.ToList();//"dabAcCaCBAcCcaDA".ToList();

                var continueWhile = true;

                while (continueWhile)
                {
                    continueWhile = false;
                    for (int i = charArray.Count - 1; i >= 0; i--)
                    {
                            if (char.ToLower(charArray[i]) == letter)
                            {
                                continueWhile = true;
                                charArray.RemoveAt(i);                           
                            }
                    }
                }

                continueWhile = true;

                while (continueWhile)
                {
                    continueWhile = false;
                    for (int i = charArray.Count - 1; i >= 0; i--)
                    {
                        if (i > 0)
                        {
                            if (char.ToLower(charArray[i]) == char.ToLower(charArray[i-1]) &&
                                charArray[i] != charArray[i-1])
                            {
                                continueWhile = true;
                                charArray.RemoveAt(i);
                                charArray.RemoveAt(i-1);

                                i = i - 2;                            
                            }
                        }
                    }
                }

                dict.Add(letter, charArray.Count);
            }

            var orderedDict = dict.OrderBy(o => o.Value).ToList();
            Console.WriteLine(orderedDict.First().Key + " " + orderedDict.First().Value); // 4944
        }
    }
} 