using System;

namespace LR16_event_calculator
{
    class Program
    {
        delegate int Expression(int x, int y);

        static void Main(string[] args)
        {
            Expression Calculator = null;

            Console.Write("Enter the first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter the first number: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Enter action (+,-,*,/): ");
            string action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Calculator = (a, b) => a + b;
                        break;
                case "-":
                    Calculator = (a, b) => a - b;
                    break;
                case "*":
                    Calculator = (a, b) => a * b;
                    break;
                case "/":
                    Calculator = (a, b) => a / b;
                    break;
                default:
                    Console.WriteLine("Error: Incorrect action.");
                    break;
            }

            int result = Calculator(x, y);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
