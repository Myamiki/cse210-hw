using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private string filePath = "goals.txt";

    public void Run()
    {
        LoadGoals();
        while (true)
        {
            Console.WriteLine("\nGoal Manager");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. List Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateSimpleGoal();
                    break;
                case "2":
                    CreateEternalGoal();
                    break;
                case "3":
                    CreateChecklistGoal();
                    break;
                case "4":
                    ListGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    Console.WriteLine("Exiting Goal Manager.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void CreateSimpleGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());
        goals.Add(new SimpleGoal(name, description, points));
    }

    private void CreateEternalGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());
        goals.Add(new EternalGoal(name, description, points));
    }

    private void CreateChecklistGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for this goal: ");
        int points = int.Parse(Console.ReadLine());
        Console.Write("Enter target number for checklist goal: ");
        int target = int.Parse(Console.ReadLine());
        Console.Write("Enter bonus points for completing checklist goal: ");
        int bonus = int.Parse(Console.ReadLine());
        goals.Add(new ChecklistGoal(name, description, points, target, bonus));
    }

    private void ListGoals()
    {
        Console.WriteLine("\nGoals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void RecordEvent()
    {
        Console.Write("Enter the name of the goal to record event: ");
        string goalName = Console.ReadLine();
        Goal goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            Console.WriteLine($"Event recorded for goal: {goal.Name}");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            foreach (var goal in goals)
            {
                sw.WriteLine(goal.ToFileString());
            }
        }
    }

    private void LoadGoals()
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
