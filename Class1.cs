using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    class NumberClass
    {
        private float Number;
        public NumberClass() {
        }
        public double Num {
            get { return Number; }
            set { Number = (float)value; }
        }
    }
}
