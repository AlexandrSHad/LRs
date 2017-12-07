using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace task_04
{
    class Program
    {
        /*
        4. Напишіть програму, яка розділяє масив на 2 масиви. Перший зберігає парні числа, другий непарні
        Н-д: 
           Вхідні дані: 25 47 42 56 32 
           Вихідні дані: 
             Парні елементи - 42, 56, 32
             Непарні елементи - 25, 47
        */
        static void Main(string[] args)
        {
            int[] arr = ArrayHelper.CreateArrayInteract();

            var even_arr = new int[arr.Length];
            var nevn_arr = new int[arr.Length];

            int count_ev = 0;
            int count_nv = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even_arr[count_ev] = arr[i];
                    count_ev++;
                }
                else
                {
                    nevn_arr[count_nv] = arr[i];
                    count_nv++;
                }
            }

            ArrayHelper.Print(even_arr, "Array of even elements:");

            ArrayHelper.Print(nevn_arr, "Array of not even elements:");

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
