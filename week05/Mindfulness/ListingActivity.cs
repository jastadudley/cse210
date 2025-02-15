using System;
using System.Collections.Generic;
using System.Threading;
namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>()
        {
            "If tomorrow you did not wake up to have another average day what would you most miss about mundane life? Prepare to list items.",
            "List all the people that make up your found family. People you could not live without. Prepare to list items.",
            "List your favortie things about yourself? Prepare to list items.",
            "What are you are greatful for today? Prepare to list items."
        };
        public ListingActivity()
        :base("ListeningActivity","This Activity will help you slow down and listen.", 10 )
        {}
        public void RunListeningActivity()
        {
            Console.WriteLine();
            DisplayStartingMessage();
            Thread.Sleep(4000);
            Random rand = new Random();
            int secondsElapsed = 0;
            string chosenPrompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine($"Promt: {chosenPrompt}");
            Console.WriteLine();
            PauseAnnimation();
            secondsElapsed += 5;
            List<string> response  = new List<string>();

            while(secondsElapsed < GetDuration())
            {
                Console.WriteLine("Type an answer and Enter when you want to stop. ");
                Console.WriteLine();
                Thread.Sleep(1000);

                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    break;
                }
                response.Add(userInput);
                secondsElapsed =+ 5;
            }
            Console.WriteLine($"You have listed a total of {response.Count} intems!");
            Console.WriteLine("There is so much to be greatful for.");
            Thread.Sleep(4000);   
        }
    }









}

