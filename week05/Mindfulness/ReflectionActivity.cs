using System;
using System.Collections.Generic;
using System.Threading;

namespace Mindfulness
{
    public class ReflectionActivity : Activity
    {
        privite List<string> prompts = new List<string>
        {


        };
        private list<string> questions = new list <string>
        {

        };

        public ReflectionActivity()
            base : ("Refelction Activity", "blah blah")
        {

        }

        public void RunReflectionActivity()
        {
            DisplayStartingMessage;

            Random go = new Random();
            string chosenPrompt = prompts[go.Next(prompts.count)];
            Console.WriteLine($"Prompt: {chosenPrompt}");

            int secondsElasped = 0;
            while (secondsElasped< GetDuration())
            {
                string question = questions
            }
        }
    }

    














}