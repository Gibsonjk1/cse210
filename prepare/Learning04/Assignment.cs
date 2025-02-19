using System.Runtime.CompilerServices;

public class Assignment
{
    protected string _studentName;
    protected string _topic;
    public Assignment(string studentName, string topic)
    {
        _topic = topic;
        _studentName = studentName;
    }

    public string GetSummary()
    {
        return $"Name: {_studentName}, Topic: {_topic}";
    }

}