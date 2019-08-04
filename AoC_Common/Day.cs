﻿using System;

namespace AoC_Common
{
    public abstract class Day : IDay
    {
        public virtual string Title => "No title";

        public virtual void Run()
        {
            PartOne();
            PartTwo();
        }

        public virtual void PartOne()
        {
            Console.WriteLine($"--- Part 1 {Title}");
        }

        public virtual void PartTwo()
        {
            Console.WriteLine($"--- Part 2 {Title}");
        }
    }
}