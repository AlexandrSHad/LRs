using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace task_02
{
    class Program
    {
        /*
        2. Напишіть програму, яка зчитує з консолі n елементів, записує їх в масив та виводить суму всіх елементів.
        Н-д: 
           Вхідні дані: 4 6 1
           Вихідні дані: 11
        */
        static void Main(string[] args)
        {
            int[] arr = ArrayHelper.CreateArrayInteract();

            ArrayHelper.Print(arr, "Your array:");

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine();
            Console.WriteLine($"Sum of all elements: {sum}");

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
