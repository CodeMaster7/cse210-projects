using System;

public class Job
{
    //    Create member variables in the class for each element that this class should contain.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Member function: (method) to display the job information
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}
