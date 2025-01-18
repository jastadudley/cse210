using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        int parsedAddition;

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        List<int>numbers = new List<int>();

        do
        {
            Console.WriteLine("Enter a number: ");
            userInput = Console.ReadLine();
            parsedAddition = int.Parse(userInput);

            if (parsedAddition != 0)
                {
                    numbers.Add(parsedAddition);

                } 
        }while (parsedAddition != 0 );

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of your numbers is {sum}.");

        double average;
        average = (double)sum/numbers.Count;
        Console.WriteLine($"The average of your numbers is {average}.");

        int max = numbers [0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max= number;
            }
        }
        Console.WriteLine($"The largest of your numbers is {max}.");
    }  
}