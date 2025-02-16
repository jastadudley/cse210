using System;
namespace Shapes
{
    public class Rectangle : Shape
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width, string color)
        :base(color)
        {
            _height = height;
            _width = width;
        }

        public override double GetArea()
        {
            return _height * _width;
        }
    }
}