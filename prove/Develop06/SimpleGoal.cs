public class SimpleGoal : Goal
{
    private bool isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isComplete = false;
    }

    public override void RecordEvent()
    {
        isComplete = true;
    }

    public override bool IsComplete() => isComplete;

    public override string GetDetailsString()
    {
        return $"SimpleGoal: {name}, {description}, {points} points, Completed: {isComplete}";
    }

    public override string ToFileString()
    {
        return $"Simple,{name},{description},{points}";
    }
}
