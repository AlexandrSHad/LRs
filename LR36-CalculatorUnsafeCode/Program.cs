using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR36_CalculatorUnsafeCode
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int c;

            Calculator.Add(&a, &b, &c);

            Console.WriteLine(c);

            Calculator.Sub(&a, &b, &c);

            Console.WriteLine(c);

            Calculator.Mult(&a, &b, &c);

            Console.WriteLine(c);

            Calculator.Div(&a, &b, &c);

            Console.WriteLine(c);

            int n = 33;
            NumToByte.Convert(&n);

            Console.ReadLine();
        }
    }
}
