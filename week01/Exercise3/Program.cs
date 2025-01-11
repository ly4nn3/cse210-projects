using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        while (true)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int count = 0;

            while (true)
            {
                Console.Write("What is the magic number? ");
                string guess = Console.ReadLine();

                // Validate user input is an integer
                if (!int.TryParse(guess, out int guessNumber))
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }

                count++;

                if (guessNumber < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    string word = count == 1? "guess" : "guesses";
                    
                    Console.WriteLine($"You guessed it! You took {count} {word}.");
                
                    Console.Write("Play again? (yes/no) ");
                    string playAgain = Console.ReadLine();

                    if (playAgain.ToLower() != "yes")
                    {
                        Console.WriteLine("Thanks for playing!");
                        return;
                    }

                    break;

                }
            }

        }

    }
}