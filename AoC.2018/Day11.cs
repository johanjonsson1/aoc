using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AoC.Common;

namespace AoC2018
{
    /*
    --- Day 11: Chronal Charge ---
    You watch the Elves and their sleigh fade into the distance as they head toward the North Pole.
    Actually, you're the one fading. The falling sensation returns.
    The low fuel warning light is illuminated on your wrist-mounted device.
    Tapping it once causes it to project a hologram of the situation: 
    a 300x300 grid of fuel cells and their current power levels, some negative. 
    You're not sure what negative power means in the context of time travel, but it can't be good.

    Each fuel cell has a coordinate ranging from 1 to 300 in both the X (horizontal) and Y (vertical) direction. 
    In X,Y notation, the top-left cell is 1,1, and the top-right cell is 300,1.

    The interface lets you select any 3x3 square of fuel cells. 
    To increase your chances of getting to your destination, you decide to choose the 3x3 square with the largest total power.

    The power level in a given fuel cell can be found through the following process:

    Find the fuel cell's rack ID, which is its X coordinate plus 10.
    Begin with a power level of the rack ID times the Y coordinate.
    Increase the power level by the value of the grid serial number (your puzzle input).
    Set the power level to itself multiplied by the rack ID.
    Keep only the hundreds digit of the power level (so 12345 becomes 3; numbers with no hundreds digit become 0).
    Subtract 5 from the power level.
    For example, to find the power level of the fuel cell at 3,5 in a grid with serial number 8:

    The rack ID is 3 + 10 = 13.
    The power level starts at 13 * 5 = 65.
    Adding the serial number produces 65 + 8 = 73.
    Multiplying by the rack ID produces 73 * 13 = 949.
    The hundreds digit of 949 is 9.
    Subtracting 5 produces 9 - 5 = 4.
    So, the power level of this fuel cell is 4.

    Here are some more example power levels:

    Fuel cell at  122,79, grid serial number 57: power level -5.
    Fuel cell at 217,196, grid serial number 39: power level  0.
    Fuel cell at 101,153, grid serial number 71: power level  4.
    Your goal is to find the 3x3 square which has the largest total power. 
    The square must be entirely within the 300x300 grid. 
    Identify this square using the X,Y coordinate of its top-left fuel cell. For example:

    For grid serial number 18, the largest total 3x3 square has a top-left corner of 33,45 (with a total power of 29); 
    these fuel cells appear in the middle of this 5x5 region:

    -2  -4   4   4   4
    -4   4   4   4  -5
     4   3   3   4  -4
     1   1   2   4  -3
    -1   0   2  -5  -2

    For grid serial number 42, the largest 3x3 square's top-left is 21,61 (with a total power of 30); 
    they are in the middle of this region:

    -3   4   2   2   2
    -4   4   3   3   4
    -5   3   3   4  -4
     4   3   3   4  -3
     3   3   3  -5  -1
    What is the X,Y coordinate of the top-left fuel cell of the 3x3 square with the largest total power?

    Your puzzle answer was 20,46.

    --- Part Two ---
    You discover a dial on the side of the device; it seems to let you select a square of any size, not just 3x3. Sizes from 1x1 to 300x300 are supported.

    Realizing this, you now must find the square of any size with the largest total power. 
    Identify this square by including its size as a third parameter after the top-left coordinate: a 9x9 square with a top-left corner of 3,5 is identified as 3,5,9.

    For example:

    For grid serial number 18, the largest total square (with a total power of 113) is 16x16 and has a top-left corner of 90,269, so its identifier is 90,269,16.
    For grid serial number 42, the largest total square (with a total power of 119) is 12x12 and has a top-left corner of 232,251, so its identifier is 232,251,12.
    What is the X,Y,size identifier of the square with the largest total power?

    Your puzzle answer was 231,65,14.
    */

    public class Day11 : Day
    {
        public static int MaxX = 300;
        public static int MaxY = 300;
        public static int StartIndex = 1;
        public static object Lock = new object();
        public static Point300 Max = null;
        public static int TotalPower = int.MinValue;
        public static int SquareEdgeSize = 0;

        public override string Title => "2018 - Day 11: Chronal Charge";

        public override void PartOne()
        {
            base.PartOne();
            var allPoints = new List<Point300>();
            var serial = 4151;
            Populate(allPoints, serial);

            //var test = allPoints.Where(p => p.X == 3 && p.Y == 5).First(); // 8
            //var test = allPoints.Where(p => p.X == 122 && p.Y == 79).First(); // 57
            //var test = allPoints.Where(p => p.X == 217 && p.Y == 196).First(); // 39
            //var test = allPoints.Where(p => p.X == 101 && p.Y == 153).First(); // 8
            //var a = test.PowerLevel;

            Console.WriteLine();
            Point300 max = null;
            int totalPower = int.MinValue;

            foreach (var point300 in allPoints)
            {
                if (point300.Id % 10000 == 0)
                {
                    Console.Write(".");
                }

                var powerLevel = point300.GetTotalPowerLevel(allPoints);
                if (powerLevel > totalPower)
                {
                    totalPower = powerLevel;
                    max = point300;
                }
            }

            if (max != null) Console.WriteLine(totalPower + " at " + max.X + ", " + max.Y); // 20,46
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var allPoints = new List<Point300>();
            var serial = 4151;
            Populate(allPoints, serial);

            Console.WriteLine();

            Parallel.ForEach(allPoints, point300 =>
            {
                if (point300.Id % 10000 == 0)
                {
                    Console.Write(".");
                }

                for (int edge = 300; edge > 1; edge--)
                {
                    var powerLevel = point300.GetTotalPowerLevel(allPoints, edge, edge - 1);
                    CheckValue(point300, powerLevel, edge);
                }
            });

            if (Max != null) Console.WriteLine(TotalPower + " at " + Max.X + ", " + Max.Y + ", " + SquareEdgeSize); // 231,65,14
        }

        private static void CheckValue(Point300 point, int totalValue, int squareEdge)
        {
            lock (Lock)
            {
                if (totalValue > TotalPower)
                {
                    TotalPower = totalValue;
                    Max = point;
                    SquareEdgeSize = squareEdge;
                }
            }
        }

        private static void Populate(List<Point300> allPoints, int serial)
        {
            var idCounter = 1;

            for (int x = StartIndex; x <= MaxX; x++)
            {
                for (int y = StartIndex; y <= MaxY; y++)
                {
                    allPoints.Add(new Point300(idCounter, x, y, serial));
                    idCounter++;
                }
            }
        }
    }

    public class Point300
    {
        public int Id;
        public int RackId;
        public int X;
        public int Y;
        public int PowerLevel;
        private int _serialNo;

        private static int _squareEdge = 3;
        private static int _squareEdgeDiff = 2;

        public Point300(int id, int x, int y, int serial)
        {
            Id = id;
            RackId = x + 10;
            X = x;
            Y = y;
            _serialNo = serial;
            PowerLevel = GetPowerLevel();
        }

        private int GetPowerLevel()
        {
            /*The rack ID is 3 + 10 = 13.
            The power level starts at 13 * 5 = 65.
            Adding the serial number produces 65 + 8 = 73.
            Multiplying by the rack ID produces 73 * 13 = 949.
            The hundreds digit of 949 is 9.
            Subtracting 5 produces 9 - 5 = 4.
            */

            var pl = RackId * Y;
            pl += _serialNo;
            pl *= RackId;

            if (pl < 100)
            {
                return 0;
            }

            if (pl < 1000)
            {
                return Convert.ToInt32(pl.ToString().Substring(0, 1)) - 5;
            }

            var allDigits = pl.ToString().ToInts();
            return allDigits[allDigits.Count - 3] - 5;
        }

        public int GetTotalPowerLevel(List<Point300> points)
        {
            var mySquare = GetNeighbours(points);

            if (mySquare.Any())
            {
                return mySquare.Sum(s => s.PowerLevel) + PowerLevel;
            }

            return 0;
        }

        public int GetTotalPowerLevel(List<Point300> points, int squareEdge, int squareEdgeDiff)
        {
            if (X + squareEdge-1 > Day11.MaxX || Y + squareEdge-1 > Day11.MaxY)
            {
                return 0;
            }

            var neighbours = points.Where(p => p.Id != Id &&
                                    p.X >= X && p.X <= X + squareEdgeDiff &&
                                    p.Y >= Y && p.Y <= Y + squareEdgeDiff).ToList();

            var validNumbers = squareEdge * squareEdge - 1;
            if (neighbours.Count != validNumbers)
            {
                return 0;
            }

            return neighbours.Sum(s => s.PowerLevel) + PowerLevel;
        }

        public List<Point300> GetNeighbours(List<Point300> points)
        {
            var neighbours = points.Where(p => p.Id != Id &&
                                p.X >= X && p.X <= X + _squareEdgeDiff &&
                                p.Y >= Y && p.Y <= Y + _squareEdgeDiff).ToList();

            var validNumbers = _squareEdge * _squareEdge - 1;
            if (neighbours.Count != validNumbers)
            {
                return new List<Point300>();
            }

            return neighbours;
        }
    }
}