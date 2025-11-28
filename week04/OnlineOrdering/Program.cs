using System;
class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        Customer c1 = new Customer("Christian Mathieu", new Address("Betafo","Antananarivo","Madagascar"));
        Product p1 = new Product("Portable Power Bank","P001",29.99,1);
        Product p2 = new Product("Mechanical Keyboard","P002",89.00,1);
        Product p3 = new Product("LED Desk Lamp","P003",24.75,2);
        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);
        order1.AddCustomer(c1);
        order1.DisplayOrder();
        
        Order order2 = new Order();
        Customer c2 = new Customer("Mathieu Ramasinjanahary", new Address("Betafo","Antananarivo","Madagascar"));
        Product p4 = new Product("Wireless Mouse","P004",19.99,2);
        Product p5 = new Product("Bluetooth Headphones","P005",49.99,1);
        Product p6 = new Product("USB-C Charger","P006",14.50,3);
        order2.AddProduct(p4);
        order2.AddProduct(p5);
        order2.AddProduct(p6);
        order2.AddCustomer(c2);
        order2.DisplayOrder();
    }
}