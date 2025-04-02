public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address = new Address();

    public Event(string title, string date, string time)
    {
        _title = title;
        _date = date;
        _time = time;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"{_title}\n{_description}\n{_date} - {_time}\n{_address}");
        Console.WriteLine();
    }

    public void AddAddress(string street, string city, string state, string country)
    {
        _address.SetAddress(street, city, state, country);
    }


}