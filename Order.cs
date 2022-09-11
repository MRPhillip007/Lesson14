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
        public Order(Client client, List<Product> products) // add auto price calculation
        {
            Id += 1;
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
    }
}

