using System;
//This class customizes the base Activity for swimming activities.
public class Swimming : Activity
{
    private int activitylaps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        activitylaps = laps;
    }

    public override double  CalculateDistance() => activitylaps * 50 / 1000.0;

    public override double CalculateSpeed() => ( CalculateDistance() /  Minutes) * 60;

    public override double CalculatePace() =>  Minutes /  CalculateDistance();
}
/*activitylaps: The number of laps swum during the activity each lap is 50 meters.
Constructor:
It takes the date, time (in minutes), and laps as input.
Passes the date and time to the base Activity class and stores the laps in activitylaps.
 CalculateDistance(): Converts the number of laps into kilometers (1 lap = 50 meters).
CalculateSpeed(): Calculates the swimming speed in kilometers per hour.
CalculatePace(): Calculates the time (in minutes) needed to swim 1 kilometer.*/