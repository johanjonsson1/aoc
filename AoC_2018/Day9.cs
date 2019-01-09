using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2018
{
    /*
    */
    public class Day9 : Day
    {
        public override string Title => "2018 - Day 9";

        public override void PartOne()
        {
            base.PartOne();

            var allMarbles = new List<Marble>();
            var large = 71058 * 100;
            for (int i = 1; i <= large; i++)
            {
                var isDivisible = i % 23 == 0;
                allMarbles.Add(new Marble { Worth = i, Divisible = isDivisible });
            }

            var allElves = new Elves();
            for (int i = 1; i <= 411 ; i++)
            {
                allElves.Add(new Elf { Id = i });
            }

            var circle = new Circle();
            foreach (var marble in allMarbles)
            {
                var currentElf = allElves.GetNext();
                currentElf.Score += circle.AddMarble(marble);//.Marbles.AddRange(circle.AddMarble(marble));
            }

            Console.WriteLine(allElves.HighestScore.Score);
        }

        public override void PartTwo()
        {
            base.PartTwo();
           // var inputs = Inputs.Day1.SplitAsIntsBy(NewlineCarriageReturn);
            Console.WriteLine();
        }
    }

    public class Circle
    {
        public List<Marble> Marbles = new List<Marble>();
        public Marble CurrentMarble;
        public int CurrentMarbleIndex;

        public Circle()
        {
            var startMarble = new Marble { Worth = 0 };
            Marbles.Add(startMarble);
            CurrentMarble = startMarble;
            CurrentMarbleIndex = 0;
        }

        public long /*List<Marble>*/ AddMarble(Marble marble)
        {
            if (marble.Divisible)
            {
                // ge tillbaka marble och 7 bakåt,
                // sätt current till 7an + 1;
                var indexToRemove = CurrentMarbleIndex;//Marbles.IndexOf(CurrentMarble);
                for (int i = 0; i < 7; i++)
                {
                    indexToRemove = PreviousIndex(indexToRemove);
                }

                var otherMarble = Marbles[indexToRemove];// Marbles.ElementAt(indexToRemove);
                var nextIndex = NextIndex(indexToRemove);
                CurrentMarble = Marbles[nextIndex];// Marbles.ElementAt(nextIndex);
                CurrentMarbleIndex = indexToRemove;
                Marbles.RemoveAt(indexToRemove);

                return marble.Worth + otherMarble.Worth;//new List<Marble> { marble, otherMarble };
            }
            else
            {
                // lägg till på rätt ställe
                if (Marbles.Count == 1)
                {
                    Marbles.Add(marble);
                    CurrentMarbleIndex = 1;
                }
                else
                {
                    var indexToAddTo = CurrentMarbleIndex;//Marbles.IndexOf(CurrentMarble);
                    for (int i = 0; i < 2; i++)
                    {
                        indexToAddTo = NextIndex(indexToAddTo);
                    }

                    Marbles.Insert(indexToAddTo, marble);
                    CurrentMarbleIndex = indexToAddTo;
                }                

                CurrentMarble = marble;
                return 0;// new List<Marble>();
            }
        }

        private int NextIndex(int index)
        {
            index++;
            index %= Marbles.Count;

            return index;
        }

        private int PreviousIndex(int index)
        {
            index--;
            if (index < 0)
            {
                index = Marbles.Count - 1;
            }

            return index;
        }
    }

    public class Elf
    {
        public int Id;
        //public List<Marble> Marbles = new List<Marble>();
        public long Score;// => Marbles.Sum(m => m.Worth);
    }

    public class Elves
    {
        private List<Elf> _elves = new List<Elf>();
        private int currentIndex = 0;
        public Elf HighestScore => _elves.OrderByDescending(o => o.Score).First();

        public void Add(Elf elf)
        {
            _elves.Add(elf);
        }

        public Elf GetNext()
        {
            if (currentIndex > _elves.Count-1)
            {
                currentIndex = 0;
            }

            var elf = _elves[currentIndex];// _elves.ElementAt(currentIndex);
            currentIndex++;

            return elf;
        }
    }

    public struct Marble
    {
        public int Worth;
        public bool Divisible;
    }
}
