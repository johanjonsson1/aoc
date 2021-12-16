namespace AoC2020;

public class Day13 : Day
{
    public override string Title => "day 13";

    public override void PartOne()
    {
        base.PartOne();

        var inputs = @"939
7,13,x,x,59,x,31,19";

        var input = @"1000507
29,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,37,x,x,x,x,x,631,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,x,13,19,x,x,x,23,x,x,x,x,x,x,x,383,x,x,x,x,x,x,x,x,x,41,x,x,x,x,x,x,17".ToStringList();

        var departureTime = long.Parse(input[0]);
        var buses = input[1].Replace("x", "").SplitAsLongsBy(',').Select(s => new Bus(s)).ToList();

        foreach (var bus in buses)
        {
            bus.CalculateWait(departureTime);
        }

        var ordered = buses.OrderBy(b => b.WaitTime).ToList();
        var result = ordered.First().Id * ordered.First().WaitTime;
        Console.WriteLine(result);
    }

    public class Bus
    {
        public long Id { get; private set; }
        public long WaitTime { get; private set; }

        public Bus(long id)
        {
            Id = id;
        }

        public void CalculateWait(long departure)
        {
            WaitTime = Id - (departure % Id);
        }
    }
}