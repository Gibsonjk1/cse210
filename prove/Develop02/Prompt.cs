public class Prompt
{
    public List<string> _prompts = ["What was the best thing that happened today?", "Who was someone interesting that you met today?", "What is something you are grateful for today?", "What is the kindest thing that you saw someone do today?", "What is something that you did for fun today?"];


    public string[] Display()
    {
        string[] newEntry = new string[2];
        string date = DateTime.Now.ToString("MM/dd/yyyy h:mm");
        Random r = new Random();
        int randInt = r.Next(0, 4);
        Console.WriteLine(_prompts[randInt]);
        Console.Write("Your Response: ");
        string response = Console.ReadLine();
        newEntry[0] = date;
        newEntry[1] = response;
        return newEntry;
    }
}
