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
    public class Day4 : Day
    {
        private readonly List<string> _inputs = Inputs.Day4.ToStringList().OrderBy(o => o).ToList();
        private readonly Dictionary<string, Guard> _guards = new Dictionary<string, Guard>();

        public override string Title => "2018 - Day 4: Repose Record";

        /*
[1518-11-01 00:00] Guard #10 begins shift
[1518-11-01 00:05] falls asleep
[1518-11-01 00:25] wakes up
[1518-11-01 00:30] falls asleep
[1518-11-01 00:55] wakes up
[1518-11-01 23:58] Guard #99 begins shift
*/


        public override void PartOne()
        {
            base.PartOne();

            Guard currentGuard = null;
            foreach (var item in _inputs)
            {
                var tstamp = DateTime.Parse(item.Substring(1, 16));
                var split = item.Split(' ');

                var entryType = split[2]; // Guard/falls/wakes

                if (entryType == "Guard")
                {
                    var guardId = split[3];
                    Guard guard;
                    if (_guards.TryGetValue(guardId, out guard))
                    {
                        currentGuard = guard;
                    }
                    else
                    {
                        _guards.Add(guardId, new Guard(guardId));
                        currentGuard = _guards[guardId];
                    }

                    currentGuard.ForceAddAwake(tstamp);
                }
                else if (entryType == "falls")
                {
                    currentGuard.AddAsleep(tstamp);
                }
                else if (entryType == "wakes")
                {
                    currentGuard.AddAwake(tstamp);
                }
            }

            var mostAsleep = _guards.Values.OrderByDescending(o => o.MinutesAsleep).First();
            Console.WriteLine(int.Parse(mostAsleep.Id.Replace("#","")) * mostAsleep.MaxMinuteAsleep);
        }

        public override void PartTwo()
        {
            base.PartTwo();

            var byFrequency = _guards.Values.OrderByDescending(o => o.MaxMinuteAsleepCount.Times).First();
            Console.WriteLine(int.Parse(byFrequency.Id.Replace("#", "")) * byFrequency.MaxMinuteAsleepCount.Minute);
        }
    }

    public class Guard
    {
        public string Id;

        public int MinutesAsleep
        {
            get
            {
                return DateMinutes.Count(x => x.Action == Action.Asleep);
            }
        }

        public MaxMax MaxMinuteAsleepCount
        {
            get
            {
                var grp = DateMinutes.Where(x => x.Action == Action.Asleep).GroupBy(g => g.Minute)
                    .OrderByDescending(o => o.Count()).FirstOrDefault();

                if (grp == null)
                {
                    return new MaxMax { Minute = 0, Times = 0 };
                }

                return new MaxMax { Minute = grp.Key, Times = grp.Count() };
            }
        }

        public int MaxMinuteAsleep
        {
            get
            {
                return DateMinutes.Where(x => x.Action == Action.Asleep).GroupBy(g => g.Minute)
                    .OrderByDescending(o => o.Count()).First().Key;
            }
        }

        public int MaxMinuteAwake
        {
            get
            {
                return DateMinutes.Where(x => x.Action == Action.Awake).GroupBy(g => g.Minute)
                    .OrderByDescending(o => o.Count()).First().Key;
            }
        }

        private List<DateMinuteAction> DateMinutes = new List<DateMinuteAction>();

        public Guard(string id)
        {
            Id = id;
        }

        public void AddAsleep(DateTime tstamp)
        {
            AddAction(tstamp, Action.Asleep);
        }

        public void AddAwake(DateTime tstamp)
        {
            AddAction(tstamp, Action.Awake);
        }

        public void ForceAddAwake(DateTime tstamp)
        {
            DateMinutes.Add(new DateMinuteAction { Date = tstamp, Action = Action.Awake, Minute = tstamp.Minute });
        }

        private void AddAction(DateTime tstamp, Action action)
        {
            if (DateMinutes.Count == 0)
            {
                DateMinutes.Add(new DateMinuteAction { Date = tstamp, Action = action, Minute = tstamp.Minute });
            }
            else
            {
                var lastEntry = DateMinutes.Last();

                var newDateTime = lastEntry.Date.AddMinutes(1);
                while (newDateTime < tstamp)
                {                    
                    var newEntry = new DateMinuteAction { Date = newDateTime, Action = lastEntry.Action, Minute = newDateTime.Minute };
                    DateMinutes.Add(newEntry);

                    lastEntry = newEntry;
                    newDateTime = lastEntry.Date.AddMinutes(1);
                }

                DateMinutes.Add(new DateMinuteAction { Date = tstamp, Action = action, Minute = tstamp.Minute });
            }
        }
    }

    public struct DateMinuteAction
    {
        public DateTime Date;
        public int Minute;
        public Action Action;
    }

    public struct MaxMax
    {
        public int Minute;
        public int Times;
    }

    public enum Action
    {
        Asleep,
        Awake
    }
} 