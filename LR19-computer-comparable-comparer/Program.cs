using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19_computer_comparable_comparer
{
    class Program
    {
        static List<Computer> computerList = new List<Computer>
        {
            new Computer("Server", 3.6, 52, 2000),
            new Computer("Desktop1", 3.0, 8, 500),
            new Computer("Desktop2", 2.4, 4, 750),
            new Computer("Laptop2", 1.6, 2, 120),
            new Computer("Laptop1", 2.4, 2, 1000)
        };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("list, list sortByCoreFreq, list sortByMem, list sortByHdd, exit");

                Console.Write("command> ");

                string command = Console.ReadLine();
                string[] commandParameters = command.Split(' ').ToArray();

                if (commandParameters[0] == "list")
                {
                    if (commandParameters.Length == 1)
                    {
                        ShowList();
                    }
                    else if (commandParameters[1] == "sortByCoreFreq")
                    {
                        ShowList(new ComputerCoreFrequencyComparer());
                    }
                    else if (commandParameters[1] == "sortByMem")
                    {
                        ShowList(new ComputerMemorySizeComparer());
                    }
                    else if (commandParameters[1] == "sortByHdd")
                    {
                        ShowList(new ComputerHddSizeComparer());
                    }
                }
                else if (commandParameters[0] == "exit")
                {
                    return;
                }

            }
        }

        private static void ShowList(IComparer<Computer> comparer = null)
        {
            if (comparer == null)
            {
                computerList.Sort();
            }
            else
            {
                computerList.Sort(comparer);
            }

            foreach (var c in computerList)
            {
                Console.WriteLine();
                Console.WriteLine($"Computer: {c.Name}");
                Console.WriteLine($"  Core frequency: {c.CoreFrequency}");
                Console.WriteLine($"  Memory size: {c.MemorySize}");
                Console.WriteLine($"  HDD size: {c.HddSize}");
            }
        }
    }
}
