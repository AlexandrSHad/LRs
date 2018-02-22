using LR38_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace LR38_WebAPI
{
    public class DbInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var testProductArray = new Product[3]
            {
                new Product {
                    OrderNumber = "OR123",
                    ProductName = "Product 1",
                    UnitPrice = 100.00,
                    Count = 10
                },
                new Product {
                    OrderNumber = "OR356",
                    ProductName = "Product 2",
                    UnitPrice = 548.50,
                    Count = 1
                },
                new Product {
                    OrderNumber = "OR547",
                    ProductName = "Product 3",
                    UnitPrice = 12546.20,
                    Count = 2
                },
            };

            context.Products.AddOrUpdate(p => p.ProductName, testProductArray);
        }
    }
}