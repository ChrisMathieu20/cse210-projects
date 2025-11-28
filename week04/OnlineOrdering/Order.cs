public class Order
{
    private List<Product> _product = new List<Product>();
    private List<Customer> _customer = new List<Customer>();

    public void AddProduct(Product Product)
    {
        _product.Add(Product);
    }

    public void AddCustomer(Customer Customer)
    {
        _customer.Add(Customer);
    }

    public void PackingLabel()
    {
        foreach (Product prod in _product)
        {
            prod.DisplayProduct();
        }
    }

    public void ShippingLabel()
    {
        foreach (Customer customer in _customer)
        {
            customer.DisplayCustomer();
        }
    }

    public double ShippingCostAmount()
    {
        bool check = true;
        foreach (Customer c in _customer)
        {
            check = c.CheckLiving();
        }
        if (check)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public double TotalPrice()
    {
        double x;
        double total = 0;
        foreach (Product p in _product)
        {
            x = p.TotalCost();
            total = total + x;
        }
        return total + ShippingCostAmount();
    }

    public void DisplayOrder()
    {
        Console.WriteLine("/////////////////////////////////////////////");
        ShippingLabel();
        Console.WriteLine("Order:");
        PackingLabel();
        Console.WriteLine($"Shipping Cost: ${ShippingCostAmount()}");
        Console.WriteLine($"Total Price: ${TotalPrice()}");
        Console.WriteLine("/////////////////////////////////////////////");
    }
}