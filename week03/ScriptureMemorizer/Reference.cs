namespace ScriptureMemorizer;
public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = -1;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse) 
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string result = "";

        if (_endVerse == -1) 
        {
            result = $"{_book} {_chapter}:{_startVerse}";
        }
        else 
        {
            result = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }

        return result;
    }
}