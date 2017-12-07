using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR25_skype4_interface_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog("Bobeeek");

            Console.WriteLine(d.Describe());

            Console.ReadLine();
        }
    }

    public interface IAnimal
    {
        string Name { get; set; }
        string Describe();
    }

    public class Dog : IAnimal
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public string Describe()
        {
            return String.Format("Hello, I am a dog, and my name is {0}.", Name);
        }
    }
}
