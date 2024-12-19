public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // No event recording for eternal goals
    }

    public override bool IsComplete() => false; // Eternal goals are never complete

    public override string GetDetailsString()
    {
        return $"EternalGoal: {name}, {description}, {points} points";
    }

    public override string ToFileString()
    {
        return $"Eternal,{name},{description},{points}";
    }
}
