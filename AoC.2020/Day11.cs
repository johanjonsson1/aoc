namespace AoC2020;

public class Day11 : Day
{
    public override string Title => "day 11";

    public static int MaxX = 0;
    public static int MaxY = 0;
    public static int MinX = 0;
    public static int MinY = 0;

    public override void PartOne()
    {
        base.PartOne();

        var input1 = @"
L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL";

        var input = Inputs.Day11.ToStringList();
        var grid = new Grid<Coordinate, WaitingAreaItem>();

        for (var y = 0; y < input.Count; y++)
        {
            var row = input[y];
            for (var x = 0; x < row.Length; x++)
            {
                var areaItem = new WaitingAreaItem(y, x, row[x]);
                grid.Add(areaItem.Coordinate, areaItem);

                MaxX++;
            }

            MaxY++;
        }

        var all = grid.GetAll();
        while (all.Any(x => x.State != x.PreviousState))
        {
            foreach (var waitingAreaItem in all)
            {
                waitingAreaItem.DecideNextState(grid);
            }

            foreach (var waitingAreaItem in all)
            {
                waitingAreaItem.SetNextState();
            }
        }

        var result = all.Where(x => x.State == State.OccupiedSeat).ToList();

        Console.WriteLine(result.Count);
    }

    public override void PartTwo()
    {
        base.PartTwo();
        MaxX = 0;
        MaxY = 0;
        MinX = 0;
        MinY = 0;
        var input1 = @"
L.LL.LL.LL
LLLLLLL.LL
L.L.L..L..
LLLL.LL.LL
L.LL.LL.LL
L.LLLLL.LL
..L.L.....
LLLLLLLLLL
L.LLLLLL.L
L.LLLLL.LL";

        var input = Inputs.Day11.ToStringList();
        var grid = new Grid<Coordinate, WaitingAreaItem>();

        for (var y = 0; y < input.Count; y++)
        {
            var row = input[y];
            for (var x = 0; x < row.Length; x++)
            {
                var areaItem = new WaitingAreaItem(y, x, row[x]);
                grid.Add(areaItem.Coordinate, areaItem);

                MaxX++;
            }

            MaxY++;
        }

        var all = grid.GetAll();
        while (all.Any(x => x.State != x.PreviousState))
        {
            foreach (var waitingAreaItem in all)
            {
                waitingAreaItem.DecideNextState(grid, advancedFind: true);
            }

            foreach (var waitingAreaItem in all)
            {
                waitingAreaItem.SetNextState();
            }

            //Console.WriteLine(all.Count(x => x.State == State.OccupiedSeat));
        }

        var result = all.Where(x => x.State == State.OccupiedSeat).ToList();

        Console.WriteLine(result.Count);
    }

    public class WaitingAreaItem : ICoordinate
    {
        public int Id { get; }
        public Coordinate Coordinate { get; set; }
        public State State { get; private set; }
        public State NextState { get; private set; } = State.None;
        public State PreviousState { get; private set; } = State.None;

        public WaitingAreaItem(int y, int x, char symbol)
        {
            Coordinate = new Coordinate(x, y);

            State = symbol switch
            {
                '.' => State.Floor,
                'L' => State.EmptySeat,
                '#' => State.OccupiedSeat,
                _ => throw new ArgumentException(symbol + "")
            };
        }

        private IEnumerable<WaitingAreaItem> GetFirstNeighboursAllDirections(Grid<Coordinate, WaitingAreaItem> grid)
        {
            var upperLeft = grid.GetForKeys(this.Coordinate.GetAllUpperLeft(MinX, MaxY))
                .FirstOrDefault(x => x.State != State.Floor);

            if (upperLeft != null)
            {
                yield return upperLeft;
            }

            var upperRight = grid.GetForKeys(this.Coordinate.GetAllUpperRight(MaxX, MaxY))
                .FirstOrDefault(x => x.State != State.Floor);

            if (upperRight != null)
            {
                yield return upperRight;
            }

            var lowerLeft = grid.GetForKeys(this.Coordinate.GetAllLowerLeft(MinX, MinY))
                .FirstOrDefault(x => x.State != State.Floor);

            if (lowerLeft != null)
            {
                yield return lowerLeft;
            }

            var lowerRight = grid.GetForKeys(this.Coordinate.GetAllLowerRight(MaxX, MinY))
                .FirstOrDefault(x => x.State != State.Floor);

            if (lowerRight != null)
            {
                yield return lowerRight;
            }

            var left = grid.GetForKeys(this.Coordinate.GetAllLeft(MinX))
                .FirstOrDefault(x => x.State != State.Floor);

            if (left != null)
            {
                yield return left;
            }

            var right = grid.GetForKeys(this.Coordinate.GetAllRight(MaxX))
                .FirstOrDefault(x => x.State != State.Floor);

            if (right != null)
            {
                yield return right;
            }

            var up = grid.GetForKeys(this.Coordinate.GetAllUp(MaxY))
                .FirstOrDefault(x => x.State != State.Floor);

            if (up != null)
            {
                yield return up;
            }

            var down = grid.GetForKeys(this.Coordinate.GetAllDown(MinY))
                .FirstOrDefault(x => x.State != State.Floor);

            if (down != null)
            {
                yield return down;
            }
        }

        public void DecideNextState(Grid<Coordinate, WaitingAreaItem> grid, bool advancedFind = false)
        {
            if (State == State.Floor)
            {
                NextState = State.Floor;
                return;
            }

            IEnumerable<WaitingAreaItem> neighbours;
            if (advancedFind)
            {
                neighbours = GetFirstNeighboursAllDirections(grid);
            }
            else
            {
                neighbours = grid.GetForKeys(this.Coordinate.GetAdjacentPlusDiag());
            }

            var limit = advancedFind ? 5 : 4;

            switch (State)
            {
                case State.EmptySeat when neighbours.Any(x => x.State == State.OccupiedSeat):
                    NextState = State;
                    return;
                case State.EmptySeat:
                    NextState = State.OccupiedSeat;
                    break;
                case State.OccupiedSeat:
                {
                    var count = 0;
                    foreach (var _ in neighbours.Where(x => x.State == State.OccupiedSeat))
                    {
                        count++;

                        if (count >= limit)
                        {
                            NextState = State.EmptySeat;
                            return;
                        }
                    }

                    NextState = State;
                    break;
                }
            }
        }

        public void SetNextState()
        {
            PreviousState = State;
            State = NextState;
        }
    }

    public enum State
    {
        None,
        Floor,
        EmptySeat,
        OccupiedSeat
    }
}