using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    class NumberClass
    {
        private double Number;
        public NumberClass() {
        }
        public double Num {
            get { return Number; }
            set { Number =value; }
        }
    }
}
