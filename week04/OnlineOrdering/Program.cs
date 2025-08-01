using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1600 Pennsylvania Ave NW", "Washington", "DC", "USA");
        Customer customer1 = new Customer("James Carter", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM1001", 24.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "MK2045", 89.50, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine("----------------------------------------");

        Address address2 = new Address("10 Downing St", "London", "Greater London", "UK");
        Customer customer2 = new Customer("Oliver Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("27-inch Monitor", "MON2712", 219.00, 1));
        order2.AddProduct(new Product("USB-C Hub", "USBC801", 34.75, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
        Console.WriteLine("----------------------------------------");

        Address address3 = new Address("2-11-3 Meguro", "Tokyo", "Tokyo", "Japan");
        Customer customer3 = new Customer("Haruto Tanaka", address3);

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("External SSD 1TB", "SSD1000X", 129.99, 2));
        order3.AddProduct(new Product("Noise-Canceling Headphones", "NC900X", 199.99, 1));

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order3.GetTotalPrice():0.00}");
        Console.WriteLine("----------------------------------------");
    }
}