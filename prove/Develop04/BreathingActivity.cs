public class BreathingActivity:Activity
{
    public BreathingActivity():base()
    {

    }
    public BreathingActivity(string name, string description, int duration):base(name, description, duration)
    {

    }
    public void Breathing()
    {
        DateTime start = DateTime.Now;
        DateTime endTime = start.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            Countdown(5);
            Console.Write("\nBreathe out...");
            Countdown(5);
        }
        Console.WriteLine("");
    }
}