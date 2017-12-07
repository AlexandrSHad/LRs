using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR07_calculator_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Megacalculator using OOP.");
            Console.WriteLine("Choise operation +, -, * or /: ");

            string operation = Console.ReadLine();

            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                Console.WriteLine("Input double number 1: ");
                string inputX = Console.ReadLine();

                Console.WriteLine("Input double number 2: ");
                string inputY = Console.ReadLine();

                double? result = null;

                var calc = new Calculator(inputX, inputY);

                switch (operation)
                {
                    case "+":
                        result = calc.Addition();
                        break;
                    case "-":
                        result = calc.Subtraction();
                        break;
                    case "*":
                        result = calc.Multiplication();
                        break;
                    case "/":
                        result = calc.Division();
                        break;
                }

                if (result != null)
                {
                    Console.WriteLine("{0} {1} {2} = {3}", inputX, operation, inputY, result);
                }
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
