public class ScriptureWord
{
    string _word;

    public ScriptureWord()
    {
        //Do Something. In what instance would I create a ScriptureWord without passing a string?
    }
    public ScriptureWord(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public string HideWord()
    {
        int length = _word.Length;
        string hidden = "";

        for (int i = 0; i <= length; i++)
        {
            hidden = hidden + "_ "
            }

        return hidden;
    }
}