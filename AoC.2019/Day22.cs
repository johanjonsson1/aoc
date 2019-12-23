using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day22 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day22.ToStringList();
//            input = @"deal into new stack
//cut -2
//deal with increment 7
//cut 8
//cut -4
//deal with increment 7
//cut 3
//deal with increment 9
//deal with increment 3
//cut -1".ToStringList();
            var original = Enumerable.Range(0, 10007).ToList();
            //var n = DealWithIncrementN(original, 7);

            foreach (var instruction in input)
            {
                var split = instruction.Split();

                if (instruction.StartsWith("cut"))
                {
                    original = CutNCards(original, int.Parse(split.Last()));
                }
                else if (instruction.Contains("increment"))
                {
                    original = DealWithIncrementN(original, int.Parse(split.Last()));
                }
                else
                {
                    original = DealIntoNewStack(original);
                }
                
            }

            Console.WriteLine(original.IndexOf(2019));
        }

        public override void PartTwo()
        {
            base.PartTwo();
            //var input = Inputs.Day22.ToStringList();
            //var original = Enumerable.Range(0, 10007).ToList();
            ////var n = DealWithIncrementN(original, 7);

            //foreach (var instruction in input)
            //{
            //    var split = instruction.Split();

            //    if (instruction.StartsWith("cut"))
            //    {
            //        original = CutNCards(original, int.Parse(split.Last()));
            //    }
            //    else if (instruction.Contains("increment"))
            //    {
            //        original = DealWithIncrementN(original, int.Parse(split.Last()));
            //    }
            //    else
            //    {
            //        original = DealIntoNewStack(original);
            //    }

            //}

            //Console.WriteLine(original.IndexOf(2019));
            Console.WriteLine();
        }

        public static List<int> DealIntoNewStack(List<int> before)
        {
            var l = new List<int>(before);
            l.Reverse();
            return l;
        }

        public static List<int> CutNCards(List<int> before, int cut)
        {
            var slice = before.Count - Math.Abs(cut);
            var l = new List<int>();
            if (cut < 0)
            {
                var a = before.Take(slice);
                var b = before.Skip(slice);

                l.AddRange(b);
                l.AddRange(a);

                return l;
            }
            else
            {
                var a = before.Take(cut);
                var b = before.Skip(cut);

                l.AddRange(b);
                l.AddRange(a);

                return l;
            }
        }

        public static List<int> DealWithIncrementN(List<int> before, int incr)
        {
            var l = new CircularList<int>(new int[before.Count]);
            var idx = 0;
            l.Items[0] = before[0];

            for (var index = 1; index < before.Count; index++)
            {
                var i = before[index];
                idx = l.GetNext(idx, incr);
                l.Items[idx] = i;
            }

            return l.Items;
        }
    }
}