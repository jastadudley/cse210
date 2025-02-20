namespace ExerciseTracking 
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, int minutes, int laps)
        :base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetSpeed()
        {
            return(GetDistance()/_minutes)*60;
        }

        public override double GetPace()
        {
            return _minutes / GetDistance();
        }

        public override double GetDistance()
        {
            return(_laps*50/0.62);
        }

        public string GetSummary()
        {
            return _date + " Swimming (" + _minutes + "min) - Distance " + GetDistance().ToString("0.00") + 
            " km, speed: " + GetSpeed().ToString("0.00") + "kph, Pace: " + GetPace().ToString("0.00") + "min/km";
        }
    }
}
