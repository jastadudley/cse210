using System;
namespace EternalQuest
{
    public abstract class Goal
    {
        private string _goal;
        private int _points;
        private bool _isComplete;


        public Goal(string goal, int points, bool isComplete)
        {
            _goal = goal;
            _points = points;
            _isComplete = isComplete;
        }

        public string GetName()
        {
            return _goal;
        }

        public int GetPoints()
        {
            return _points;
        }

        public abstract string GetDetailsString();

        public abstract void RecordEvent();

        private bool IsComplete()
        {
            return _isComplete;
        }
    }
}