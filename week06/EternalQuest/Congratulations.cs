public static class Congratulations
{
    public static void ShowSpinner(int seconds)
    {
        List<string> spinnerStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    public static void ShowStars()
    {
        string[] frames = {
            "    *     ",
            "  * * *   ",
            "* * * * * ",
            "+ * * * +",
            "  + * +  ",
            "    +     "
        };
        for (int i = 0; i < 3; i++)
        {
            foreach (string frame in frames)
            {
                Console.WriteLine(frame);
                Thread.Sleep(100);
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
        }
        Console.WriteLine();
    }

    public static void ShowCongratulations(string goalName, int points)
    {
        Console.WriteLine("\n╔════════════════════════════════════════╗");
        Console.WriteLine("║             CONGRATULATIONS!           ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        
        ShowStars();
        
        Console.WriteLine($"You completed: {goalName}");
        Console.WriteLine($"You earned: {points} points!");
        
        ShowSpinner(2);
        
        string[] messages = {
            "Amazing work!",
            "You're crushing it!",
            "Keep up the great work!",
            "You're on fire!",
            "Outstanding achievement!"
        };

        Random rand = new Random();
        Console.WriteLine("\n" + messages[rand.Next(messages.Length)] + "\n");
    }
}