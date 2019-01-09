using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC_Common
{
    public static class SantaExtensions
    {
        public static List<int> ToInts(this IEnumerable<char> input)
        {
            return input.Select(s => (int)Char.GetNumericValue(s)).ToList();
        }

        public static List<string> ToStringList(this string input)
        {
            return input.Split('\r', '\n').Where(x => x != "").ToList();
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

        public static List<decimal> SplitAsDecimalsBy(this string input, params char[] splitters)
        {
            return input.SplitByAs(s => { return Convert.ToDecimal(s); }, splitters);
        }

        public static List<byte> SplitAsBytesBy(this string input, params char[] splitters)
        {
            return input.SplitByAs(s => { return Convert.ToByte(s); }, splitters);
        }

        public static string RemoveAToZ(this string input)
        {
            return Regex.Replace(input, "[A-Za-z]", "");
        }

        public static string RemoveSomeSpecialCharacters(this string input)
        {
            return Regex.Replace(input, "[^0-9a-zA-Z- ]+", "");
        }

        public static string RemoveNonNumeric(this string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }
    }
}
