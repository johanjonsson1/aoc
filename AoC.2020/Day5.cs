using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;

namespace AoC2020
{
    public class Day5 : Day
    {
        public override string Title => "day5";

        public override void PartOne()
        {
            base.PartOne();
            //var input = "FBFBBFFRLR";

            var allRows = new List<Row>();
            for (var i = 0; i < 128; i++)
            {
                allRows.Add(new Row(i));
            }

            foreach (var input in Inputs.Day5.ToStringList())
            {
                CalculateSeatID(allRows, input);
            }

            var result = allRows.SelectMany(r => r.Seats).OrderByDescending(s => s.ID);

            Console.WriteLine(result.First().ID);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var allRows = new List<Row>();
            for (var i = 0; i < 128; i++)
            {
                allRows.Add(new Row(i));
            }

            foreach (var input in Inputs.Day5.ToStringList())
            {
                CalculateSeatID(allRows, input);
            }

            var result = allRows.SelectMany(r => r.Seats).Where(s1 => s1.ID != 0).OrderByDescending(s => s.ID).ToList();
            var dict = result.ToDictionary((s) => s.ID);
            for (var i = result.Last().ID; i < result.First().ID; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        private static void CalculateSeatID(List<Row> allRows, string input)
        {
            var currentRows = new List<Row>(allRows).ToArray();
            foreach (var letter in input.Take(7))
            {
                var half = currentRows.Length / 2;
                var range = letter switch
                {
                    'F' => ..half,
                    'B' => half..,
                    _ => throw new ArgumentException("unexpected")
                };

                currentRows = currentRows[range];
            }

            var currentSeats = currentRows.Single().Seats.ToArray();
            foreach (var letter in input.TakeLast(3))
            {
                var half = currentSeats.Length / 2;
                var range = letter switch
                {
                    'L' => ..half,
                    'R' => half..,
                    _ => throw new ArgumentException("unexpected")
                };

                currentSeats = currentSeats[range];
            }

            var seat = currentSeats.Single();
            seat.ID = (currentRows.Single().Id * 8) + seat.Id;
        }

        public class Row
        {
            public int Id;
            public List<Seat> Seats = new List<Seat>();

            public Row(int id)
            {
                Id = id;
                for (var i = 0; i < 8; i++)
                {
                    Seats.Add(new Seat(i));
                }
            }
        }

        public class Seat
        {
            public int Id;
            private int _id;

            public int ID
            {
                get => _id;
                set => _id = _id != 0 ? throw new ArgumentException("inte sätta värde två ggr?") : value;
            }

            public Seat(int id)
            {
                Id = id;
            }
        }
    }
}