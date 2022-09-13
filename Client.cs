using AbstractHw.AbstractionLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHw
{
    internal class Client: IClient, IClientAction
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Product> Cart { get; set; }

        public Client(string name, string email)
        {
            Name = name;
            Cart = new List<Product>();

            Validator validator = new Validator();
            if (validator.IsValidEmail(email))
            {
                Email = email;
            }
        }

        public void AddToCart(Product product)
        {
            Cart.Add(product);
        }
        public void EmptyCart()
        {
            Cart.Clear();
        }
    }
}
