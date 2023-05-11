public class SensingActivity:Activity
{
    public SensingActivity():base()
    {

    }
    public SensingActivity(string name, string description):base(name, description)
    {

    }
    public void Sense()
    {
        DateTime start = DateTime.Now;
        DateTime endTime = start.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            string prompt = GetSensingPrompts();
            Console.Write($"\n{prompt}");
            Spinner(10);
        }
        Console.WriteLine("");
    }
    public string GetSensingPrompts()
    {
        AddItems("Name one thing that catches your attention when you look around.");
        AddItems("Name a scent that you notice when you take a sniff with your nose.");
        AddItems("Name an object that you enjoy feeling with your hands.");
        AddItems("Name one thing that you hear when you listen with your ears.");
        Random rnd = new Random();
        int i = rnd.Next(GetList().Count);
        return GetList()[i];
    }
}