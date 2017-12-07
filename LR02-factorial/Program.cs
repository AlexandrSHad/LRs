using System;

namespace LR02_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer: ");

            string inputString = Console.ReadLine();

            int num;

            if (int.TryParse(inputString, out num))
            {
                long result = 1;

                for (int i = 1; i <= num; i++)
                {
                    result *= i;
                }

                Console.WriteLine("Factorial {0} is {1}", num, result);
            }
            else
            {
                Console.WriteLine("{0} is not an integer", inputString);
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
