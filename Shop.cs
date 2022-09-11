using AbstractHw.AbstractionLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHw
{
    internal class Shop: IShop
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Shop(string shopName)
        {
            Name = shopName;
            Products = new List<Product>();
        }

        public void AddProduct(string name, int price)
        {
            Product product = new Product(name, price);
            Products.Add(product);
            Console.WriteLine($"Product {product.ProductName} added! ");
        }

        public void RemoveProduct(string name)
        {
            Products.RemoveAt(Products.FindIndex(x => x.ProductName == name));
            Console.WriteLine("Product deleted! ");
        }
    }
}
