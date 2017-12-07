using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scetch_Enumerable_Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //IEnumerable<int> numbers = new List<int>
            //{
            //    1, 5, 3, 2, 5, 8
            //};

            //foreach(var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //IEnumerator<int> numbers2 = new List<int>
            //{
            //    1, 5, 3, 2, 6, 8
            //}.GetEnumerator();

            //while (numbers2.MoveNext())
            //{
            //    Console.WriteLine(numbers2.Current);
            //}

            //PrintTo5(numbers2);

            var cities = new Cities();

            foreach (var c in cities)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }

        static public void PrintTo5(IEnumerator<int> o)
        {
            while (o.MoveNext())
            {
                if (o.Current > 5)
                {
                    PrintFrom5(o);
                }
            }
        }

        static public void PrintFrom5(IEnumerator<int> o)
        {
             Console.WriteLine(o.Current);
        }

        public class Cities : IEnumerable
        {
            private List<string> cities = new List<string>
            {
                "Kyiv", "Kharkiv", "Odesa", "Donetsk", "Lviv"
            };

            public IEnumerator GetEnumerator()
            {
                yield return cities;
            }
        }
    }
}
