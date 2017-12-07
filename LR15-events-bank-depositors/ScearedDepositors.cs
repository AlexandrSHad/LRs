using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR15_events_bank_depositors
{
    public class ScearedDepositors : Depositors
    {
        public ScearedDepositors(string firstName, string lastName, Bank bank) :
            base(firstName, lastName)
        {
            bank.CurrGrow += delegate () { Console.WriteLine($"{FirstName} {LastName} saying: What to do? Shell I sell?"); };
            bank.CurrFall += delegate () { Console.WriteLine($"{FirstName} {LastName} saying: Ohh! Shell I buy?"); };
        }
    }
}
