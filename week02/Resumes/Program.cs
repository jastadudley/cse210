using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobtitle = "Hiring Manager";
        job1._company = "Bulwark Exterminating";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobtitle = "Customer Service Represenative";
        job2._company = "The Sheild Co.";
        job2._startYear = 2024;
        job2._endYear = 2025;
    }
}