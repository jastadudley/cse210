using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = GetUserName();
        int numberSquared = SquareNumber();

        GiveSquaredNumber ( userName,numberSquared);

    }

    static void DisplayWelcome()
    {
      Console.WriteLine("Welcome to the program!");  
    }
    
    static string GetUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }
    
    static int SquareNumber()
    {
        Console.WriteLine("What is your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number * number;
    }

    static void GiveSquaredNumber(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
    }

}