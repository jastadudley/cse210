using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display past entrys");
            Console.WriteLine("3. Save Journal to a file");
            Console.WriteLine("4. Load file to journal");
            Console.WriteLine("5. Quit");
            Console.WriteLine("--------------------------");

            choice = Console.ReadLine();

            if (choice=="1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.Write($"{prompt}");
                Console.WriteLine(">>> ");
                string responce = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(date, prompt, responce);
                journal.AddEntry(newEntry);
            }

            if (choice=="2")
            {
                Console.WriteLine("Here are your past entrys:");
                journal.DisplayAll();
                
            }

            if (choice=="3")
            {
                Console.WriteLine("Please enter your new file name: ");
                string fileName= Console.ReadLine();
                journal.SaveToFile(fileName);

                Console.WriteLine("Your journal has been saved!");
            }

            if (choice=="4")
            {
                Console.WriteLine("Please enter the filename to load: ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }



        }
        while ( choice != "5");

        Console.WriteLine("Goodbye!");
    }
}