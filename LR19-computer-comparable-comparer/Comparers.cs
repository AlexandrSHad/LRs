using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19_computer_comparable_comparer
{
    public class ComputerCoreFrequencyComparer : IComparer<Computer>
    {
        public int Compare(Computer x, Computer y)
        {
            return x.CoreFrequency.CompareTo(y.CoreFrequency);
        }
    }

    public class ComputerMemorySizeComparer : IComparer<Computer>
    {
        public int Compare(Computer x, Computer y)
        {
            if (x.MemorySize == y.MemorySize)
            {
                return x.Name.CompareTo(y.Name);
            }

            return x.MemorySize.CompareTo(y.MemorySize);
        }
    }

    public class ComputerHddSizeComparer : IComparer<Computer>
    {
        public int Compare(Computer x, Computer y)
        {
            return x.HddSize.CompareTo(y.HddSize);
        }
    }
}
