using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHw.AbstractionLevel
{
    internal interface IShop
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public void AddProduct(string name, int price);
        public void RemoveProduct(string name);


    }
}
