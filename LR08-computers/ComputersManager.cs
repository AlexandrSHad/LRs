using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR08_computers
{
    public class ComputersManager
    {
        private Computer[] _computersArray;

        public ComputersManager(Computer[] computersArray)
        {
            _computersArray = computersArray;
        }

        public Computer[] GetComputers(ComputerType type)
        {
            //return _computersArray.Where(comp => comp.Type == type).ToArray<Computer>();

            var resArray = new Computer[_computersArray.Length];

            int count = 0;

            foreach (var comp in _computersArray)
            {
                if (comp.Type == type)
                {
                    resArray[count] = comp;
                    count++;
                }
            }

            return resArray;
        }

        public Computer[] GetComputers(bool isUsed)
        {
            var resArray = new Computer[_computersArray.Length];

            int count = 0;

            foreach (var comp in _computersArray)
            {
                if (comp.IsUsed == isUsed)
                {
                    resArray[count] = comp;
                    count++;
                }
            }

            return resArray;
        }

        public Computer[] GetComputers(int minMemory)
        {
            var resArray = new Computer[_computersArray.Length];

            int count = 0;

            foreach (var comp in _computersArray)
            {
                if (comp.SizeRAM >= minMemory)
                {
                    resArray[count] = comp;
                    count++;
                }
            }

            return resArray;
        }

        public Computer[] GetMostPowerfulComputers()
        {
            var resArray = new Computer[_computersArray.Length];

            int maxCoreCount = 0;
            foreach (var comp in _computersArray)
            {
                if (comp.CoreCount > maxCoreCount)
                {
                    maxCoreCount = comp.CoreCount;
                }
            }

            int count = 0;

            foreach (var comp in _computersArray)
            {
                if (comp.CoreCount == maxCoreCount)
                {
                    resArray[count] = comp;
                    count++;
                }
            }

            return resArray;
        }
    }
}
