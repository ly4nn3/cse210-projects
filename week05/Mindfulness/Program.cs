// - Added foreground color to console text for some fun visual variation
// - Added method in ReflectionActivity.cs to make sure no questions are repeated when getting a new random question

using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mindfulness Program Menu:");
                Console.WriteLine("=========================");
                Console.WriteLine("1. Start a breathing activity");
                Console.WriteLine("2. Start a reflection activity");
                Console.WriteLine("3. Start a listing activity");
                Console.WriteLine("4. Exit");
                Console.WriteLine("=========================");
                Console.Write("Select a choice from the menu: ");
                Console.ResetColor();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Run();
                        break;
                    case "2":
                        ReflectionActivity reflectionActivity = new ReflectionActivity();
                        reflectionActivity.Run();
                        break;
                    case "3":
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Run();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
            
            catch (Exception e)
            {
                Console.WriteLine($"\nAn error occured: {e.Message}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}