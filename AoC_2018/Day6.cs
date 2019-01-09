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
    public class Day6 : Day
    {
        public override string Title => "2018 - Day 6";

        public int MinX;
        public int MinY;
        public int MaxX;
        public int MaxY;
        public List<RealPoint> _realPoints = new List<RealPoint>();
        public List<RealPoint> _pointsOrderedX = new List<RealPoint>();
        public List<RealPoint> _pointsOrderedY = new List<RealPoint>();
        public List<Point> _grid = new List<Point>();
        public PointEqualityComparer _comparer = new PointEqualityComparer();
        public static object _lock = new object();
        public List<Point> _pointsWithinDistance = new List<Point>();
        private const int _limit = 10000; //32

        public override void PartOne()
        {
            base.PartOne();
            return;
            PopulatePoints();

            foreach (var p in _grid)
            {
                var expandIndex = 0;
                while (true)
                {
                    if (expandIndex == 0)
                    {
                        var realPoint = _realPoints.FirstOrDefault(x => x.Equals(p));
                        if (realPoint == null)
                        {
                            expandIndex++;
                            continue;
                        }

                        AddToArea(realPoint, p);
                        break;
                    }

                    var borderPointsToCheck = new List<Point>();

                    // upper right corner
                    var yStart = p.Y - expandIndex;
                    var xStart = p.X;
                    while (yStart < p.Y)
                    {
                        borderPointsToCheck.Add(new Point(xStart, yStart));
                        xStart++;
                        yStart++;
                    }

                    // lower right corner
                    xStart = p.X + expandIndex;
                    yStart = p.Y;
                    while (xStart > p.X)
                    {
                        borderPointsToCheck.Add(new Point(xStart, yStart));
                        xStart--;
                        yStart++;
                    }

                    // lower left corner
                    yStart = p.Y + expandIndex;
                    xStart = p.X;
                    while (yStart > p.Y)
                    {
                        borderPointsToCheck.Add(new Point(xStart, yStart));
                        xStart--;
                        yStart--;
                    }

                    // upper left corner
                    xStart = p.X - expandIndex;
                    yStart = p.Y;
                    while (xStart < p.X)
                    {
                        borderPointsToCheck.Add(new Point(xStart, yStart));
                        xStart++;
                        yStart--;
                    }

                    var matches = (from bp in borderPointsToCheck
                                   join rp in _realPoints on new { bp.X, bp.Y } equals new { rp.X, rp.Y }
                                   select rp).ToList();

                    if (matches.Count == 1)
                    {
                        AddToArea(matches.First(), p);
                        break;
                    }
                    else if (matches.Count > 1)
                    {
                        foreach (var item in matches)
                        {
                            item.CollidingArea.Add(p);
                        }

                        break;
                    }

                    expandIndex++;
                }
            }

            var result = _realPoints.Where(x => x.Infinite == false).OrderByDescending(o => o.Area.Count).ToList();

            Console.WriteLine(result.First().Area.Count);
        }

        private void AddToArea(RealPoint rp, Point p)
        {
            rp.Area.Add(p);

            if (p.X >= MaxX || p.X <= MinX || p.Y >= MaxY || p.Y <= MinY)
            {
                rp.Infinite = true;
            }
            else if (rp.X == MaxX || rp.X == MinX || rp.Y == MaxY || rp.Y == MinY)
            {
                rp.Infinite = true;
            }
        }

        private void PopulatePoints()
        {
            var counter = 0;
            foreach (var line in Inputs.Day6.ToStringList())
            {
                var arr = line.SplitAsIntsBy(',');
                var x = arr[0];
                var y = arr[1];
                _realPoints.Add(new RealPoint(++counter, x, y));
            }

            _pointsOrderedX = _realPoints.OrderByDescending(o => o.X).ToList();
            _pointsOrderedY = _realPoints.OrderByDescending(o => o.Y).ToList();
            MinX = _pointsOrderedX.Last().X;
            MinY = _pointsOrderedY.Last().Y;
            MaxX = _pointsOrderedX.First().X;
            MaxY = _pointsOrderedY.First().Y;

            for (int x = MinX; x < MaxX; x++)
            {
                for (int y = MinY; y < MaxY; y++)
                {
                    _grid.Add(new Point(x, y));
                }
            }
        }

        public override void PartTwo()
        {
            base.PartTwo();
            PopulatePoints();

            Parallel.ForEach(_grid, p =>
            {
                if (AllWithinDistance(p, _realPoints))
                {
                    AddPoint(p);
                }
            });

            Console.WriteLine(_pointsWithinDistance.Count);
        }

        private bool AllWithinDistance(Point p, List<RealPoint> realPoints)
        {
            var totalDistance = 0;

            foreach (var rp in realPoints)
            {
                totalDistance += Math.Abs(p.X - rp.X) + Math.Abs(p.Y - rp.Y);
                if (totalDistance >= _limit)
                {
                    return false;
                }
            }

            return true;
        }

        public void AddPoint(Point point)
        {
            lock (_lock)
            {
                _pointsWithinDistance.Add(point);
            }
        }
    }












    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            var point = obj as Point;
            return point != null &&
                   X == point.X &&
                   Y == point.Y;
        }
    }

    public class RealPoint : Point
    {
        public int Id;
        public HashSet<Point> Area = new HashSet<Point>(new PointEqualityComparer());
        public List<Point> CollidingArea = new List<Point>();
        public bool Infinite = false;

        public RealPoint(int id, int x, int y) : base(x, y)
        {
            Id = id;
            //Area.Add(new Point(x, y));
        }
    }

    public class PointEqualityComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point b1, Point b2)
        {
            if (b2 == null && b1 == null)
                return true;
            else if (b1 == null || b2 == null)
                return false;
            else if (b1.X == b2.X && b1.Y == b2.Y)
                return true;
            else
                return false;
        }

        public int GetHashCode(Point bx)
        {
            int hCode = bx.X ^ bx.Y;
            return hCode.GetHashCode();
        }
    }
}