using System;

// Base abstract class for an activity
public abstract class Activity
{
    // This is an abstract base class for different types of activities like Running, Cycling, Swimming.
// It stores the date and duration of the activity and has methods that will be implemented by child classes to calculate distance, speed, and pace.
    private DateTime activityDate;
    private int activityDuration;
// Private fields store the date and duration of the activity.
// The constructor initializes the activity with a specific date and duration in minutes.
    public Activity(DateTime date, int minutes)
    {
        activityDate = date;
        activityDuration = minutes;
    }
    
// Public properties allow access to the date and duration values.

    public DateTime Date => activityDate;
    public int Minutes => activityDuration;
    

    // Abstract methods CalculateDistance, CalculateSpeed,
    //and CalculatePace will be implemented by the child classes to define how to calculate these values for specific activities.
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    // The ActivitySummary method provides a formatted summary of the activity, including its date, type, duration, distance, speed, and pace.
    public virtual string ActivitySummary()
    {
        return $"{activityDate.ToString("dd MMM yyyy")} - {GetType().Name} ({activityDuration} min): " +
               $"Distance: {CalculateDistance():0.0} km, Speed: {CalculateSpeed():0.0} kph, Pace: {CalculatePace():0.0} min per km";
    }
}
