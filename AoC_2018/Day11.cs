using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /* 
    */

    public class Day11 : Day
    {
        public static int MaxX = 300;
        public static int MaxY = 300;
        public static int StartIndex = 1;

        public static object _lock = new object();
        public static Point300 _max = null;
        public static int _totalPower = int.MinValue;
        public static int _squareEdgeSize = 0;

        public override string Title => "2018 - Day 11";

        public override void PartOne()
        {
            base.PartOne();
            return;
            var allPoints = new List<Point300>();
            var serial = 4151;
            Populate(allPoints, serial);

            //var test = allPoints.Where(p => p.X == 3 && p.Y == 5).First(); // 8
            //var test = allPoints.Where(p => p.X == 122 && p.Y == 79).First(); // 57
            //var test = allPoints.Where(p => p.X == 217 && p.Y == 196).First(); // 39
            //var test = allPoints.Where(p => p.X == 101 && p.Y == 153).First(); // 8
            //test.GetPowerLevel();

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

            if (max != null) Console.WriteLine(totalPower + " at " + max.X + ", " + max.Y);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var allPoints = new List<Point300>();
            var serial = 4151;
            Populate(allPoints, serial);

            //var test = allPoints.Where(p => p.X == 3 && p.Y == 5).First(); // 8
            //var test = allPoints.Where(p => p.X == 122 && p.Y == 79).First(); // 57
            //var test = allPoints.Where(p => p.X == 217 && p.Y == 196).First(); // 39
            //var test = allPoints.Where(p => p.X == 101 && p.Y == 153).First(); // 8
            //test.GetPowerLevel();

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

            if (_max != null) Console.WriteLine(_totalPower + " at " + _max.X + ", " + _max.Y + ", " + _squareEdgeSize);
        }

        private static void CheckValue(Point300 point, int totalValue, int squareEdge)
        {
            lock (_lock)
            {
                if (totalValue > _totalPower)
                {
                    _totalPower = totalValue;
                    _max = point;
                    _squareEdgeSize = squareEdge;
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
        private int SerialNo;

        private static int _squareEdge = 3;
        private static int _squareEdgeDiff = 2;

        public Point300(int id, int x, int y, int serial)
        {
            Id = id;
            RackId = x + 10;
            X = x;
            Y = y;
            SerialNo = serial;
            PowerLevel = GetPowerLevel();
        }

        public int GetPowerLevel()
        {
            /*The rack ID is 3 + 10 = 13.
            The power level starts at 13 * 5 = 65.
            Adding the serial number produces 65 + 8 = 73.
            Multiplying by the rack ID produces 73 * 13 = 949.
            The hundreds digit of 949 is 9.
            Subtracting 5 produces 9 - 5 = 4.
            */

            var pl = RackId * Y;
            pl += SerialNo;
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