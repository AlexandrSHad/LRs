using System;

namespace LR08_computers
{
    public enum ComputerType { Desktop, Laptop, Serer }

    public class Computer
    {
        public ComputerType Type { get; set; }
        public int CoreCount { get; set; }
        public double CoreFrequency { get; set; }
        public int SizeRAM { get; set; }
        public int SizeHDD { get; set; }
        public bool IsUsed { get; set; }

        public Computer(ComputerType type, int coreCount, double coreFrequency, int sizeRAM, int sizeHDD, bool isUsed)
        {
            Type = type;
            CoreCount = coreCount;
            CoreFrequency = coreFrequency;
            SizeRAM = sizeRAM;
            SizeHDD = sizeHDD;
            IsUsed = isUsed;
        }

        public Computer(ComputerType type, int coreCount, double coreFrequency, int sizeRAM, int sizeHDD) :
            this (type, coreCount, coreFrequency, sizeRAM, sizeHDD, true) { }

        public void GetInfo()
        {
            string status = IsUsed ? "Used" : "New";

            Console.WriteLine("Computer info:");
            Console.WriteLine($"   Status:        {status}");
            Console.WriteLine($"   Type:          {Type}");
            Console.WriteLine($"   Core count:    {CoreCount}");
            Console.WriteLine($"   CoreFrequency: {CoreFrequency} GHz");
            Console.WriteLine($"   Memory size:   {SizeRAM} Gb");
            Console.WriteLine($"   HDD size:      {SizeHDD} Gb");
        }
    }
}
