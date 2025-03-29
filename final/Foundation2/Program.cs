using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        static void CreateOrder1()
        {
            Product magentaInk = new Product(22.14, "Magenta", 487, 3);
            Product cyanInk = new Product(23.82, "Cyan", 452, 2);
            Product yellowInk = new Product(28.73, "Yellow", 421, 5);

            Customer customer = new Customer("Bob Barker");
            customer.SetAddress("21 Fat Cow Farm", "Milky", "West Virginia", "United States");

            Order order = new Order(customer);
            order.AddProduct(magentaInk);
            order.AddProduct(cyanInk);
            order.AddProduct(yellowInk);

Console.WriteLine("Order 1:");
            Console.WriteLine("Packing Label: ");
            List<string> packingList = order.PackingLabel();
            foreach(string packingItem in packingList)
            {
                Console.WriteLine(packingItem);
            }
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("Total Price: ");
            Console.WriteLine(order.CalculateCost());
            Console.WriteLine();

        }
        static void CreateOrder2()
        {
            Product pinkPickle = new Product(22.14, "Pinckle", 235, 3);
            Product fanBox = new Product(23.82, "Fan Box", 212, 2);
            Product stickers = new Product(21.73, "Stickers", 276, 5);

            Customer customer = new Customer("Bob Saget");
            customer.SetAddress("69 Linden Rd", "Birmingham", "West Midlands", "United Kingdom");

            Order order = new Order(customer);
            order.AddProduct(pinkPickle);
            order.AddProduct(fanBox);
            order.AddProduct(stickers);

            Console.WriteLine("Order 2:");
            Console.WriteLine("Packing Label: ");
            List<string> packingList = order.PackingLabel();
            foreach(string packingItem in packingList)
            {
                Console.WriteLine(packingItem);
            }
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine("Total Price: ");
            Console.WriteLine(order.CalculateCost());
            Console.WriteLine();
        }
        CreateOrder1();
        CreateOrder2();
    }
}