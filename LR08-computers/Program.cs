using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR08_computers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Computers manager.");

            var computers = new Computer[11]
            {
                new Computer(ComputerType.Serer,   16, 2.5, 56, 2000),
                new Computer(ComputerType.Serer,   16, 3.0, 32, 5000),
                new Computer(ComputerType.Desktop,  2, 3.0,  8, 1000),
                new Computer(ComputerType.Desktop,  4, 2.5, 16,  750),
                new Computer(ComputerType.Desktop,  4, 2.5,  8,  500, false),
                new Computer(ComputerType.Desktop,  2, 1.8,  2,  500),
                new Computer(ComputerType.Desktop,  1, 2.0,  4,  300),
                new Computer(ComputerType.Desktop,  4, 2.2,  8,  500),
                new Computer(ComputerType.Laptop,   2, 2.5,  4,  500),
                new Computer(ComputerType.Laptop,   4, 2.5,  8,  750, false),
                new Computer(ComputerType.Laptop,   2, 3.2, 16, 1250)
            };

            Console.WriteLine();
            var computersManager = new ComputersManager(computers);


            Console.WriteLine("GetComputers by type: ");

            var searchedComputers = computersManager.GetComputers(ComputerType.Laptop);

            ShowList(searchedComputers);

            Console.WriteLine();
            Console.WriteLine("GetMostPowerfulComputers: ");

            searchedComputers = computersManager.GetMostPowerfulComputers();

            ShowList(searchedComputers);


            Console.WriteLine();
            Console.WriteLine("GetComputers by status: ");

            searchedComputers = computersManager.GetComputers(false);

            ShowList(searchedComputers);


            Console.WriteLine();
            Console.WriteLine("GetComputers by required memory: ");

            searchedComputers = computersManager.GetComputers(16);

            ShowList(searchedComputers);


            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        static void ShowList(Computer[] computersArray)
        {
            foreach (var comp in computersArray)
            {
                if (comp != null)
                {
                    Console.WriteLine();
                    comp.GetInfo();
                }
            }
        }
    }
}
