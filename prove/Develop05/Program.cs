class Program
{
    static void Main(string[] args)
    {
        //This loop keeps showing the menu until the user chooses to quit (option 4).
        while (true)
        {
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            //The function prompts the user for a choice
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            //This variable holds  the activity object based on the user's choice either BreathingActivity, ReflectionActivity, or ListingActivity
            Activity MainActivity;

            //The variable  stores the user's menu selection. It can be 1, 2, 3, or 4.
            if (choice == "1")
            {
                MainActivity = new BreathingActivity(); 
            }
            else if (choice == "2")
            {
                MainActivity = new ReflectionActivity(); 
            }
            else if (choice == "3")
            {
                MainActivity = new ListingActivity(); 
            }
            else if (choice == "4")
            {
                MainActivity = null; 
            }
            else
            {
                // This function handles invalid input
                Console.WriteLine("Invalid choice. Please try again.");
                //when the user enters an invalid menu choice, continue skips to the next iteration of the loop, showing the menu again.
                continue; 
            }

            //This checks if the user wants to quit
            if (MainActivity == null) break;

            // This function perform the chosen activity
            MainActivity.PerformActivity();
        }

        //This function displays the activity counts when the user quits
        Activity.DisplayActivityCounts();
    }
}  
