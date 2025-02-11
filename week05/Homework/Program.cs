using System;
namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Axel Mellado, Multipling Common Denominators");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Axel Mellado", "7.3", "3-10", "20-21");
        Console.WriteLine(mathAssignment1.GetSummary());

        WritingAssignment writingAssignment1 = new WritingAssignment("Axel Mellado", "Assesment of The Hero's Journey");
        Console.WriteLine(writingAssignment1.GetSummary()); 


    }
}