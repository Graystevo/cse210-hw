using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 1911;
        job1._endYear = 1955;
        
        // Console.WriteLine("job1 created");

        Job job2 = new Job();
        job2._jobTitle = "Software tester";
        job2._company = "Apple";
        job2._startYear = 1911;
        job2._endYear = 1955;

        // Console.WriteLine("job2 created");

        // replace with Display call.
        Resume resume1 = new Resume();
        resume1._name = "John test";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}