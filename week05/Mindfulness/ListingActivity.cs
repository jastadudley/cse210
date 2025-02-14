using System;
using System.Collections.Generic;
using System.Threading;
namespace Mindfulness
{
    private class ListingActivity : Activity
    {
        private List<string> prompts = new List<string>()
        {
            "If tomorrow you did not wake up to have another average day what would you most miss about mundane life?",
            "List all the people that make up your found family?",
            "List your favortie things about yourself?",
            "What are 10 things you are greatful for today?"
        };
        public ListingActivity()
        : base ("ListeningActivity","This Activity will help you slow down and listen.", 5 )
        {}
        public void RunListeningActivity()
        {
            DisplayStartingMessage();
            Random rand = new Random();
            int secondsElapsed = 0;
            string chosenPrompt = prompts[rand.Next(prompts.Count)];
            Console.WriteLine($"Promt: {chosenPrompt}");
            PauseAnnimation();
            secondsElapsed += 5;
            List<string> response  = new List<string>();

            while(secondsElapsed < GetDuration())
            {
                Console.WriteLine("What else? ");
                string responce = Console.ReadLine();
                responses.Add(responce);
                secondsElapsed =+ 5;
            }
            Console.WriteLine($"You have listed {response.Count} intems!");
        }
    }









}

