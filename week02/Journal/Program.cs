// Added if statement in Journal.cs to add ".txt" extension automatically when user provides a filename for both SaveEntry() and LoadEntry() options
// Added moodRating feature for user to rate their mood between 1 to 10 in an Entry
// Added try blocks to handle errors with SaveEntry() and LoadEntry() in Journal.cs

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        journal.ShowMenu();
        
    }
}