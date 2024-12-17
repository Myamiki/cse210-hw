using System;
// This is a Base abstract class for an activity
public class Running : Activity
{
    private double activityDistance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
         activityDistance = distance;
    }
    public override double CalculateDistance() =>  activityDistance;

    public override double CalculateSpeed() => ( activityDistance/ Minutes) * 60;
    public override double CalculatePace() => Minutes /  activityDistance;
}

/*activityDistance: Stores the total distance of the run.
 activityDistance: Initializes the date, duration in minutes, and distance of the run by calling the base class constructor and setting it.
 CalculateDistance(): Returns the stored distance of the run.
 CalculateSpeed(): Calculates the running speed in kilometers per hour based on the distance and duration.
 CalculatePace(): Calculates the average time it takes to run 1 kilometer (pace) in minutes.
*/