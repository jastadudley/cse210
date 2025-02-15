using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public class ReflectionActivity : Activity
    {
        private List<string> prompts = new List <string>
        {
            "Think of a time when you were afrade to do the right thing.",
            "Think of a time when you had to overcome something really difficult.",
            "Think of a time when you helpped someone in need.",
            "Think of a time when you saw someone being truly selfles."
        };

        private List<string> questions = new List<string>
        {
            "What about this experience made it memorable?",
            "What did you learn about yourself through this experience?",
            "How did you feel once it was compleate?",
            "How can this experience make you a better person for tomorrow?",

        };
        public ReflectionActivity()
           :base( "Reflection activity.", 
            "This activity will help you reflect on a time when you had to preactice stregnth or resilience.",
            5 )
        {}
        public void RunReflectionActivity()
        {
            DisplayStartingMessage();

            Random go = new Random();
            string chosenPrompt = prompts[go.Next(prompts.Count)];
            Console.WriteLine($"Prompt: {chosenPrompt}");

            int secondsElasped = -5;
            while (secondsElasped < GetDuration())
            {
                string question = questions[go.Next(questions.Count)];
                Console.WriteLine(question);
                PauseAnnimation();
                secondsElasped += 5;
            }
            DisplayEndingMessage();
        }
    }
}