using AbstractHw.AbstractionLevel;

namespace AbstractHw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<======== Welcome to the Store >========");

            Client client1 = new Client("Vasya", "username@gmail.com");
            Shop shop = new Shop("MyShop");

            shop.AddProduct("shampoo", 12);
            shop.AddProduct("banana", 24);
            shop.AddProduct("milk", 19);

            ShopAssortment.Check(shop);

            bool isDone = false;
            while (!isDone)
            {
                DoShopping(client1, shop);
                
            }        
        }
        static void CommandParser(string command, Client client)
        {
            switch (command.ToLower())
            {
                case "pay":
                    CreateOrder(client);
                    break;

                case "n":
                    break;

                default:
                    break;
            }
        }
        static void CreateOrder(Client client)
        {
            Order order = new Order(client, client.Cart);
            Console.WriteLine($"Order Details:\n\tId: {order.Id}\n\t Price: {order.Price}\n\t Date:{order.OrderDate}\n\t From: " +
                $"{order.OrderFrom.Name}\n\t Email: {order.OrderFrom.Email}\n\t Products:\t");

            foreach (var item in order.Products)
            {
                Console.WriteLine($"\t\t{item.ProductName}");
            }

            client.EmptyCart();
        }
        static void DoShopping(Client client, Shop shop)
        {
            Console.Write("Select what you want to buy: >>> ");

            bool choice = Int32.TryParse(Console.ReadLine(), out int product);
            if (choice)
            {
                try
                {
                    client.AddToCart(shop.Products[product]);
                    Console.WriteLine("Press enter to continue or 'pay' command - to buy. ");
                    string? command = Console.ReadLine();
                    CommandParser(command, client);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Enter an existing product value");
                }
            }
            else
            {
                Console.WriteLine("Select number of product! ");
            }
        }
    }
}
//checked
