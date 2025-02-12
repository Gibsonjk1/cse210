using System.ComponentModel.DataAnnotations;
using System.IO;


public class Journal
{
    public static List<Entry> _entries = new List<Entry>();

    public static void Save(Entry entry)
    {
        _entries.Add(entry);
    }

    public static int Count()
    {
        return _entries.Count;
    }
    public static void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public static void Load()
    {
        _entries.Clear();

        Console.Write("What is the file name?: ");
        string filePath = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"files/{filePath}");
        foreach (string line in lines)
        {
            string[] data = line.Split("~|~");
            Entry entry = new Entry(data[0], data[1], data[2]);
            Save(entry);
        }
        Console.WriteLine("File is Loaded");
    }

    public static void SaveFile()
    {
        Console.Write("What is the file name?: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter($"files/{fileName}"))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.Format());
            }
        }
        Console.WriteLine("File Saved.");
        Console.WriteLine();
    }
}