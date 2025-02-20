namespace ExcerciseTracing
{
    public class Cycling() : Activity
    {
        private string _date;
        private int _minutes;
        private int _speed;

        public Cycling(string _date, int minutes, int speed)
        :base(date, minutes)
        {
            _speed = speed;
        }

        public override double GetDistance()
        {
            return _speed * (_minutes *60 );
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            return (60 / _speed);        
            }

        public string GetSummary()
        {
            return _date + "Cycling (" + _minutes + "min) - Distance: " + GetDistance().ToString("0.00") + 
            "miles, speed: " + GetSpeed().ToString("0.00") + " mph, Pace: " + GetPace().ToString("0.00") + "min/miles";
        }
    }







    
}