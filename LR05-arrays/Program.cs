using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR05_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - define
            int[] one_dim_arr = new int[5] { 0, 1, 2, 3, 4 };
            Console.WriteLine("one_dim_arr[3] = {0}", one_dim_arr[3]);

            var multi_dim_arr = new int[2, 2]
            {
                { 7, 9 },
                { 1, 8 }
            };
            Console.WriteLine("multi_dim_arr[0,1] = {0}", multi_dim_arr[0,1]);

            var jug_arr = new int[2][];
            jug_arr[0] = new int[5] { 0, 1, 2, 3, 4 };
            jug_arr[1] = new int[3] { 9, 8, 7 };
            Console.WriteLine("jug_array[1][2] = {0}", jug_arr[1][2]);

            // 2 - output
            Console.WriteLine();
            Console.WriteLine("one_dim_arr: ");

            for (int i=0; i<one_dim_arr.Length; i++)
            {
                Console.Write(one_dim_arr[i] + " ");
            }
            Console.WriteLine();

            // 3 - invert
            var arr = new int[10] { 10, -56, 7, 8, 2, 0, -1, -9, 100, 5 };

            Console.WriteLine();
            Console.WriteLine("inverted arr: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(-1 * arr[i] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
