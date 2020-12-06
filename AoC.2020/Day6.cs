using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;

namespace AoC2020
{
    public class Day6 : Day
    {
        public override string Title => "day6";
        public List<Group> Groups;

        public override void PartOne()
        {
            base.PartOne();

            var input = @"abc

a
b
c

ab
ac

a
a
a
a

b";

            var grpInputs = Inputs.Day6.Split('\n').Select(s => s.Replace("\r", "")).ToList();

            var groups = new List<Group>();
            var currentGroup = new List<Person>();

            for (var index = 0; index < grpInputs.Count; index++)
            {
                var line = grpInputs[index];
                if (string.IsNullOrWhiteSpace(line) && currentGroup.Count > 0)
                {
                    var group = new Group(index);
                    group.People.AddRange(currentGroup);
                    groups.Add(group);
                    currentGroup.Clear();
                    continue;
                }

                var person = new Person(line);
                currentGroup.Add(person);

                if (index == grpInputs.Count - 1)
                {
                    var group = new Group(index);
                    group.People.AddRange(currentGroup);
                    groups.Add(group);
                    currentGroup.Clear();
                }
            }

            Groups = groups;
            var result = groups.Sum(g => g.Answers);
            Console.WriteLine(result);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var result = Groups.Sum(g => g.GetAllYesAnswers());
            Console.WriteLine(result);
        }

        public class Group
        {
            public int Id { get; }
            public List<Person> People = new List<Person>();

            public int Answers => People.SelectMany(p => p.Answers).Distinct().Count();

            public Group(int id)
            {
                Id = id;
            }

            public int GetAllYesAnswers()
            {
                var count = 0;

                foreach (var answer in People.SelectMany(p => p.Answers).Distinct())
                {
                    if (People.Any() && People.All(p => p.Answers.Contains(answer)))
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public class Person
        {
            public HashSet<char> Answers = new HashSet<char>();

            public Person(string answers)
            {
                foreach (var answer in answers)
                {
                    Answers.Add(answer);
                }
            }
        }
    }
}