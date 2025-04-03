public class Receptions : Event
{
    private List<string> _guestList = new List<string>();
    private string _rsvp;

    public Receptions(string title, string date, string time, string email, List<string> guestlist = null) : base(title, date, time)
    {
        _rsvp = email;
        if (guestlist is not null)
        {
            _guestList = guestlist;
        }
    }

    public List<string> GetGuestList()
    {
        return _guestList;
    }

    public void AddGuest(string guest)
    {
        _guestList.Add(guest);
    }
    public void FullDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine("Event Type: Reception");
        Console.WriteLine($"{_title}\n{_description}\n{_date} - {_time}\n{_address.GetAddress()}");
        Console.WriteLine();
        Console.WriteLine($"RSVP: {_rsvp}");

    }

    public void ShortDescription()
    {
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine("Event Type: Reception");
        Console.WriteLine($"{_title}\n{_date}");
    }
}