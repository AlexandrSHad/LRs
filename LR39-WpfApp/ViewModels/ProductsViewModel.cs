using LR39_WpfApp.Data;
using LR39_WpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR39_WpfApp.ViewModels
{
    public class ProductsViewModel
    {
        public List<Product> ProductList { get; set; } = new List<Product>();

        public ProductsViewModel()
        {
            var context = new DataContext();
            ProductList = context.Products.ToList();
        }
    }
}
