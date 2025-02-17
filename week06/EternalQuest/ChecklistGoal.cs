using System;
namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _timesCompleted;
        private int _target;
        private int _bonusPoints;

        public ChecklistGoal(string name, int points, int target, int bonusPoints)
        :base(name, points, false)
        {
            _timesCompleted = 0;
            _target = target;
            _bonusPoints = bonusPoints;
        }

        public override string GetDetailsString()
        {
            return $"[ {(IsComplete() ? "X" : " ")} ] {GetName()} ({GetPoints()} pts) -- Completed {_timesCompleted}/{_target} times";
        }

        public override void RecordEvent()
        {
            //DONT FORGET ME!! >:(
        }
    }
}