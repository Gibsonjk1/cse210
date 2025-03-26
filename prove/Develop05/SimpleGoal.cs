public class SimpleGoal : Goals
{
    private bool _goalComplete = false;

    public SimpleGoal() : base("SimpleGoal")
    {

    }

    public override void CreateGoal()
    {
        Console.WriteLine("What is the Title of Your Goal?");
        _goalTitle = Console.ReadLine();
        Console.WriteLine("Describe your Goal: ");
        _goalDesc = Console.ReadLine();
        Console.WriteLine("How many points do you get when you're done?");
        _goalValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Your goal has been set!");
    }

    public override string FormatGoal()
    {
        string formattedGoal = _goalType + "~|~" + _goalTitle + "~|~" + _goalDesc + "~|~" + _goalValue + "~|~" + _goalComplete;
        return formattedGoal;
    }

    public override void LoadGoal(string[] data)
    {
        _goalType = data[0];
        _goalTitle = data[1];
        _goalDesc = data[2];
        _goalValue = int.Parse(data[3]);
        _goalComplete = bool.Parse(data[4]);
    }

    public override void RecordEvent()
    {
        _goalComplete = true;
    }
    public override string IsComplete()
    {
        string isComplete = "[ ]";
        if (_goalComplete == true)
        {
            isComplete = "[X]";
        }
        return isComplete;
    }
}