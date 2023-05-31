public class Running : Activity
{
    // Constructors
    public Running():base()
    {

    }
    public Running(string date):base(date)
    {
        
    }

    // Methods
    public override double ComputeSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public override void GetInfo()
    {
        GetBasicInfo();
        Console.Write("What is the distance (in km) you have run? ");
        string dist = Console.ReadLine();
        double distance = double.Parse(dist);
        SetDistance(distance);
        SetSpeed(ComputeSpeed());
        Setpace(ComputePace(GetLength(), GetDistance()));
        SetActivity("Running");
    }
}