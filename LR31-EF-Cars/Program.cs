using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LR31_EF_Cars.Managers;
using LR31_EF_Cars.Models;

namespace LR31_EF_Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbm = new DatabaseManager();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Cars manager.");
                Console.WriteLine("Available commands:");
                Console.WriteLine("  1 - Cars list.");
                Console.WriteLine("  2 - Brands list.");
                Console.WriteLine("  3 - Owners list.");
                Console.WriteLine("  9 - exit");
                Console.Write("command> ");

                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        PrintCars(dbm.ShowCars());
                        break;
                    case 2:
                        PrintBrands(dbm.ShowBrands());
                        break;
                    case 3:
                        PrintOwners(dbm.ShowOwners());
                        break;
                    case 9:
                        return;
                }
            }
        }

        static void PrintCars(List<Car> cars)
        {
            foreach (var c in cars)
            {
                Console.WriteLine("{0} {1}, body type {2}, engine capacity {3} l, power {4} hp",
                    c.Brand, c.Model, c.BodyType, c.EngineCapacity, c.EngineHorsePower);
            }
        }

        static void PrintBrands(List<Brand> brands)
        {
            foreach (var b in brands)
            {
                Console.WriteLine(b.Name);
            }
        }

        static void PrintOwners(List<CarOwner> owners)
        {
            foreach (var o in owners)
            {
                Console.WriteLine("{0} {1} {2}", o.Owner.Name, o.Car.Brand.Name, o.Car.Model);
            }
        }
    }
}
