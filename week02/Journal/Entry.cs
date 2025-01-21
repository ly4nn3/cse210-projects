public class Entry
{
    private string _prompt;
    private string _response;
    private DateTime _date;
    private int _moodRating;

    public Entry(string prompt, string response, int moodRating)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
        _moodRating = moodRating;
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date.ToShortDateString}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Mood: {_moodRating}/ 10");
    }

    public string GetEntryAsString()
    {
        return $"{_prompt}|{_response}|{_date}|{_moodRating}";
    }
}