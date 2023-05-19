public class Goal
{
    private string _name, _description;
    private int _points, _totalpts;
    private bool _isCompleted = false;
    private List<Goal> _goalList = new List<Goal>();

    public Goal(string name, string description, int points, bool isCompleted)
    {
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public Goal()
    {

    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }
    // public List<Goal> GetList()
    // {
    //     return _goalList;
    // }
    // public void SetList(List<Goal> goallist)
    // {
    //     _goalList = goallist;
    // }

    public virtual void SetIsCompleted(bool IsCompleted)
    {
        _isCompleted = IsCompleted;
    }

    public bool GetIsCompleted()
    {
        return _isCompleted;
    }

    public int GetTotal()
    {
        return _totalpts;
    }

    public void SetTotal(int total)
    {
        _totalpts = total;
    }



    public virtual string GetGoalAsTxt()
    {
        return "";
    }

    public void DisplayMenu()
    {
        Console.WriteLine($"\nYou have {_totalpts} points.\n");
        Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit");
        Console.Write("\nSelect a choice from the menu: ");
    }

    public virtual void CreateGoal()
    {
        Console.Write("What is the name of the goal? ");
        string ans1 = Console.ReadLine();
        SetName(ans1);

        Console.Write("What is a short description of it? ");
        string ans2 = Console.ReadLine();
        SetDescription(ans2);

        Console.Write("What is the amount of points associated with this goal? ");
        string ans3 = Console.ReadLine();
        SetPoints(int.Parse(ans3));
    }

    public void DisplayGoal(List<Goal> goalList)
    {
        for (int i = 0; i < goalList.Count; i++)
        {
            if (goalList[i].GetIsCompleted() == false)
            {
                Console.WriteLine($"{i+1}. [ ] {goalList[i].Display()}");
            }
            else if (goalList[i].GetIsCompleted() == true)
            {
                Console.WriteLine($"{i+1}. [X] {goalList[i].Display()}");
            }
        }
    }

    public virtual string Display()
    {
        return $"{GetName()} ({GetDescription()})";
    }

    public void Save(List<Goal> goalList)
    {
        Console.WriteLine("\nWhat is the filename? ");
        string  filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
            outputFile.WriteLine(_totalpts);
            foreach (Goal goal in goalList)
            {
                outputFile.WriteLine($"{goal.GetGoalAsTxt()}");
            }
        }
    }

    public List<Goal> Load(List<Goal> goallist)
    {
        goallist = new List<Goal>();
        Console.WriteLine("\nWhat is the filename? ");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);
        
        foreach (string line in lines) 
        {
            if (int.TryParse(line, out int n))
            {
                _totalpts = n;    // To see if the line contains the total amount of points
            }
            else 
            {
                string[] parts = line.Split("|");    // Split the line the first time using "|"
                string obj = parts[0];
                string content = parts[1];
                string[] parts2 = content.Split("%");    // Split the line the second time using "%"
                string name = parts2[0];
                string description = parts2[1];
                string points = parts2[2];
                int pts = int.Parse(points);
                
                // Determine which type of goal it is to further split the line or store the goal info
                if (obj == "SimpleGoal")
                {
                    string comp = parts2[3];
                    bool completed = bool.Parse(comp);
                    SimpleGoal g1 = new SimpleGoal(name, description, pts, completed);
                    goallist.Add(g1);
                }
                else if (obj == "EternalGoal")
                {
                    EternalGoal g2 = new EternalGoal(name, description, pts);
                    goallist.Add(g2);
                }
                else if (obj == "ChecklistGoal")
                {
                    string bonuses = parts2[3];
                    int bonus = int.Parse(bonuses);
                    string num = parts2[4];
                    int times = int.Parse(num);
                    string cur = parts2[5];
                    int current = int.Parse(cur);
                    string comp = parts2[6];
                    bool completed = bool.Parse(comp);
                    ChecklistGoal g3 = new ChecklistGoal(name, description, pts, bonus, times, current, completed);
                    goallist.Add(g3);
                }
            }
        }
        return goallist;
    }

    public void Record(List<Goal> goallist)
    {
        // Display the list of goals
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < goallist.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goallist[i].GetName()}");
        }

        // Ask for the goal to report on
        Console.Write("Which goal did you accomplish? ");
        string answer = Console.ReadLine();
        int ans = int.Parse(answer);    // Parse the string to int
        Goal goal = goallist[ans-1];    // Create a new variable for convenience

        if (goal is SimpleGoal)
        {
            if (goal._isCompleted == false)    // Check if it is completed or not. If completed, the user cannot get more points.
            {
                goal.SetIsCompleted(true);
                Console.WriteLine($"Congratulations! You have earned {goal._points} points!");
                _totalpts += goal._points;
                Console.WriteLine($"You now have {_totalpts} points.");
            }
            else 
            {
                Console.WriteLine("You have already completed this goal. Please make a new goal.");
            }
        }
        else if (goal is EternalGoal)
        {
            Console.WriteLine($"Congratulations! You have earned {goal._points} points!");
            _totalpts += goal._points;
            Console.WriteLine($"You now have {_totalpts} points.");
        }
        else if (goal is ChecklistGoal)
        {
            int totalpts = goal.RecordCompletion();
            _totalpts += totalpts;
            Console.WriteLine($"You now have {_totalpts} points.");
        }
    }

    public virtual int RecordCompletion()
    {
        return -1;
    }
}