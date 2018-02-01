using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR35_CalculatorAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = new Stopwatch();
            w.Start();

            DoWork();

            w.Stop();
            Console.WriteLine(w.ElapsedMilliseconds);

            w.Reset();
            w.Start();

            //DoWorkAsync();          // run and do not wait
            //var t = DoWorkAsync();  // run and wait
            var t = DoWorkParallel();
            t.Wait();

            w.Stop();
            Console.WriteLine(w.ElapsedMilliseconds);

            Console.ReadLine();
        }

        private static void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                int r = Calculator.Add(i * 100, 1000);

                Console.WriteLine($"result: {r}");
            }
        }

        private static async Task DoWorkAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                int r = await Calculator.AddAsync(i * 100, 1000);

                Console.WriteLine($"result: {r}");
            }
        }

        private static async Task DoWorkParallel()
        {
            var taskList = new List<Task<int>>();

            for (int i = 0; i < 10; i++)
            {
                var task = Calculator.AddAsync(i * 100, 1000);

                taskList.Add(task);
            }

            await Task.WhenAll(taskList.ToArray());

            foreach (var task in taskList)
            {
                Console.WriteLine($"result: {task.Result}");
            }
        }
    }
}
