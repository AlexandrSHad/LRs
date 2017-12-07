using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR13_delegate
{
    public class Listener
    {
        public Listener(UpToTenCounter counter)
        {
            counter.OnSwitch += Beep;
        }

        public void Beep()
        {
            Console.Beep(500, 500);
        }
    }
}
