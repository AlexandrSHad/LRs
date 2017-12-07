using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR17_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Typer.GetType<int>(100);
            Typer.GetType<double>(10.0);
            Typer.GetType<decimal>(10.0m);
            Typer.GetType<string>("Generic");
            Typer.GetType<char>('d');

            Console.ReadLine();
        }
    }
}
