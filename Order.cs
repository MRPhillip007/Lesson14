using System;

namespace AbstractHw
{
    internal class Order : IOrder
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public int Price { get; }
        public Client OrderFrom { get; set; }
        public DateTime OrderDate { get; set; }
        public Order(Client client, List<Product> products) 
        {
            Id = GenerateId();
            Products = products;
            Price = CalculateOrderPrice();
            OrderFrom = client;
            OrderDate = DateTime.Now;
        }

        int CalculateOrderPrice()
        {
            int finalPrice = 0;
            foreach (Product product in Products) 
            {
                finalPrice += product.Price;
            }
            return finalPrice;
        }

        int GenerateId()
        {
            Random random = new Random();
            return random.Next(0, 2147483647);
        }
    }
}

