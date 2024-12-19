public class SimpleGoal : Goal
{
    private bool isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        isCompleted = false;
    }

    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            isCompleted = true;
            // You can add the points to the user's score here if needed
        }
    }

    public override bool IsComplete() => isCompleted;

    public override string GetDetailsString()
    {
        return $"SimpleGoal: {name}, {description}, {points} points, Completed: {isCompleted}";
    }

    public override string ToFileString()
    {
        return $"Simple,{name},{description},{points},{isCompleted}";
    }
}
