namespace AoC2016;

/*
Finally, you come across an information kiosk with a list of rooms. Of course, the list is encrypted and full of decoy data, but the instructions to decode the list are barely hidden nearby. Better remove the decoy data first.

Each room consists of an encrypted name (lowercase letters separated by dashes) followed by a dash, a sector ID, and a checksum in square brackets.

A room is real (not a decoy) if the checksum is the five most common letters in the encrypted name, in order, with ties broken by alphabetization. For example:

aaaaa-bbb-z-y-x-123[abxyz] is a real room because the most common letters are a (5), b (3), and then a tie between x, y, and z, which are listed alphabetically.
a-b-c-d-e-f-g-h-987[abcde] is a real room because although the letters are all tied (1 of each), the first five are listed alphabetically.
not-a-real-room-404[oarel] is a real room.
totally-real-room-200[decoy] is not.
Of the real rooms from the list above, the sum of their sector IDs is 1514.

What is the sum of the sector IDs of the real rooms?

Your puzzle answer was 173787.

The first half of this puzzle is complete! It provides one gold star: *

--- Part Two ---
With all the decoy data out of the way, it's time to decrypt this list and get moving.

The room names are encrypted by a state-of-the-art shift cipher, which is nearly unbreakable without the right software. 
However, the information kiosk designers at Easter Bunny HQ were not expecting to deal with a master cryptographer like yourself.

To decrypt a room name, rotate each letter forward through the alphabet a number of times equal to the room's sector ID. 
A becomes B, B becomes C, Z becomes A, and so on. Dashes become spaces.

For example, the real name for qzmt-zixmtkozy-ivhz-343 is very encrypted name.

What is the sector ID of the room where North Pole objects are stored?
*/
public class Day4 : Day
{
    public override string Title => "--- Day 4: Security Through Obscurity ---";

    private List<Room> _realRooms;

    public override void PartOne()
    {
        base.PartOne();
        //var input = "totally-real-room-200[decoy]";
        var input = Inputs.Day4.ToStringList();
        var rooms = new List<Room>();

        foreach (var line in input)
        {
            rooms.Add(new Room(line));
        }

        Console.WriteLine("Result part 1");
        _realRooms = rooms.Where(x => !x.IsDecoy).ToList();
        Console.WriteLine(_realRooms.Sum(s => s.Id));
    }

    public override void PartTwo()
    {
        base.PartTwo();
        var northPoleRooms = _realRooms.Where(x => x.DecryptedName.Contains("north")).ToList();
        Console.WriteLine("Result part 2");
        Console.WriteLine(northPoleRooms.First().Id);
    }

    public class Room
    {
        public string Raw { get; }
        public int Id { get; }
        public string CheckSum { get; }
        private string Letters { get; }

        public bool IsDecoy { get; }

        public string DecryptedName => DecryptName();

        private static string _alphabet = "abcdefghijklmnopqrstuvwxyz";
        private static string _substitution = "bcdefghijklmnopqrstuvwxyza";

        private string DecryptName()
        {
            var sb = new StringBuilder();
            var i = 0;
            var currentChar = Raw[i];
            while (!char.IsDigit(currentChar))
            {
                if (currentChar == '-')
                {
                    sb.Append(' ');
                }
                else
                {
                    var j = 0;
                    var tempChar = currentChar;

                    while (j < Id)
                    {
                        var index = _alphabet.IndexOf(tempChar);
                        tempChar = _substitution[index];
                        j++;
                    }

                    sb.Append(tempChar);
                }

                i++;
                currentChar = Raw[i];
            }

            return sb.ToString();
        }

        public Room(string raw)
        {
            Raw = raw;
            CheckSum = raw.Split('[').Last().TrimEnd(']');
            var dashSplit = raw.Split('-');
            Id = int.Parse(dashSplit.Last().Split('[')[0]);
            var a = dashSplit.Reverse().Skip(1);
            Letters = string.Join("", string.Join("", a).OrderBy(o => o));

            var grouped = Letters.GroupBy(l => l).OrderByDescending(o => o.Count()).ToList();
            var mostCommon = grouped.Select(s => s.Key).Take(5);

            IsDecoy = string.Join("", mostCommon) != CheckSum;
        }
    }
}