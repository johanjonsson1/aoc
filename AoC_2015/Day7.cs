using AoC_Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AoC_2015
{
    /*
    --- Day 7: Some Assembly Required ---
    This year, Santa brought little Bobby Tables a set of wires and bitwise logic gates! 
    Unfortunately, little Bobby is a little under the recommended age range, and he needs help assembling the circuit.

    Each wire has an identifier (some lowercase letters) and can carry a 16-bit signal (a number from 0 to 65535). 
    A signal is provided to each wire by a gate, another wire, or some specific value. 
    Each wire can only get a signal from one source, but can provide its signal to multiple destinations. 
    A gate provides no signal until all of its inputs have a signal.

    The included instructions booklet describes how to connect the parts together: x AND y -> z means to connect wires x and y to an AND gate, and then connect its output to wire z.

    For example:

    123 -> x means that the signal 123 is provided to wire x.
    x AND y -> z means that the bitwise AND of wire x and wire y is provided to wire z.
    p LSHIFT 2 -> q means that the value from wire p is left-shifted by 2 and then provided to wire q.
    NOT e -> f means that the bitwise complement of the value from wire e is provided to wire f.
    Other possible gates include OR (bitwise OR) and RSHIFT (right-shift). 
    If, for some reason, you'd like to emulate the circuit instead, almost all programming languages (for example, C, JavaScript, or Python) provide operators for these gates.

    For example, here is a simple circuit:

    123 -> x
    456 -> y
    x AND y -> d
    x OR y -> e
    x LSHIFT 2 -> f
    y RSHIFT 2 -> g
    NOT x -> h
    NOT y -> i
    After it is run, these are the signals on the wires:

    d: 72
    e: 507
    f: 492
    g: 114
    h: 65412
    i: 65079
    x: 123
    y: 456
    In little Bobby's kit's instructions booklet (provided as your puzzle input), what signal is ultimately provided to wire a?

    Your puzzle answer was 3176.

    --- Part Two ---
    Now, take the signal you got on wire a, override wire b to that signal, and reset the other wires (including wire a). 
    What new signal is ultimately provided to wire a?

    Your puzzle answer was 14710.
     */
    public class Day7 : Day
    {
        public override string Title => "--- Day 7: Some Assembly Required ---";
        public static List<Wire> Wires = new List<Wire>();

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

            //var input = test.ToStringList();
            var input = Inputs.Day7.ToStringList();

            foreach (var instruction in input)
            {
                var wire = BitwiseConverter.GetWire(instruction);
                //Console.WriteLine($"{wire.Id}: {wire.Value}");
                if (wire == null)
                {
                    continue;
                }

                Wires.Add(wire);
            }

            while(Wires.FirstOrDefault(x => x.Id == "a").Value == null)
            {
                var wiresLeftToCompute = Wires.Where(x => x.Value == null).ToList();

                foreach (var wire in wiresLeftToCompute)
                {
                    wire.TryComputeValue();
                }
            }

            Console.WriteLine("Result part 1");
            Console.WriteLine(Wires.FirstOrDefault(x=>x.Id == "a")?.Value);
        }

        public override void PartTwo()
        {
            base.PartTwo();
            Wires = new List<Wire>();
            var input = Inputs.Day7.ToStringList();

            foreach (var instruction in input)
            {
                var wire = BitwiseConverter.GetWire(instruction);
                if (wire.Id == "b")
                {
                    wire.SetValue(3176);
                }

                if (wire == null)
                {
                    continue;
                }

                Wires.Add(wire);
            }

            while (Wires.FirstOrDefault(x => x.Id == "a").Value == null)
            {
                var wiresLeftToCompute = Wires.Where(x => x.Value == null).ToList();

                foreach (var wire in wiresLeftToCompute)
                {
                    wire.TryComputeValue();
                }
            }

            Console.WriteLine("Result part 2");
            Console.WriteLine(Wires.FirstOrDefault(x => x.Id == "a")?.Value);
        }
    }

    public static class BitwiseConverter
    {
        private static ushort? HandleNot(string[] input, bool calculate)
        {
            var fromWire = input[1];

            var firstWireValue = GetValue(fromWire, calculate);
            if (firstWireValue == null)
            {
                return null;
            }

            return (ushort)~firstWireValue;
        }

        private static ushort? HandleAnd(string[] input, bool calculate)
        {
            var firstWireValue = GetValue(input[0], calculate);
            var secondWireValue = GetValue(input[2], calculate);

            if (firstWireValue == null || secondWireValue == null)
            {
                return null;
            }

            return (ushort)(firstWireValue & secondWireValue);
        }

        private static ushort? HandleOr(string[] input, bool calculate)
        {
            var firstWireValue = GetValue(input[0], calculate);
            var secondWireValue = GetValue(input[2], calculate);

            if (firstWireValue == null || secondWireValue == null)
            {
                return null;
            }

            return (ushort)(firstWireValue | secondWireValue);
        }

        private static ushort? HandleLShift(string[] input, bool calculate)
        {
            var firstWireValue = GetValue(input[0], calculate);
            var shiftValue = GetValue(input[2], calculate);

            if (firstWireValue == null || shiftValue == null)
            {
                return null;
            }

            return (ushort)(firstWireValue << shiftValue);
        }

        private static ushort? HandleRShift(string[] input, bool calculate)
        {
            var firstWireValue = GetValue(input[0], calculate);
            var shiftValue = GetValue(input[2], calculate);

            if (firstWireValue == null || shiftValue == null)
            {
                return null;
            }

            return (ushort)(firstWireValue >> shiftValue);
        }

        private static ushort? HandleAssign(string[] input, bool calculate)
        {
            var val = GetValue(input[0], calculate);

            if (val == null)
            {
                return null;
            }

            return (ushort)val;
        }

        public static Wire GetWire(string input)
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
            var toWire = inputArray.Last();

            if (input.StartsWith("NOT"))
            {
                return new Wire(toWire, HandleNot, inputArray);
            }
            else if (input.Contains("AND"))
            {
                return new Wire(toWire, HandleAnd, inputArray);
            }
            else if (input.Contains("OR"))
            {
                return new Wire(toWire, HandleOr, inputArray);
            }
            else if (input.Contains("LSHIFT"))
            {
                return new Wire(toWire, HandleLShift, inputArray);
            }
            else if (input.Contains("RSHIFT"))
            {
                return new Wire(toWire, HandleRShift, inputArray);
            }
            else
            {
                return new Wire(toWire, HandleAssign, inputArray);
            }
        }

        private static ushort? GetValue(string valueOrId, bool recalculate)
        {
            if (Regex.Match(valueOrId, "[a-z]+").Success)
            {
                var wire = Day7.Wires.FirstOrDefault(w => w.Id == valueOrId);

                if (recalculate && wire != null)
                {
                    wire.TryComputeValue();
                }

                return wire?.Value;
            }

            return ushort.Parse(valueOrId);
        }
    }

    public class Wire
    {
        public string Id { get; set; }
        public ushort? Value { get; private set; }

        private readonly Func<string[], bool, ushort?> Operation;
        private readonly string[] OperationInput;

        public Wire(string id, Func<string[], bool, ushort?> operation, string[] operationInput)
        {
            Id = id;
            Operation = operation;
            OperationInput = operationInput;
            TryComputeValue();
        }

        public bool TryComputeValue()
        {
            var result = Operation.Invoke(OperationInput, false);

            if (result != null)
            {
                Value = (ushort)result;
                return true;
            }

            return false;
        }

        public void SetValue(ushort newValue)
        {
            Value = newValue;
        }
    }
}