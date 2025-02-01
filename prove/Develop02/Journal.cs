using System.IO;


public class Journal
{
    public List<string[]> _entries = new List<string[]>();
    public string filePath;
    public void Save(string[] entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (string[] entry in _entries)
        {
            Console.WriteLine($"{entry[0]} -- {entry[1]}");
        }
    }

    public void Load()
    {
        string filePath = "testFile.csv";
        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] entry = line.Split(",");
            Save(entry);
        }
        Console.WriteLine("File is Loaded");
    }

    public void SaveFile()
    {
        string fileName = "testFile.csv";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string[] entry in _entries)
            {
                outputFile.WriteLine(entry[0], entry[1]);
            }
        }
        Console.WriteLine("File Saved.");
        Console.WriteLine();
    }
}