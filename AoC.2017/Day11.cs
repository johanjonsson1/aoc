using System;
using System.Linq;
using AoC.Common;

namespace AoC2017
{
    /*
    --- Day 11: Hex Ed ---
    Crossing the bridge, you've barely reached the other side of the stream when a program comes up to you, clearly in distress.
    "It's my child process," she says, "he's gotten lost in an infinite grid!"

    Fortunately for her, you have plenty of experience with infinite grids.

    Unfortunately for you, it's a hex grid.

    The hexagons ("hexes") in this grid are aligned such that adjacent hexes can be found to the north, northeast, southeast, south, southwest, and northwest:

      \ n  /
    nw +--+ ne
      /    \
    -+      +-
      \    /
    sw +--+ se
      / s  \
    You have the path the child process took. Starting where he started, you need to determine the fewest number of steps required to reach him. 
    (A "step" means to move from the hex you are in to any adjacent hex.)

    For example:

    ne,ne,ne is 3 steps away.
    ne,ne,sw,sw is 0 steps away (back where you started).
    ne,ne,s,s is 2 steps away (se,se).
    se,sw,se,sw,sw is 3 steps away (s,s,sw).
    Your puzzle answer was 796.

    --- Part Two ---
    How many steps away is the furthest he ever got from his starting position?

    Your puzzle answer was 1585.
     */
    public class Day11 : Day
    {
        public override string Title => "--- Day 11: Hex Ed ---";
        public static Grid<Coordinate3D, Point3D<Hex>> Grid = new Grid<Coordinate3D, Point3D<Hex>>();

        public override void PartOne()
        {
            base.PartOne();
            //var input = "se,sw,se,sw,sw".Split(new [] { "," }, StringSplitOptions.RemoveEmptyEntries);
            var input = Inputs.Day11.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            var emptyHex = new Hex();

            var startHex = new Point3D<Hex>(0, 0, 0, emptyHex);
            Grid.Add(startHex.Coordinate, startHex);

            Point3D<Hex> current = startHex;
            for (int i = 0; i < input.Length; i++)
            {
                var adjacent = current.CreateAdjacent(input[i]);
                Grid.Add(adjacent.Coordinate, adjacent);

                current = adjacent;
            }

            Console.WriteLine("Result part 1");
            Console.WriteLine(HexExtensions.GetDistance(startHex, current));
        }

        public override void PartTwo()
        {
            base.PartTwo();
            int maxDistance = 0;

            var allPoints = Grid.GetAll();
            var start = allPoints.First();

            for (int i = 1; i < allPoints.Count; i++)
            {
                var distance = HexExtensions.GetDistance(start, allPoints[i]);

                if (distance > maxDistance)
                {
                    maxDistance = distance;
                }
            }

            Console.WriteLine("Result part 2");
            Console.WriteLine(maxDistance);
        }

        public class Hex
        {
        }
    }

    public static class HexExtensions
    {
        public static Point3D<Day11.Hex> CreateAdjacent(this Point3D<Day11.Hex> current, string identifier)
        {
            var c = current.Coordinate;

            switch (identifier)
            {
                case "n":
                    return new Point3D<Day11.Hex>(c.X, c.Y + 1, c.Z - 1, current.Item);
                case "ne":
                    return new Point3D<Day11.Hex>(c.X + 1, c.Y, c.Z - 1, current.Item);
                case "se":
                    return new Point3D<Day11.Hex>(c.X + 1, c.Y - 1, c.Z, current.Item);
                case "s":
                    return new Point3D<Day11.Hex>(c.X, c.Y - 1, c.Z + 1, current.Item);
                case "sw":
                    return new Point3D<Day11.Hex>(c.X - 1, c.Y, c.Z + 1, current.Item);
                case "nw":
                    return new Point3D<Day11.Hex>(c.X - 1, c.Y + 1, c.Z, current.Item);
                default:
                    throw new ArgumentException($"cant handle input {identifier}");
            }
        }

        public static int GetDistance(this Point3D<Day11.Hex> current, Point3D<Day11.Hex> target)
        {
            if (current.Coordinate.Equals(target.Coordinate))
            {
                return 0;
            }

            return current.GetDistance(target) / 2;
        }
    }
}