// Resume.cs
using System;
using System.Collections.Generic;

public class Resume
{
    // Member variable for storing the person's name
    public string _name;
    
    // Member variable for storing a list of Job objects
    public List<Job> _jobs = new List<Job>();

    // Method to display the resume details
    public void Display()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Jobs:");
        
        // Loop through each job and call its Display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}