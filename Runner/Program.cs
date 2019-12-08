using AoC.Common;
using System;

namespace Runner
{
    class Program
    {
        static void Main()
        {
            IDay day = new AoC2019.Day9();
            Console.WriteLine($"Running puzzle {day.Title}");
            day.Run();

            Console.WriteLine("Press any key to quit");
            Console.ReadLine();
        }
    }
}