using System;
/*
public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}
*/
public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();
    //This is so that there is a new "list" of custom "Job" data types
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach( Job job in _jobs)
        {
            job.Display();
        }
    }
}