namespace AbstractHw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Vasya", "username@gmail.com");
            Console.WriteLine(client1.Name + client1.Email);

            Shop shop = new Shop("MyShop");
            shop.AddProduct("shampoo", 12);
            shop.AddProduct("banana", 24);
            shop.AddProduct("milk", 19);
            Console.WriteLine(shop.Products[0]);
            Order order = new Order(client1, shop.Products);
            Console.WriteLine(order.Price);
        }
    }
}