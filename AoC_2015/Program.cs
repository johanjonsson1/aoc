using AoC_Common;
using System;

namespace AoC_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            IDay day = new AoC_2017.Day19();
            Console.WriteLine($"Running puzzle {day.Title}");
            day.Run();

            Console.ReadLine();
        }
    }
}
