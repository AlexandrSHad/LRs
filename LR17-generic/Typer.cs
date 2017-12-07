using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR17_generic
{
    public static class Typer
    {
        public static void GetType<T>(T value)
        {
            Console.WriteLine($"Type of {value} is {value.GetType()}");
        }
    }
}
