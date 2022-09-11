using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHw
{
    internal class Client: IClient
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }

        public Client(string name, string email)
        {
            Name = name;

            Validator validator = new Validator();
            if (validator.IsValidEmail(email))
            {
                Email = email;
            }
        }
    }
}
