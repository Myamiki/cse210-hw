using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static string filePath = "goals.txt";
    private static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        LoadGoals();
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Goal Tracker");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. View goals");
            Console.WriteLine("4. Save and Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ViewGoals();
                    break;
                case "4":
                    SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Enter goal type (Simple, Eternal, Checklist): ");
        string goalType = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (goalType.ToLower() == "simple")
        {
            goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType.ToLower() == "eternal")
        {
            goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType.ToLower() == "checklist")
        {
            Console.Write("Enter target (number of times to complete): ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus points for completion: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record an event for:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goals.Count)
        {
            goals[choice].RecordEvent();
            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void ViewGoals()
    {
        Console.Clear();
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            foreach (var goal in goals)
            {
                sw.WriteLine(goal.ToFileString());
            }
        }
    }

    static void LoadGoals()
    {
        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "Simple":
                            goals.Add(new SimpleGoal(name, description, points));
                            break;
                        case "Eternal":
                            goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "Checklist":
                            int target = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                            break;
                    }
                }
            }
        }
    }
}

/*This is where the user interacts with the program. It lets the user create goals, mark them as done, and save or load them from a file. 
It takes the logic from the goal files and makes it work with the user, making the program feel interactive. */

/*This program can save your progress the goals you’ve set and completed and load it later. This is done with the SaveGoals() and LoadGoals() methods. 
So, if you close the program and come back later, your goals are still there! This adds practical creativity, making sure your data is saved and ready when you return.*/
