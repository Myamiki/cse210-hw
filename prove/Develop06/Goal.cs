public abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string ToFileString();
}
//Creativity
/*This file has the basic information that all types of goals share, like the goal's name, description, and points.
It’s like a blueprint for goals, setting up what every goal should have.
This shows abstraction, meaning we focus on what’s common to all goals without worrying about the details of each type of goal. */
