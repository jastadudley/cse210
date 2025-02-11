namespace Mindfulness;
{
    public class BreathingActivity : Activity
    {
        public class BreathingActivity()
        : base ("BreathingActivity")

        public void BreathingActivity(int duration);
        {
            DisplayStartingMessage();

            int secondsElasped = 0;
            While (secondsElasped < duration)
            {
                Console.WriteLine("Breath in...");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                Console.WriteLine;

                Console.WriteLine("...and breath out.");
                for (int i = 3; i > 0; i--)
                {
                    Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
            }
        }
    }


}