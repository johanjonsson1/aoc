using System.Runtime.InteropServices.ComTypes;

namespace AoC2021;

public class Day4 : Day
{
    public override string Title => "--- Day 4: Giant Squid ---";

    public override void PartOne()
    {
        base.PartOne();

        var allRows = Inputs.Day4.ToStringList();

        var drawlist = allRows[0].SplitAsIntsBy(',');
        var bingoboards = new List<BingoBoard>();

        ConvertToBingoBoards(allRows, bingoboards);

        foreach (var drawNumber in drawlist)
        {
            foreach (var bingoboard in bingoboards)
            {
                bingoboard.Draw(drawNumber);

                if (bingoboard.HasWin())
                {
                    var result = bingoboard.GetUnmarkedSum() * drawNumber;
                    Console.WriteLine(result); // 27027
                    return;
                }
            }
        }
    }

    public override void PartTwo()
    {
        base.PartTwo();

        var allRows = Inputs.Day4.ToStringList();

        var drawlist = allRows[0].SplitAsIntsBy(',');
        var bingoboards = new List<BingoBoard>();

        ConvertToBingoBoards(allRows, bingoboards);
        int result = 0;
        foreach (var drawNumber in drawlist)
        {
            foreach (var bingoboard in bingoboards.Where(b => !b.HasWin()))
            {
                bingoboard.Draw(drawNumber);

                if (bingoboard.HasWin())
                {
                    result = bingoboard.GetUnmarkedSum() * drawNumber;
                }
            }
        }

        Console.WriteLine(result); // 36975
    }

    private static void ConvertToBingoBoards(List<string> allRows, List<BingoBoard> bingoboards)
    {
        var counter = 0;
        var bingonumbers = new List<BingoNumber>();
        var currentX = 0;
        var currentY = 0;
        foreach (var row in allRows.Skip(1))
        {
            foreach (var number in row.SplitAsIntsBy())
            {
                bingonumbers.Add(new BingoNumber(number, currentX, currentY));
                currentY++;
            }

            currentX++;
            currentY = 0;
            counter++;
            if (counter == 5)
            {
                bingoboards.Add(new BingoBoard(bingonumbers));
                bingonumbers = new List<BingoNumber>();
                counter = 0;
                currentY = 0;
                currentX = 0;
            }
        }
    }

    public class BingoBoard
    {
        public List<BingoNumber> BingoNumbers { get; set; }
        public List<IGrouping<int, BingoNumber>> Rows { get; set; }
        public List<IGrouping<int, BingoNumber>> Columns { get; set; }

        public BingoBoard(List<BingoNumber> allBingoNumbers)
        {
            BingoNumbers = allBingoNumbers;
            Rows = allBingoNumbers.GroupBy(x => x.X).ToList();
            Columns = allBingoNumbers.GroupBy(x => x.Y).ToList();
        }

        public void Draw(int drawNumber)
        {
            foreach (var bingoNumber in BingoNumbers.Where(x => x.Number == drawNumber))
            {
                bingoNumber.IsMarked = true;
            }
        }

        public bool HasWin()
        {
            return Rows.Any(x => x.All(r => r.IsMarked)) || 
                   Columns.Any(x => x.All(c => c.IsMarked));
        }

        public int GetUnmarkedSum()
        {
            return BingoNumbers.Where(x => !x.IsMarked).Sum(s => s.Number);
        }
    }

    public class BingoNumber
    {
        public int Number { get; set; }
        public bool IsMarked { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public BingoNumber(int number, int x, int y)
        {
            Number = number;
            X = x;
            Y = y;
        }
    }
}