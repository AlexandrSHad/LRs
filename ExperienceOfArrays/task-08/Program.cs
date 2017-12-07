using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace task_08
{
    class Program
    {
        /*
        8. Дана матриця А розміром nxm.
        Знайти в матриці першту строку, всі елементи якої дорівнюють 0.
        Помножити всі елементи стовпа з таким номером на 2.
            Вхідні дані:  5 4 8 5 7 5 
                          7 5 3 2 1 6
                          0 0 0 0 0 0 
                          1 6 9 8 5 4
 
            Вихідні дані:  5 4 16 5 7 5 
                           7 5 6 2 1 6
                           0 0 0 0 0 0 
                           1 6 18 8 5 4
        */
        static void Main(string[] args)
        {
            var arr = new int[4, 6]
            {
                { 5, 4, 8, 5, 7, 5 },
                { 7, 5, 3, 2, 1, 6 },
                { 0, 0, 0, 0, 0, 0 },
                { 1, 6, 9, 8, 5, 4 }
            };

            ArrayHelper.Print(arr, "Your array:");

            int idx;

            for (idx = 0; idx < arr.GetLength(0); idx++)
            {
                int sum = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum += arr[idx, j];
                }

                if (sum == 0)
                {
                    break;
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                arr[i, idx] *= 2;
            }

            ArrayHelper.Print(arr, "Result array:");

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
