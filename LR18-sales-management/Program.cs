using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR18_sales_management
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new OnlineShop();

            var customer1 = new Customer("Ivan", shop);
            var customer2 = new Customer("Petro", shop);
            var customer3 = new Customer("Vasyl", shop);

            shop.NewGoods("Repa");

            Console.ReadLine();
        }
    }
}
