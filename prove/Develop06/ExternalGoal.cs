public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        
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

/* The EternalGoal class represents a goal that never gets completed. 
It inherits from the Goal class and has a constructor to set up the goal's name, description, and points. 

The RecordEvent() method doesn't do anything because the goal is eternal. 
The IsComplete() method always returns false since the goal never finishes. 

The GetDetailsString() method returns a summary of the goal, and the ToFileString() method formats the goal's data to save it to a file.
 This class is for goals that don't have an end.*/
