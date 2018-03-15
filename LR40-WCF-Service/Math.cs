using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR40_WCF_Service
{
    class Math : IMath
    {
        public int Factorial(int num)
        {
            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
