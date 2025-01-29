using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Melaleuca";
        job1._jobTitle = "Quality Assurance Engineer";
        job1._startYear = 2021;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Emery Telcom";
        job2._startYear = 2020;
        job2._jobTitle = "Network Engineer";
        job2._endYear = 2021;

        Resume resume = new Resume();
        resume._name = "Jason Gibson";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}