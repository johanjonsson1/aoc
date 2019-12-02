using System;
using System.Collections.Generic;
using System.Text;
using AoC.Common;
using System.Linq;
using static AoC.Common.SantaHelper;

namespace AoC2019
{
    /*

    */

    public class Day2 : Day
    {
        public override string Title => "";

        public override void PartOne()
        {
            base.PartOne();
            var input = Inputs.Day2.SplitAsIntsBy(',');
            //var input = "1,9,10,3,2,3,11,0,99,30,40,50".SplitAsIntsBy(',');
            input[1] = 12;
            input[2] = 2;

            var index = 0;

            var currentOpCode = input[index];

            while (currentOpCode != 99)
            {
                var valOne = input[input[index + 1]];
                var valTwo = input[input[index + 2]];
                var storeAt = input[index + 3];

                if (currentOpCode == 1)
                {
                    input[storeAt] = valOne + valTwo;
                }
                else if (currentOpCode == 2)
                {
                    input[storeAt] = valOne * valTwo;
                }

                index += 4;
                currentOpCode = input[index];
            }



            Console.WriteLine(input[0]);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            //var input = "1,9,10,3,2,3,11,0,99,30,40,50".SplitAsIntsBy(',')

            var verb = 0;
            var noun = 0;
            var done = false;

            while (!done)
            {
                for (int i = 0; i < 99; i++)
                {
                    verb = i;
                    for (int j = 0; j < 99; j++)
                    {
                        noun = j;

                        var input = Inputs.Day2.SplitAsIntsBy(',');
                        input[1] = verb;
                        input[2] = noun;

                        var index = 0;
                        var currentOpCode = input[index];

                        while (currentOpCode != 99)
                        {
                            var valOne = input[input[index + 1]];
                            var valTwo = input[input[index + 2]];
                            var storeAt = input[index + 3];

                            if (currentOpCode == 1)
                            {
                                input[storeAt] = valOne + valTwo;
                            }
                            else if (currentOpCode == 2)
                            {
                                input[storeAt] = valOne * valTwo;
                            }

                            index += 4;
                            currentOpCode = input[index];
                        }

                        if (input[0] == 19690720)
                        {
                            done = true;
                            break;
                        }
                    }

                    if (done)
                    {
                        break;
                    }
                }


                
            }

            var res = 100 * verb + noun;
            Console.WriteLine(res);
        }
    }
}