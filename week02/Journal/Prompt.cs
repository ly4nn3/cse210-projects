public class Prompt
{
    private List<string> _prompts;

    public Prompt()
    {
        _prompts = new List<string>
        {
            "What's the strongest emotion you felt today?",
            "Is there something you're grateful for today?",
            "What was the most challenging thing you faced today?",
            "Are there any accomplishments you're proud of today?",
            "What's the weather like today? Did it affect you?",
            "What's the best mealtime you had today?",
            "What's the worst mealtime you had today?",
            "Is there anything you'd like to do but couldn't today?",
            "What are you looking forward to the most tomorrow?"
        };
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}