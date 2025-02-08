public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName)
        : base("Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing",
            0)
        {
        }

    public void Run()
    {
        DisplayStartMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
        }

        DisplayEndMessage();
    }
}