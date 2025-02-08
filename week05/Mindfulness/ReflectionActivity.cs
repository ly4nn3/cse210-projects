using System.Diagnostics.CodeAnalysis;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _unusedQuestions;

    public ReflectionActivity()
        : base("Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have an dhow you can use it in other aspects of your life.",
            0)
    {
        _prompts = new List<string>
        {
            "Think of a time whe nyou stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        ResetQuestions();
    }

    private void ResetQuestions()
    {
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartMessage();
        DisplayPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
        }

        DisplayEndMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            ResetQuestions();
        }

        Random random = new Random();
        int index = random.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index);
        return question;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following: ");

        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Ponder on each of the following questions while relating to this experience. ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }

    private void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}