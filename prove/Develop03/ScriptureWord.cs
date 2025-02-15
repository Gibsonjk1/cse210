public class ScriptureWord
{
    private string _word;

    private int _index;

    private string _hidden;

    public ScriptureWord(string word, int index)
    {
        _word = word;
        _index = index;
        _hidden = HideWord();
    }

    public string GetWord()
    {
        return _word;
    }
    public int GetIndex()
    {
        return _index;
    }

    public string GetHidden()
    {
        return _hidden;
    }
    public void SetWord(string word)
    {
        _word = word;
    }
    public string HideWord()
    {
        int length = _word.Length;
        string hidden = "";

        for (int i = 0; i < length; i++)
        {
            hidden = hidden + "_";
        }

        return hidden;
    }
}