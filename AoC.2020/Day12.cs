namespace AoC2020;

public class Day12 : Day
{
    public override string Title => "day 12";

    public override void PartOne()
    {
        base.PartOne();

        var input1 = @"F10
N3
F7
R90
F11";
        var input = Inputs.Day12.ToStringList();

        var navigator = new Navigator(new Coordinate(0, 0), Navigator.Face.Right);

        foreach (var instr in input)
        {
            var letter = instr[0];
            var number = int.Parse(instr[1..]);
            var oldFacing = navigator.Facing;

            switch (letter)
            {
                case 'N':
                    navigator.FaceTo(Navigator.Face.Up);
                    navigator.Move(number);
                    navigator.FaceTo(oldFacing);
                    break;
                case 'S':
                    navigator.FaceTo(Navigator.Face.Down);
                    navigator.Move(number);
                    navigator.FaceTo(oldFacing);
                    break;
                case 'E':
                    navigator.FaceTo(Navigator.Face.Right);
                    navigator.Move(number);
                    navigator.FaceTo(oldFacing);
                    break;
                case 'W':
                    navigator.FaceTo(Navigator.Face.Left);
                    navigator.Move(number);
                    navigator.FaceTo(oldFacing);
                    break;
                case 'L':
                {
                    var turns = number / 90;
                    for (var i = 0; i < turns; i++)
                    {
                        navigator.TurnLeft();
                    }

                    break;
                }
                case 'R':
                {
                    var turns = number / 90;
                    for (var i = 0; i < turns; i++)
                    {
                        navigator.TurnRight();
                    }

                    break;
                }
                case 'F':
                    navigator.Move(number);
                    break;
            }
        }

        var current = navigator.CurrentCoordinate;
        var manhattan = current.GetDistance(new Coordinate(0, 0));

        Console.WriteLine(manhattan);

        /*
Action N means to move north by the given value.
Action S means to move south by the given value.
Action E means to move east by the given value.
Action W means to move west by the given value.
Action L means to turn left the given number of degrees.
Action R means to turn right the given number of degrees.
Action F means to move forward by the given value in the direction the ship is currently facing.

         */
    }
}