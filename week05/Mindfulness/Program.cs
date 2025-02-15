using System;
using Mindfulness;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool running = true;
        
        while (running)
        {
            Console.WriteLine("Please make a selection from the menu:");
            Console.WriteLine("1.Breathing Activity");
            Console.WriteLine("2.Reflection Activity");
            Console.WriteLine("3.Listing Activity");
            Console.WriteLine("Or enter 4 to Quit");

            string choice = ConsoleReadLine();


            choice
            {
                "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.RunBreathingActivity();

                "2":
                ReflectionActivity reflection = new ReflectionActivity();


                "3":
                ListingActivity listing = ListingActivity();

                "4":
                running = false;
                Consol.WriteLine("Goodbye!");

            }
        }
    }
}