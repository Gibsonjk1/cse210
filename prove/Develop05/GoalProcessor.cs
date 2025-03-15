using System.Reflection.PortableExecutable;

public class GoalProcessor
{
    public static List<Goals> _goalList = new List<Goals>();
    public static int _score;

    public static void Save(Goals entry)
    {
        _goalList.Add(entry);
    }
    public static void Load()
    {
        _goalList.Clear();

        Console.Write("What is the file name?: ");
        string filePath = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"files/{filePath}");

        foreach (string line in lines)
        {
            string[] entry = line.Split("~|~");
            switch (entry[0])
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.LoadGoal(entry);
                    Save(simpleGoal);
                    break;
                case "EternalGoal":
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.LoadGoal(entry);
                    Save(eternalGoal);
                    break;
                case "ChecklistGoal":
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.LoadGoal(entry);
                    Save(checklistGoal);
                    break;
                default:
                    _score = int.Parse(entry[0]);
                    break;
            }

            //Save(entry);
        }
        Console.WriteLine("File is Loaded");
    }

    public static void SaveFile()
    {
        Console.Write("What is the file name?: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter($"files/{fileName}"))
        {
            outputFile.WriteLine(_score);
            foreach (Goals goal in _goalList)
            {
                string line = goal.FormatGoal();
                outputFile.WriteLine(line);
            }
        }
        Console.WriteLine("File Saved.");
        Console.WriteLine();
    }

    public void RecordEvent()
    {
        int index = 0;
        Console.WriteLine();
        foreach (Goals goal in _goalList)
        {
            index++;
            Console.Write($"{index}. ");
            goal.DisplayTitle();
        }
        Console.WriteLine();
        Console.WriteLine("Which goal did you accomplish?: ");
        int choice = int.Parse(Console.ReadLine());
        _goalList[choice - 1].RecordEvent();
        int addToScore = _goalList[choice - 1].AddScore();
        _score = _score + addToScore;
        Console.WriteLine($"Congratulations! You have earned {addToScore} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void GetLevel()
    {
        int level = _score / 100;
        Console.WriteLine(Character.GetLevel(level));
        Console.WriteLine(Character.GetCharacter(level));

    }
}