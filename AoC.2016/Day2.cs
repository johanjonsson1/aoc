namespace AoC2016;

/*
--- Day 2: Bathroom Security ---
You arrive at Easter Bunny Headquarters under cover of darkness. However, you left in such a rush that you forgot to use the bathroom! 
Fancy office buildings like this one usually have keypad locks on their bathrooms, so you search the front desk for the code.

"In order to improve security," the document you find says, "bathroom codes will no longer be written down. 
Instead, please memorize and follow the procedure below to access the bathrooms."

The document goes on to explain that each button to be pressed can be found by starting on the previous button and moving to adjacent buttons on the keypad:
U moves up, D moves down, L moves left, and R moves right. Each line of instructions corresponds to one button, starting at the previous button (or, for the first line, the "5" button); 
press whatever button you're on at the end of each line. If a move doesn't lead to a button, ignore it.

You can't hold it much longer, so you decide to figure out the code as you walk to the bathroom. You picture a keypad like this:

1 2 3
4 5 6
7 8 9
Suppose your instructions are:

ULL
RRDDD
LURDL
UUUUD
You start at "5" and move up (to "2"), left (to "1"), and left (you can't, and stay on "1"), so the first button is 1.
Starting from the previous button ("1"), you move right twice (to "3") and then down three times (stopping at "9" after two moves and ignoring the third), ending up with 9.
Continuing from "9", you move left, up, right, down, and left, ending with 8.
Finally, you move up four times (stopping at "2"), then down once, ending with 5.
So, in this example, the bathroom code is 1985.

Your puzzle input is the instructions from the document you found at the front desk. What is the bathroom code?

Your puzzle answer was 56855.

--- Part Two ---
You finally arrive at the bathroom (it's a several minute walk from the lobby so visitors can behold the many fancy conference rooms and water coolers on this floor) and go to punch in the code. 
Much to your bladder's dismay, the keypad is not at all like you imagined it. Instead, you are confronted with the result of hundreds of man-hours of bathroom-keypad-design meetings:

    1
  2 3 4
5 6 7 8 9
  A B C
    D
You still start at "5" and stop when you're at an edge, but given the same instructions as above, the outcome is very different:

You start at "5" and don't move at all (up and left are both edges), ending at 5.
Continuing from "5", you move right twice and down three times (through "6", "7", "B", "D", "D"), ending at D.
Then, from "D", you move five more times (through "D", "B", "C", "C", "B"), ending at B.
Finally, after five more moves, you end at 3.
So, given the actual keypad layout, the code would be 5DB3.

Using the same instructions in your puzzle input, what is the correct bathroom code?

Your puzzle answer was B3C27.
*/
public class Day2 : Day
{
    public override string Title => "--- Day 2: Bathroom Security ---";
    private static List<Button> _keyPad = new List<Button>
    {
        new Button { NumberOrChar = "5", Coordinate = new Coordinate(0,0)},
        new Button { NumberOrChar = "4", Coordinate = new Coordinate(-1,0)},
        new Button { NumberOrChar = "6", Coordinate = new Coordinate(1,0)},
        new Button { NumberOrChar = "1", Coordinate = new Coordinate(-1,1)},
        new Button { NumberOrChar = "2", Coordinate = new Coordinate(0,1)},
        new Button { NumberOrChar = "3", Coordinate = new Coordinate(1,1)},
        new Button { NumberOrChar = "7", Coordinate = new Coordinate(-1,-1)},
        new Button { NumberOrChar = "8", Coordinate = new Coordinate(0,-1)},
        new Button { NumberOrChar = "9", Coordinate = new Coordinate(1,-1)},
    };

    private static List<Button> _specialKeyPad = new List<Button>
    {
        new Button { NumberOrChar = "5", Coordinate = new Coordinate(0,0)},
        new Button { NumberOrChar = "6", Coordinate = new Coordinate(1,0)},
        new Button { NumberOrChar = "7", Coordinate = new Coordinate(2,0)},
        new Button { NumberOrChar = "8", Coordinate = new Coordinate(3,0)},
        new Button { NumberOrChar = "9", Coordinate = new Coordinate(4,0)},
        new Button { NumberOrChar = "2", Coordinate = new Coordinate(1,1)},
        new Button { NumberOrChar = "3", Coordinate = new Coordinate(2,1)},
        new Button { NumberOrChar = "4", Coordinate = new Coordinate(3,1)},
        new Button { NumberOrChar = "1", Coordinate = new Coordinate(2,2)},
        new Button { NumberOrChar = "A", Coordinate = new Coordinate(1,-1)},
        new Button { NumberOrChar = "B", Coordinate = new Coordinate(2,-1)},
        new Button { NumberOrChar = "C", Coordinate = new Coordinate(3,-1)},
        new Button { NumberOrChar = "D", Coordinate = new Coordinate(2,-2)}
    };

    public override void PartOne()
    {
        base.PartOne();
        //            var instructions = @"ULL
        //RRDDD
        //LURDL
        //UUUUD".ToStringList();
        var instructions = Inputs.Day2.ToStringList();
        KeypadInstruction.KeyPad = _keyPad;
        KeypadInstruction.CurrentButton = _keyPad.FirstOrDefault(x => x.NumberOrChar == "5");
        string result = TapKeys(instructions);

        Console.WriteLine("Result part 1");
        Console.WriteLine(result);
    }
    public override void PartTwo()
    {
        base.PartTwo();
        //            var instructions = @"ULL
        //RRDDD
        //LURDL
        //UUUUD".ToStringList();
        var instructions = Inputs.Day2.ToStringList();
        KeypadInstruction.KeyPad = _specialKeyPad;
        KeypadInstruction.CurrentButton = _keyPad.FirstOrDefault(x => x.NumberOrChar == "5");
        string result = TapKeys(instructions);

        Console.WriteLine("Result part 2");
        Console.WriteLine(result);
    }

    private static string TapKeys(List<string> instructions)
    {
        var result = "";

        foreach (var line in instructions)
        {
            KeypadInstruction.Move(line);
            Console.WriteLine(KeypadInstruction.CurrentButton.NumberOrChar);
            result += KeypadInstruction.CurrentButton.NumberOrChar;
        }

        return result;
    }

    public static class KeypadInstruction
    {
        public static List<Button> KeyPad { get; set; }
        public static Button CurrentButton { get; set; }

        public static void Move(string instruction)
        {
            for (int i = 0; i < instruction.Length; i++)
            {
                var next = instruction[i];
                Coordinate newCoordinate;

                switch (next)
                {
                    case 'R':
                        newCoordinate = new Coordinate(CurrentButton.Coordinate.X + 1, CurrentButton.Coordinate.Y);
                        break;
                    case 'L':
                        newCoordinate = new Coordinate(CurrentButton.Coordinate.X - 1, CurrentButton.Coordinate.Y);
                        break;
                    case 'U':
                        newCoordinate = new Coordinate(CurrentButton.Coordinate.X, CurrentButton.Coordinate.Y + 1);
                        break;
                    case 'D':
                        newCoordinate = new Coordinate(CurrentButton.Coordinate.X, CurrentButton.Coordinate.Y - 1);
                        break;
                    default:
                        throw new ArgumentException();
                }

                var match = KeyPad.FirstOrDefault(a => a.Coordinate.Equals(newCoordinate));

                if (match != null)
                {
                    CurrentButton = match;
                }
            }
        }
    }

    public class Button
    {
        public Coordinate Coordinate { get; set; }
        public string NumberOrChar { get; set; }
    }
}