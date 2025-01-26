namespace ScriptureMemorizer;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
        
    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split( ' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
        }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (! _words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + ": ";

        foreach (Word word in _words)
        {
        displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }
    public bool IsCompleatlyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}