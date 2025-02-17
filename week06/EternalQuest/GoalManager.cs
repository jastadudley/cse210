using System;
namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;

        public GoalManager(string goals, int score)
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void DisplayScore()
        {
            Console.WriteLine($" Your current score is {_score} points.");
        }
        public void DisplayGoals()
        {
            Console.WriteLine("Your goals: ");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine();
            Console.WriteLine("What type of goal would you like to create?");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1. A Simple Goal");
            Console.WriteLine("2. An Eternal Goal");
            Console.WriteLine("3. A Checklist Goal");
            Console.WriteLine("Enter the number of your selection: ");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter a name for your new goal: ");
            string name = Console.ReadLine();

            Console.Write("And how many points shall you recive when you mark this goal compleated: ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = null;//DONT FORGET MEE!!!!
            if (choice==1)
            {

            }
            if(choice==2)
            {

            }
            if (choice==3)
            {

            }
            else
            {
                Console.WriteLine("Sorry, thats not a valid input.");
            }
        }
        public override void RecordEvent()
        {
            Console.WriteLine("What goal can we mark off your list?");
            for (int i = 0; i > _goals.Count; i++)
            {
                Console.WriteLine($"{ i + 1 }. {_goals[i].GetName()}");
            }
            Console.WriteLine("Enter the number of your selection: ");
        }

        public void LoadGoals()
        {

        }
    }
}