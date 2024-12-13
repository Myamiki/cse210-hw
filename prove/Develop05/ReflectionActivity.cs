public class ReflectionActivity : Activity
{
    //The variable ActivityPrompts will store the reflective questions and  is private to protect its content from being changed directly.
    private List<string> ActivityPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
      //The variable ReflectionQuestions will store the reflective questions and  is private to protect its content from being changed directly.
    private List<string> ReflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "What did you learn about yourself through this experience?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "How can you keep this experience in mind in the future?"
    };

    //This function sets up the activity by giving it a name and a description
    public ReflectionActivity()
    {
       ActivityName = "Reflection Activity";
        ActivityDescription ="This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    
    //This function gives a specific instruction for how the activity runs.
    public override void PerformActivity()
    {
        //The function keeps track of how many times the activity has been performed
        IncrementActivityCount();  
        //The function shows a message that introduces the activity ,its name and its description
        StartMessage();
        Random random = new Random();
        Console.WriteLine(ActivityPrompts[random.Next(ActivityPrompts.Count)]);
        //The function pauses the program  for a specified number of sec and shows an animation
        PauseWithAnimation(3);
        // The loop repeats the process of asking questions until the activity duration is complete.
        for (int i = 0; i < ActivityDuration / 5; i++)
        {
            Console.WriteLine(ReflectionQuestions[random.Next(ReflectionQuestions.Count)]);
            PauseWithAnimation(5);
        }
        EndMessage();
    }
}