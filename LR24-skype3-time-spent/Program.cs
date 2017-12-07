using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR24_skype3_time_spent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input: ");

            var ts = new TimeSpent(
                int.Parse(Console.ReadLine()),
                int.Parse(Console.ReadLine()));

            Console.WriteLine("Output: ");
            Console.WriteLine(ts);

            Console.ReadLine();
        }
    }

    public class TimeSpent
    {
        public TimeSpent(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public int Hours { get; set; }
        public int Minutes { get; set; }

        public override string ToString()
        {
            return (Hours * 60 + Minutes).ToString();
        }
    }
}
