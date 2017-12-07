using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR13_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new UpToTenCounter();
            var listener = new Listener(counter);
            counter.Start();
        }
    }
}
