using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR06_min_max_average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculation Min, Max, Average of array of integer.");
            Console.Write("Input array length: ");
            string inputString = Console.ReadLine();

            Console.WriteLine();

            int length;

            if (int.TryParse(inputString, out length))
            {
                var arr = new int[length];

                int i = 0;

                while (i<length)
                {
                    Console.Write("Input element {0}: ", i);
                    inputString = Console.ReadLine();

                    int value;

                    if (int.TryParse(inputString, out value))
                    {
                        arr[i] = value;
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("{0} is not an integer. Try again.", inputString);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Your arr: ");

                int min = arr[0];
                int max = arr[0];
                int sum = 0;
                double avr;

                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j] + " ");

                    if (arr[j] < min)
                    {
                        min = arr[j];
                    }

                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }

                    sum += arr[j];
                }

                avr = (double)sum / (double)length;

                Console.WriteLine();
                Console.WriteLine("Min: {0}", min);
                Console.WriteLine("Max: {0}", max);
                Console.WriteLine("Average: {0}", avr);
            }
            else
            {
                Console.WriteLine("{0} is not an integer.", inputString);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
