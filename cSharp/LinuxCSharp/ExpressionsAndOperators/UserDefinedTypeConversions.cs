using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressionsAndOperators
{
    class LimitedInt {
        const int MaxValue = 100;
        const int MinValue = 0;
        public static explicit operator int(LimitedInt li) {    //with explicit you will need conversion operator
            return li.TheValue;
        }

        public static implicit operator float(LimitedInt li) { // implicit doesn't need it
            return li.TheValue;
        }

        public static implicit operator LimitedInt(int x) {
            LimitedInt li = new LimitedInt();
            li.TheValue = x;
            return li;
        }

        private int mTheValue = 0;
        public int TheValue {
            get { return mTheValue;}
            set {
                if (value < MinValue)
                    mTheValue = 0;
                else    
                    mTheValue = value > MaxValue
                                ? MaxValue     
                                : value;
            }
        }

    }
    public static class UserDefinedTypeConversions
    {
        public static void RunIt() {
            LimitedInt li = 500;        // Convert 500 to LimitedInt
            int value     = (int)li;         // Convert LimitedInt to int

            Console.WriteLine($"li: { li.TheValue }, value: {value}");

            li = 80;
            float fvalue = li;

            Console.WriteLine($"li: { li.TheValue }, value: {fvalue}");
        }
    }
}