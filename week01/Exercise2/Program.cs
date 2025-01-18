using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What score did you recive on the test?");
        string valueInText = Console.ReadLine();
        int grade = int.Parse(valueInText);
        grade =int.Parse(valueInText);
        string letter = "";
        if (grade >= 90)
        {
            letter= "A";
        }
        else if (grade >= 80)
        {
            letter= "B";
        }
        else if (grade >= 70)
        {
            letter= "C";;
        }
        else if (grade >= 60)
        {
            letter= "D";
        }
        else (grade <= 60)
        {
            letter= "F";
        }
    
        Console.WriteLine($"Your letter grade is {letter}.")
        if (grade>= 70)
        {
            Console.WriteLine("congradulations! You passed!");
        }
        else
        {
            Console.WriteLine("Im sorry, you did not pass. Study hard and try again!");
        }
    }
}