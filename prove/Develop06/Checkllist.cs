public class ChecklistGoal : Goal
{
    private int amountCompleted;
    private int target;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        amountCompleted = 0;
        this.target = target;
        this.bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (amountCompleted < target)
        {
            amountCompleted++;
        }
    }

    public override bool IsComplete() => amountCompleted >= target;

    public override string GetDetailsString()
    {
        return $"ChecklistGoal: {name}, {description}, {points} points, Completed: {amountCompleted}/{target}, Bonus: {bonus} points";
    }

    public override string ToFileString()
    {
        return $"Checklist,{name},{description},{points},{target},{bonus}";
    }
}
