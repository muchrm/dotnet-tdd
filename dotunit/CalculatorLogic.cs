using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotunit
{
    public class CalculatorLogic: ICalculatorLogic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return _multi(a, b);
        }

        private int _multi(int a,int b)
        {
            return a * b;
        }
    }
}
