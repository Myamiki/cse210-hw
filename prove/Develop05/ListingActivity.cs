public class ListingActivity : Activity
{
    //The variable ActivityPrompts will store the Listining Activity questions
    private List<string> ActivityPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    //This function sets up the activity by giving it a name and a description
    public ListingActivity()
    {
        ActivityName = "Listing Activity";
        ActivityDescription ="This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    /*This function gives a specific instruction for how the activity runs.
     It shows one random sentence from the list , it lets
     the user type as many responses as they can before time runs out and
     it counts how many things the user has listed and shows the total at the end*/
    public override void PerformActivity()
    {
        //This function tracks how mant times this activity has been used
        IncrementActivityCount(); 
        /*This function shows the Activity name ,description and allow the user 
        decide how long the activity will last */
        StartMessage();
        //The random variable is used to pick one sentence randomly from the list
        Random random = new Random();
        Console.WriteLine(ActivityPrompts[random.Next(ActivityPrompts.Count)]);
        //This function pauses the program for a few sec and shows a little animation during the pause
        PauseWithAnimation(3);
        
        //The variable keeps track of how many things the user has typed during the activity
        int itemCount = 0;
        /*The variable marks the time when the activity will stop , its calculated using the 
        current time and the duration.*/
        DateTime endTime = DateTime.Now.AddSeconds(ActivityDuration);
        //the loop keeps running until the activity's time is up
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter: ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You have listed {itemCount} things! ");
        EndMessage();
    }
}
