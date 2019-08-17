using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2017
{
    public class Day10 : IDay
    {
        public string Title => "2017 Day 10";

        public void Run()
        {
            var test = @"197,97,204,108,1,29,5,71,0,50,2,255,248,78,254,63";//@"1,2,3";
            //var test = @"1,2,3";
            var asciiPartOne = test.Select(s => (int)s).ToList();
            var asciiPartTwo = new List<int> { 17, 31, 73, 47, 23 };
            //var lengths = test.Split(',').Select(s => int.Parse(s)).ToList();
            var lengths = new List<int>(asciiPartOne.Concat(asciiPartTwo));

            var circularList = new List<ListValue>();

            for (int i = 0; i <= 255; i++)
            {
                circularList.Add(new ListValue(i, i));
            }
            
            // 0, 1, 2, 3, 4, and were given input lengths of 3, 4, 1, 5.
            // to int list original
            var currentPos = 0;
            var maxSizeIndex = 255;
            var skipSize = 0;

            //foreach (var length in lengths)
            //{
            //    currentPos = Loop(circularList, currentPos, maxSizeIndex, ref skipSize, length);
            //}

            //var answer = circularList[0].Value * circularList[1].Value;
            //Console.WriteLine(answer);

            //part two
            for (int i = 0; i < 64; i++)
            {
                foreach (var length in lengths)
                {
                    currentPos = Loop(circularList, currentPos, maxSizeIndex, ref skipSize, length);
                }
            }

            var parts16 = ToParts(circularList, 16);
            var denseHash = parts16.Select(s => s.Aggregate((a, b) => a ^ b)).ToList();
            var knotHash = string.Join("", denseHash.Select(s => s.ToString("x2")));
            Console.WriteLine(knotHash);
        }

        public static string CreateKnotHash(List<int> asciiCodes)
        {
            var asciiPartTwo = new List<int> { 17, 31, 73, 47, 23 };
            var lengths = new List<int>(asciiCodes.Concat(asciiPartTwo));

            var circularList = new List<ListValue>();

            for (int i = 0; i <= 255; i++)
            {
                circularList.Add(new ListValue(i, i));
            }

            var currentPos = 0;
            var maxSizeIndex = 255;
            var skipSize = 0;

            for (int i = 0; i < 64; i++)
            {
                foreach (var length in lengths)
                {
                    currentPos = Loop(circularList, currentPos, maxSizeIndex, ref skipSize, length);
                }
            }

            var parts16 = ToParts(circularList, 16);
            var denseHash = parts16.Select(s => s.Aggregate((a, b) => a ^ b)).ToList();
            var knotHash = string.Join("", denseHash.Select(s => s.ToString("x2")));

            return knotHash;
        }

        private static int Loop(List<ListValue> circularList, int currentPos, int maxSizeIndex, ref int skipSize, int length)
        {
            if (length > 1)
            {
                var newMaxIndex = currentPos + length - 1;

                if (newMaxIndex > maxSizeIndex)
                {
                    var partOne = circularList.Where(x => x.Index >= currentPos && x.Index <= maxSizeIndex).ToList();
                    var partTwo = circularList.Where(x => x.Index <= (newMaxIndex % (maxSizeIndex+1))).ToList();
                    partOne.AddRange(partTwo);

                    var reversed = partOne.Select(s => s.Value).Reverse().ToArray();

                    for (int i = 0; i < partOne.Count; i++)
                    {
                        partOne[i].Value = reversed[i];
                    }
                }
                else
                {
                    var partOne = circularList.Where(x => x.Index >= currentPos && x.Index <= newMaxIndex).ToList();
                    var reversed = partOne.Select(s => s.Value).Reverse().ToArray();

                    for (int i = 0; i < partOne.Count; i++)
                    {
                        partOne[i].Value = reversed[i];
                    }
                }
            }

            currentPos += length + skipSize++;
            currentPos %= (maxSizeIndex+1);

            return currentPos;
        }

        public static List<List<int>> ToParts(List<ListValue> source, int partSize)
        {
            var parts = new List<List<int>>();
            var part = new List<int>();

            foreach (var item in source.Select(s => s.Value))
            {
                if (part.Count == partSize)
                {
                    parts.Add(new List<int>(part));
                    part = new List<int>();
                }
                part.Add(item);
            }

            parts.Add(new List<int>(part));

            return parts;
        }
    }

    public class ListValue
    {
        public int Index { get; private set; }
        public int Value { get; set; }

        public ListValue(int index, int value)
        {
            Index = index;
            Value = value;
        }
    }
}