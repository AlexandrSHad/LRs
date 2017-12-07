using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace task_05
{
    class Program
    {
        /*
        5. Напишіть програму, яка видаляє елемент з масиву за певним індексом
            Вхідні дані: 8 6 32 54 1 12
            Індекс елемента, що треба видалити: 2
            Вихідні дані: 8 6 54 1 12
        */
        static void Main(string[] args)
        {
            int[] arr = ArrayHelper.CreateArrayInteract();

            Console.Write("Input index of element for deletion: ");

            int del_idx = int.Parse(Console.ReadLine());

            var new_arr = new int[arr.Length - 1];
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != del_idx)
                {
                    new_arr[count] = arr[i];
                    count++;
                }
            }

            ArrayHelper.Print(new_arr, "Array after deletion:");

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
