public class Activity
{
    // Setting up variables
    private string _name, _description;
    private int _duration;
    
    // Constructors
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }   
    public Activity()
    {

    }

    // Methods
    // Setters and Getters for the two attributes
    public void SetName(string name)
    {
        _name = name;
    }
    public string Getname()
    {
        return _name;
    }
    public void SetDes(string description)
    {
        _description = description;
    }
    public string GetDes()
    {
        return _description;
    }
    public void SetDuration()
    {
        Console.WriteLine("\nHow long, in seconds, would you like for your session (Recommendation: At least 10 seconds)? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }
    public int GetDuration()
    {
        return _duration;
    }

    // Other methods
    public void StartMsg()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        SetDuration();
    }
    
    public void PrepareMsg()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(4);
    }
    public void EndMsg()
    {
        Console.WriteLine("\nWell done!");
        Spinner(4);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}!");
        Spinner(4);
    }
    public void Spinner(int num)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(num);
        
        List<string> spinnerString = new List<string>();
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");
        spinnerString.Add("|");
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            string l = spinnerString[i];
            Console.Write(l);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= spinnerString.Count)
            {
                i = 0;
            }
        }
    }
    public void Countdown(int num)
    {
        for (int i = num; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}   