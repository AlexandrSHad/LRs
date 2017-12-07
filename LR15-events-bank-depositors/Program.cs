using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR15_events_bank_depositors
{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank(27.5m);

            var depositor1 = new TuffDepositors("John", "Smith", bank);
            var depositor2 = new ScearedDepositors("Small", "Sun", bank);
            var depositor3 = new ScearedDepositors("Debra", "Morgan", bank);

            while (true)
            {
                Console.WriteLine();
                Console.Write("Input current currency: ");
                decimal currency = Convert.ToDecimal(Console.ReadLine());

                bank.SetCurrency(currency);
            }
        }
    }
}
