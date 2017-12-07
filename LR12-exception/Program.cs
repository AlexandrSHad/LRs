using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR12_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var result = Division(1, 0);
            }
            catch (ZeroDivideException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        private static decimal Division(decimal x, decimal y)
        {
            if (y == 0)
            {
                throw new ZeroDivideException("Zero divide.");
            }

            return x / y;
        }
    }

    public class ZeroDivideException : Exception
    {
        public ZeroDivideException(string message) :
            base(message)
        {
        }
    }
}
