public class Entry
{
    private string _entry;
    private string _date;
    private string _prompt;

    public Entry(string entry, string date, string prompt)
    {
        _entry = entry;
        _date = date;
        _prompt = prompt;
    }
    public string Format()
    {
        string line = $"{_entry}~|~{_date}~|~{_prompt}";
        return line;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_prompt}");
        Console.WriteLine(_entry);
    }

}