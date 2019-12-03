using System;
using System.Linq;
using AoC.Common;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day3 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = @"".ToStringList();
            //var input = Inputs.Day3.ToStringList();

            var wire1 = Inputs.Day3.Split(','); //"R8,U5,L5,D3".Split(',');
            var wire2 = Inputs.Day3_2.Split(','); //"U7,R6,D4,L4".Split(',');

            var counter = 0;
            var navigator = new Navigator(new Coordinate(0,0), Navigator.Face.Right);
            foreach (var instruction in wire1)
            {
                if (counter > 0)
                {
                    switch (instruction[0])
                    {
                        case 'R':
                            navigator.FaceTo(Navigator.Face.Right);
                            break;
                        case 'L':
                            navigator.FaceTo(Navigator.Face.Left);
                            break;
                        case 'U':
                            navigator.FaceTo(Navigator.Face.Up);
                            break;
                        case 'D':
                            navigator.FaceTo(Navigator.Face.Down);
                            break;
                    }
                }

                navigator.Move(Convert.ToInt32(instruction.RemoveAToZ()));
                counter++;
            }

            counter = 0;
            var navigator2 = new Navigator(new Coordinate(0, 0), Navigator.Face.Left);//Left
            foreach (var instruction in wire2)
            {
                if (counter > 0)
                {
                    switch (instruction[0])
                    {
                        case 'R':
                            navigator2.FaceTo(Navigator.Face.Right);
                            break;
                        case 'L':
                            navigator2.FaceTo(Navigator.Face.Left);
                            break;
                        case 'U':
                            navigator2.FaceTo(Navigator.Face.Up);
                            break;
                        case 'D':
                            navigator2.FaceTo(Navigator.Face.Down);
                            break;
                    }
                }

                navigator2.Move(Convert.ToInt32(instruction.RemoveAToZ()));
                counter++;
            }

            var center = new Coordinate(0,0);
            var intersections = navigator.VisitedCoordinates.Where(x => !x.Equals(center))
                .Intersect(navigator2.VisitedCoordinates, Coordinate.CoordinateComparer).OrderBy(o => o.GetDistance(center)).ToList();

            var coord1 = navigator.VisitedCoordinates.ToList();
            var coord2 = navigator2.VisitedCoordinates.ToList();

            var closest  = intersections.Select(o => coord1.IndexOf(o) + coord2.IndexOf(o)).OrderBy(i => i);

            Console.WriteLine(intersections.First().GetDistance(center));
            Console.WriteLine(closest.First());
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var input = @"".ToStringList();
            //var input = Inputs.Day3.ToStringList();

            Console.WriteLine();
        }
    }
}