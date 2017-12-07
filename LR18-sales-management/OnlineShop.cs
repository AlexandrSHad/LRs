using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR18_sales_management
{
    public class OnlineShop
    {
        public event EventHandler<GoodsInfoEventArgs> NewGoodsEvent;

        public void NewGoods(string goodsName)
        {
            NewGoodsEvent?.Invoke(this, new GoodsInfoEventArgs(goodsName));
        }
    }
}
