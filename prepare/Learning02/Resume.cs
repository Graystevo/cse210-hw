using System;

public class Resume
{
    // Member variable persons name
    public string _name;

    // Member variable for the list of jobs
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.DisplayJobDetails();
        }
    }
}