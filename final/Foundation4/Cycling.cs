public class Cycling : Activity
{
    // Constructors
    public Cycling():base()
    {

    }
    public Cycling(string date):base(date)
    {
        
    }

    // Methods
    public override double ComputeDistance()
    {
        double distance = GetSpeed() / 60 * GetLength();
        return distance;
    }
    public override void GetInfo()
    {
        GetBasicInfo();
        Console.Write("What is the speed (in kph) at which you rode? ");
        string s = Console.ReadLine();
        double speed = double.Parse(s);
        SetSpeed(speed);
        SetDistance(ComputeDistance());
        Setpace(ComputePace(GetLength(), GetDistance()));
        SetActivity("Cycling");
    }
}