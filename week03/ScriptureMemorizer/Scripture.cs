public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideRandomWord(int numberToHide)
    {
        int wordsHidden = 0;
        while (wordsHidden < numberToHide)
        {
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
            if (!visibleWords.Any()) break;

            int index = _random.Next(visibleWords.Count);
            string selectedWord = visibleWords[index].GetText();

            foreach (Word word in _words)
            {
                if (!word.IsHidden() && word.IsSameWord(selectedWord))
                {
                    word.Hide();
                    wordsHidden++;
                }
            }
        }
    }

    public string GetDisplayText()
    {
        string wordText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {wordText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}