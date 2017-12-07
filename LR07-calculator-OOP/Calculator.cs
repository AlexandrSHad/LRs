using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR07_calculator_OOP
{
    public class Calculator
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Calculator(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Calculator(int x, int y)
        {
            X = (double)x;
            Y = (double)y;
        }

        public Calculator(string inputX, string inputY)
        {
            X = SafeParse(inputX);
            Y = SafeParse(inputY);
        }

        public double? Addition()
        {
            return X + Y;
        }

        public double? Subtraction()
        {
            return X - Y;
        }

        public double? Multiplication()
        {
            return X * Y;
        }

        public double? Division()
        {
            if (Y == 0)
            {
                Console.WriteLine("Zero divide.");
                return null;
            }

            return X / Y;
        }

        private double SafeParse(string inputString)
        {
            double result = 0.0;

            if (!double.TryParse(inputString, out result))
            {
                Console.WriteLine($"{inputString} is not a double.");
            }

            return result;
        }
    }
}
