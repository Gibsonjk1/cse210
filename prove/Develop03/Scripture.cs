public class Scripture
{
    public List<ScriptureWord> _words = new List<ScriptureWord>();

    public List<int> _randoms = new List<int>();
    string _ogText;

    string _reference;

    public Scripture()
    {
        Reference scripture = new Reference();
        _ogText = scripture.GetText();
        _reference = scripture.GetReference();
        GetWords();
    }
    public Scripture(string book, int chapter, int firstVerse, int lastVerse = 0)
    {
        Reference scripture = new Reference(book, chapter, firstVerse, lastVerse);
        _ogText = scripture.GetText();
        _reference = scripture.GetReference();
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
        Random r = new Random();
        for (int i = 0; i < 3; i++)
        {
            int randInt1 = r.Next(0, _words.Count);
            if (_randoms.Contains(randInt1))
            {
                i--;
            }
            else
            {
                _randoms.Add(randInt1);
            }
            if (_randoms.Count == _words.Count)
            {
                i = 3;
            }
        }
    }
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference);
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