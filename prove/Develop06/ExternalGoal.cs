public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Eternal goals are never complete, so no action is taken here.
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"EternalGoal: {name}, {description}, {points} points";
    }

    public override string ToFileString()
    {
        return $"Eternal,{name},{description},{points}";
    }
}
