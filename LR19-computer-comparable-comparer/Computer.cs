using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR19_computer_comparable_comparer
{
    public class Computer : IComparable<Computer>
    {
        public Computer(string name, double coreFrequency, int memorySize, int hddSize)
        {
            Name = name;
            CoreFrequency = coreFrequency;
            MemorySize = memorySize;
            HddSize = hddSize;
        }

        public string Name { get; set; }
        public double CoreFrequency { get; set; }
        public int MemorySize { get; set; }
        public int HddSize { get; set; }

        public int CompareTo(Computer other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
