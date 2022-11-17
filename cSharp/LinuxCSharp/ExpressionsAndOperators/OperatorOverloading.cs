using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressionsAndOperators
{
    class EOLimitedInt{
        const int MaxValue = 100;
        const int MinValue = 0;

        public static EOLimitedInt operator -(EOLimitedInt x) {
            // in this strange class, negating a value just sets its value to 0.
            EOLimitedInt EOli = new EOLimitedInt();
            EOli.TheValue = 0;
            return EOli;
        }

        public static EOLimitedInt operator -(EOLimitedInt x, EOLimitedInt y) {
            EOLimitedInt EOli = new EOLimitedInt();
            EOli.TheValue = x.TheValue - y.TheValue;
            return EOli;
        }

        public static EOLimitedInt operator +(EOLimitedInt x, double y) {
            EOLimitedInt EOli = new EOLimitedInt();
            EOli.TheValue = x.TheValue + (int)y;
            return EOli;
        }

        private int _theValue = 0;
        public int TheValue {
            get { return _theValue;}
            set {
                if (value < MinValue)
                    _theValue = 0;
                else
                    _theValue = value > MaxValue
                                ? MaxValue  
                                : value;
            }
        }
    }
    public static class OperatorOverloading
    {
        public static void RunIt() {
            EOLimitedInt EOli1 = new EOLimitedInt();
            EOLimitedInt EOli2 = new EOLimitedInt();
            EOLimitedInt EOli3 = new EOLimitedInt();
            EOli1.TheValue = 10; EOli2.TheValue = 26;
            Console.WriteLine($"EOli1: { EOli1.TheValue }, EOli2: {EOli2.TheValue}");

            EOli3 = -EOli1;
            Console.WriteLine($"-{ EOli1.TheValue } = {EOli3.TheValue}");
            EOli3 = EOli2 - EOli1;
            Console.WriteLine($"{ EOli2.TheValue } - {EOli1.TheValue} = {EOli3.TheValue}");
            EOli3 = EOli1 - EOli2;
            Console.WriteLine($"{ EOli1.TheValue } - {EOli2.TheValue} = {EOli3.TheValue}");

        }
    }
}