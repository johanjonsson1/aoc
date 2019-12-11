using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day11 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day11.SplitAsLongsBy(',').ToArray();
            var newList = new long[100000];
            input.CopyTo(newList, 0);

            var bot = new HullPaintingRobot(newList);

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
            var input = Inputs.Day11.SplitAsLongsBy(',').ToArray();
            var newList = new long[100000];
            input.CopyTo(newList, 0);

            var bot = new HullPaintingRobot(newList, true);

            while (!bot.BrainTerminated)
            {
                bot.DoWork();
            }

            var panels = bot.AllPanels;

            var maxY = panels.Max(x => x.Coordinate.Y);
            var minY = panels.Min(x => x.Coordinate.Y);
            var maxX = panels.Max(x => x.Coordinate.X);
            var minX = panels.Min(x => x.Coordinate.X);

            var grid = bot._grid;
            Console.WriteLine();
            for (int i = minY; i <= maxY; i++)
            {
                for (int j = minX; j <= maxX; j++)
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
        private Navigator _navigator = new Navigator(new Coordinate(0,0), Navigator.Face.Up);
        private Panel CurrentPanel { get; set; }
        private readonly IntCodeProgram _intCodeProgram;
        public readonly Grid<Coordinate, Panel> _grid = new Grid<Coordinate, Panel>();
        public List<Panel> AllPanels => _grid.GetAll();
        public bool BrainTerminated => _intCodeProgram.IsTerminated;
        //The program uses input instructions to access the robot's camera: provide 0 if the robot is over a black panel or 1 if the robot is over a white panel. Then, the program will output two values:

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
            _grid.Add(startCoordinate, startPanel);
            CurrentPanel = startPanel;
        }

        public void DoWork()
        {
            if (_intCodeProgram.IsTerminated)
            {
                return;
            }

            long instruction;
            if (CurrentPanel.IsBlack)
            {
                instruction = 0;
            }
            else
            {
                instruction = 1;
            }

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
            if (_grid.TryGet(newCoordinate, out var panel))
            {
                nextPanel = panel;
            }
            else
            {
                nextPanel = new Panel(newCoordinate);
                _grid.Add(newCoordinate, nextPanel);
            }

            CurrentPanel = nextPanel;
        }

        public void Paint(long value)
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