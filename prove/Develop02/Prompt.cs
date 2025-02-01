public class Prompt
{
    public static List<string> _prompts = ["What was the best thing that happened today?", "Who was someone interesting that you met today?", "What is something you are grateful for today?", "What is the kindest thing that you saw someone do today?", "What is something that you did for fun today?"];

    public static string[] Decide()
    {
        Console.WriteLine("Would you like to: ");
        Console.WriteLine();
        Console.WriteLine("1. Add to an existing Journal");
        Console.WriteLine("2. Start a new Journal");
        Console.Write(">");
        string response = "";

        while (response != "1" && response != "2" && response != "3")
        {
            response = Console.ReadLine();
            if (response != "1" && response != "2" && response != "3")
            {
                Console.WriteLine($"{response} is not a valid entry. Please enter 1 or 2. enter 3 to cancel.");
            }
        }
        if (response == "1")
        {
            Journal.Load();
            return CreateEntry();
        }
        else if (response == "2")
        {
            return CreateEntry();
        }
        else
        {
            string[] blank = Array.Empty<string>();
            return blank;
        }
    }
    public static string[] CreateEntry()
    {
        string[] newEntry = new string[3];
        string date = DateTime.Now.ToString("MM/dd/yyyy h:mm");
        Random r = new Random();
        int randInt = r.Next(0, 4);
        string prompt = _prompts[randInt];
        Console.WriteLine(prompt);
        Console.Write("Your Response: ");
        string response = Console.ReadLine();
        newEntry[0] = date;
        newEntry[1] = prompt;
        newEntry[2] = response;
        return newEntry;
    }
}
