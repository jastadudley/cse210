using System;
using System.Media;
namespace EternalQuest
{
    class Program
    {
        public static void PlayChime()//My creative addition! Only on Windows but a fun new thing I learned :)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Beep(1000, 500);
                    Thread.Sleep(150);
                }
            }
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Hello World! This is the EternalQuest Project.");
            GoalManager run = new GoalManager();

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please make a selection from our menu:");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("1. Greate A New Goal");
                Console.WriteLine("2. List Current Goals");
                Console.WriteLine("3. Mark A Goal As Accomplished");
                Console.WriteLine("4. Veiw Current Score");
                Console.WriteLine("5. Load Goals From File");
                Console.WriteLine("6. To Exit the program");
                Console.WriteLine();

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    run.CreateGoal();
                }
                else if (choice == 2)
                {
                    run.DisplayGoals();
                }
                else if (choice == 3)
                {
                    run.RecordEvent();
                    run.CheckLevelUp();//My creative addition!
                }
                else if (choice == 4)
                {
                    run.DisplayScore();
                }
                else if (choice == 5)
                {
                    run.LoadGoals();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Good luck on your goals!");
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, thats not a valid input.");
                }
            }
        }
    }
}