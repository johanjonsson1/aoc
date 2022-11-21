namespace AoC2021;

public class Day6 : Day
{
    public override string Title => "--- Day 6: Lanternfish ---";

    public override void PartOne()
    {
        base.PartOne();

        var fishStates = "1,5,5,1,5,1,5,3,1,3,2,4,3,4,1,1,3,5,4,4,2,1,2,1,2,1,2,1,5,2,1,5,1,2,2,1,5,5,5,1,1,1,5,1,3,4,5,1,2,2,5,5,3,4,5,4,4,1,4,5,3,4,4,5,2,4,2,2,1,3,4,3,2,3,4,1,4,4,4,5,1,3,4,2,5,4,5,3,1,4,1,1,1,2,4,2,1,5,1,4,5,3,3,4,1,1,4,3,4,1,1,1,5,4,3,5,2,4,1,1,2,3,2,4,4,3,3,5,3,1,4,5,5,4,3,3,5,1,5,3,5,2,5,1,5,5,2,3,3,1,1,2,2,4,3,1,5,1,1,3,1,4,1,2,3,5,5,1,2,3,4,3,4,1,1,5,5,3,3,4,5,1,1,4,1,4,1,3,5,5,1,4,3,1,3,5,5,5,5,5,2,2,1,2,4,1,5,3,3,5,4,5,4,1,5,1,5,1,2,5,4,5,5,3,2,2,2,5,4,4,3,3,1,4,1,2,3,1,5,4,5,3,4,1,1,2,2,1,2,5,1,1,1,5,4,5,2,1,4,4,1,1,3,3,1,3,2,1,5,2,3,4,5,3,5,4,3,1,3,5,5,5,5,2,1,1,4,2,5,1,5,1,3,4,3,5,5,1,4,3".SplitAsIntsBy(',');
        var lanternfish = fishStates.ConvertAll(f => new Lanternfish(f));
        
        for (var day = 0; day < 80; day++)
        {
            for (var i = lanternfish.Count - 1; i >= 0; i--)
            {
                if (lanternfish[i].PassDay(out var newFish))
                {
                    lanternfish.Add(newFish);
                }
            }

            //Console.WriteLine(string.Join(',', lanternfish));
        }

        Console.WriteLine(lanternfish.Count); // 346063
    }

    public override void PartTwo()
    {
        base.PartTwo();

        var fishStates = "1,5,5,1,5,1,5,3,1,3,2,4,3,4,1,1,3,5,4,4,2,1,2,1,2,1,2,1,5,2,1,5,1,2,2,1,5,5,5,1,1,1,5,1,3,4,5,1,2,2,5,5,3,4,5,4,4,1,4,5,3,4,4,5,2,4,2,2,1,3,4,3,2,3,4,1,4,4,4,5,1,3,4,2,5,4,5,3,1,4,1,1,1,2,4,2,1,5,1,4,5,3,3,4,1,1,4,3,4,1,1,1,5,4,3,5,2,4,1,1,2,3,2,4,4,3,3,5,3,1,4,5,5,4,3,3,5,1,5,3,5,2,5,1,5,5,2,3,3,1,1,2,2,4,3,1,5,1,1,3,1,4,1,2,3,5,5,1,2,3,4,3,4,1,1,5,5,3,3,4,5,1,1,4,1,4,1,3,5,5,1,4,3,1,3,5,5,5,5,5,2,2,1,2,4,1,5,3,3,5,4,5,4,1,5,1,5,1,2,5,4,5,5,3,2,2,2,5,4,4,3,3,1,4,1,2,3,1,5,4,5,3,4,1,1,2,2,1,2,5,1,1,1,5,4,5,2,1,4,4,1,1,3,3,1,3,2,1,5,2,3,4,5,3,5,4,3,1,3,5,5,5,5,2,1,1,4,2,5,1,5,1,3,4,3,5,5,1,4,3".SplitAsIntsBy(',');
        //fishStates = "3,4,3,1,2".SplitAsIntsBy(',');
        var states = new States();

        foreach (var fishState in fishStates)
        {
            switch (fishState)
            {
                case 0:
                    states._0++;
                    break;
                case 1:
                    states._1++;
                    break;
                case 2:
                    states._2++;
                    break;
                case 3:
                    states._3++;
                    break;
                case 4:
                    states._4++;
                    break;
                case 5:
                    states._5++;
                    break;
                case 6:
                    states._6++;
                    break;
                case 7:
                    states._7++;
                    break;
                case 8:
                    states._8++;
                    break;
            }
        }

        for (var i = 0; i < 256; i++)
        {
            var temp = states._8;
            states._8 = states._0;
            var temp2 = states._7;
            states._7 = temp;

            temp = states._6;
            states._6 = temp2 + states._0;
            temp2 = states._5;
            states._5 = temp;

            temp = states._4;
            states._4 = temp2;
            temp2 = states._3;
            states._3 = temp;

            temp = states._2;
            states._2 = temp2;
            temp2 = states._1;
            states._1 = temp;

            states._0 = temp2;

            //Console.WriteLine(states.Sum);
        }

        Console.WriteLine(states.Sum); // 1572358335990
    }
}

public class States
{
    public long _0 = 0;
    public long _1 = 0;
    public long _2 = 0;
    public long _3 = 0;
    public long _4 = 0;
    public long _5 = 0;
    public long _6 = 0;
    public long _7 = 0;
    public long _8 = 0;

    public long Sum => _0 + _1 + _2 + _3 + _4 + _5 + _6 + _7 + _8;
}

public class Lanternfish
{
    public int State { get; set; }

    public Lanternfish(int initialState)
    {
        State = initialState;
    }

    public bool PassDay(out Lanternfish lanternfish)
    {
        State--;

        if (State == -1)
        {
            State = 6;
            lanternfish = new Lanternfish(8);
            return true;
        }

        lanternfish = null;
        return false;
    }

    public override string ToString()
    {
        return State.ToString();
    }
}