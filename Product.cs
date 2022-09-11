using AbstractHw.AbstractionLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHw
{
    internal class Product : IProduct
    {
        public string ProductName { get; set; }
        public int Price { get; set; }

        public Product(string productName, int price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
