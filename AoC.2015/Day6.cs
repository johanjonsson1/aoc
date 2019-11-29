using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;

namespace AoC2015
{
    /*
    --- Day 6: Probably a Fire Hazard ---

    Because your neighbors keep defeating you in the holiday house decorating contest year after year, 
    you've decided to deploy one million lights in a 1000x1000 grid.

    Furthermore, because you've been especially nice this year, 
    Santa has mailed you instructions on how to display the ideal lighting configuration.

    Lights in your grid are numbered from 0 to 999 in each direction; 
    the lights at each corner are at 0,0, 0,999, 999,999, and 999,0. 
    The instructions include whether to turn on, turn off, or toggle various inclusive ranges given as coordinate pairs. 
    Each coordinate pair represents opposite corners of a rectangle, inclusive; 
    a coordinate pair like 0,0 through 2,2 therefore refers to 9 lights in a 3x3 square. 
    The lights all start turned off.

    To defeat your neighbors this year, all you have to do is set up your lights by doing the instructions Santa sent you in order.

    For example:

    turn on 0,0 through 999,999 would turn on (or leave on) every light.
    toggle 0,0 through 999,0 would toggle the first line of 1000 lights,
    turning off the ones that were on, and turning on the ones that were off.
    turn off 499,499 through 500,500 would turn off (or leave off) the middle four lights.
    After following the instructions, how many lights are lit? 

    --- Part Two ---

    You just finish implementing your winning light pattern when you realize you mistranslated Santa's message from Ancient Nordic Elvish.

    The light grid you bought actually has individual brightness controls; each light can have a brightness of zero or more. 
    The lights all start at zero.

    The phrase turn on actually means that you should increase the brightness of those lights by 1.

    The phrase turn off actually means that you should decrease the brightness of those lights by 1, to a minimum of zero.

    The phrase toggle actually means that you should increase the brightness of those lights by 2.

    What is the total brightness of all lights combined after following Santa's instructions?

    For example:

    turn on 0,0 through 0,0 would increase the total brightness by 1.
    toggle 0,0 through 999,999 would increase the total brightness by 2000000.
    */

    public class Day6 : IDay
    {
        public string Title => "Day6";

        public void Run()
        {
            PartOne();
        }

        private void PartOne()
        {
            var test = @"turn on 1,1 through 2,2
toggle 0,2 through 0,2";

            var input = Inputs.Day6.ToStringList();
            var lightGrid = new LightGrid(1000);

            foreach (var instruction in input)
            {
                Range r;
                var aaa = ConvertInstruction(instruction, out r);
                lightGrid.PerformAction(aaa, r);
            }

            var on = lightGrid.Grid.Where(x => x.TurnedOn).ToList();
            var brightness = lightGrid.Grid.Sum(x => x.Brightness);
            Console.WriteLine("Turned on: " + on.Count);
            Console.WriteLine("Brightness: " + brightness);
        }   
        
        private InstructionType ConvertInstruction(string instruction, out Range range)
        {
            InstructionType result;

            if (instruction.StartsWith("turn on"))
            {
                result = InstructionType.TurnOn;
            }
            else if (instruction.StartsWith("turn off"))
            {
                result = InstructionType.TurnOff;
            }
            else if (instruction.StartsWith("toggle"))
            {
                result = InstructionType.Toggle;
            }
            else
            {
                throw new ArgumentException("invalid instruction?! what");
            }

            var strippedInst = instruction.RemoveAToZ().Trim();
            var xsAndYs = strippedInst.Split(' ', ',').Where(x => x != "").ToArray();

            range = new Range
            {
                StartX = int.Parse(xsAndYs[0]),
                StartY = int.Parse(xsAndYs[1]),
                EndX = int.Parse(xsAndYs[2]),
                EndY = int.Parse(xsAndYs[3]),
            };

            return result;
        }     
    }

    public enum InstructionType
    {
        Toggle,
        TurnOn,
        TurnOff
    }

    public class Range
    {
        public int StartX { get; set; }
        public int EndX { get; set; }
        public int StartY { get; set; }
        public int EndY { get; set; }
    }

    public class LightGrid
    {
        public List<Light> Grid { get; } = new List<Light>();

        public LightGrid(int squareSize)
        {
            // y 0 x 0
            // y 0 x 1
            // y 0 x 2

            // y 1 x 0
            // y 1 x 1
            // y 1 x 2

            // y 2 x 0
            // y 2 x 1
            // y 2 x 2

            for (int y = 0; y < squareSize; y++)
            {
                for (int x = 0; x < squareSize; x++)
                {
                    Grid.Add(new Light(x, y));
                }
            }
        }

        public void PerformAction(InstructionType type, Range range)
        {
            var match = Grid.Where(g => g.X >= range.StartX && g.X <= range.EndX && g.Y >= range.StartY && g.Y <= range.EndY).ToList();

            switch (type)
            {
                case InstructionType.Toggle:
                    match.ForEach((g) => { g.Toggle(); });
                    break;
                case InstructionType.TurnOn:
                    match.ForEach((g) => { g.TurnOn(); });
                    break;
                case InstructionType.TurnOff:
                    match.ForEach((g) => { g.TurnOff(); });
                    break;
                default:
                    break;
            }
        }
    }

    public class Light
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public bool TurnedOn { get; private set; } = false;
        private int _brightness;

        public int Brightness
        {
            get { return _brightness; }
            set
            {
                if (value == -1 && _brightness == 0)
                {
                    return;
                }

                _brightness = value;
            }
        }


        public Light(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Toggle()
        {
            TurnedOn = !TurnedOn;
            Brightness = Brightness + 2;
        }

        public void TurnOn()
        {
            TurnedOn = true;
            Brightness = Brightness + 1;
        }

        public void TurnOff()
        {
            TurnedOn = false;
            Brightness = Brightness - 1;
        }
    }
}
