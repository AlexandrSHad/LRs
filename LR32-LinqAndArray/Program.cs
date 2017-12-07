using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRsGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 4, 6, 1 };

            Console.WriteLine($"Summ of 4, 6, 1 is {nums1.Sum()}.");

            var nums2 = new int[] { 1, 6, 1 };

            //var uniqueNums = nums2.Where(x => nums2.Count(n => n == x) == 1);
            var uniqueNums = nums2.GroupBy(n => n).Where(g => g.Count() == 1).Select(s => s.Key);

            Console.Write("Unique nums: ");
            foreach (var n in uniqueNums)
            {
                Console.Write(n + " ");
            }

            var nums3 = new int[] { 25, 47, 42, 56, 32 };

            var evenNums = nums3.Where(x => x % 2 == 0).ToArray();
            var notEvenNums = nums3.Where(x => x % 2 != 0).ToArray();

            Console.WriteLine();
            Console.Write("Even nums: ");
            foreach(var n in evenNums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.Write("Not even nums: ");
            foreach (var n in notEvenNums)
            {
                Console.Write(n + " ");
            }

            Console.ReadLine();
        }
    }
}
