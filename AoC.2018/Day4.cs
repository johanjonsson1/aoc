using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;

namespace AoC2018
{
    /*
   --- Day 4: Repose Record ---
    You've sneaked into another supply closet - this time, it's across from the prototype suit manufacturing lab. 
    You need to sneak inside and fix the issues with the suit, but there's a guard stationed outside the lab, so this is as close as you can safely get.

    As you search the closet for anything that might help, you discover that you're not the first person to want to sneak in. 
    Covering the walls, someone has spent an hour starting every midnight for the past few months secretly observing this guard post! 
    They've been writing down the ID of the one guard on duty that night - 
    the Elves seem to have decided that one guard was enough for the overnight shift - 
    as well as when they fall asleep or wake up while at their post (your puzzle input).

    For example, consider the following records, which have already been organized into chronological order:

    [1518-11-01 00:00] Guard #10 begins shift
    [1518-11-01 00:05] falls asleep
    [1518-11-01 00:25] wakes up
    [1518-11-01 00:30] falls asleep
    [1518-11-01 00:55] wakes up
    [1518-11-01 23:58] Guard #99 begins shift
    [1518-11-02 00:40] falls asleep
    [1518-11-02 00:50] wakes up
    [1518-11-03 00:05] Guard #10 begins shift
    [1518-11-03 00:24] falls asleep
    [1518-11-03 00:29] wakes up
    [1518-11-04 00:02] Guard #99 begins shift
    [1518-11-04 00:36] falls asleep
    [1518-11-04 00:46] wakes up
    [1518-11-05 00:03] Guard #99 begins shift
    [1518-11-05 00:45] falls asleep
    [1518-11-05 00:55] wakes up
    Timestamps are written using year-month-day hour:minute format. The guard falling asleep or waking up is always the one whose shift most recently started. 
    Because all asleep/awake times are during the midnight hour (00:00 - 00:59), only the minute portion (00 - 59) is relevant for those events.

    Visually, these records show that the guards are asleep at these times:

    Date   ID   Minute
                000000000011111111112222222222333333333344444444445555555555
                012345678901234567890123456789012345678901234567890123456789
    11-01  #10  .....####################.....#########################.....
    11-02  #99  ........................................##########..........
    11-03  #10  ........................#####...............................
    11-04  #99  ....................................##########..............
    11-05  #99  .............................................##########.....
    The columns are Date, which shows the month-day portion of the relevant day; ID, which shows the guard on duty that day; 
    and Minute, which shows the minutes during which the guard was asleep within the midnight hour.
    (The Minute column's header shows the minute's ten's digit in the first row and the one's digit in the second row.) 
    Awake is shown as ., and asleep is shown as #.

    Note that guards count as asleep on the minute they fall asleep, and they count as awake on the minute they wake up. 
    For example, because Guard #10 wakes up at 00:25 on 1518-11-01, minute 25 is marked as awake.

    If you can figure out the guard most likely to be asleep at a specific time, you might be able to trick that guard into working tonight so you can have the best chance of sneaking in. 
    You have two strategies for choosing the best guard/minute combination.

    Strategy 1: Find the guard that has the most minutes asleep. What minute does that guard spend asleep the most?

    In the example above, Guard #10 spent the most minutes asleep, a total of 50 minutes (20+25+5), while Guard #99 only slept for a total of 30 minutes (10+10+10). 
    Guard #10 was asleep most during minute 24 (on two days, whereas any other minute the guard was asleep was only seen on one day).

    While this example listed the entries in chronological order, your entries are in the order you found them.
    You'll need to organize them before they can be analyzed.

    What is the ID of the guard you chose multiplied by the minute you chose? 
    (In the above example, the answer would be 10 * 24 = 240.)

    --- Part Two ---
    Strategy 2: Of all guards, which guard is most frequently asleep on the same minute?

    In the example above, Guard #99 spent minute 45 asleep more than any other guard or minute - three times in total. 
    (In all other cases, any guard spent any minute asleep at most twice.)

    What is the ID of the guard you chose multiplied by the minute you chose? 
    (In the above example, the answer would be 99 * 45 = 4455.)
     */
    public class Day4 : Day
    {
        private readonly List<string> _inputs = Inputs.Day4.ToStringList().OrderBy(o => o).ToList();
        private readonly Dictionary<string, Guard> _guards = new Dictionary<string, Guard>();
        public override string Title => "2018 - Day 4: Repose Record";

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
                    if (_guards.TryGetValue(guardId, out Guard guard))
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
            Console.WriteLine(int.Parse(mostAsleep.Id.Replace("#","")) * mostAsleep.MaxMinuteAsleep); //38813
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var byFrequency = _guards.Values.OrderByDescending(o => o.MaxMinuteAsleepCount.Times).First();
            Console.WriteLine(int.Parse(byFrequency.Id.Replace("#", "")) * byFrequency.MaxMinuteAsleepCount.Minute); //141071
        }
    }

    public class Guard
    {
        public string Id;

        public int MinutesAsleep => _dateMinutes.Count(x => x.Action == Action.Asleep);

        public MaxMax MaxMinuteAsleepCount
        {
            get
            {
                var grp = _dateMinutes.Where(x => x.Action == Action.Asleep).GroupBy(g => g.Minute)
                    .OrderByDescending(o => o.Count()).FirstOrDefault();

                if (grp == null)
                {
                    return new MaxMax { Minute = 0, Times = 0 };
                }

                return new MaxMax { Minute = grp.Key, Times = grp.Count() };
            }
        }

        public int MaxMinuteAsleep => _dateMinutes.Where(x => x.Action == Action.Asleep).GroupBy(g => g.Minute)
                    .OrderByDescending(o => o.Count()).First().Key;

        public int MaxMinuteAwake => _dateMinutes.Where(x => x.Action == Action.Awake).GroupBy(g => g.Minute)
                    .OrderByDescending(o => o.Count()).First().Key;

        private List<DateMinuteAction> _dateMinutes = new List<DateMinuteAction>();

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
            _dateMinutes.Add(new DateMinuteAction { Date = tstamp, Action = Action.Awake, Minute = tstamp.Minute });
        }

        private void AddAction(DateTime tstamp, Action action)
        {
            if (_dateMinutes.Count == 0)
            {
                _dateMinutes.Add(new DateMinuteAction { Date = tstamp, Action = action, Minute = tstamp.Minute });
            }
            else
            {
                var lastEntry = _dateMinutes.Last();

                var newDateTime = lastEntry.Date.AddMinutes(1);
                while (newDateTime < tstamp)
                {                    
                    var newEntry = new DateMinuteAction { Date = newDateTime, Action = lastEntry.Action, Minute = newDateTime.Minute };
                    _dateMinutes.Add(newEntry);

                    lastEntry = newEntry;
                    newDateTime = lastEntry.Date.AddMinutes(1);
                }

                _dateMinutes.Add(new DateMinuteAction { Date = tstamp, Action = action, Minute = tstamp.Minute });
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