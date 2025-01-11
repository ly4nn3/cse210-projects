using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Validate user input is an integer
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Please enter a number.");
                continue;
            }

            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                break;
            }
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            int largest = numbers.Max();
            Console.WriteLine($"The largest number is: {largest}");

            // For smallest positive number
            int smallestPositive = numbers.Where(n => n > 0).Min();
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            numbers.Sort();

            Console.WriteLine("The sorted list is:");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
            Console.WriteLine("Exiting program.");
        }
    }
}