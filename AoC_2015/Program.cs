using AoC_Common;
using System;

namespace AoC_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            IDay day = new AoC_2016.Day4();
            Console.WriteLine($"Running puzzle {day.Title}");
            day.Run();

            Console.ReadLine();
        }
    }
}
