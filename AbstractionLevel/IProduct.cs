using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHw.AbstractionLevel
{
    internal interface IProduct
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}