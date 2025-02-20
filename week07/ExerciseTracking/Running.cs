namespace ExcerciseTracing
{
    public class Running : Activity
    {
        private string _date;
        private int _minutes;
        private double _distance;

        public Running(string date, int minutes, double distance)
        :base()
        {
            _date = date;
            _minutes = minutes;
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

        public string GetSummery()
        {

        }

    }









    
}