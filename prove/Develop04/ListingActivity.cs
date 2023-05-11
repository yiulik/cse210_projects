public class ListingActivity:Activity
{
    public ListingActivity():base()
    {

    }
    public ListingActivity(string name, string description):base(name, description)
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
        AddItems("Who are people that you appreciate?");
        AddItems("What are personal strengths of yours?");
        AddItems("Who are people that you have helped this week?");
        AddItems("When have you felt the Holy Ghost this month?");
        AddItems("Who are some of your personal heroes?");
        Random rnd = new Random();
        int i = rnd.Next(GetList().Count);
        return GetList()[i];
    }
}