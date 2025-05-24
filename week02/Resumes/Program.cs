using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Job instance
        Job job1 = new Job();
        // set the member variables
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // create a second job instance
        Job job2 = new Job();
        // set the member variables
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Comment out these lines to avoid displaying jobs before the resume
        // job1.Display();
        // job2.Display();

        // create a new Resume instance
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // add the job instances to the list of jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}