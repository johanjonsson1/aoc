using System;
using System.Collections.Generic;

namespace AoC.Common
{
    /// <summary>
    /// Made from 2017/day18 and added sub and jnz from day23
    /// </summary>
    public class InstructionParser
    {
        protected readonly Dictionary<char, long> Registers;

        protected readonly Dictionary<string, Func<int, string, int>> Operation =
            new Dictionary<string, Func<int, string, int>>();

        protected long LastPlayed;

        public long RecoverValue { get; private set; }

        private InstructionParser()
        {
            Operation.Add("snd", Snd);
            Operation.Add("set", Set);
            Operation.Add("add", Add);
            Operation.Add("mul", Mul);
            Operation.Add("mod", Mod);
            Operation.Add("rcv", Rcv);
            Operation.Add("jgz", Jgz);
            Operation.Add("sub", Sub);
            Operation.Add("jnz", Jnz);
        }

        public InstructionParser(Dictionary<char, long> registers) : this()
        {
            Registers = registers;
        }

        public int PerformInstruction(int currentIndex, string instruction)
        {
            return Operation[instruction.Substring(0, 3)]
                .Invoke(currentIndex, instruction.Substring(4, instruction.Length - 4));
        }

        protected virtual int Sub(int currentIndex, string instruction)
        {
            var split = instruction.Split();
            var x = split[0].AsChar();
            var y = split[1];
            //sub X Y decreases register X by the value of Y.
            if (int.TryParse(y, out var value))
            {
                Registers[x] -= value;
            }
            else
            {
                Registers[x] -= Registers[y.AsChar()];
            }

            return currentIndex + 1;
        }

        protected virtual int Snd(int currentIndex, string instruction)
        {
            //snd X plays a sound with a frequency equal to the value of X.
            //_registersLastPlayed[instruction.AsChar()] = _registers[instruction.AsChar()];
            var x = instruction.AsChar();
            LastPlayed = Registers[x];

            return currentIndex + 1;
        }

        protected virtual int Set(int currentIndex, string instruction)
        {
            var split = instruction.Split();
            var x = split[0].AsChar();
            var y = split[1];
            //set X Y sets register X to the value of Y.
            if (int.TryParse(y, out var value))
            {
                Registers[x] = value;
            }
            else
            {
                Registers[x] = Registers[y.AsChar()];
            }

            return currentIndex + 1;
        }

        protected virtual int Add(int currentIndex, string instruction)
        {
            var split = instruction.Split();
            var x = split[0].AsChar();
            var y = split[1];
            //add X Y increases register X by the value of Y.
            if (long.TryParse(y, out var value))
            {
                Registers[x] += value;
            }
            else
            {
                Registers[x] += Registers[y.AsChar()];
            }

            return currentIndex + 1;
        }

        protected virtual int Mul(int currentIndex, string instruction)
        {
            var split = instruction.Split();
            var x = split[0].AsChar();
            var y = split[1];
            //mul X Y sets register X to the result of multiplying the value contained in register X by the value of Y.
            if (long.TryParse(y, out var value))
            {
                Registers[x] *= value;
            }
            else
            {
                Registers[x] *= Registers[y.AsChar()];
            }

            return currentIndex + 1;
        }

        protected virtual int Mod(int currentIndex, string instruction)
        {
            var split = instruction.Split();
            var x = split[0].AsChar();
            var y = split[1];
            //mod X Y sets register X to the remainder of dividing the value contained in register X by the value of Y (that is, it sets X to the result of X modulo Y).
            if (long.TryParse(y, out var value))
            {
                Registers[x] %= value;
            }
            else
            {
                Registers[x] %= Registers[y.AsChar()];
            }

            return currentIndex + 1;
        }

        protected virtual int Rcv(int currentIndex, string instruction)
        {
            //rcv X recovers the frequency of the last sound played, but only when the value of X is not zero. (If it is zero, the command does nothing.)

            if (Registers[instruction.AsChar()] != 0)
            {
                RecoverValue = LastPlayed;
            }

            return currentIndex + 1;
        }

        protected virtual int Jgz(int currentIndex, string instruction)
        {
            var split = instruction.Split();
            var x = split[0];
            var y = split[1];
            //jgz X Y jumps with an offset of the value of Y, but only if the value of X is greater than zero.
            //(An offset of 2 skips the next instruction, an offset of -1 jumps to the previous instruction, and so on.)
            long gtZero = 0;
            if (long.TryParse(x, out var value))
            {
                gtZero = value;
            }
            else
            {
                gtZero = Registers[x.AsChar()];
            }

            if (gtZero <= 0)
            {
                return currentIndex + 1;
            }

            if (int.TryParse(y, out var ind))
            {
                return currentIndex + ind;
            }

            return currentIndex + (int) Registers[x.AsChar()];

        }

        protected virtual int Jnz(int currentIndex, string instruction)
        {
            var split = instruction.Split();
            var x = split[0];
            var y = split[1];
            //jnz X Y jumps with an offset of the value of Y, but only if the value of X is not zero.
            //(An offset of 2 skips the next instruction, an offset of -1 jumps to the previous instruction, and so on.)
            long zero;
            if (long.TryParse(x, out var value))
            {
                zero = value;
            }
            else
            {
                zero = Registers[x.AsChar()];
            }

            if (zero == 0)
            {
                return currentIndex + 1;
            }

            if (int.TryParse(y, out var ind))
            {
                return currentIndex + ind;
            }

            return currentIndex + (int) Registers[x.AsChar()];
        }
    }
}