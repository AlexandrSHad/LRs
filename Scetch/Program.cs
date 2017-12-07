using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scetch
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intList = new List<int>() { 6, 7, 1, 2, 3, 8 };

            //Console.WriteLine("Non sorted list");

            //foreach (var i in intList)
            //{
            //    Console.WriteLine(i);
            //}

            //intList.Sort();

            //Console.WriteLine("Sorted list");

            //foreach (var i in intList)
            //{
            //    Console.WriteLine(i);
            //}

            var empl1 = new Employee
            {
                FirstName = "John",
                LastName = "Snow",
                Salary = 100
            };

            var empl2 = new Employee
            {
                FirstName = "Daenerys",
                LastName = "Targarien",
                Salary = 1000000
            };

            var empl3 = new Employee
            {
                FirstName = "Sersi",
                LastName = "Lannister",
                Salary = 2000000
            };

            List<Employee> empList = new List<Employee>();
            empList.Add(empl1);
            empList.Add(empl2);
            empList.Add(empl3);

            var comparer = new NameComparer();

            empList.Sort(comparer);

            foreach (var e in empList)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName}");
            }

            Console.ReadLine();
        }
    }

    public class Employee : IComparable<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }

    public class NameComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }
}
