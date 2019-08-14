using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2016
{
    /*

    */
    public class Day6 : Day
    {
        public override string Title => "--- Day 6: Signals and Noise ---";

        public override void PartOne()
        {
            base.PartOne();
//            var input = @"eedadn
//drvtee
//eandsr
//raavrd
//atevrs
//tsrnev
//sdttsa
//rasrtv
//nssdts
//ntnada
//svetve
//tesnvt
//vntsnd
//vrdear
//dvrsen
//enarar";

            var errorCorrectedMessage = string.Join("", Inputs.Day6
                .ToStringList()
                .ToColumns()
                .Select(s => s.Value
                    .GroupBy(g => g)
                    .OrderByDescending(o => o.Count())
                    .First().Key)
            );

            Console.WriteLine("Result part 1");
            Console.WriteLine(errorCorrectedMessage);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var errorCorrectedMessage = string.Join("", Inputs.Day6
                .ToStringList()
                .ToColumns()
                .Select(s => s.Value
                    .GroupBy(g => g)
                    .OrderBy(o => o.Count())
                    .First().Key)
            );

            Console.WriteLine("Result part 2");
            Console.WriteLine(errorCorrectedMessage);
        }
    }
}