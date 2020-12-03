using System;
using System.Linq;
using AoC.Common;

namespace AoC2020
{
    public class Day2 : Day
    {
        public override string Title => "day2";

        public override void PartOne()
        {
            base.PartOne();
            var validPasswords = Inputs.Day2.ToStringList().Select(s => new Password(s)).Count(p => p.IsValid());

            Console.WriteLine(validPasswords);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            var validPasswords = Inputs.Day2.ToStringList().Select(s => new Password(s)).Count(p => p.IsValid2());

            Console.WriteLine(validPasswords);
        }

        public class Password
        {
            private readonly int _minOccurances;
            private readonly int _maxOccurances;
            private readonly char _letter;

            public string Policy { get; private set; }
            public string PasswordPhrase { get; private set; }

            public Password(string policyPassword)
            {
                var split = policyPassword.Split(':');
                Policy = split[0];
                PasswordPhrase = split[1].Remove(0, 1);

                var policySplit = Policy.Split(' ');
                _letter = policySplit[1][0];
                var numbers = policySplit[0].SplitAsIntsBy('-');
                _minOccurances = numbers[0]; 
                _maxOccurances = numbers[1];
            }

            public bool IsValid()
            {
                var count = PasswordPhrase.Count(p => p == _letter);
                return count >= _minOccurances && count <= _maxOccurances;
            }

            public bool IsValid2()
            {
                var matches = 0;
                for (var i = 0; i < PasswordPhrase.Length; i++)
                {
                    var oneBasedIndex = i + 1;
                    if ((oneBasedIndex == _minOccurances || oneBasedIndex == _maxOccurances) && PasswordPhrase[i] == _letter)
                    {
                        matches++;
                    }
                }

                return matches == 1;
            }
        }
    }
}