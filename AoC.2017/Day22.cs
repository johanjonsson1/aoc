using AoC.Common;
using System;
using System.Linq;

namespace AoC2017
{
    /*

    */

    public class Day22 : Day
    {
        public override string Title => "--- Day 22: Sporifica Virus ---";

        public override void PartOne()
        {
            base.PartOne();

            //            var input = @"..#
            //#..
            //...".ToStringList();

            var input = @".......##.#..####.#....##
..###....###.####..##.##.
#..####.#....#.#....##...
.#....#.#.#....#######...
.###..###.#########....##
##...#####..#####.###.#..
.#..##.###.#.#....######.
.#.##.#..####..#.##.....#
#.#..###..##..#......##.#
##.###.##.#.#...##.#.##..
##...#.######.#..##.#...#
....#.####..#..###.##..##
...#....#.###.#.#..#.....
..###.#.#....#.....#.####
.#....##..##.#.#...#.#.#.
...##.#.####.###.##...#.#
##.#.####.#######.##..##.
.##...#......####..####.#
#..###.#.###.##.#.#.##..#
#..###.#.#.#.#.#....#.#.#
####.#..##..#.#..#..#.###
##.....#..#.#.#..#.####..
#####.....###.........#..
##...#...####..#####...##
.....##.#....##...#.....#".ToStringList();

            var infiniteGrid = new Grid<Coordinate, Node>();

            for (var y = 0; y < input.Count; y++)
            {
                for (var x = 0; x < input.First().Length; x++)
                {
                    var coordinate = new Coordinate(x, y);
                    var state = input[y][x] == '#' ? Node.State.Infected : Node.State.Clean;
                    var node = new Node(coordinate, state);
                    infiniteGrid.Add(coordinate, node);
                }
            }

            var currentGrid = infiniteGrid.GetAll();
            var centerY = (int) currentGrid.Average(a => a.Coordinate.Y);
            var centerX = (int) currentGrid.Average(a => a.Coordinate.X);
            var center = new Coordinate(centerX, centerY);
            infiniteGrid.TryGet(center, out var startNode);
            var carrier = new EvolvedVirusCarrier(center, startNode, infiniteGrid);

            for (var i = 0; i < 10_000_000; i++)
            {
                //Print(infiniteGrid, carrier.CurrentCoordinate);
                carrier.PerformBurst();
            }

            var causedInfection = infiniteGrid.GetAll().Sum(s => s.InfectedCount);

            Console.WriteLine($"Result {causedInfection}");
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Console.WriteLine();
        }

        public void Print(Grid<Coordinate, Node> grid, Coordinate carrierCoordinate)
        {
            for (var y = -3; y <= 4; y++)
            {
                for (var x = -3; x <= 5; x++)
                {
                    var currentCoordinate = new Coordinate(x, y);

                    if (currentCoordinate.Equals(carrierCoordinate))
                    {
                        Console.Write("V");
                    }
                    else if(grid.TryGet(currentCoordinate, out var node))
                    {
                        if (node.CurrentState == Node.State.Infected)
                        {
                            Console.Write("#");
                        }
                        else if (node.CurrentState == Node.State.Weakened)
                        {
                            Console.Write("W");
                        }
                        else if (node.CurrentState == Node.State.Flagged)
                        {
                            Console.Write("F");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(".");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
            }
        }
    }

    public class EvolvedVirusCarrier : VirusCarrier
    {
        public EvolvedVirusCarrier(Coordinate startCoordinate, Node startNode, Grid<Coordinate, Node> grid) : base(
            startCoordinate, startNode, grid)
        {
        }

        public override void PerformBurst()
        {
            switch (CurrentNode.CurrentState)
            {
                case Node.State.Clean:
                    Navigator.TurnLeft();
                    CurrentNode.Weaken();
                    break;
                case Node.State.Weakened:
                    CurrentNode.Infect();
                    break;
                case Node.State.Infected:
                    Navigator.TurnRight();
                    CurrentNode.Flag();
                    break;
                case Node.State.Flagged:
                    Navigator.TurnAround();
                    CurrentNode.Clean();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            Move();
        }
    }

    public class VirusCarrier
    {
        private readonly Grid<Coordinate, Node> _grid;
        public Coordinate CurrentCoordinate { get; private set; }
        //public AoC.Common.Navigator.Direction CurrentDirection { get; private set; }
        public Node CurrentNode { get; private set; }
        protected readonly AoC.Common.Navigator Navigator;

        public VirusCarrier(Coordinate startCoordinate, Node startNode, Grid<Coordinate, Node> grid)
        {
            Navigator = new AoC.Common.Navigator(startCoordinate, AoC.Common.Navigator.Face.Up);
            _grid = grid;
            CurrentCoordinate = startCoordinate;
            //CurrentDirection = AoC.Common.Navigator.Direction.Up;
            CurrentNode = startNode;
        }

        public virtual void PerformBurst()
        {
            //If the current node is infected, it turns to its right.Otherwise, it turns to its left.
            //(Turning is done in -place; the current node does not change.)

            if (CurrentNode.CurrentState != Node.State.Infected)
            {
                Navigator.TurnLeft();
                CurrentNode.Infect();
            }
            else
            {
                Navigator.TurnRight();
                CurrentNode.Clean();
            }

            //If the current node is clean, it becomes infected.Otherwise, it becomes cleaned. (This is done after the node is considered for the purposes of changing direction.)
            //The virus carrier moves forward one node in the direction it is facing.

            Move();
        }

        protected void Move()
        {
            Navigator.Move(1);

            var newCoordinate = Navigator.CurrentCoordinate;
            CurrentCoordinate = newCoordinate;

            Node nextNode;
            if (_grid.TryGet(newCoordinate, out var node))
            {
                nextNode = node;
            }
            else
            {
                nextNode = new Node(newCoordinate, Node.State.Clean);
                _grid.Add(newCoordinate, nextNode);
            }

            CurrentNode = nextNode;
        }
    }

    public class Node
    {
        public Coordinate Coordinate { get; private set; }
        public State CurrentState { get; private set; }
        public int VisitedCount { get; private set; }
        public int InfectedCount { get; private set; }

        public Node(Coordinate coordinate, State state)
        {
            Coordinate = coordinate;
            CurrentState = state;
        }

        public void Infect()
        {
            CurrentState = State.Infected;
            InfectedCount++;
            VisitedCount++;
        }

        public void Clean()
        {
            CurrentState = State.Clean;
            VisitedCount++;
        }

        public void Weaken()
        {
            CurrentState = State.Weakened;
            VisitedCount++;
        }

        public void Flag()
        {
            CurrentState = State.Flagged;
            VisitedCount++;
        }

        public enum State
        {
            Clean,
            Weakened,
            Infected,
            Flagged
        }
    }
}