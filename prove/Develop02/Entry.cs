public class Entry
{
    private static string _entry;
    private static string _date;
    private static string _prompt;

    public Entry(string entry, string date, string prompt)
    {
        _entry = entry;
        _date = date;
        _prompt = prompt;
    }
    public string Format()
    {
        string line = $"{_date} + ',' + {_prompt} + ',' + {_entry}";
        return line;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt:{_prompt}");
        Console.WriteLine(_entry);
    }

}