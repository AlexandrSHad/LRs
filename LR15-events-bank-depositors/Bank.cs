using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR15_events_bank_depositors
{
    public class Bank
    {
        public Bank(decimal currency)
        {
            this.Currency = currency;
        }

        public delegate void CurrencyGrow();
        public delegate void CurrencyFall();

        public event CurrencyGrow CurrGrow;
        public event CurrencyFall CurrFall;

        public decimal Currency { get; set; }

        public void SetCurrency(decimal currency)
        {
            if (this.Currency < currency)
            {
                CurrGrow();
            }
            else if (this.Currency > currency)
            {
                CurrFall();
            }

            Currency = currency;
        }
    }
}
