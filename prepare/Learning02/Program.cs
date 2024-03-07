using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Job job1 = new Job();
        job1._title = "Software-Engineer";
        job1._startYear = "2020";
        job1._endYear = "2024";
        job1._company = "MyCompany1";

        Job job2 = new Job();
        job2._title = "Petroleum Engineer";
        job2._startYear = "1990";
        job2._endYear = "2010";
        job2._company = "Chevron2";

        Resume resume = new Resume();
        resume._firstName = "Ndikum";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResume();
        Console.WriteLine();

    }
}