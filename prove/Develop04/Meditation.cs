public class Meditation : Mindfulness
{

    private string _meditationDescription = "This activity will help you focus your mind and train it to find rest and peace. This will give you tools to use when you're feeling stressed and out of control.";
    private int _timer;

    public Meditation(string activityName) : base(activityName)
    {
        base._description = _meditationDescription;
    }

    public void MeditationActivity()
    {
        base.StartingMessage();
        _timer = base._duration;

        Console.WriteLine("Focus on the animation and try to clear your mind. If you mind starts to wander, that's OK. Notice it, don't judge it, and then gently bring your mind back to calm.");
        Console.WriteLine();
        Console.WriteLine("Press Enter when you're Ready: ");
        Console.ReadKey();
        MeditationAnimation();
        base.EndingMessage();
        Console.WriteLine();
    }
    private void MeditationAnimation()
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_timer);
        while (currentTime < futureTime)
        {
            Console.Clear();
            Console.SetCursorPosition(10, 5);
            Console.Write("*");
            Thread.Sleep(300);

            Console.SetCursorPosition(9, 4);
            Console.Write("***");
            Console.SetCursorPosition(9, 5);
            Console.Write("* *");
            Console.SetCursorPosition(9, 6);
            Console.Write("***");
            Thread.Sleep(300);

            Console.SetCursorPosition(8, 3);
            Console.Write("*****");
            Console.SetCursorPosition(8, 4);
            Console.Write("*   *");
            Console.SetCursorPosition(8, 5);
            Console.Write("*   *");
            Console.SetCursorPosition(8, 6);
            Console.Write("*   *");
            Console.SetCursorPosition(8, 7);
            Console.Write("*****");
            Thread.Sleep(300);

            currentTime = DateTime.Now;
        }
        Console.Clear();
    }
}