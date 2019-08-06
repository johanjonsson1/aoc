using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC_2015
{
    public class Day7 : Day
    {
        public override string Title => "--- Day 7: Some Assembly Required ---";

        public override void PartOne()
        {
            base.PartOne();
            var test = @"123 -> x
456 -> y
x AND y -> d
x OR y -> e
x LSHIFT 2 -> f
y RSHIFT 2 -> g
NOT x -> h
NOT y -> i";

            var input = test.ToStringList(); // Inputs.Day7.ToStringList(); //
            var wires = new List<Wire>();

            // gör om
            // setup och sedan run

            foreach (var instruction in input)
            {
                var wire = BitwiseConverter.GetWire(instruction, wires);
                //Console.WriteLine($"{wire.Id}: {wire.Value}");
                if (wire == null)
                {
                    continue;
                }

                wires.Add(wire);
            }

            Console.WriteLine("Result part 1");
            Console.WriteLine(wires.FirstOrDefault(x=>x.Id == "a")?.Value);
        }

        public override void PartTwo()
        {
            base.PartTwo();
        }
    }

    public static class BitwiseConverter
    {
        public static Wire GetWire(string input, List<Wire> wires)
        {
            /*
                123 -> x
                456 -> y
                x AND y -> d
                x OR y -> e
                x LSHIFT 2 -> f
                y RSHIFT 2 -> g
                NOT x -> h
                NOT y -> i
             */

            ushort? GetValue(string a)
            {
                if(Regex.Match(a, "[a-z]+").Success)
                {
                    return wires.FirstOrDefault(w => w.Id == a)?.Value ?? null;
                }

                return ushort.Parse(a);
            }

            var inputArray = input.Split(' ');
            if (input.StartsWith("NOT"))
            {
                var fromWire = inputArray[1];
                var toWire = inputArray[3];

                var firstWireValue = GetValue(fromWire);
                if (firstWireValue == null)
                {
                    return null;
                }

                var targetWire = wires.FirstOrDefault(w => w.Id == toWire);

                if (targetWire == null)
                {
                    return new Wire { Id = toWire, Value = (ushort)~firstWireValue };
                }

                targetWire.Value = (ushort)~firstWireValue;

                return targetWire;
            }
            else if (input.Contains("AND"))
            {
                var firstWireValue = GetValue(input.First().ToString());
                var secondWireValue = GetValue(input.Split(' ')[2]);

                if (firstWireValue == null || secondWireValue == null)
                {
                    return null;
                }

                var targetWire = wires.FirstOrDefault(w => w.Id == input.Split(' ').Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Split(' ').Last(), Value = ((ushort)(firstWireValue & secondWireValue)) };
                }

                targetWire.Value = ((ushort)(firstWireValue & secondWireValue));

                return targetWire;
            }
            else if (input.Contains("OR"))
            {
                var firstWireValue = GetValue(input.First().ToString());
                var secondWireValue = GetValue(input.Split(' ')[2]);

                if (firstWireValue == null || secondWireValue == null)
                {
                    return null;
                }

                var targetWire = wires.FirstOrDefault(w => w.Id == input.Split(' ').Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Split(' ').Last(), Value = ((ushort)(firstWireValue | secondWireValue)) };
                }

                targetWire.Value = ((ushort)(firstWireValue | secondWireValue));

                return targetWire;
            }
            else if (input.Contains("LSHIFT"))
            {
                var firstWireValue = GetValue(input.First().ToString());
                var shiftValue = GetValue(input.Split(' ')[2]);

                if (firstWireValue == null || shiftValue == null)
                {
                    return null;
                }

                var targetWire = wires.FirstOrDefault(w => w.Id == input.Split(' ').Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Split(' ').Last(), Value = ((ushort)(firstWireValue << shiftValue)) };
                }

                targetWire.Value = ((ushort)(firstWireValue << shiftValue));

                return targetWire;
            }
            else if (input.Contains("RSHIFT"))
            {
                var firstWireValue = GetValue(input.First().ToString());
                var shiftValue = GetValue(input.Split(' ')[2]);

                if (firstWireValue == null || shiftValue == null)
                {
                    return null;
                }

                var targetWire = wires.FirstOrDefault(w => w.Id == input.Split(' ').Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Split(' ').Last(), Value = ((ushort)(firstWireValue >> shiftValue)) };
                }

                targetWire.Value = ((ushort)(firstWireValue >> shiftValue));

                return targetWire;
            }
            else
            {
                // assign value
                var targetWire = wires.FirstOrDefault(w => w.Id == input.Last().ToString());
                var val = GetValue(input.Split(' ').First());

                if (val == null)
                {
                    return null;
                }

                if (targetWire == null)
                {
                    return new Wire { Id = input.Last().ToString(), Value = (ushort)val };
                }

                targetWire.Value = (ushort)val;

                return targetWire;
            }
        }
    }

    public class Wire
    {
        public string Id { get; set; }
        public ushort Value { get; set; }
    }
}