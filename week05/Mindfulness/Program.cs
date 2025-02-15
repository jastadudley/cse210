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

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.RunBreathingActivity();
                break;

                case "2":
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.RunReflectionActivity();
                break;

                case "3":
                ListingActivity listing = new ListingActivity();
                listing.RunListeningActivity();
                break;

                case "4":
                running = false;
                Console.WriteLine("Goodbye!");
                break;

                default:
                    break;
            }
        }
    }
}