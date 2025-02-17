using System;
namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string goal, int points)
        :base(goal, points, false)
        {
        }

        public override string GetDetailsString()
        {
            
        }


        public bool RecordEvent()
        {
            return isComplete = true;
        }

    }



    
}