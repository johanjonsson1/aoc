using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*
    --- Day 11: Space Police ---
    On the way to Jupiter, you're pulled over by the Space Police.

    "Attention, unmarked spacecraft! You are in violation of Space Law! All spacecraft must have a clearly visible registration identifier! 
    You have 24 hours to comply or be sent to Space Jail!"

    Not wanting to be sent to Space Jail, you radio back to the Elves on Earth for help. 
    Although it takes almost three hours for their reply signal to reach you, they send instructions for how to power up the emergency hull painting robot and even provide a small Intcode program (your puzzle input)
    that will cause it to paint your ship appropriately.

    There's just one problem: you don't have an emergency hull painting robot.

    You'll need to build a new emergency hull painting robot. 
    The robot needs to be able to move around on the grid of square panels on the side of your ship, detect the color of its current panel, and paint its current panel black or white. 
    (All of the panels are currently black.)

    The Intcode program will serve as the brain of the robot. 
    The program uses input instructions to access the robot's camera: provide 0 if the robot is over a black panel or 1 if the robot is over a white panel. 
    Then, the program will output two values:

    First, it will output a value indicating the color to paint the panel the robot is over: 0 means to paint the panel black, and 1 means to paint the panel white.
    Second, it will output a value indicating the direction the robot should turn: 0 means it should turn left 90 degrees, and 1 means it should turn right 90 degrees.
    After the robot turns, it should always move forward exactly one panel. The robot starts facing up.

    The robot will continue running for a while like this and halt when it is finished drawing. Do not restart the Intcode computer inside the robot during this process.

    For example, suppose the robot is about to start running. Drawing black panels as ., white panels as #, and the robot pointing the direction it is facing (< ^ > v), 
    the initial state and region near the robot looks like this:

    .....
    .....
    ..^..
    .....
    .....
    The panel under the robot (not visible here because a ^ is shown instead) is also black, and so any input instructions at this point should be provided 0. 
    Suppose the robot eventually outputs 1 (paint white) and then 0 (turn left). After taking these actions and moving forward one panel, the region now looks like this:

    .....
    .....
    .<#..
    .....
    .....
    Input instructions should still be provided 0. Next, the robot might output 0 (paint black) and then 0 (turn left):

    .....
    .....
    ..#..
    .v...
    .....
    After more outputs (1,0, 1,0):

    .....
    .....
    ..^..
    .##..
    .....
    The robot is now back where it started, but because it is now on a white panel, input instructions should be provided 1. After several more outputs (0,1, 1,0, 1,0), the area looks like this:

    .....
    ..<#.
    ...#.
    .##..
    .....
    Before you deploy the robot, you should probably have an estimate of the area it will cover: specifically, you need to know the number of panels it paints at least once, regardless of color. 
    In the example above, the robot painted 6 panels at least once. (It painted its starting panel twice, but that panel is still only counted once; it also never painted the panel it ended on.)

    Build a new emergency hull painting robot and run the Intcode program on it. How many panels does it paint at least once?

    Your puzzle answer was 1732.

    --- Part Two ---
    You're not sure what it's trying to paint, but it's definitely not a registration identifier. The Space Police are getting impatient.

    Checking your external ship cameras again, you notice a white panel marked "emergency hull painting robot starting panel". 
    The rest of the panels are still black, but it looks like the robot was expecting to start on a white panel, not a black one.

    Based on the Space Law Space Brochure that the Space Police attached to one of your windows, a valid registration identifier is always eight capital letters. 
    After starting the robot on a single white panel instead, what registration identifier does it paint on your hull?

    Your puzzle answer was ABCLFUHJ.
    */

    public class Day11 : Day
    {
        public override string Title => "--- Day 11: Space Police ---";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day11
                .SplitAsLongsBy(',')
                .ToArray()
                .ExpandTo(100000);

            var bot = new HullPaintingRobot(input);

            while (!bot.BrainTerminated)
            {
                bot.DoWork();
            }

            var panels = bot.AllPanels;
            var painted = panels.Where(x => x.Painted > 0).ToList();

            Console.WriteLine(painted.Count);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = Inputs.Day11
                .SplitAsLongsBy(',')
                .ToArray()
                .ExpandTo(100000);

            var bot = new HullPaintingRobot(input, true);

            while (!bot.BrainTerminated)
            {
                bot.DoWork();
            }

            var panels = bot.AllPanels;

            var maxY = panels.Max(x => x.Coordinate.Y);
            var minY = panels.Min(x => x.Coordinate.Y);
            var maxX = panels.Max(x => x.Coordinate.X);
            var minX = panels.Min(x => x.Coordinate.X);

            var grid = bot.Grid;
            Console.WriteLine();
            for (var i = minY; i <= maxY; i++)
            {
                for (var j = minX; j <= maxX; j++)
                {

                    grid.TryGet(new Coordinate(j, i), out var panel);

                    if (panel == null)
                    {
                        Console.Write('.');
                        continue;
                    }

                    Console.Write(panel.IsBlack ? '.' : '#');
                }

                Console.WriteLine();
            }
        }
    }

    public class HullPaintingRobot
    {
        private readonly Navigator _navigator = new Navigator(new Coordinate(0,0), Navigator.Face.Up);
        private Panel CurrentPanel { get; set; }
        private readonly IntCodeProgram _intCodeProgram;
        public readonly Grid<Coordinate, Panel> Grid = new Grid<Coordinate, Panel>();
        public List<Panel> AllPanels => Grid.GetAll();
        public bool BrainTerminated => _intCodeProgram.IsTerminated;

        public HullPaintingRobot(long[] brain, bool startWhite) : this(brain)
        {
            if (startWhite)
            {
                CurrentPanel.PaintWhite();
            }
        }

        public HullPaintingRobot(long[] brain)
        {
            _intCodeProgram = new IntCodeProgram(brain);
            var startCoordinate = new Coordinate(0,0);
            var startPanel = new Panel(startCoordinate);
            Grid.Add(startCoordinate, startPanel);
            CurrentPanel = startPanel;
        }

        public void DoWork()
        {
            if (_intCodeProgram.IsTerminated)
            {
                return;
            }

            long instruction = CurrentPanel.IsBlack ? 0 : 1;

            _intCodeProgram.LoopUntilHalt(instruction);
            if (_intCodeProgram.IsTerminated)
            {
                return;
            }

            Paint(_intCodeProgram.Output);
            _intCodeProgram.LoopUntilHalt(instruction);
            if (_intCodeProgram.IsTerminated)
            {
                return;
            }

            Navigate(_intCodeProgram.Output);
        }

        private void Navigate(long output)
        {
            if (output == 0)
            {
                _navigator.TurnLeft();
            }
            else
            {
                _navigator.TurnRight();
            }

            _navigator.Move(1);

            var newCoordinate = _navigator.CurrentCoordinate;

            Panel nextPanel;
            if (Grid.TryGet(newCoordinate, out var panel))
            {
                nextPanel = panel;
            }
            else
            {
                nextPanel = new Panel(newCoordinate);
                Grid.Add(newCoordinate, nextPanel);
            }

            CurrentPanel = nextPanel;
        }

        private void Paint(long value)
        {
            if (value == 0)
            {
                CurrentPanel.PaintBlack();
                return;
            }

            CurrentPanel.PaintWhite();
        }
    }

    public class Panel
    {
        public bool IsBlack = true;
        public Coordinate Coordinate;
        public int Painted;

        public Panel(Coordinate coordinate)
        {
            Coordinate = coordinate;
        }

        public void PaintBlack()
        {
            Painted++;
            IsBlack = true;
        }

        public void PaintWhite()
        {
            Painted++;
            IsBlack = false;
        }
    }
}