using System;

namespace Helpers
{
    public static class ArrayHelper
    {
        public static int[] CreateArrayInteract()
        {
            Console.Write("Input array size: ");

            int array_size = int.Parse(Console.ReadLine());

            var arr = new int[array_size];

            for (int i = 0; i < array_size; i++)
            {
                Console.Write($"Input element [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        public static void Copy(int[] target_array, int[] source_array, int index)
        {
            for (int i = 0; i < source_array.Length; i++)
            {
                target_array[i + index] = source_array[i];
            }
        }

        public static void Print(int[] arr, string message = "")
        {
            Console.WriteLine();

			if (message != "")
            {
                Console.WriteLine(message);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Print(int[,] arr, string message = "")
        {
            Console.WriteLine();

            if (message != "")
            {
                Console.WriteLine(message);
            }

            for (int i = 0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");

                    if (j == arr.GetLength(1) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
