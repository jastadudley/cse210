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
            return $"[ {(IsComplete() ? "X" : " ")} ] {GetName()} ({GetPoints()} pts)";
        }

        public override void RecordEvent()
        {
            SetComplete();
        }
    }
}