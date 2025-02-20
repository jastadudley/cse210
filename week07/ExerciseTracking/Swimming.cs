namespace ExcerciseTracing
{
    public class Swimming : Activity
    {
        private string _date;
        private int _minutes;
        private int _laps;

        public Swimming(string date, int minutes, int laps)
        :base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetSpeed()
        {
            return (GetDistance() / _minutes) * 60;
    
        }

        public override double GetPace()
        {
            return _minutes / GetDistance();
        }

        public override double GetDistance()
        {
            return (_laps * 50 / 0.62 );
        }

        public string GetSummery()
        {

        }


    }







    
}
