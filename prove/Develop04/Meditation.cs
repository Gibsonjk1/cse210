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
    }
    private void MeditationAnimation()
    {
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(_timer);
        while (currentTime < futureTime)
        {
            Console.SetCursorPosition(10, 10);
            Console.Write("*");
            Thread.Sleep(300);

            Console.SetCursorPosition(9, 9);
            Console.Write("***");
            Console.SetCursorPosition(10, 9);
            Console.Write("* *");
            Console.SetCursorPosition(11, 9);
            Console.Write("***");
            Thread.Sleep(300);

            Console.SetCursorPosition(8, 8);
            Console.Write("*****");
            Console.SetCursorPosition(9, 8);
            Console.Write("*   *");
            Console.SetCursorPosition(10, 8);
            Console.Write("*   *");
            Console.SetCursorPosition(11, 8);
            Console.Write("*   *");
            Console.SetCursorPosition(12, 8);
            Console.Write("*****");
            Thread.Sleep(300);
        }
    }
}