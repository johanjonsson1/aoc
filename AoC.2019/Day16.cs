using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day16 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var inputSignal = Inputs.Day16.ToInts();
            //inputSignal = @"80871224585914546619083218645595".ToInts();
            var basePattern = "0, 1, 0, -1".SplitAsIntsBy(',');

            var currentSignal = new List<int>(inputSignal);
            for (var phase = 0; phase < 100; phase++)
            {
                var newSignal = new List<int>();
                for (var position = 1; position < currentSignal.Count + 1; position++)
                {
                    var pattern = GetPattern(basePattern, position, currentSignal.Count);
                    var sum = 0;

                    for (var i = 0; i < currentSignal.Count; i++)
                    {
                        sum += currentSignal[i] * pattern[i];
                    }

                    newSignal.Add(Math.Abs(sum % 10));
                }

                currentSignal = newSignal;
            }

            var result = string.Join("", currentSignal.Take(8));
            Console.WriteLine(result);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var inputSignal = Inputs.Day16.ToInts();
            inputSignal = "03036732577212944063491565474664".ToInts();
            var offset = int.Parse(string.Join("", Inputs.Day16.Take(7)));
            offset = int.Parse(string.Join("", "03036732577212944063491565474664".Take(7)));
            var times = 10000;
            var currentSignal = new List<int>(inputSignal.Count * times);
            for (var i = 0; i < times; i++)
            {
                currentSignal.AddRange(inputSignal);
            }

            var currentSignal2 = currentSignal.GetRange(offset - 5, currentSignal.Count - (offset + 5)).ToArray();
            var length = currentSignal2.Length;
            var basePattern = "0, 1, 0, -1".SplitAsIntsBy(',');

            for (var phase = 0; phase < 100; phase++)
            {
                var newSignal = new int[length];
                for (var position = 1; position < length + 1; position++)
                {
                    var pattern = GetPattern2(position, length);
                    var sum = 0;

                    for (var i = 0; i < length; i++)
                    {
                        sum += currentSignal[i] * pattern[i];
                    }

                    newSignal[position-1] = Math.Abs(sum % 10);
                }

                currentSignal2 = newSignal;
                Console.WriteLine("Phase completed: ", phase);
            }


            //for (var phase = 0; phase < 100; phase++)
            //{
            //    for (var position = currentSignal.Count - 2; position > offset - 5; position--)
            //    {
            //        var num = currentSignal[position + 1] + currentSignal[position];
            //        currentSignal[position] = Math.Abs(num % 10);
            //    }
            //}

            //for (var phase = 0; phase < 100; phase++)
            //{
            //    for (var position = currentSignal.Count - 2; position > offset - 5; position--)
            //    {
            //        var num = currentSignal[position + 1] + currentSignal[position];
            //        currentSignal[position] = Math.Abs(num % 10);
            //    }
            //}

            var result = string.Join("", currentSignal2.Take(8));
            var result2 = string.Join("", currentSignal2.Skip(5).Take(8));
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }

        private List<int> GetPattern(List<int> pattern, int position, int length)
        {
            var newPattern = new List<int>();

            foreach (var value in pattern)
            {
                for (var i = 0; i < position; i++)
                {
                    newPattern.Add(value);
                }
            }

            var repeatedPattern = new List<int>(length);

            while (repeatedPattern.Count < length + 1)
            {
                repeatedPattern.AddRange(newPattern);
            }

            repeatedPattern.RemoveAt(0);

            return repeatedPattern;
        }

        private List<int> GetPattern2(int position, int length)
        {
            var newPattern = new List<int>(position*4);
            newPattern.AddRange(Enumerable.Repeat(0, position));
            newPattern.AddRange(Enumerable.Repeat(1, position));
            newPattern.AddRange(Enumerable.Repeat(0, position));
            newPattern.AddRange(Enumerable.Repeat(-1, position));

            var repeatedPattern = new List<int>(length);
            while (repeatedPattern.Count < length + 1)
            {
                repeatedPattern.AddRange(newPattern);
            }

            repeatedPattern.RemoveAt(0);

            return repeatedPattern;
        }
    }
}