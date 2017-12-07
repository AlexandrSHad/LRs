using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace task_03._1
{
    class Program
    {
        /*
        3.1. Напишіть програму, яка зчитує з консолі n елементів, записує їх в масив та виводить на консоль 
        лише унікальні елементи
        Н-д: 
         Вхідні дані: 1 6 1 
         Вихідні дані: 6
        */

        static void Main(string[] args)
        {
            int[] arr = ArrayHelper.CreateArrayInteract();

            var uniq_arr = new int[arr.Length];
            int count = 0;

            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                int currElement = arr[i];
                bool unique = true;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (j != i)
                    {
                        if (arr[j] == currElement)
                        {
                            unique = false;
                        }
                    }
                }

                if (unique)
                {
                    uniq_arr[count] = arr[i];
                    count++;
                }
            }

            ArrayHelper.Print(uniq_arr, "Array of unique elements:");

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
