public class ListingActivity:Activity
{
    public ListingActivity():base()
    {

    }
    public ListingActivity(string name, string description, int duration):base(name, description, duration)
    {

    }
    public void Listing()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        string prompt = GetListPrompts();
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        Countdown(5);
        Console.WriteLine("");

        DateTime start = DateTime.Now;
        DateTime endTime = start.AddSeconds(GetDuration());
        int counter = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            Console.ReadLine();
            counter++;
        }
        Console.WriteLine($"You listed {counter} items!");
    }
    public string GetListPrompts()
    {
        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        Random rnd = new Random();
        int i = rnd.Next(prompts.Count);
        return prompts[i];
    }
}