public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public Address(string street, string city, string country)
    {
        _street = street;
        _city = city;
        _province = city;
        _country = country;
    }

    public bool CheckCountry()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"{_street}, {_city}, {_province}, {_country}";
    }
}