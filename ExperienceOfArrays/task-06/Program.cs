using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_06
{
    class Program
    {
        /*
        6. Напишіть програму, що приймає на вхід елементи матриці 3х3 (2-мірний масив) та виводить її
        на друк
         Вхідні дані:
           element - [0],[0] : 1 
           element - [0],[1] : 2 
           element - [0],[2] : 3 
           element - [1],[0] : 4 
           element - [1],[1] : 5 
           element - [1],[2] : 6 
           element - [2],[0] : 7 
           element - [2],[1] : 8 
           element - [2],[2] : 9 
         Вихідні дані:  1 2 3 
                        4 5 6 
                        7 8 9
        */
        static void Main(string[] args)
        {
            int array_size = 3;

            var arr = new int[array_size, array_size];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Input element [{i},{j}]: ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your array:");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                    if (j == arr.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
