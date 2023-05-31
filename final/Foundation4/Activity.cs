public class Activity
{
    // Attributes
    private string _date, _type;
    private int _length;
    private double _distance, _speed, _pace;

    // Constructors
    public Activity()
    {

    }
    public Activity(string date)
    {
        _date = date;
    }

    // Methods
    public virtual double ComputeDistance()
    {
        return -0.1;
    }
    public virtual double ComputeSpeed()
    {
        return -0.1;
    }
    public virtual double ComputePace(double length, double distance)
    {
        if (distance < 1)
        {
            return 0;
        }
        else
        {
            return length / distance;
        }
    }
    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_length} min) - Distance: {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km");
    }
    public void GetBasicInfo()
    {
        // Console.Clear();
        Console.Write("How long (in minutes) have you spent on this activity? ");
        string len = Console.ReadLine();
        int length = int.Parse(len);
        SetLength(length);
        Console.Write("What is the date on which you completed this activity (Enter in the format of '03 Nov 2023')? ");
        string date = Console.ReadLine();
        SetDate(date);
    }
    public virtual void GetInfo()
    {

    }

    // Getters and Setters
    public void Setpace(double pace)
    {
        _pace = pace;
    }
    public double GetPace()
    {
        return _pace;
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public double GetSpeed()
    {
        return _speed;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public string GetDate()
    {
        return _date;
    }
    public void SetActivity(string type)
    {
        _type = type;
    }
    public string GetActivity()
    {
        return _type;
    }
}