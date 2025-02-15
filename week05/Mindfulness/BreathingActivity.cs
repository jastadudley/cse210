using System;
using System.Threading;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        : base ("This Breathing Activity.", "This activity will help you relax by guiding you through slow breathing. Clear your mind. For best results breath in for 4 counts, hold for 3, out for 5 counts.", 36)

        {
        }

        public void RunBreathingActivity()
        {
            Console.WriteLine();
            DisplayStartingMessage();
            Thread.Sleep(9000);

            int secondsElasped = 0;
            while (secondsElasped < GetDuration())
            {
                Console.WriteLine("Breath in...");
                for (int i = 4; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Thread.Sleep(800);

                Console.WriteLine("...and hold...");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Thread.Sleep(1000);

                Console.WriteLine("...now breath out...");
                for (int i = 5; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                Thread.Sleep(1000);

                secondsElasped += 6;
            }
            DisplayEndingMessage();
        }
    }
}