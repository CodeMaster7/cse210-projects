using System;

public class Resume
{
    // create a member variable for the person's name
    public string _name;

    // create a member variable for the list of jobs
    public List<Job> _jobs = new List<Job>();

    // Member function: (method) to display the resume information
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Iterate through the list of jobs and display each one
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
