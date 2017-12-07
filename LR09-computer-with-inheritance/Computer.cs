using System;

namespace LR09_computer_with_inheritance
{
    public abstract class Computer
    {
        public int CoreCount { get; set; }
        public double CoreFrequency { get; set; }
        public int SizeRAM { get; set; }
        public int SizeHDD { get; set; }

        public Computer(int coreCount, double coreFrequency, int sizeRAM, int sizeHDD)
        {
            CoreCount = coreCount;
            CoreFrequency = coreFrequency;
            SizeRAM = sizeRAM;
            SizeHDD = sizeHDD;
        }

        public void Print()
        {
            Console.WriteLine("Computer info:");
            Console.WriteLine($"   Core count:    {CoreCount}");
            Console.WriteLine($"   CoreFrequency: {CoreFrequency} GHz");
            Console.WriteLine($"   Memory size:   {SizeRAM} Gb");
            Console.WriteLine($"   HDD size:      {SizeHDD} Gb");
        }

        public abstract void Power();
    }
}
