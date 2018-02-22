using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LR38_WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string OrderNumber { get; set; }
        public double UnitPrice { get; set; }
        public int Count { get; set; }
    }
}