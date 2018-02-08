using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR36_CalculatorUnsafeCode
{
    public static class NumToByte
    {
        unsafe public static void Convert(int* num)
        {
            Console.WriteLine("Binary: {0}", System.Convert.ToString(*num, 2));
            Console.WriteLine("Addres: {0}", new IntPtr(num).ToString("x8"));
        }
    }
}
