namespace AoC2017;
/*
--- Day 22: Sporifica Virus ---
Diagnostics indicate that the local grid computing cluster has been contaminated with the Sporifica Virus. 
The grid computing cluster is a seemingly-infinite two-dimensional grid of compute nodes. 
Each node is either clean or infected by the virus.

To prevent overloading the nodes (which would render them useless to the virus) or detection by system administrators, exactly one virus carrier moves through the network, infecting or cleaning nodes as it moves. 
The virus carrier is always located on a single node in the network (the current node) and keeps track of the direction it is facing.

To avoid detection, the virus carrier works in bursts; in each burst, it wakes up, does some work, and goes back to sleep. 
The following steps are all executed in order one time each burst:

If the current node is infected, it turns to its right. Otherwise, it turns to its left. (Turning is done in-place; the current node does not change.)
If the current node is clean, it becomes infected. Otherwise, it becomes cleaned. (This is done after the node is considered for the purposes of changing direction.)
The virus carrier moves forward one node in the direction it is facing.
Diagnostics have also provided a map of the node infection status (your puzzle input). Clean nodes are shown as .; infected nodes are shown as #. 
This map only shows the center of the grid; there are many more nodes beyond those shown, but none of them are currently infected.

The virus carrier begins in the middle of the map facing up.

For example, suppose you are given a map like this:

..#
#..
...
Then, the middle of the infinite grid looks like this, with the virus carrier's position marked with [ ]:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . # . . .
. . . #[.]. . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
The virus carrier is on a clean node, so it turns left, infects the node, and moves left:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . # . . .
. . .[#]# . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
The virus carrier is on an infected node, so it turns right, cleans the node, and moves up:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . .[.]. # . . .
. . . . # . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
Four times in a row, the virus carrier finds a clean, infects it, turns left, and moves forward, ending in the same place and still facing up:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . #[#]. # . . .
. . # # # . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
Now on the same node as before, it sees an infection, which causes it to turn right, clean the node, and move forward:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . # .[.]# . . .
. . # # # . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
After the above actions, a total of 7 bursts of activity had taken place. Of them, 5 bursts of activity caused an infection.

After a total of 70, the grid looks like this, with the virus carrier facing up:

. . . . . # # . .
. . . . # . . # .
. . . # . . . . #
. . # . #[.]. . #
. . # . # . . # .
. . . . . # # . .
. . . . . . . . .
. . . . . . . . .
By this time, 41 bursts of activity caused an infection (though most of those nodes have since been cleaned).

After a total of 10000 bursts of activity, 5587 bursts will have caused an infection.

Given your actual map, after 10000 bursts of activity, how many bursts cause a node to become infected? (Do not count nodes that begin infected.)

Your puzzle answer was 5575.

--- Part Two ---
As you go to remove the virus from the infected nodes, it evolves to resist your attempt.

Now, before it infects a clean node, it will weaken it to disable your defenses. 
If it encounters an infected node, it will instead flag the node to be cleaned in the future. So:

Clean nodes become weakened.
Weakened nodes become infected.
Infected nodes become flagged.
Flagged nodes become clean.
Every node is always in exactly one of the above states.

The virus carrier still functions in a similar way, but now uses the following logic during its bursts of action:

Decide which way to turn based on the current node:
If it is clean, it turns left.
If it is weakened, it does not turn, and will continue moving in the same direction.
If it is infected, it turns right.
If it is flagged, it reverses direction, and will go back the way it came.
Modify the state of the current node, as described above.
The virus carrier moves forward one node in the direction it is facing.
Start with the same map (still using . for clean and # for infected) and still with the virus carrier starting in the middle and facing up.

Using the same initial state as the previous example, and drawing weakened as W and flagged as F, the middle of the infinite grid looks like this, with the virus carrier's position again marked with [ ]:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . # . . .
. . . #[.]. . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
This is the same as before, since no initial nodes are weakened or flagged. The virus carrier is on a clean node, so it still turns left, instead weakens the node, and moves left:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . # . . .
. . .[#]W . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
The virus carrier is on an infected node, so it still turns right, instead flags the node, and moves up:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . .[.]. # . . .
. . . F W . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
This process repeats three more times, ending on the previously-flagged node and facing right:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . W W . # . . .
. . W[F]W . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
Finding a flagged node, it reverses direction and cleans the node:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . W W . # . . .
. .[W]. W . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
The weakened node becomes infected, and it continues in the same direction:

. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
. . W W . # . . .
.[.]# . W . . . .
. . . . . . . . .
. . . . . . . . .
. . . . . . . . .
Of the first 100 bursts, 26 will result in infection. Unfortunately, another feature of this evolved virus is speed; of the first 10000000 bursts, 2511944 will result in infection.

Given your actual map, after 10000000 bursts of activity, how many bursts cause a node to become infected? (Do not count nodes that begin infected.)

Your puzzle answer was 2511991.
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
        var centerY = (int)currentGrid.Average(a => a.Coordinate.Y);
        var centerX = (int)currentGrid.Average(a => a.Coordinate.X);
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
        // use evolvedcarrier in part 1
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
                else if (grid.TryGet(currentCoordinate, out var node))
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
    public Node CurrentNode { get; private set; }
    protected readonly AoC.Common.Navigator Navigator;

    public VirusCarrier(Coordinate startCoordinate, Node startNode, Grid<Coordinate, Node> grid)
    {
        Navigator = new AoC.Common.Navigator(startCoordinate, AoC.Common.Navigator.Face.Up);
        _grid = grid;
        CurrentCoordinate = startCoordinate;
        CurrentNode = startNode;
    }

    public virtual void PerformBurst()
    {
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