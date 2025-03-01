public class Breathing : Mindfulness
{
    private string _breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    private int _timer;
    public Breathing(string activityName) : base(activityName)
    {
        base._description = _breathingDescription;
    }

    public void BreathingActivity()
    {
        base._activityName = "Breathing";

        base.StartingMessage();
        _timer = base._duration;
        string step = "Breath In...";
        while (_timer > 0)
        {
            Console.Write(step);
            base.Countdown(5, 14);
            _timer = _timer - 4;
            step = step == "Breath In..." ? "Breath Out..." : "Breath In...";
            Console.WriteLine();
        }
        base.EndingMessage();
        Console.WriteLine();


    }
}