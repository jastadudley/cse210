namespace ExerciseTracking 
{
    public class Running : Activity
    {
        private string _date;
        private int _minutes;
        private double _distance;

        public Running(string date, int minutes, double distance)
        :base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return ( _distance / _minutes * 60) ;
        }

        public override double GetPace()
        {
           return ( _minutes / _distance ) ;
        }
        public string GetSummary()
        {
            return _date + "Running (" + _minutes + "min) - Distance: " + GetDistance().ToString("0.00") + 
            "miles, speed: " + GetSpeed().ToString("0.00") + " mph, Pace: " + GetPace().ToString("0.00") + "min/miles";
        }
    }
}