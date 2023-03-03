using System;

public class Job
{
    //Create member variables in the class for each element that this class should contain. By convention these member variables should begin with an underscore and a lowercase letter such as _jobTitle .
    public String _company;
    public String _jobTitle;
    public int _startYear;
    public int _endYear;
    
    //add a method (member function) to display the job details. This method should not have any parameters and does not need to return anything. By convention, this method should begin with a capital letter, such as Display, and if you have multiple words each word should be capitalized
    public void DisplayDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}