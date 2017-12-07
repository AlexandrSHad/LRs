using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR15_events_bank_depositors
{
    public class TuffDepositors : Depositors
    {
        public TuffDepositors(string firstName, string lastName, Bank bank) :
            base(firstName, lastName)
        {
            bank.CurrGrow += delegate () { Console.WriteLine($"{FirstName} {LastName} saying: Hooray!"); };
            bank.CurrFall += delegate () { Console.WriteLine($"{FirstName} {LastName} saying: Oh! FTC."); };
        }
    }
}
