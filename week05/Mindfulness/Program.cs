using System;
using Mindfulness;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Activity testActivity = new Activity("this is a test","this is the test discription.", 5);

        testActivity.DisplayStartingMessage();
        testActivity.PauseAnnimation();
        testActivity.DisplayEndingMessage();
    }
}