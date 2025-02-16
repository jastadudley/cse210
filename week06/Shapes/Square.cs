using System;

namespace Shapes
{
    public class Square : Shape
    {
        private string _side;

        public Square(string side)
        :base(color)
        {
            _side = side;
        }


        override GetAre()
        {
            return _side * _side;
        }






    }






}