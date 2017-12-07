using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR28_fibonacci_to_file
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonachi nums to file.");
            Console.Write("Input file name: ");
            string fileName = Console.ReadLine();

            Console.Write("Input num's count: ");
            int numCount = int.Parse(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                int i = 1, j = 1, val;

                while (numCount > 0)
                {
                    writer.WriteLine(j);
                    Console.Write("{0} ", j);

                    val = i + j;
                    j = i;
                    i = val;

                    numCount--;
                }
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
