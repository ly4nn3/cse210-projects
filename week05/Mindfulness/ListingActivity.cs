public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in.",
            0)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths that you're proud of?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");

        Console.ForegroundColor = ConsoleColor.Magenta;
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> responses = GetListFromUser();
        _count = responses.Count;

        Console.WriteLine($"You've listed {_count} responses!");

        DisplayEndMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    
    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write(">>> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        return responses;
    }
}