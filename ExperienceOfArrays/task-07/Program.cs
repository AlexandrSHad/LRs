using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_07
{
    class Program
    {
        /*
        7. Напишіть програму, яка в масиві знаходить числа, сума яких дорівнює 0
            Вхідні дані: 5 -11 25 -40 -14 7 4 -2
            Вихідні дані:(-11 7 4), (-11 25 -14)
        */
        static void Main(string[] args)
        {
            var arr = new int[] { 5, -11, 25, -40, -14, 7, 4, -2 };

            int[][] all_combinations = GetAllCombinations(arr);

            for (int i = 0; i < all_combinations.Length; i++)
            {
                int sum = GetSumOfArrayElements(all_combinations[i]);

                if (sum == 0)
                {
                    Console.Write("(");
                    for (int j = 0; j < all_combinations[i].Length; j++)
                    {
                        Console.Write(all_combinations[i][j] + " ");
                    }
                    Console.WriteLine(")");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        static int GetSumOfArrayElements(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        static int[][] GetAllCombinations(int[] arr)
        {
            int count = (int)Math.Pow(2, arr.Length)- 1;
            var all_combinations = new int[count][];

            for (int i = 0; i < count; i++)
            {
                string str = Convert.ToString(i + 1, 2).PadLeft(arr.Length, '0');

                char[] char_arr = str.ToCharArray();
                Array.Reverse(char_arr);

                all_combinations[i] = new int[GetNeededSize(char_arr)];

                int n = 0;

                for (int j = 0; j < char_arr.Length; j++)
                {
                    if (char_arr[j] == '1')
                    {
                        Console.Write(arr[j] + " ");
                        all_combinations[i][n] = arr[j];
                        n++;
                    }
                }
                Console.WriteLine();
            }

            return all_combinations;
        }

        private static int GetNeededSize(char[] char_arr)
        {
            int k = 0;
            for (int j = 0; j < char_arr.Length; j++)
            {
                if (char_arr[j] == '1')
                {
                    k++;
                }
            }

            return k;
        }
    }
}
