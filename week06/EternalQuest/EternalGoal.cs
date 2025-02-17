using System;
namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points)
        :base(goal, points, false)
        {
            
        }

        public override string GetDetailsString()
        {
            Console.WriteLine($"You gained {GetPoints()} points for {GetPoints()}!");
        }
        

        public override void RecordEvent()
        {

        }



    }



    
} 