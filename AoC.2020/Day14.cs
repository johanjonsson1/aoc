namespace AoC2020;

public class Day14 : Day
{
    public override string Title => "day 14";

    public override void PartOne()
    {
        base.PartOne();
        var inputs = @"mask = XXXXXXXXXXXXXXXXXXXXXXXXXXXXX1XXXX0X
mem[8] = 11
mem[7] = 101
mem[8] = 0";

        var input = Inputs.Day14.ToStringList();
        var array = Enumerable.Repeat((long)0, 100000).ToArray();
        BitMask currentMask = null;
        foreach (var line in input)
        {
            if (line.StartsWith("mask"))
            {
                currentMask = new BitMask(line.Split().Last());
                continue;
            }

            var clean = Regex.Replace(line, "[^0-9 ]+", "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var memoryLocation = int.Parse(clean[0].Trim());
            var currentValue = long.Parse(clean[1].Trim());

            var newValue = currentMask?.ApplyMask(currentValue) ?? throw new Exception();
            array[memoryLocation] = newValue;
        }

        var sum = array.Sum();
        Console.WriteLine(sum);
    }

    public class BitMask
    {
        public string Mask { get; }

        public List<(int indexOf, char bit)> Flips = new List<(int indexOf, char bit)>();

        public BitMask(string mask)
        {
            Mask = mask;

            for (var i = 0; i < mask.Length; i++)
            {
                var character = mask[i];

                if (character == 'X')
                {
                    continue;
                }

                Flips.Add((i, character));
            }
        }

        public long ApplyMask(long inputValue)
        {
            var asString = Convert.ToString(inputValue, 2).PadLeft(36, '0');//inputValue.ToString().ToBinaryString().PadLeft(36, '0')));
            var temp = asString.ToCharArray();

            foreach (var (indexOf, bit) in Flips)
            {
                temp[indexOf] = bit;
            }

            var newString = string.Join("", temp);
            var result = Convert.ToInt64(newString, 2);

            return result;
        }
    }
}