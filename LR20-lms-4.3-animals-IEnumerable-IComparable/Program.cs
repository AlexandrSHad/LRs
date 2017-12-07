using System;

namespace LR20_lms_4._3_animals_IEnumerable_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animals(
                new Animal[4] {
                    new Animal("Dog", 5),
                    new Animal("SuperDog", 7),
                    new Animal("GigaDog", 15),
                    new Animal("MegaDog", 10),
                }
            );

            Console.WriteLine("Unsorted list of animals.");
            foreach(var a in animals)
            {
                Console.WriteLine(a);
            }

            animals.Sort();

            Console.WriteLine();
            Console.WriteLine("List of animals sorted by genus (default).");
            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }

            animals.Sort(Animal.SortGenusDescending);

            Console.WriteLine();
            Console.WriteLine("List of animals sorted by genus descending.");
            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }

            animals.Sort(Animal.SortWeightAscending);

            Console.WriteLine();
            Console.WriteLine("List of animals sorted by weight ascending.");
            foreach (var a in animals)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
