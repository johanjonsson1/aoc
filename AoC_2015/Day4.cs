using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2015
{
    /*
    --- Day 4: The Ideal Stocking Stuffer ---

    Santa needs help mining some AdventCoins (very similar to bitcoins) to use as gifts for all the economically 
    forward-thinking little girls and boys.

    To do this, he needs to find MD5 hashes which, in hexadecimal, start with at least five zeroes. 
    The input to the MD5 hash is some secret key (your puzzle input, given below) followed by a number in decimal.
    To mine AdventCoins, you must find Santa the lowest positive number (no leading zeroes: 1, 2, 3, ...) that produces such a hash.

    For example:

    If your secret key is abcdef, the answer is 609043, because the MD5 hash of abcdef609043 starts with five zeroes (000001dbbfa...), 
    and it is the lowest such number to do so.
    If your secret key is pqrstuv, the lowest number it combines with to make an MD5 hash starting with five zeroes is 1048970; 
    that is, the MD5 hash of pqrstuv1048970 looks like 000006136ef....
    Your puzzle input is ckczppom.

    -- Part Two ---

    Now find one that starts with six zeroes.
     */

    public class Day4 : IDay
    {
        public string Title => "Day 4";

        public void Run()
        {
            PartOne();
        }

        private static void PartOne()
        {
            Console.WriteLine("--- Day 4: The Ideal Stocking Stuffer ---");
            var input = "ckczppom";
            var notFound = true;
            long number = 0;

            byte[] data = null;

            using (MD5 md5Hash = MD5.Create())
            {
                while (notFound)
                {
                    var testString = input + number;
                    data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(testString));
                    var md5 = BitConverter.ToString(data).Replace("-", "");

                    //Console.WriteLine(md5);

                    if (md5.StartsWith("000000"))
                    {
                        notFound = false;
                    }
                    else
                    {
                        number++;
                    }

                    if (number == 12000000)
                    {
                        notFound = false;
                        Console.WriteLine("dafaq");
                    }
                }
            } 

            Console.WriteLine(number);
        }
    }
}
