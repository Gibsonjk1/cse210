public class Customer
{
    private string _name;
    private Address _address = new Address();

    public Customer(string name)
    {
        _name = name;
    }

    public bool IsUSCustomer()
    {
        bool usCustomer = _address.IsUSAddress();

        return usCustomer;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _address.SetAddress(street, city, state, country);
    }
}