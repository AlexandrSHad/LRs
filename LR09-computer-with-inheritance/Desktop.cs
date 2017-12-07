using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR09_computer_with_inheritance
{
    class Desktop : Computer
    {
        public Desktop(int coreCount, double coreFrequency, int sizeRAM, int sizeHDD) :
            base(coreCount, coreFrequency, sizeRAM, sizeHDD) { }

        public override void Power()
        {
            Console.WriteLine("Have no accumulator.");
        }
    }
}
