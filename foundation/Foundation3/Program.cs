using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 12, 18), 40, 8.0),
            new Cycling(new DateTime(2024, 12, 18), 30, 60.0),
            new Swimming(new DateTime(2024, 12, 18), 25, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.ActivitySummary());
        }
    }
}
/* 
 This program defines a list of different types of activities Running, Cycling, Swimming and stores them in a list called activities.
Each activity has a date, duration, and distance or time for swimming. 
The program then loops through each activity and prints a summary of it using the ActivitySummary method.
*/
