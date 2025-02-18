// Created Congratulations.cs:
// - Displays congratulatory message
// - Adds fun loading animations with the spinner method from week 5
// Used | as delimiter instead of commas
// - Allow users more freedom in their inputs
// Added ShowMilestone() in GoalManager.cs
// - Displays milestone achieved every 1000 points

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine($"\nYou have {manager.GetScore()} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.CreateNewGoal();
                    break;
                case 2:
                    manager.DisplayGoals();
                    break;
                case 3:
                    Console.Write("What filename would you like to save as? ");
                    manager.SaveGoals(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("What is the filename of the file you would like to load? ");
                    manager.LoadGoals(Console.ReadLine());
                    break;
                case 5:
                    manager.DisplayGoals();
                    Console.Write("Which goal did you accomplish? ");
                    manager.RecordEvent(int.Parse(Console.ReadLine()) - 1);
                    break;
                case 6:
                    return;
            }
        }
    }
}