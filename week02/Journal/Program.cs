using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display past entrys");
            Console.WriteLine("3. Save Journal to a file");
            Console.WriteLine("4. Load file to journal");
            Console.WriteLine("5. Quit");
        }
        while ( choice != "5");


    }
}