using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR26_skype5_struct_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");

            string clr = Console.ReadLine();
            var c = new Car(clr);

            Console.WriteLine("Output:");
            c.Describe();

            Console.ReadLine();
        }
    }

    public struct Car
    {
        public Car(string colour)
        {
            _colour = colour;
        }

        string _colour;
        public string Colour { get { return _colour; } }

        public void Describe()
        {
            Console.WriteLine("This car is {0}.", Colour);
        }
    }
}
