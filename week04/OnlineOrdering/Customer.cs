public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool CheckLiving()
    {
        bool check = _address.CheckCountry();
        if (check)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void DisplayCustomer()
    {
        _name = GetName();
        _address = GetAddress();
        Console.WriteLine($"Customer: {_name}\nAddress: {_address}");
    }
}