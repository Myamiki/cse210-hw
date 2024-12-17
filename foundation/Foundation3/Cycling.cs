using System;
//This class does the math specifically for cycling.
public class Cycling : Activity
{
    private double  activitySpeed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        activitySpeed = speed;
    }

    public override double CalculateDistance() => ( activitySpeed *  Minutes) / 60;

    public override double CalculateSpeed() =>  activitySpeed;

    public override double CalculatePace() => 60 /  activitySpeed;
}

/*activitySpeed: Stores the speed of the cyclist in kilometers per hour.
 Constructor:
Takes the date, time spent cycling, and speed.
Passes the date and time to the base Activity class.
Saves the speed in activitySpeed.
CalculateDistance(): Figures out how far you cycled using your speed and time.
CalculateSpeed(): Returns the speed you were cycling.
CalculatePace(): Figures out how many minutes it takes to cycle 1 kilometer.*/
