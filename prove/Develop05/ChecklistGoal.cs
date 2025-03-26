using System.Security.Principal;

public class ChecklistGoal : Goals
{
    int _goalCount;
    int _goalEnd;
    public ChecklistGoal() : base("ChecklistGoal")
    {

    }
    public override void CreateGoal()
    {
        Console.WriteLine("What is the Title of Your Goal?");
        _goalTitle = Console.ReadLine();
        Console.WriteLine("Describe your Goal: ");
        _goalDesc = Console.ReadLine();
        Console.WriteLine("How many times do you want to complete this goal?");
        _goalEnd = int.Parse(Console.ReadLine());
        Console.WriteLine("How many points do you get each time you complete the task?");
        _goalValue = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points do you get when you're totally done?");
        _goalBonus = int.Parse(Console.ReadLine());
        Console.WriteLine("Your goal has been set!");
    }

    public override string FormatGoal()
    {
        string formattedGoal = _goalType + "~|~" + _goalTitle + "~|~" + _goalDesc + "~|~" + _goalValue + "~|~" + _goalBonus + "~|~" + _goalEnd + "~|~" + _goalCount;
        return formattedGoal;
    }

    public override void LoadGoal(string[] data)
    {
        _goalType = data[0];
        _goalTitle = data[1];
        _goalDesc = data[2];
        _goalValue = int.Parse(data[3]);
        _goalBonus = int.Parse(data[4]);
        _goalEnd = int.Parse(data[5]);
        _goalCount = int.Parse(data[6]);
    }

    public override int AddScore()
    {
        int scoreAdd = 0;
        if (_goalEnd == _goalCount)
        {
            scoreAdd = _goalBonus;
        }
        else
        {
            scoreAdd = _goalValue;
        }
        return scoreAdd;
    }

    public override void RecordEvent()
    {
        _goalCount++;
    }

    public override string IsComplete()
    {
        string isComplete = "[ ]";
        if (_goalCount == _goalEnd)
        {
            isComplete = "[X]";
        }
        return isComplete;
    }
}