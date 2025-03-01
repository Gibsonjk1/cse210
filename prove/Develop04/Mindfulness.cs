using System.Globalization;
using System.IO.Compression;

public class Mindfulness
{
    protected int _duration;
    protected string _activityName;
    protected string _description;

    protected Mindfulness(string activityName)
    {

        _activityName = activityName;
    }

    protected void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity. {_description}");
        Console.WriteLine();
        GetDuration();
        Console.WriteLine("Get Ready...");
        WaitAnimation(20);
    }
    private void GetDuration()
    {
        Console.Write($"How many seconds would you like to do the {_activityName} Activity?: ");
        _duration = int.Parse(Console.ReadLine());
    }
    protected void WaitAnimation(int time)
    {
        var loaderChars = new[] { '/', '-', '\\', '|' };
        int a = 0;
        int times = 0;
        while (times < time)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(loaderChars[a++]);
            a = a == loaderChars.Length ? 0 : a;
            Thread.Sleep(300);
            times++;
        }
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write("");
    }

    protected void EndingMessage()
    {
        Console.WriteLine($"Great job! You're making steps towards a healthier you!");
        WaitAnimation(10);
        Console.WriteLine($"You have just spent {_duration} seconds completing the {_activityName} Activity");
        WaitAnimation(10);
    }

    protected void Countdown(int duration, int cursorPosition)
    {
        int countdown = duration;

        while (countdown > 0)
        {
            Console.SetCursorPosition(cursorPosition, Console.CursorTop);
            Console.Write(countdown);
            countdown--;
            Thread.Sleep(1000);
        }
    }
}