using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities =
        [
            new Running(new DateTime(2025, 02, 19), 30, 5.5),
            new Cycling(new DateTime(2025, 02, 18), 45, 10),
            new Swimming(new DateTime(2025, 02, 17), 40, 20),
        ];

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}