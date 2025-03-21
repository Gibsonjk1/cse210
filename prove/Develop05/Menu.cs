public class Menu
{
    private int _actionChoice;
    public bool _isRunning = true;
    private List<string> _options = new List<string>() { "1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Display Character/Level", "7. Quit" };

    private GoalProcessor goalProcessor = new GoalProcessor();
    public Menu()
    {

    }

    public void DisplayMenu()
    {
        foreach (string option in _options)
            Console.WriteLine(option);
    }

    public int GetUserChoice()
    {
        Console.Write("Your Choice: ");
        _actionChoice = int.Parse(Console.ReadLine());
        return _actionChoice;
    }

    public void RunSelection(int choice)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("What Kind of Goal Would you like to create?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write(">");
                int goalChoice = int.Parse(Console.ReadLine());
                switch (goalChoice)
                {
                    case 1:
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.CreateGoal();
                        GoalProcessor.Save(simpleGoal);
                        break;
                    case 2:
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.CreateGoal();
                        GoalProcessor.Save(eternalGoal);
                        break;
                    case 3:
                        ChecklistGoal checklistGoal = new ChecklistGoal();
                        checklistGoal.CreateGoal();
                        GoalProcessor.Save(checklistGoal);
                        break;
                }
                break;
            case 2:
                int index = 0;
                Console.WriteLine();
                foreach (Goals goal in GoalProcessor._goalList)
                {
                    index++;
                    string isComplete = goal.IsComplete();
                    Console.Write(isComplete);
                    Console.Write($"{index}. ");
                    goal.DisplayTitle();
                }
                Console.WriteLine();
                break;
            case 3:
                GoalProcessor.SaveFile();
                break;
            case 4:
                GoalProcessor.Load();
                break;
            case 5:
                goalProcessor.RecordEvent();
                break;
            case 6:
                goalProcessor.GetLevel();
                break;
            case 7:
                _isRunning = false;
                break;

        }
    }
}