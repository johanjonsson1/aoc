using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day17 : Day
    {
        private static bool PrintEnabled = true;

        public override string Title => "";
        public List<Space> ExploredScaffolding;
        public VacuumRobot ExplorerBot;

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day17.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            var bot = new VacuumRobot(input);

            bot.ExploreWithIntCode();
            Print(bot.Grid, bot);
            var intersections = bot.Grid.GetAll().Where(x => x.IsIntersection).ToList();
            var result = intersections.Sum(s => s.AlignmentParameter);

            ExploredScaffolding = bot.Grid.GetAll().Where(x => x.Type == SpaceType.Scaffolding).ToList();
            ExplorerBot = bot;

            Console.WriteLine(result);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var targetSpace = ExploredScaffolding.OrderByDescending(s => s.Coordinate.X).First();
            var currentSpace = ExploredScaffolding.First(f => f.Coordinate.Equals(ExplorerBot.StartCoordinate));
            var sb = new StringBuilder().Append('L');
            var navi = new Navigator(currentSpace.Coordinate, Navigator.Face.Left);
            var sum = 0;

            while (currentSpace != targetSpace)
            {
                currentSpace = ExploredScaffolding.First(e => e.Coordinate.Equals(navi.CurrentCoordinate));
                var straight = navi.PeekMove(1);
                if (ExploredScaffolding.Any(e => e.Coordinate.Equals(straight)))
                {
                    navi.Move(1);
                    sum++;
                    continue;
                }

                navi.TurnLeft();
                var left = navi.PeekMove(1);
                if (ExploredScaffolding.Any(e => e.Coordinate.Equals(left)))
                {
                    sb.Append(sum);
                    sum = 0;
                    sb.Append(',');
                    sb.Append('L');
                    navi.Move(1);
                    sum++;
                    continue;
                }

                navi.TurnAround();
                var right = navi.PeekMove(1);
                if (ExploredScaffolding.Any(e => e.Coordinate.Equals(right)))
                {
                    sb.Append(sum);
                    sum = 0;
                    sb.Append(',');
                    sb.Append('R');
                    navi.Move(1);
                    sum++;
                    continue;
                }

                sb.Append(sum);
            }

            var calc = sb.ToString();

            var input2 =
                "L10,L8,R8,L8,R6,L10,R8,R8,L8,R6,R6,R8,R6,R8,R6,L8,L10,R6,R8,R8,R6,R6,L8,L10,R6,R8,R8,R6,R6,L8,L10,R6,R8,R8,L10,L8,R8,L8,R6";
            // L10,L8,R8,L8,R6 | R6,R8,R8 | R6,R6,L8,L10
            // L10,L8,R8,L8,R6 | L10,L8,R8,L8,R6 | R6,R8,R8 | R6,R6,L8,L10 | R6,R8,R8 | R6,R6,L8,L10 | R6,R8,R8 | R6,R6,L8,L10 | R6,R8,R8 | L10,L8,R8,L8,R6 |
            // L10,L8,R8,L8,R6   L10,L8,R8,L8,R6   R6,R8,R8   R6,R6,L8,L10,  R6,R8,R8,  R6,R6,L8,L10   R6,R8,R8   R6,R6,L8,L10   R6,R8,R8   L10,L8,R8,L8,R6
            // A,A,B,C,B,C,B,C,B,A
            var input = Inputs.Day17.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
            input[0] = 2;

            var bot = new VacuumRobot(input);
            var result = bot.ReceiveMovementRoutine(GetRoutines());

            Console.WriteLine();
        }

        private IEnumerable<long> GetRoutines()
        {
            var mainRoutine = "A,A,B,C,B,C,B,C,B,A\n";
            var functionA = "L,10,L,8,R,8,L,8,R,6\n";//.Replace(",", " , ").Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);
            var functionB = "R,6,R,8,R,8\n";//.Replace(",", " , ").Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var functionC = "R,6,R,6,L,8,L,10\n";//.Replace(",", " , ").Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var end = "y\n";

            foreach (var c in ASCIIEncoding.ASCII.GetBytes(mainRoutine).Select(s => (long)s))
            {
                yield return c;
            }

            foreach (var c in ASCIIEncoding.ASCII.GetBytes(functionA).Select(s => (long)s))
            {
                yield return c;
            }

            foreach (var c in ASCIIEncoding.ASCII.GetBytes(functionB).Select(s => (long)s))
            {
                yield return c;
            }

            foreach (var c in ASCIIEncoding.ASCII.GetBytes(functionC).Select(s => (long)s))
            {
                yield return c;
            }

            foreach (var c in ASCIIEncoding.ASCII.GetBytes(end).Select(s => (long)s))
            {
                yield return c;
            }
        }

        private static void Print(Grid<Coordinate, Space> grid, VacuumRobot bot)
        {
            if (!PrintEnabled)
                return;

            var locations = grid.GetAll();
            var maxY = locations.Max(x => x.Coordinate.Y);
            var maxX = locations.Max(x => x.Coordinate.X);

            Console.WriteLine();
            for (var i = 0; i <= maxY; i++)
            {
                for (var j = 0; j <= maxX; j++)
                {
                    if (bot.CurrentCoordinate.X == j && bot.CurrentCoordinate.Y == i)
                    {
                        Console.Write('B');
                        continue;
                    }

                    if (grid.TryGet(new Coordinate(j, i), out var space))
                    {
                        char aa = space.Type == SpaceType.Scaffolding ? '#' : '.';
                        Console.Write(aa);
                        continue;
                    }

                    Console.Write(' ');
                }

                Console.WriteLine();
            }
        }

        public class VacuumRobot
        {
            public readonly Navigator Navigator;
            public readonly IntCodeProgram IntCodeProgram;
            public Coordinate CurrentCoordinate;
            public bool HasCoordinate;
            public Coordinate LastCoordinate;
            public Grid<Coordinate, Space> Grid = new Grid<Coordinate, Space>();
            public Navigator.Face Facing;
            public Coordinate StartCoordinate;

            public VacuumRobot(long[] memory)
            {
                var startCoordinate = new Coordinate(0, 0);
                Navigator = new Navigator(startCoordinate, Navigator.Face.Right);
                IntCodeProgram = new IntCodeProgram(memory);
            }

            public long ReceiveMovementRoutine(IEnumerable<long> routineAndFunctions)
            {
                foreach (var routineAndFunction in routineAndFunctions)
                {
                    IntCodeProgram.AddInput(routineAndFunction);
                }
                
                while (!IntCodeProgram.IsTerminated)
                {
                    //Console.Write(i);
                    //Console.Write(',');
                    IntCodeProgram.LoopUntilHalt(0);
                    var locationState = IntCodeProgram.Output;
                    char asChar = (char)locationState;

                    if (asChar == '\n')
                    {
                        Navigator.TeleportTo(new Coordinate(0, Navigator.CurrentCoordinate.Y + 1));
                        //Print(Grid, this);
                        continue;
                    }

                    if (!Grid.TryGet(Navigator.CurrentCoordinate, out var space))
                    {
                        Grid.Add(Navigator.CurrentCoordinate, new Space
                        {
                            Coordinate = Navigator.CurrentCoordinate,
                            Type = Space.GetType(asChar)
                        });
                    }

                    MaybeSetRobot(Navigator.CurrentCoordinate, asChar);
                    //Print(Grid, this);
                    Navigator.Move(1);
                

                    
                }

                return IntCodeProgram.Output;
            }

            public void ExploreWithIntCode()
            {
                while (!IntCodeProgram.IsTerminated)
                {
                    IntCodeProgram.LoopUntilHalt(0);
                    var locationState = IntCodeProgram.Output;
                    char asChar = (char) locationState;

                    if (asChar == '\n')
                    {
                        Navigator.TeleportTo(new Coordinate(0, Navigator.CurrentCoordinate.Y + 1));
                        //Print(Grid, this);
                        continue;
                    }

                    if (!Grid.TryGet(Navigator.CurrentCoordinate, out var space))
                    {
                        Grid.Add(Navigator.CurrentCoordinate, new Space
                        {
                            Coordinate = Navigator.CurrentCoordinate,
                            Type = Space.GetType(asChar)
                        });
                    }

                    MaybeSetRobot(Navigator.CurrentCoordinate, asChar);
                    Navigator.Move(1);
                }

                var allSpace = Grid.GetAll();

                foreach (var space in allSpace)
                {
                    if (space.Type != SpaceType.Scaffolding)
                    {
                        continue;
                    }

                    var adjacent = allSpace.Count(a => a.Type == SpaceType.Scaffolding && space.Coordinate.IsAdjacent(a.Coordinate));

                    if (adjacent == 4)
                    {
                        space.IsIntersection = true;
                    }
                }
            }

            private void MaybeSetRobot(Coordinate currentCoordinate, char asChar)
            {
                if (asChar == '<')
                {
                    if (!HasCoordinate)
                    {
                        this.StartCoordinate = currentCoordinate;
                    }
                    this.Facing = Navigator.Face.Left;
                    this.CurrentCoordinate = currentCoordinate;
                    HasCoordinate = true;
                }
                else if (asChar == '>')
                {
                    if (!HasCoordinate)
                    {
                        this.StartCoordinate = currentCoordinate;
                    }
                    this.Facing = Navigator.Face.Right;
                    this.CurrentCoordinate = currentCoordinate;
                    HasCoordinate = true;
                }
                else if (asChar == '^')
                {
                    if (!HasCoordinate)
                    {
                        this.StartCoordinate = currentCoordinate;
                    }
                    this.Facing = Navigator.Face.Up;
                    this.CurrentCoordinate = currentCoordinate;
                    HasCoordinate = true;
                }
                else if (asChar == 'v')
                {
                    if (!HasCoordinate)
                    {
                        this.StartCoordinate = currentCoordinate;
                    }
                    this.Facing = Navigator.Face.Down;
                    this.CurrentCoordinate = currentCoordinate;
                    HasCoordinate = true;
                }
            }
        }

        public class Space
        {
            public Coordinate Coordinate;
            public bool IsIntersection;
            public SpaceType Type;
            public int AlignmentParameter => IsIntersection ? Math.Abs(Coordinate.X) * Math.Abs(Coordinate.Y) : 0;

            public static SpaceType GetType(char input)
            {
                if (input == '.')
                    return SpaceType.OpenSpace;

                if (input == '#' || input == '^' || input == 'v' || input == '>' || input == '<')
                    return SpaceType.Scaffolding;

                return SpaceType.Fail;
            }
        }

        public enum SpaceType
        {
            Scaffolding,
            OpenSpace,
            Fail
        }

    }
}