public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base(name, description, points, isCompleted)
    {

    }
    public SimpleGoal() : base()
    {

    }
    public override string Display()
    {
        return $"{GetName()} ({GetDescription()})";
    }
    public override string GetGoalAsTxt()
    {
        return $"SimpleGoal|{GetName()}%{GetDescription()}%{GetPoints()}%{GetIsCompleted()}";
    }
}