using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    class Program
    {
        /*
        1. Напишіть програму, яка зчитує з консолі n елементів, записує їх в масив та виводить їх на консоль 
        в зворотньому порядку.
        Н-д: 
            Вхідні дані: 4 6 7 5 3 4
            Вихідні дані: 4 3 5 7 6 4
        */
        static void Main(string[] args)
        {
            Console.Write("Input array size: ");

            int array_size = int.Parse(Console.ReadLine());

            var arr = new int[array_size];

            for (int i = 0; i<array_size; i++)
            {
                Console.Write($"Input element [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Yuor array:");

            for (int i = array_size-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
