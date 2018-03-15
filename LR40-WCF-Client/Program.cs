using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR40_WCF_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Connecting...");

            var client = new MathService.MathClient();
            var factory = client.ChannelFactory;
            var channel = factory.CreateChannel();

            Console.WriteLine("Connected.");

            while (true)
            {
                Console.WriteLine("Input number for get factorial.");
                Console.Write("> ");

                var n = Console.ReadLine();

                if (string.IsNullOrEmpty(n))
                {
                    break;
                }

                var result = channel.Factorial(Convert.ToInt32(n));

                Console.WriteLine("Factorial {0} is {1}.", n, result);
            }
        }
    }
}
