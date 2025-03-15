public class EternalGoal : Goals
{
    public EternalGoal() : base("EternalGoal")
    {

    }
    public override void CreateGoal()
    {
        Console.WriteLine("What is the Title of Your Goal?");
        _goalTitle = Console.ReadLine();
        Console.WriteLine("Describe your Goal: ");
        _goalDesc = Console.ReadLine();
        Console.WriteLine("How many points do you get each time you complete the task?");
        _goalValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Your goal has been set!");
    }

    public override string FormatGoal()
    {
        string formattedGoal = _goalType + "~|~" + _goalTitle + "~|~" + _goalDesc + "~|~" + _goalValue;
        return formattedGoal;
    }

    public override void LoadGoal(string[] data)
    {
        _goalType = data[0];
        _goalTitle = data[1];
        _goalDesc = data[2];
        _goalValue = int.Parse(data[3]);
    }

    public override void RecordEvent()
    {
        Console.WriteLine("Good job! Keep Going!");
    }
}