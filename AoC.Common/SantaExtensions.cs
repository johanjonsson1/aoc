using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AoC.Common
{
    public static class SantaExtensions
    {
        public static List<int> ToInts(this IEnumerable<char> input)
        {
            return input.Select(s => (int)char.GetNumericValue(s)).ToList();
        }

        public static List<string> ToStringList(this string input, bool leaveEmpty = false)
        {
            return leaveEmpty ? input.Split('\r', '\n').ToList() : input.Split('\r', '\n').Where(x => x != "").ToList();
        }

        public static string ToBinaryString(this string input)
        {
            return string.Join(string.Empty,
                input.Select(
                    c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
                )
            );
        }

        public static Dictionary<int, List<char>> ToColumns(this List<string> input)
        {
            var dict = new Dictionary<int, List<char>>();

            foreach (var line in input)
            {
                for (var i = 0; i < line.Length; i++)
                {
                    if (dict.TryGetValue(i, out var entry))
                    {
                        entry.Add(line[i]);
                    }
                    else
                    {
                        dict[i] = new List<char> { line[i] };
                    }
                }
            }

            return dict;
        }

        public static List<T> SplitByAs<T>(this string input, Func<string, T> converter, params char[] splitters)
        {
            var a = splitters.ToList();
            a.Add(' ');
            return input.Split(a.ToArray()).Where(x => x != "").Select(s => 
            converter(s)).ToList();
        }

        public static List<int> SplitAsIntsBy(this string input, params char[] splitters)
        {
            return input.SplitByAs(s => { return Convert.ToInt32(s); }, splitters);
        }

        public static List<long> SplitAsLongsBy(this string input, params char[] splitters)
        {
            return input.SplitByAs(s => { return Convert.ToInt64(s); }, splitters);
        }

        public static List<decimal> SplitAsDecimalsBy(this string input, params char[] splitters)
        {
            return input.SplitByAs(s => { return Convert.ToDecimal(s); }, splitters);
        }

        public static List<double> SplitAsDoublesBy(this string input, params char[] splitters)
        {
            return input.SplitByAs(s => { return Convert.ToDouble(s); }, splitters);
        }

        public static List<byte> SplitAsBytesBy(this string input, params char[] splitters)
        {
            return input.SplitByAs(s => { return Convert.ToByte(s); }, splitters);
        }

        public static string RemoveAToZ(this string input)
        {
            return Regex.Replace(input, "[A-Za-z]", "");
        }

        public static string Remove0To9(this string input)
        {
            return Regex.Replace(input, "[0-9]", "");
        }

        public static string RemoveSomeSpecialCharacters(this string input)
        {
            return Regex.Replace(input, "[^0-9a-zA-Z- ]+", "");
        }

        public static string RemoveNonNumeric(this string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

        public static char AsChar(this string input)
        {
            return input[0];
        }

        public static long[] ExpandTo(this long[] array, int expandTo)
        {
            var @new = new long[100000];
            array.CopyTo(@new, 0);

            return @new;
        }
    }
}
