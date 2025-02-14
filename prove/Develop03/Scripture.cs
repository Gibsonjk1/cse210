public class Scripture
{
    List<ScriptureWord> _words = new List<ScriptureWord>();

    List<int> _randoms = new List<int>();
    string _ogText;

    string _reference;

    public Scripture()
    {
        _ogText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        _reference = "Proverbs 3:5-6";
        GetWords();
    }
    public Scripture(string book, int chapter, int firstVerse, int lastVerse = 0)
    {
        string end = "";
        if (lastVerse != 0)
        {
            end = $"-{lastVerse}";
        }
        _reference = $"{book} {chapter}:{firstVerse}{end}";

        Reference scripture = new Reference(_reference);
        _ogText = scripture.GetText();
        GetWords();
    }

    private void GetWords()
    {
        string[] words = _ogText.Split(" ");
        int index = 0;
        foreach (string word in words)
        {
            ScriptureWord thing = new ScriptureWord(word, index);
            _words.Add(thing);
            index += 1;
        }
    }
    public void AddWord()
    {

    }
    public void RandomBlank()
    {

    }
    public void Display()
    {
        foreach (ScriptureWord word in _words)
        {
            if (!_randoms.Contains(word.GetIndex()))
            {
                Console.Write($"{word.GetWord()} ");
            }
            else
            {
                Console.Write($"{word.GetHidden()} ");
            }

        }
    }
}