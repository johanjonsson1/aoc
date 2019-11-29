using System;
using System.Collections.Generic;
using System.Linq;
using AoC.Common;

namespace AoC2017
{
    public class Day8 : IDay
    {
        public string Title => "2017 Day8";

        public void Run()
        {
            var test = @"b inc 5 if a > 1
a inc 1 if b < 5
c dec -10 if a >= 1
c inc -20 if c == 10";
            var input = Inputs.Day8.ToStringList();
            var store = new RegisterStore();

            foreach (var instruction in input)
            {
                Instruction inst = ConvertToInstruction(instruction);
                ProcessInstruction(inst, store);
            }

            Console.WriteLine(store.Greatest);
            Console.WriteLine(store.GreatestEver);
        }

        private void ProcessInstruction(Instruction instruction, RegisterStore registerStore)
        {
            var ifRegister = instruction.IfRegister;
            var ifValue = instruction.IfValue;
            var sign = instruction.Sign;
            var register = instruction.Register;
            var value = instruction.Value;
            var registerValue = registerStore.Get(register);
            var ifRegisterValue = registerStore.Get(ifRegister);

            var perform = false;
            switch (instruction.Operator)
            {
                case Operator.Lt:
                    if (ifRegisterValue < ifValue)
                    {
                        perform = true;
                    }
                    break;
                case Operator.Le:
                    if (ifRegisterValue <= ifValue)
                    {
                        perform = true;
                    }
                    break;
                case Operator.Gt:
                    if (ifRegisterValue > ifValue)
                    {
                        perform = true;
                    }
                    break;
                case Operator.Ge:
                    if (ifRegisterValue >= ifValue)
                    {
                        perform = true;
                    }
                    break;
                case Operator.Eq:
                    if (ifRegisterValue == ifValue)
                    {
                        perform = true;
                    }
                    break;
                case Operator.Ne:
                    if (ifRegisterValue != ifValue)
                    {
                        perform = true;
                    }
                    break;
                default:
                    break;
            }

            if (perform)
            {
                if (sign == Sign.Plus)
                {
                    registerStore.Set(register, registerValue += value);
                }
                else
                {
                    registerStore.Set(register, registerValue -= value);
                }
            }
        }

        private Instruction ConvertToInstruction(string input)
        {
            var split = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var instruction = new Instruction();
            instruction.Register = split[0];
            instruction.Sign = split[1] == "inc" ? Sign.Plus : Sign.Minus;
            instruction.Value = int.Parse(split[2]);
            instruction.IfRegister = split[4];
            instruction.IfValue = int.Parse(split[6]);

            switch (split[5])
            {
                case "==":
                    instruction.Operator = Operator.Eq;
                    break;
                case "!=":
                    instruction.Operator = Operator.Ne;
                    break;
                case ">=":
                    instruction.Operator = Operator.Ge;
                    break;
                case "<=":
                    instruction.Operator = Operator.Le;
                    break;
                case ">":
                    instruction.Operator = Operator.Gt;
                    break;
                case "<":
                    instruction.Operator = Operator.Lt;
                    break;
                default:
                    break;
            }

            return instruction;
        }
    }

    public class RegisterStore
    {
        private Dictionary<string, int> _store = new Dictionary<string, int>();
        private int _highest = 0;

        public int Get(string registerName)
        {
            if (!_store.ContainsKey(registerName))
            {
                _store[registerName] = 0;
            }

            return _store[registerName];
        }

        public void Set(string registerName, int value)
        {
            _store[registerName] = value;

            if (value > _highest)
            {
                _highest = value;
            }
        }

        public int Greatest => _store.Values.Max();
        public int GreatestEver => _highest;
    }

    public class Instruction
    {
        public Operator Operator { get; set; }
        public string Register { get; set; }
        public string IfRegister { get; set; }
        public Sign Sign { get; set; }
        public int Value { get; set; }
        public int IfValue { get; set; }
    }

    public enum Sign
    {
        Plus,
        Minus
    }

    public enum Operator
    {
        Lt,
        Le,
        Gt,
        Ge,
        Eq,
        Ne
    }
}
