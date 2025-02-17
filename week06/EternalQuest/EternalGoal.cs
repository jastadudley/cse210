using System;
namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        private int _timesCompleted;
        public EternalGoal(string name, int points, int timesCompleted=0)
        :base(name, points, false)
        {
            _timesCompleted = timesCompleted;
        }

        public override string GetDetailsString()
        {
            return $"[ {(IsComplete() ? "X" : " ")} ] {GetName()} ({GetPoints()} pts)--Compleated {_timesCompleted} times";
        }

        public override void RecordEvent()
        {
            _timesCompleted++;
            Console.WriteLine($"You gained {GetPoints()} points for {GetName()}!");
        }
    }
} 