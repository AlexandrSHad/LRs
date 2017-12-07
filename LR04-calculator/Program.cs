using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR04_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Megacalculator. ");
            Console.WriteLine("Choise operation +, -, * or /: ");

            string operation = Console.ReadLine();

            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
            {
                int num1;

                Console.WriteLine("Input integer number 1: ");
                string inputString = Console.ReadLine();

                if (int.TryParse(inputString, out num1))
                {
                    int num2;

                    Console.WriteLine("Input integer number 2: ");
                    inputString = Console.ReadLine();

                    if (int.TryParse(inputString, out num2))
                    {
                        if (!(operation == "/" && num2 == 0))
                        {
                            double result = 0.0;

                            switch (operation)
                            {
                                case "+":
                                    result = num1 + num2;
                                    break;
                                case "-":
                                    result = num1 - num2;
                                    break;
                                case "*":
                                    result = num1 * num2;
                                    break;
                                case "/":
                                    result = (double)num1 / (double)num2;
                                    break;
                            }

                            Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, result);
                        }
                        else
                        {
                            Console.WriteLine("Zero divide.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0} is not an integer.", inputString);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is not an integer.", inputString);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid operation.", operation);
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
