using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR18_sales_management
{
    public class GoodsInfoEventArgs : EventArgs
    {
        public GoodsInfoEventArgs(string goodsName)
        {
            GoodsName = goodsName;
        }

        public string GoodsName { get; set; }
    }
}
