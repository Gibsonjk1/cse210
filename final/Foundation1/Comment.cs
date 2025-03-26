public class Comment
{
    private string _name;
    private string _commentText;

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetComment()
    {
        return _commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_name}, Comment: {_commentText}");
    }
}