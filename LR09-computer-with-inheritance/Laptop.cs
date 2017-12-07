using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR09_computer_with_inheritance
{
    class Laptop : Computer
    {
        public Laptop(int coreCount, double coreFrequency, int sizeRAM, int sizeHDD) :
            base(coreCount, coreFrequency, sizeRAM, sizeHDD) { }

        public override void Power()
        {
            Console.WriteLine("89% - 3 h 22 min left.");
        }
    }
}
