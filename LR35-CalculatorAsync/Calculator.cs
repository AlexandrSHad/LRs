using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LR35_CalculatorAsync
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            Thread.Sleep(a);
            return a + b;
        }

        public static Task<int> AddAsync(int a, int b)
        {
            return Task.Run(() => Add(a, b));
        }
    }
}
