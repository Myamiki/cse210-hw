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

/*The SimpleGoal class represents a basic goal. 
It has a bool to track whether the goal is completed.

In the constructor, the goal is initially not complete.
RecordEvent() marks the goal as complete.
IsComplete() returns whether the goal is complete.
GetDetailsString() gives a string showing the goal's details.
ToFileString() saves the goal details in a file format.

This class inherits from the Goal class, which means it uses the shared properties like name, description, and points. */

/*Creativity

Tracking Completion with a Boolean:
The isComplete variable is used to track if the goal is finished. It’s a simple and clear way to check progress.

RecordEvent Method:
The RecordEvent() method changes the goal’s state from incomplete to complete, making it easy to mark progress.

IsComplete Method:
The IsComplete() method checks if the goal is finished and returns true or false.

GetDetailsString Method:
This method gives a clear string showing the goal’s name, description, points, and completion status.

ToFileString Method:
The ToFileString() method saves the goal’s information in a format that can be stored in a file for later use.
 */
