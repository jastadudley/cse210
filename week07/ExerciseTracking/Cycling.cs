namespace ExcerciseTracing
{
    public class Cycling() : Activity
    {
        private string _date;
        private int _minutes;
        private int _speed;

        public Cycling(string date, int minutes, int speed)
        :base()
        {
            _date = date;
            _minutes = minutes;
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

        public string GetSummery()
        {
            
        }


    }







    
}