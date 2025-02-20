namespace ExcerciseTracing
{
    public class Activity
    {
        private string _date;
        private int _minutes;
    

        public Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }
    
        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public string GetSummery()
        {
            return $"{_date} {GetType()Name} ({_minutes} min)";
        }
    }

}