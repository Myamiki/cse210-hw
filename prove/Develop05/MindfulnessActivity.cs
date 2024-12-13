
using System;
using System.Collections.Generic;

public abstract class Activity
{
    // These properties store the name, description, and duration of the activity.
    protected string ActivityName { get; set; }
    protected string ActivityDescription { get; set; }
    protected int ActivityDuration { get; set; }

    // This dictionary tracks how many times each activity has been performed.
    private static Dictionary<string, int> ActivityCounts = new Dictionary<string, int>();

    // This method increases the count of how many times the current activity has been performed.
    protected void IncrementActivityCount()
    {
        // If the activity is not in the dictionary yet, add it with a count of 0.
        if (!ActivityCounts.ContainsKey(ActivityName))
        {
            ActivityCounts[ActivityName] = 0; // Initialize the count to 0 if it doesn't exist.
        }

        // Increases the activity count by 1.
        ActivityCounts[ActivityName]++;
    }

    // This method displays the total counts of all activities after the user finishes.
    public static void DisplayActivityCounts()
    {
        Console.WriteLine("Summary:");

        // Display each activity's name and how many times it has been performed.
        foreach (var entry in ActivityCounts)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} time(s)");
        }
    }

    // This method shows a message when an activity starts and asks for the duration.
    public void StartMessage()
    {
        // Show activity name and description.
        Console.WriteLine($"Start: {ActivityName}");
        Console.WriteLine(ActivityDescription);

        // Ask the user to enter the duration for the activity in seconds.
        Console.Write("Enter the duration (in seconds): ");
        ActivityDuration = int.Parse(Console.ReadLine());

        // Inform the user to prepare and pause briefly before starting.
        Console.WriteLine("Prepare to begin...");
        PauseWithAnimation(3);
    }

    // This function shows a message when an activity ends.
    public void EndMessage()
    {
        // Display a congratulatory message and the duration the user completed.
        Console.WriteLine($"Well done! You completed {ActivityName} for {ActivityDuration} seconds.");
        PauseWithAnimation(3); // Pause for 3 seconds with a simple animation.
    }

    // This function pauses the program for a given number of seconds while displaying an animation.
    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("..."); 
            System.Threading.Thread.Sleep(1000); 
        }
        Console.WriteLine(); 
    }

    // Abstract method to perform the specific activity.
    public abstract void PerformActivity();
}
