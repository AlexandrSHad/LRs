using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR36_CalculatorUnsafeCode
{
    public static class Calculator
    {
        unsafe public static void Add(int *a, int *b, int *c)
        {
            *c = *a + *b;
        }

        unsafe public static void Sub(int* a, int* b, int* c)
        {
            *c = *a - *b;
        }

        unsafe public static void Mult(int* a, int* b, int* c)
        {
            *c = *a * *b;
        }

        unsafe public static void Div(int* a, int* b, int* c)
        {
            if (*b == 0)
            {
                *c = 0;
            }

            *c = *a / *b;
        }
    }
}
