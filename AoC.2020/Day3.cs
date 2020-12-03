using System;
using System.Linq;
using AoC.Common;

namespace AoC2020
{
    public class Day3 : Day
    {
        public override string Title => "day3";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day3.ToStringList().Select(s => new CircularList<char>(s)).ToList();
            var trees = 0;
            var y = 0;
            var x = 0;

            while (y < input.Count-1)
            {
                y += 1;
                x += 3;

                var current = input[y][x];

                if (current == '#')
                {
                    trees++;
                }
            }

            Console.WriteLine(trees);
        }

        public override void PartTwo()
        {
            base.PartOne();
            var input = Inputs.Day3.ToStringList().Select(s => new CircularList<char>(s)).ToList();
            var slopes = new[] {(1, 1), (3, 1), (5, 1), (7, 1), (1, 2)};
            long result = 1;

            foreach (var (right, down) in slopes)
            {
                var trees = 0;
                var y = 0;
                var x = 0;

                while (y < input.Count - down)
                {
                    y += down;
                    x += right;

                    var current = input[y][x];

                    if (current == '#')
                    {
                        trees++;
                    }
                }

                Console.WriteLine(trees);
                result *= trees;
            }

            Console.WriteLine(result);
        }
    }
}