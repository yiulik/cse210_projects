public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public EternalGoal() : base()
    {

    }
    public override string Display()
    {
        return $"{GetName()} ({GetDescription()})";
    }
    public override string GetGoalAsTxt()
    {
        return $"EternalGoal|{GetName()}%{GetDescription()}%{GetPoints()}";
    }
}