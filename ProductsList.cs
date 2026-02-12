using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuko
{
    internal class ProductsList
    {
        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product { prodName = "Chocolate Chip", itemPrice = 135.00m },
                new Product { prodName = "Dark Caramel Frappucino", itemPrice = 160.00m },
                new Product { prodName = "Dragon Drink", itemPrice = 100.00m },
                new Product { prodName = "Matcha Latte", itemPrice = 125.00m },
                new Product { prodName = "Pink Drink", itemPrice = 155.00m },
                new Product { prodName = "Strawberry Cream", itemPrice = 140.00m },
                new Product { prodName = "Strawberry Acai", itemPrice = 180.00m },
                new Product { prodName = "XOXO Frappucino", itemPrice = 115.00m }
            };
        }
    }
}
