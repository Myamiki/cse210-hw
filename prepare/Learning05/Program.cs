using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment FirstAssignment = new Assignment("Nicky Tanya", "Statistics");
        Console.WriteLine(FirstAssignment.GetSummary());

        // Now create the derived class assignments
        MathAssignment SecAssignment = new MathAssignment("Mikayla Sithole", "Equations", "9.0", "18-19");
        Console.WriteLine(SecAssignment.GetSummary());
        Console.WriteLine(SecAssignment.GetHomeworkList());

        WritingAssignment ThirdAssignment = new WritingAssignment("Mya Sithole", "English", "Verbs");
        Console.WriteLine(ThirdAssignment.GetSummary());
        Console.WriteLine(ThirdAssignment.GetWritingInformation());
    }
}
