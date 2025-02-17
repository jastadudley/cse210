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
                newGoal = new SimpleGoal(name, points);
            }
            if(choice==2)
            {
                newGoal = new EternalGoal(name, points);
            }
            if (choice==3)
            {
                Console.Write("For a Checklist Goal specifically, how many goals will you be creating: ");
                int target = int.Parse(Console.ReadLine());

                Console.WriteLine("And how many bonus points will you recive when you mark the Checklist Goal as compleatly done: ");
                int bonusPoints = int.Parse(Console.ReadLine());


                newGoal = new ChecklistGoal(name, points, target, bonusPoints);
            }
            if(newGoal != null)
            {
                _goals.Add(newGoal);
                Console.WriteLine("Your goal has been added sucessfully! Time to get to work.");
            }
            else
            {
                Console.WriteLine("Sorry, thats not a valid input.");
            }
        }
        public void RecordEvent()
        {
            Console.WriteLine("What goal can we mark off your list?");
            for (int i = 0; i > _goals.Count; i++)
            {
                Console.WriteLine($"{ i + 1 }. {_goals[i].GetName()}");
            }
            Console.WriteLine("Enter the number of the goal you compleated: ");
            int index = int.Parse(Console.ReadLine())- 1;

            if(index >= 0 && index < _goals.Count)
            {
                _goals[index].RecordEvent();
                _score += _goals[index].GetPoints();
                Console.WriteLine($"Goal recorded! Your total score is now: {_score}");
            }
            else
            {
                Console.WriteLine("Sorry, thats not a valid input.");
            }
        }

        public void LoadGoals()
        {
            Console.WriteLine("Please enter the filename that you would like to load from: ");
            string fielname = Console.ReadLine();

            if(File.Exists(fielname))
            {
                string[] lines = File.ReadAllLines(fielname);
                _goals.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    string type = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);

                    if (type == "SimpleGoal")
                    {
                        _goals.Add(new SimpleGoal(name, points));

                    }
                    else if (type == "EternalGoal")
                    {
                        _goals.Add(new EternalGoal(name, points));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        int target = int.Parse(parts[3]);
                        int bonusPoints = int.Parse(parts[4]);
                        int timesCompleted = int.Parse(parts[5]);
                        _goals.Add(new ChecklistGoal(name, points, target, bonusPoints));
                    }
                }

                Console.WriteLine("Your goals have uploaded sucessfully!");
            }
            else 
            {
                Console.WriteLine("We're sorr, that filename was not found.");

            }
        }
    }
}