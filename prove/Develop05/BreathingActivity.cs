/*public class BreathingActivity : Activity
{
  //This function sets up the activity by giving it a name and a description
    public BreathingActivity()
    {
       ActivityName = "Breathing Activity";
        ActivityDescription = "This activity will help you relax by guiding your breathing.";
    }
    //This function gives a specific instruction for how the activity runs.
    public override void PerformActivity()
    {
        IncrementActivityCount();  
        StartMessage();
        for (int i = 0; i <ActivityDuration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(3);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(3);
        }
        EndMessage();
    }
}
*/
public class BreathingActivity : Activity
{
    // Constructor to set the activity name and description.
    public BreathingActivity()
    {
        ActivityName = "Breathing Activity";
        ActivityDescription = "This activity will help you relax by guiding your breathing.";
    }

    // This function gives specific instructions on how the breathing activity runs.
    public override void PerformActivity()
    {
        IncrementActivityCount();  
        StartMessage();

        // Calculate how many breath cycles the user will do based on ActivityDuration.
        int numberOfCycles = ActivityDuration / 6;

        // Performing the breathing cycles.
        for (int i = 0; i < numberOfCycles; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(3); // Pause for 3 seconds for the 'breathe in' part.
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(3); // Pause for 3 seconds for the 'breathe out' part.
        }

        // End the activity with a message.
        EndMessage();
    }
}
