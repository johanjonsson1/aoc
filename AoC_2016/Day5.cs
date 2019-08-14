using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static AoC_Common.SantaHelper;

namespace AoC_2016
{
    /*

    */
    public class Day5 : Day
    {
        public override string Title => "--- Day 5: How About a Nice Game of Chess? ---";

        public override void PartOne()
        {
            base.PartOne();
            var input = "ojvtpuvg";
            var notFound = true;
            long number = 0;
            var password = "";
            byte[] data = null;

            using (var md5Hash = MD5.Create())
            {
                while (notFound)
                {
                    var testString = input + number;
                    data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(testString));
                    var md5 = BitConverter.ToString(data).Replace("-", "");

                    if (md5.StartsWith("00000"))
                    {
                        password += md5.ElementAt(5);

                        if (password.Length >= 8)
                        {
                            notFound = false;
                        }
                    }

                    number++;
                }
            }

            Console.WriteLine("Result part 1");
            Console.WriteLine(password.ToLower());
        }

        public override void PartTwo()
        {
            base.PartTwo();

            var input = "ojvtpuvg";
            var notFound = true;
            long number = 0;
            var password = new char[8];
            var foundCount = 0;
            byte[] data = null;

            using (var md5Hash = MD5.Create())
            {
                while (notFound)
                {
                    var testString = input + number;
                    data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(testString));
                    var md5 = BitConverter.ToString(data).Replace("-", "");

                    if (md5.StartsWith("00000"))
                    {
                        var index = (int)char.GetNumericValue(md5.ElementAt(5));

                        if (index < 8 && index > -1 && password[index] == '\0')
                        {
                            var value = md5.ElementAt(6);
                            password[index] = value;
                            foundCount++;

                            if (foundCount >= 8)
                            {
                                notFound = false;
                            }
                        }
                    }

                    number++;
                }
            }

            var pass = string.Join("", password);
            Console.WriteLine("Result part 2");
            Console.WriteLine(pass.ToLower());
        }
    }
}