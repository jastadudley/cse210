using System;
namespace Shapes
{
    public class Rectangle : Shape
    {
        private double _height;
        private double _width;

        public Rectangle(double width, double height, string color)
        :base(color)
        {
            _width = width;
            _height = height;
        }

        public override double GetArea()
        {
            return _height * _width;
        }
    }
}