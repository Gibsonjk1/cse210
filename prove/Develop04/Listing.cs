using System.Net;

public class Listing : Mindfulness
{
    private string _listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string[] _listingPrompt =
    [
"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"
    ];
    private List<string> _list = new List<string>();
    private int _timer;
    private int _count;

    public Listing(string activityName) : base(activityName)
    {
        base._description = _listingDescription;
    }

    public void ListingActivity()
    {
        base.StartingMessage();
        _timer = base._duration;
        Random random = new Random();
        int randInt = random.Next(0, _listingPrompt.Length - 1);
        string prompt = _listingPrompt[randInt];

        Console.WriteLine("List as many responses as you can for the following prompt: ");
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        base.Countdown(5, 18);
        Console.WriteLine();
        Console.WriteLine("Begin:");
        ListingResponses(_timer);
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        base.WaitAnimation(15);
    }

    private void ListingResponses(int timer)
    {
        DateTime currentTime = DateTime.Now;
        DateTime endingTime = currentTime.AddSeconds(timer);

        while (currentTime < endingTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            _list.Add(response);
            _count++;
            currentTime = DateTime.Now;
        }

    }
}