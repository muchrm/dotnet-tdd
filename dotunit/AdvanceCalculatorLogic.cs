using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotunit
{
    public class AdvanceCalculatorLogic
    {
        ICalculatorLogic _calculatorLogic;
        public AdvanceCalculatorLogic(ICalculatorLogic calculatorLogic)
        {
            _calculatorLogic = calculatorLogic;
        }

        public int AddTwice(int a, int b)
        {
            return _calculatorLogic.Add(a, b) *2;
        }

        public int MultiplyTwice(int a, int b)
        {
            return _calculatorLogic.Multiply(a, b) * 2;
        }
    }
}
