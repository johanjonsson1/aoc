using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC_2015
{
    public class Day7 : IDay
    {
        public string Title => "Day 7";

        public void Run()
        {
            PartOne();
        }

        private void PartOne()
        {
            Console.WriteLine("bitwise part 1");
            var test = @"123 -> x
456 -> y
x AND y -> d
x OR y -> e
x LSHIFT 2 -> f
y RSHIFT 2 -> g
NOT x -> h
NOT y -> i";

            var input = test.ToStringList();
            var wires = new List<Wire>();

            foreach (var instruction in input)
            {
                var wire = BitwiseConverter.GetWire(instruction, wires);
                Console.WriteLine($"{wire.Id}: {wire.Value}");
                wires.Add(wire);
            }
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
            var inputArray = input.Split(' ');
            if (input.StartsWith("NOT"))
            {
                var fromWire = inputArray[1];
                var toWire = inputArray[3];

                var firstWireValue = wires.FirstOrDefault(w => w.Id == fromWire)?.Value ?? 0;
                var targetWire = wires.FirstOrDefault(w => w.Id == toWire);

                if (targetWire == null)
                {
                    return new Wire { Id = toWire, Value = (short)~firstWireValue };
                }

                targetWire.Value = (short)~firstWireValue;

                return targetWire;
            }
            else if (input.Contains("AND"))
            {
                var firstWireValue = wires.FirstOrDefault(w => w.Id == input.First().ToString())?.Value ?? 0;
                var secondWireValue = wires.FirstOrDefault(w => w.Id == input.Split(' ')[2].ToString())?.Value ?? 0;
                var targetWire = wires.FirstOrDefault(w => w.Id == input.Split(' ').Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Split(' ').Last(), Value = (short)(firstWireValue & (short)secondWireValue) };
                }

                targetWire.Value = (short)(firstWireValue & (short)secondWireValue);

                return targetWire;
            }
            else if (input.Contains("OR"))
            {
                var firstWireValue = wires.FirstOrDefault(w => w.Id == input.First().ToString())?.Value ?? 0;
                var secondWireValue = wires.FirstOrDefault(w => w.Id == input.Split(' ')[2].ToString())?.Value ?? 0;
                var targetWire = wires.FirstOrDefault(w => w.Id == input.Split(' ').Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Split(' ').Last(), Value = (short)(firstWireValue | (short)secondWireValue) };
                }

                targetWire.Value = (short)(firstWireValue | (short)secondWireValue);

                return targetWire;
            }
            else if (input.Contains("LSHIFT"))
            {
                var firstWireValue = wires.FirstOrDefault(w => w.Id == input.First().ToString())?.Value ?? 0;
                var shiftValue = int.Parse(input.Split(' ')[2]);
                var targetWire = wires.FirstOrDefault(w => w.Id == input.Split(' ').Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Split(' ').Last(), Value = (short)(firstWireValue << shiftValue) };
                }

                targetWire.Value = (short)(firstWireValue << shiftValue);

                return targetWire;
            }
            else if (input.Contains("RSHIFT"))
            {
                var firstWireValue = wires.FirstOrDefault(w => w.Id == input.First().ToString())?.Value ?? 0;
                var shiftValue = int.Parse(input.Split(' ')[2]);
                var targetWire = wires.FirstOrDefault(w => w.Id == input.Split(' ').Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Split(' ').Last(), Value = (short)(firstWireValue >> shiftValue) };
                }

                targetWire.Value = (short)(firstWireValue >> shiftValue);

                return targetWire;
            }
            else
            {
                // assign value
                var targetWire = wires.FirstOrDefault(w => w.Id == input.Last().ToString());

                if (targetWire == null)
                {
                    return new Wire { Id = input.Last().ToString(), Value = (short)int.Parse(input.Split(' ').First()) };
                }

                targetWire.Value = (short)int.Parse(input.Split(' ').First());

                return targetWire;
            }
        }
    }

    public class Wire
    {
        public string Id { get; set; }
        public Int16 Value { get; set; }
    }
}