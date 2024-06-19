using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2002;
        job1._endYear = 2013;
        
        Job job2 = new Job();
        job2._jobTitle = "IT Director";
        job2._company = "Apple";
        job2._startYear = 2014;
        job2._endYear = 2019;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Park Sunghoon";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



    }
}