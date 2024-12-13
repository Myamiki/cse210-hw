
public class BreathingActivity : Activity
{
    // Constructor to set the activity name and description.
    public BreathingActivity()
    {
        ActivityName = "Breathing Activity";
        ActivityDescription = "This activity will help you relax by walking you through breathing in and out slowly, please clear your mind and focus on your breathing.";
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
