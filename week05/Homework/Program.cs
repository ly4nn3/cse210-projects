using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
    
        Assignment assignment1 = new Assignment("Lyanne Lee", "CSE210");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment("Lyanne Lee", "Division", "5.3", "1-3");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Lyanne Lee", "Korean History", "King Sejong");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}