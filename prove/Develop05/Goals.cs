public abstract class Goals
{
    protected string _goalTitle;
    protected string _goalType;
    protected string _goalDesc;
    protected int _goalValue;
    protected int _goalBonus = 0;

    public Goals(string goalType)
    {
        // Construct the goals stuff
        _goalType = goalType;
    }

    public void DisplayScore()
    {

    }
    public void DisplayTitle()
    {
        Console.WriteLine(_goalTitle);
    }
    public virtual int AddScore()
    {
        return _goalValue;
    }
    public abstract void CreateGoal();
    public abstract string FormatGoal();
    public abstract void LoadGoal(string[] data);
    public abstract void RecordEvent();

    public abstract string IsComplete();
}