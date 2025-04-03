public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string date, string time, string speaker, int capacity) : base(title, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }
    public void FullDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Full Details: ");
        Console.WriteLine("Event Type: Lecture");
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\n{_date} - {_time}\n{_address.GetAddress()}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");

    }

    public void ShortDescription()
    {
        Console.WriteLine();
        Console.WriteLine("Short Description: ");
        Console.WriteLine("Event Type: Lecture");
        Console.WriteLine($"{_title}\n{_date}");
    }
}