using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;

namespace task_03._2
{
    class Program
    {
        /*
        3.2. Напишіть програму, яка обєднує 2 масиви та їх сортує
        Н-д: 
          Вхідні дані: 
            Масив 1: 1 6 2 6 11
            Масив 2: 2 5 7 9 3   
          Вихідні дані: 1 2 2 3 5 6 6 7 9 11
        */
        
        static void Main(string[] args)
        {
            int[] arr1 = ArrayHelper.CreateArrayInteract();
            int[] arr2 = ArrayHelper.CreateArrayInteract();

            int[] result_arr = new int[arr1.Length + arr2.Length - 1];

            ArrayHelper.Copy(result_arr, arr1, 0);
            ArrayHelper.Copy(result_arr, arr2, arr1.Length);

            Array.Sort(result_arr);

            ArrayHelper.Print(result_arr, "Combined and sorted array:");

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
