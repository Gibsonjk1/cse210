using System.IO;


public class Journal
{
    public static List<string[]> _entries = new List<string[]>();

    public static void Save(string[] entry)
    {
        _entries.Add(entry);
    }

    public static void Display()
    {
        foreach (string[] entry in _entries)
        {
            Console.WriteLine($"{entry[0]} - Prompt:{entry[1]}");
            Console.WriteLine(entry[2]);
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
            string[] entry = line.Split(",");
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
            foreach (string[] entry in _entries)
            {
                string line = entry[0] + "," + entry[1] + "," + entry[2];
                outputFile.WriteLine(line);
            }
        }
        Console.WriteLine("File Saved.");
        Console.WriteLine();
    }
}