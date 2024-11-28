using System;

public class Resume
{
    // Name of the person
public string _name;
     //the list of jobs
    public List<Job> _jobs = new List<Job>(); 

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            // the Display method of the Job class
            job.Display(); 
        }
    }

}