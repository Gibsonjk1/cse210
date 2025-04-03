public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string date, string time) : base(title, date, time)
    {

    }

    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
    public void FullDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine("Event Type: Outdoor");
        Console.WriteLine($"{_title}\n{_description}\n{_date} - {_time}\n{_address.GetAddress()}");
        Console.WriteLine();
        Console.WriteLine($"Expected Weather: {_weather}");
        Console.WriteLine();

    }

    public void ShortDescription()
    {
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine("Event Type: Outdoor");
        Console.WriteLine($"{_title}\n{_date}");
        Console.WriteLine();
    }
}