public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _times;
    private int _current;
    public ChecklistGoal(string name, string description, int points, int bonus, int times, int current, bool isCompleted) : base(name, description, points, isCompleted)
    {
        _bonus = bonus;
        _times = times;
        _current = current;
    }
    public ChecklistGoal() : base()
    {

    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetTimes(int times)
    {
        _times = times;
    }
    public int GetTimes()
    {
        return _times;
    }
    public void SetCurrent(int current)
    {
        _current = current;
    }
    public int GetCurrent()
    {
        return _current;
    }
    public override void CreateGoal()
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
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string ans4 = Console.ReadLine();
        SetTimes(int.Parse(ans4));
        Console.Write("What is the bonus for accomplishing it that many times? ");
        string ans5 = Console.ReadLine();
        SetBonus(int.Parse(ans5));
    }
    public override string Display()
    {
        return $"{GetName()} ({GetDescription()}) -- Currently completed: {_current}/{_times}";;
    }
    public override string GetGoalAsTxt()
    {
        return $"ChecklistGoal|{GetName()}%{GetDescription()}%{GetPoints()}%{GetBonus()}%{GetTimes()}%{GetCurrent()}%{GetIsCompleted()}";
    }
    public override int RecordCompletion()
    {
        SetTotal(0);
        if (_current < _times)
        {
            _current++;
            if (_current < _times)
            {
                SetTotal(GetPoints());
                Console.WriteLine($"\nCongratulations! You have earned {GetPoints()} points!");
            }
            else if (_current == _times)
            {
                SetIsCompleted(true);
                SetTotal(_bonus + GetPoints());
                Console.WriteLine($"\nCongratulations! You have earned {_bonus + GetPoints()} points!");
            }
            
        }
        else if (_current >= _times)
        {
            Console.WriteLine("\nYou have already completed this goal. Please make a new goal.");
        }
        return GetTotal();
    }
}