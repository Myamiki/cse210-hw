// Job.cs
using System;

public class Job
{
    // Member variables for storing job information
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Method to display job information in a formatted way
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

