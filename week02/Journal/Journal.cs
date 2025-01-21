public class Journal
{
    private List<Entry> _entries;
    private Prompt _promptGenerator;

    public Journal()
    {
        _entries = new List<Entry>();
        _promptGenerator = new Prompt();
    }

    public void ShowMenu()
    {
        string choice = "";
        string[] options = {
            "-------------",
            "1. Write new entry",
            "2. Display journal",
            "3. Save journal to file",
            "4. Load journal from file",
            "5. Exit"
        };

        while (choice != "5")
        {
            Console.WriteLine("\nJournal menu:");
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    NewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter a filename to save: ");
                    string saveFile = Console.ReadLine();
                    SaveEntry(saveFile);
                    break;
                case "4":
                    Console.Write("Enter a filename to load: ");
                    string loadFile = Console.ReadLine();
                    LoadEntry(loadFile);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    public void NewEntry()
    {
        string prompt = _promptGenerator.GetPrompt();
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write(">>> ");
        string response = Console.ReadLine();

        Console.Write("Rate your mood today (1-10): ");
        int moodRating;
        while (!int.TryParse(Console.ReadLine(), out moodRating) || moodRating < 1 || moodRating > 10)
        {
            Console.Write("Invalid input. Enter a number between 1 and 10: ");
        }

        _entries.Add(new Entry(prompt, response, moodRating));
    }

    public void SaveEntry(string file)
    {
        if (!file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)) // Ensure case-insensitive so lower or upercase is recognized if etxtension is entered
        {
            file += ".txt";
        }

        try 
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.GetEntryAsString());
                }
            }
            Console.WriteLine($"Journal saved successfully as {file}!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error saving file: {e.Message}");
        }
    }

    public void LoadEntry(string file)
    {
        if (!file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)) // Ensure case-insensitive so lower or upercase is recognized if etxtension is entered
        {
            file += ".txt";
        }

        if (!File.Exists(file))
        {
            Console.WriteLine("File does not exist. Please check filename and try again.");
            return;
        }

        try
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(file);

            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                if (parts.Length == 4) // Entry has 4 parts in total
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    DateTime date = DateTime.Parse(parts[2]);
                    int moodRating = int.Parse(parts[3]);

                    Entry entry = new Entry(prompt, response, moodRating);
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error loading file: {e.Message}");
        }
    }

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty (._.)");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}