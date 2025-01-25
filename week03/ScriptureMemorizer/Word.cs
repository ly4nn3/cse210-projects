public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetDisplayText()
    {
        return _hidden ? new string('_', _text.Length) : _text;
    }

    public string GetText()
    {
        return _text;
    }

    public bool IsSameWord(string otherWord)
    {
        return _text.Equals(otherWord, StringComparison.OrdinalIgnoreCase);
    }
}