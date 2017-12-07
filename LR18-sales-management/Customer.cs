using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR18_sales_management
{
    public class Customer
    {
        string _name;

        public Customer(string name, OnlineShop onlineShop)
        {
            _name = name;
            onlineShop.NewGoodsEvent += GotNewGoods;
        }

        public void GotNewGoods(object sender, GoodsInfoEventArgs e)
        {
            Console.WriteLine($"{_name} got {e.GoodsName}.");
        }
    }
}
