using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC_2017
{
    /*
    --- Day 3: Spiral Memory ---

    You come across an experimental new kind of memory stored on an infinite two-dimensional grid.

    Each square on the grid is allocated in a spiral pattern starting at a location marked 1 and then counting up while spiraling outward. For example, the first few squares are allocated like this:

    17  16  15  14  13
    18   5   4   3  12
    19   6   1   2  11
    20   7   8   9  10
    21  22  23---> ...
    While this is very space-efficient (no squares are skipped), requested data must be carried back to square 1 (the location of the only access port for this memory system) by programs that can only move up, down, left, or right. They always take the shortest path: the Manhattan Distance between the location of the data and square 1.

    For example:

    Data from square 1 is carried 0 steps, since it's at the access port.
    Data from square 12 is carried 3 steps, such as: down, left, left.
    Data from square 23 is carried only 2 steps: up twice.
    Data from square 1024 must be carried 31 steps.
    How many steps are required to carry the data from the square identified in your puzzle input all the way to the access port?

    Your puzzle input is 265149.

    --- Part Two ---

    As a stress test on the system, the programs here clear the grid and then store the value 1 in square 1. 
    Then, in the same allocation order as shown above, they store the sum of the values in all adjacent squares, including diagonals.

    So, the first few squares' values are chosen as follows:

    Square 1 starts with the value 1.
    Square 2 has only one adjacent filled square (with value 1), so it also stores 1.
    Square 3 has both of the above squares as neighbors and stores the sum of their values, 2.
    Square 4 has all three of the aforementioned squares as neighbors and stores the sum of their values, 4.
    Square 5 only has the first and fourth squares as neighbors, so it gets the value 5.
    Once a square is written, its value does not change. Therefore, the first few squares would receive the following values:

    147  142  133  122   59
    304    5    4    2   57
    330   10    1    1   54
    351   11   23   25   26
    362  747  806--->   ...
    What is the first value written that is larger than your puzzle input?
     */

    public class Day3 : IDay
    {
        public string Title => "2017 - Day 3";

        public void Run()
        {
            PartOne();
            PartTwo();
        }

        private void PartOne()
        {
            Console.WriteLine("--- Day 3: Spiral Memory ---");

            var number = 1;
            var memory = new List<PointXY>();
            memory.Add(new PointXY { Id = 1, X = 0, Y = 0 });
            var navigator = new Navigator(0, 0);

            do
            {
                number++;
                var currentPosition = navigator.Move();
                currentPosition.Id = number;
                memory.Add(currentPosition);

            } while (number <= 265149);

            Console.WriteLine(GetDistanceForId(memory, 265149));
        }

        private void PartTwo()
        {
            Console.WriteLine("--- Part Two ---");

            var number = 1;
            var memory = new List<PointXY>();
            memory.Add(new PointXY { Id = 1, X = 0, Y = 0 });
            var navigator = new Navigator(0, 0);

            do
            {
                var currentPosition = navigator.Move();
                var a = memory.Where(x => (x.X == currentPosition.X || x.X == currentPosition.X - 1 || x.X == currentPosition.X + 1) && (x.Y == currentPosition.Y || x.Y == currentPosition.Y - 1 || x.Y == currentPosition.Y + 1));
                number = a.Sum(x => x.Id);
                currentPosition.Id = number;
                memory.Add(currentPosition);

            } while (number <= 265149);
            Console.WriteLine(number);
        }

        public int GetDistanceForId(List<PointXY> list, int id)
        {
            return list.Where(x => x.Id == id).Select(s => Math.Abs(s.X) + Math.Abs(s.Y)).First();
        }
    }

    public class PointXY
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class PointXYComparer : IEqualityComparer<PointXY>
    {
        public bool Equals(PointXY one, PointXY two)
        {
            if (one == null && two == null)
                return true;
            else if (one == null || two == null)
                return false;
            else if (one.X == two.X && one.Y == two.Y && one.Id == two.Id)
                return true;
            else
                return false;
        }

        public int GetHashCode(PointXY obj)
        {
            int hCode = obj.X ^ obj.Y ^ obj.Id;
            return hCode.GetHashCode();
        }
    }

    public enum HeadingX
    {
        Plus,
        Minus,
        None
    }

    public enum HeadingY
    {
        Plus,
        Minus,
        None
    }

    public class Navigator 
    {
        private int _currentPositionX = 0;
        private int _currentPositionY = 0;
        private int _maxX = 0;
        private int _maxY = 0;
        private int _minX = 0;
        private int _minY = 0;
        private HeadingX _headingX = HeadingX.Plus;
        private HeadingY _headingY = HeadingY.None;

        public Navigator(int startingPositionX, int startingPositionY)
        {
            _currentPositionX = startingPositionX;
            _currentPositionY = startingPositionY;
        }

        public PointXY Move()
        {
            switch (_headingX)
            {
                case HeadingX.Plus:
                    _currentPositionX++;
                    break;
                case HeadingX.Minus:
                    _currentPositionX--;
                    break;
                case HeadingX.None:
                    break;
                default:
                    break;
            }

            switch (_headingY)
            {
                case HeadingY.Plus:
                    _currentPositionY++;
                    break;
                case HeadingY.Minus:
                    _currentPositionY--;
                    break;
                case HeadingY.None:
                    break;
                default:
                    break;
            }

            if (_currentPositionX == _maxX+1)
            {
                _maxX = _currentPositionX;
                FaceUp();
            }
            else if (_currentPositionX == _minX-1)
            {
                _minX = _currentPositionX;
                FaceDown();
            }

            if (_currentPositionY == _maxY + 1)
            {
                _maxY = _currentPositionY;
                FaceLeft();
            }
            else if (_currentPositionY == _minY - 1)
            {
                _minY = _currentPositionY;
                FaceRight();
            }

            return new PointXY { X = _currentPositionX, Y = _currentPositionY };
        }

        private void FaceUp()
        {
            _headingX = HeadingX.None;
            _headingY = HeadingY.Plus;
        }

        private void FaceRight()
        {
            _headingX = HeadingX.Plus;
            _headingY = HeadingY.None;
        }

        private void FaceDown()
        {
            _headingX = HeadingX.None;
            _headingY = HeadingY.Minus;
        }

        private void FaceLeft()
        {
            _headingX = HeadingX.Minus;
            _headingY = HeadingY.None;
        }
    }
}
