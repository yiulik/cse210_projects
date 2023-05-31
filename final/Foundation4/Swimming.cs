public class Swimming : Activity
{
    // Attribute
    private int _lap;

    // Constructors
    public Swimming():base()
    {

    }
    public Swimming(string date):base(date)
    {

    }

    // Methods
    public override double ComputeDistance()
    {
        return GetLap() * 50 / 1000;
    }
    public override double ComputeSpeed()
    {
        return ComputeDistance() / GetLength() * 60;
    }
    public override void GetInfo()
    {
        GetBasicInfo();
        Console.Write("How many laps have you swum (If the number is less than 20, the distance would be too small to be recorded, so it would be shown as 0) ? ");
        string ans = Console.ReadLine();
        int lap = int.Parse(ans);
        SetLap(lap);
        SetDistance(ComputeDistance());
        SetSpeed(ComputeSpeed());
        Setpace(ComputePace(GetLength(), GetDistance()));
        SetActivity("Swimming");
    }

    // Getters and Setters
    public void SetLap(int lap)
    {
        _lap = lap;
    }
    public int GetLap()
    {
        return _lap;
    }
}