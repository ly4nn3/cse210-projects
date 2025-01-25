// Added ScriptureLibrary.cs to manage scriptures with varying verse ranges (1, 2, and 4 verses)
// - Gets a random scripture to present to the user when the program runs.
// Added a condition for HideRandomWord() in Scripture.cs to hide instances of the same words selected by the randomizer.
// Added try block for inputs that are not "quit" and to catch unexpected errors.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (!scripture.IsCompletelyHidden())
        {
            try {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.Write("\nEnter to continue or type 'quit' to exit: ");
                
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                else if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("\nInvalid input. Press Enter to continue or type 'quit' to exit.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                scripture.HideRandomWord(1);
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nAn error occurred: {e.Message}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nThanks for using Scripture Memorizer!");
    }
}