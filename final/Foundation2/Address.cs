public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {

    }

    public bool IsUSAddress()
    {
        if (_country == "UnitedStates")
        { return true; }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        string address = "";
        address += $"{_street}\n";
        address += $"{_city}\n";
        address += $"{_state}, ";
        address += _country;
        return address;
    }

    public void SetAddress(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
}