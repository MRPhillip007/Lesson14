using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHw
{
    static internal class ShopAssortment
    {
        public static void Check(Shop shop)
        {
            int idx = 0;
            foreach (var item in shop.Products)
            {
                Console.WriteLine($"{idx}) {item.ProductName}");
                idx++;
            }
        }
    }
}