namespace AoC2019;
/*
--- Day 13: Care Package ---
As you ponder the solitude of space and the ever-increasing three-hour roundtrip for messages between you and Earth, you notice that the Space Mail Indicator Light is blinking. 
To help keep you sane, the Elves have sent you a care package.

It's a new game for the ship's arcade cabinet! Unfortunately, the arcade is all the way on the other end of the ship. 
Surely, it won't be hard to build your own - the care package even comes with schematics.

The arcade cabinet runs Intcode software like the game the Elves sent (your puzzle input). It has a primitive screen capable of drawing square tiles on a grid. 
The software draws tiles to the screen with output instructions: every three output instructions specify the x position (distance from the left), y position (distance from the top), and tile id. 
The tile id is interpreted as follows:

0 is an empty tile. No game object appears in this tile.
1 is a wall tile. Walls are indestructible barriers.
2 is a block tile. Blocks can be broken by the ball.
3 is a horizontal paddle tile. The paddle is indestructible.
4 is a ball tile. The ball moves diagonally and bounces off objects.
For example, a sequence of output values like 1,2,3,6,5,4 would draw a horizontal paddle tile (1 tile from the left and 2 tiles from the top) and a ball tile (6 tiles from the left and 5 tiles from the top).

Start the game. How many block tiles are on the screen when the game exits?

Your puzzle answer was 298.

--- Part Two ---
The game didn't run because you didn't put in any quarters. Unfortunately, you did not bring any quarters. 
Memory address 0 represents the number of quarters that have been inserted; set it to 2 to play for free.

The arcade cabinet has a joystick that can move left and right. The software reads the position of the joystick with input instructions:

If the joystick is in the neutral position, provide 0.
If the joystick is tilted to the left, provide -1.
If the joystick is tilted to the right, provide 1.
The arcade cabinet also has a segment display capable of showing a single number that represents the player's current score. 
When three output instructions specify X=-1, Y=0, the third output instruction is not a tile; the value instead specifies the new score to show in the segment display. 
For example, a sequence of output values like -1,0,12345 would show 12345 as the player's current score.

Beat the game by breaking all the blocks. What is your score after the last block is broken?

Your puzzle answer was 13956.
*/

public class Day13 : Day
{
    public override string Title => "--- Day 13: Care Package ---";
    private const bool PrintEnabled = false;

    public override void PartOne()
    {
        base.PartOne();
        var input = Inputs.Day13.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
        var intCodeMachine = new IntCodeProgram(input);
        var list = new List<Tile>();

        while (!intCodeMachine.IsTerminated)
        {
            var outputs = new List<long>();

            for (var i = 0; i < 3; i++)
            {
                intCodeMachine.LoopUntilHalt(0);
                outputs.Add(intCodeMachine.Output);
            }

            list.Add(new Tile(outputs[0], outputs[1], outputs[2]));
        }

        Print(list);
        var result = list.Count(c => c.Id == TileId.Block);
        Console.WriteLine(result);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var input = Inputs.Day13.SplitAsLongsBy(',').ToArray().ExpandTo(100000);
        input[0] = 2;
        var intCodeMachine = new IntCodeProgram(input);
        var list = new List<Tile>();

        var ballMove = 0;
        var scores = new List<long>();

        while (!intCodeMachine.IsTerminated)
        {
            var outputs = new List<long>();
            var ball = list.LastOrDefault(l => l.Id == TileId.Ball);
            var paddle = list.LastOrDefault(l => l.Id == TileId.Paddle);

            for (var i = 0; i < 3; i++)
            {
                var joystick = 0;
                if (ball != null && paddle != null)
                {
                    if (ball.Coordinate.X > paddle.Coordinate.X)
                    {
                        joystick = 1;
                    }
                    else if (ball.Coordinate.X < paddle.Coordinate.X)
                    {
                        joystick = -1;
                    }
                }

                intCodeMachine.LoopUntilHalt(joystick);
                outputs.Add(intCodeMachine.Output);
            }

            var x = outputs[0];
            var y = outputs[1];
            var idOrScore = outputs[2];
            if (x == -1 && y == 0)
            {
                scores.Add(idOrScore);
                continue;
            }

            list.Add(new Tile(outputs[0], outputs[1], outputs[2]));
            if (idOrScore != 4)
            {
                continue;
            }

            if (ballMove % 30 == 0)
            {
                Print(list);
            }

            ballMove++;
        }

        Print(list);
        var result = scores.Last();
        Console.WriteLine(result);
    }

    private void Print(List<Tile> tiles)
    {
        if (!PrintEnabled)
            return;

        var maxY = tiles.Max(x => x.Coordinate.Y);
        var minY = tiles.Min(x => x.Coordinate.Y);
        var maxX = tiles.Max(x => x.Coordinate.X);
        var minX = tiles.Min(x => x.Coordinate.X);

        Console.WriteLine();
        for (var i = minY; i <= maxY; i++)
        {
            for (var j = minX; j <= maxX; j++)
            {
                var foundTile = tiles.LastOrDefault(f => f.Coordinate.Y == i && f.Coordinate.X == j);

                if (foundTile == null)
                {
                    Console.Write('.');
                    continue;
                }

                Console.Write(GetSymbol(foundTile.Id));
            }

            Console.WriteLine();
        }

        char GetSymbol(TileId id)
        {
            switch (id)
            {
                case TileId.Empty:
                    return '.';
                case TileId.Wall:
                    return '|';
                case TileId.Block:
                    return '#';
                case TileId.Paddle:
                    return '-';
                case TileId.Ball:
                    return 'o';
                default:
                    throw new ArgumentOutOfRangeException(nameof(id), id, null);
            }
        }
    }
}

public class Tile
{
    public Coordinate Coordinate { get; }
    public TileId Id { get; }

    public Tile(long x, long y, long id)
    {
        Coordinate = new Coordinate((int)x, (int)y);
        Id = (TileId)(int)id;
    }
}

public enum TileId
{
    Empty = 0,
    Wall = 1,
    Block = 2,
    Paddle = 3,
    Ball = 4
}