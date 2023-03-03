using System;

public class Resume
{
    //Create the member variable for the person's name.
    public String _name;
    //Create the member variable for the list of Jobs. 
    public  List<Job>_jobs = new List<Job>();

    //**add a method to display its details. This method should not have any parameters and should not return anything. In the method body, you should display the person's name and then iterate through each Job instance in the list of jobs and display them.**//
    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the DisplayDetails method on each job
            job.DisplayDetails();
        }
    }

}