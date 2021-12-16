namespace AoC2019;
/*
--- Day 17: Set and Forget ---
An early warning system detects an incoming solar flare and automatically activates the ship's electromagnetic shield. Unfortunately, this has cut off the Wi-Fi for many small robots that, unaware of the impending danger, are now trapped on exterior scaffolding on the unsafe side of the shield. To rescue them, you'll have to act quickly!

The only tools at your disposal are some wired cameras and a small vacuum robot currently asleep at its charging station. The video quality is poor, but the vacuum robot has a needlessly bright LED that makes it easy to spot no matter where it is.

An Intcode program, the Aft Scaffolding Control and Information Interface (ASCII, your puzzle input), provides access to the cameras and the vacuum robot. Currently, because the vacuum robot is asleep, you can only access the cameras.

Running the ASCII program on your Intcode computer will provide the current view of the scaffolds. This is output, purely coincidentally, as ASCII code: 35 means #, 46 means ., 10 starts a new line of output below the current one, and so on. (Within a line, characters are drawn left-to-right.)

In the camera output, # represents a scaffold and . represents open space. The vacuum robot is visible as ^, v, <, or > depending on whether it is facing up, down, left, or right respectively. When drawn like this, the vacuum robot is always on a scaffold; if the vacuum robot ever walks off of a scaffold and begins tumbling through space uncontrollably, it will instead be visible as X.

In general, the scaffold forms a path, but it sometimes loops back onto itself. For example, suppose you can see the following view from the cameras:

..#..........
..#..........
#######...###
#.#...#...#.#
#############
..#...#...#..
..#####...^..
Here, the vacuum robot, ^ is facing up and sitting at one end of the scaffold near the bottom-right of the image. The scaffold continues up, loops across itself several times, and ends at the top-left of the image.

The first step is to calibrate the cameras by getting the alignment parameters of some well-defined points. Locate all scaffold intersections; for each, its alignment parameter is the distance between its left edge and the left edge of the view multiplied by the distance between its top edge and the top edge of the view. Here, the intersections from the above image are marked O:

..#..........
..#..........
##O####...###
#.#...#...#.#
##O###O###O##
..#...#...#..
..#####...^..
For these intersections:

The top-left intersection is 2 units from the left of the image and 2 units from the top of the image, so its alignment parameter is 2 * 2 = 4.
The bottom-left intersection is 2 units from the left and 4 units from the top, so its alignment parameter is 2 * 4 = 8.
The bottom-middle intersection is 6 from the left and 4 from the top, so its alignment parameter is 24.
The bottom-right intersection's alignment parameter is 40.
To calibrate the cameras, you need the sum of the alignment parameters. In the above example, this is 76.

Run your ASCII program. What is the sum of the alignment parameters for the scaffold intersections?

Your puzzle answer was 10064.

--- Part Two ---
Now for the tricky part: notifying all the other robots about the solar flare. The vacuum robot can do this automatically if it gets into range of a robot. However, you can't see the other robots on the camera, so you need to be thorough instead: you need to make the vacuum robot visit every part of the scaffold at least once.

The vacuum robot normally wanders randomly, but there isn't time for that today. Instead, you can override its movement logic with new rules.

Force the vacuum robot to wake up by changing the value in your ASCII program at address 0 from 1 to 2. When you do this, you will be automatically prompted for the new movement rules that the vacuum robot should use. The ASCII program will use input instructions to receive them, but they need to be provided as ASCII code; end each line of logic with a single newline, ASCII code 10.

First, you will be prompted for the main movement routine. The main routine may only call the movement functions: A, B, or C. Supply the movement functions to use as ASCII text, separating them with commas (,, ASCII code 44), and ending the list with a newline (ASCII code 10). For example, to call A twice, then alternate between B and C three times, provide the string A,A,B,C,B,C,B,C and then a newline.

Then, you will be prompted for each movement function. Movement functions may use L to turn left, R to turn right, or a number to move forward that many units. Movement functions may not call other movement functions. Again, separate the actions with commas and end the list with a newline. For example, to move forward 10 units, turn left, move forward 8 units, turn right, and finally move forward 6 units, provide the string 10,L,8,R,6 and then a newline.

Finally, you will be asked whether you want to see a continuous video feed; provide either y or n and a newline. Enabling the continuous video feed can help you see what's going on, but it also requires a significant amount of processing power, and may even cause your Intcode computer to overheat.

Due to the limited amount of memory in the vacuum robot, the ASCII definitions of the main routine and the movement functions may each contain at most 20 characters, not counting the newline.

For example, consider the following camera feed:

#######...#####
#.....#...#...#
#.....#...#...#
......#...#...#
......#...###.#
......#.....#.#
^########...#.#
......#.#...#.#
......#########
........#...#..
....#########..
....#...#......
....#...#......
....#...#......
....#####......
In order for the vacuum robot to visit every part of the scaffold at least once, one path it could take is:

R,8,R,8,R,4,R,4,R,8,L,6,L,2,R,4,R,4,R,8,R,8,R,8,L,6,L,2
Without the memory limit, you could just supply this whole string to function A and have the main routine call A once. However, you'll need to split it into smaller parts.

One approach is:

Main routine: A,B,C,B,A,C
(ASCII input: 65, 44, 66, 44, 67, 44, 66, 44, 65, 44, 67, 10)
Function A:   R,8,R,8
(ASCII input: 82, 44, 56, 44, 82, 44, 56, 10)
Function B:   R,4,R,4,R,8
(ASCII input: 82, 44, 52, 44, 82, 44, 52, 44, 82, 44, 56, 10)
Function C:   L,6,L,2
(ASCII input: 76, 44, 54, 44, 76, 44, 50, 10)
Visually, this would break the desired path into the following parts:

A,        B,            C,        B,            A,        C
R,8,R,8,  R,4,R,4,R,8,  L,6,L,2,  R,4,R,4,R,8,  R,8,R,8,  L,6,L,2

CCCCCCA...BBBBB
C.....A...B...B
C.....A...B...B
......A...B...B
......A...CCC.B
......A.....C.B
^AAAAAAAA...C.B
......A.A...C.B
......AAAAAA#AB
........A...C..
....BBBB#BBBB..
....B...A......
....B...A......
....B...A......
....BBBBA......
Of course, the scaffolding outside your ship is much more complex.

As the vacuum robot finds other robots and notifies them of the impending solar flare, it also can't help but leave them squeaky clean, collecting any space dust it finds. Once it finishes the programmed set of movements, assuming it hasn't drifted off into space, the cleaning robot will return to its docking station and report the amount of space dust it collected as a large, non-ASCII value in a single output instruction.

After visiting every part of the scaffold at least once, how much dust does the vacuum robot report it has collected?

Your puzzle answer was 1197725.
*/

public class Day17 : Day
{
    private static bool PrintEnabled = true;

    public override string Title => "--- Day 17: Set and Forget ---";
    public List<Space> ExploredScaffolding;
    public VacuumRobot ExplorerBot;

    public override void PartOne()
    {
        base.PartOne();
        var input = Inputs.Day17.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
        var bot = new VacuumRobot(input);

        bot.ExploreWithIntCode();
        Print(bot.Grid, bot.CurrentCoordinate);
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

        Console.WriteLine(result);
    }

    private IEnumerable<long> GetRoutines()
    {
        var mainRoutine = "A,A,B,C,B,C,B,C,B,A\n";
        var functionA =
            "L,10,L,8,R,8,L,8,R,6\n"; //.Replace(",", " , ").Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);
        var functionB =
            "R,6,R,8,R,8\n"; //.Replace(",", " , ").Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        var functionC =
            "R,6,R,6,L,8,L,10\n"; //.Replace(",", " , ").Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        var end = "y\n";

        foreach (var c in mainRoutine)
        {
            yield return c;
        }

        foreach (var c in functionA)
        {
            yield return c;
        }

        foreach (var c in functionB)
        {
            yield return c;
        }

        foreach (var c in functionC)
        {
            yield return c;
        }

        foreach (var c in end)
        {
            yield return c;
        }
    }

    public static void Print(Grid<Coordinate, Space> grid, Coordinate bot)
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
                if (bot.X == j && bot.Y == i)
                {
                    Console.Write('B');
                    continue;
                }

                if (grid.TryGet(new Coordinate(j, i), out var space))
                {
                    var aa = space.Type == SpaceType.Scaffolding ? '#' : '.';
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
                var asChar = (char)locationState;

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
                var asChar = (char)locationState;

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

                var adjacent = allSpace.Count(a =>
                    a.Type == SpaceType.Scaffolding && space.Coordinate.IsAdjacent(a.Coordinate));

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