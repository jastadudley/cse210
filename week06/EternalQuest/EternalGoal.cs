using System;
namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points)
        :base(name, points, false)
        {
        }

        public override string GetDetailsString()
        {
            return $"[ {(IsComplete() ? "X" : " ")} ] {GetName()} ({GetPoints()} pts)";
        }

        public override void RecordEvent()
        {
            Console.WriteLine($"You gained {GetPoints()} points for {GetName()}!");
        }
    }
} 