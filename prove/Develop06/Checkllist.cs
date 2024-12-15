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

/*The ChecklistGoal class represents a goal that tracks progress toward a specific target. 
It inherits from the Goal class and adds three new properties: amountCompleted ,target and bonus. 

The constructor sets the initial values for these properties. 
The RecordEvent() method increases amountCompleted when a task is completed, but only if the target hasn't been reached.

The IsComplete() method checks if the target is met. 

The GetDetailsString() method returns a summary of the goal, while the ToFileString() method formats the goal’s data for saving to a file.
This class helps track and manage checklist-style goals. */
