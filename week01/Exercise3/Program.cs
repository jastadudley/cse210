using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your number?");
        string userInput = Console.ReadLine();
        int number =int.Parse(userInput);

        string response;
        int parsedResponse;
        do
        {
            Console.WriteLine("What is your guess?");
            response = Console.ReadLine();
            parsedResponse = int.Parse(response);

                if (parsedResponse > number)
                {
                    Console.WriteLine("Lower");
                }    
                else if (parsedResponse < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You Guessed it!");
                }

        } while (parsedResponse != number);
    }
}