using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR34_CalculatorUnitTest
{
    public static class Calculator
    {
        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
}
