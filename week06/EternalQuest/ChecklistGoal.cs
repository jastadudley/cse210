using System;
namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _timesCompleated;
        private int _target;
        private int _bonusPoints;

        public ChecklistGoal(string name, int points, int target, int bonusPoints)
        :base(name, points, false)
        {
            _ame = name;
            _points = points;
            _target = target;
            _bonusPoints = bonusPoints;
        }

        override string GetDetailsString()
        {
            return $"[ {(IsComplete() ? "X" : " ")} ] {GetName()} ({GetPoints()} pts)-- Compleated {_timesCompleated} / {_target} times";
        }



        override string RecordEvent()
        {

        }






    }



    
}