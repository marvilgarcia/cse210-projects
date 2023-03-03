using System;

class Program
{
    static void Main(string[] args)
    {
        //** Create a instance for the Job class
        Job job1 = new Job();
        //**Set the member variables using the dot notation
        job1._jobTitle ="Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2010;
        job1._endYear = 2016;
        //Verify that you can display the company of this job on the screen, again using the dot notation to access the member variable.
        job1.DisplayDetails();

        //**Create a second job, set its variables, display this company on the screen as well.

        Job job2 = new Job();
        job2._jobTitle = "Account Manager";
        job2._company = "Apple";
        job2._startYear = 2017;
        job2._endYear = 2020;
        job2.DisplayDetails();


        //Add the end of the Main function, create a new instance of the Resume class.
        Resume resume = new Resume();
        resume._name ="Marvil Garcia";
        //Add the two jobs you created earlier, to the list of jobs in the resume object.

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        //Verify that you can access and display the first job title using dot notation
        resume.DisplayDetails();





    }
}