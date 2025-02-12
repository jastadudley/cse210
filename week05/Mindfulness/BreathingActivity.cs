using System;
using System.Threading;

namespace Mindfulness;
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        : base ("This Breathing Activity.", "This activity will help you relax by guiding you through slow breathing. Clear your mind match your breathing to the ques.", 0)

        {
        }

        public void RunBreathingActivity()
        {
            DisplayStartingMessage();

            int secondsElasped = 0;
            while (secondsElasped < duration)
            {
                Console.WriteLine("Breath in...");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();

                Console.WriteLine("...and breath out.");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();

                secondsElasped += 6;
            }
            DisplayEndingMessage();
        }
    }
}