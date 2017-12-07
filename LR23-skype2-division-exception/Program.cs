using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR23_skype2_division_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                double result = num1 / num2;

                Console.WriteLine("Output:");
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Output:");
                Console.WriteLine(e.GetType().Name);
            }

            Console.ReadLine();
        }
    }
}
