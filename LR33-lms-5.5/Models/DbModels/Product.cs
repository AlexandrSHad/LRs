using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_lms_5._5.Models.DbModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public double Price { get; set; }

        public int SupplierId { get; set; }
    }
}
