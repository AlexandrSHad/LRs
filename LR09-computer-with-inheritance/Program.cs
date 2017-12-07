using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR09_computer_with_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var laptop = new Laptop(2, 2.5, 8, 1000);
            var desktop = new Desktop(4, 3.0, 16, 1250);

            laptop.Print();

            Console.WriteLine();

            desktop.Print();

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
