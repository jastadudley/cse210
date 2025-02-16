using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Shapes Project.");

            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square(5,"Red"));
            shapes.Add(new Square(9,"Pink"));
            shapes.Add(new Square(2, "Purple"));

            shapes.Add(new Rectangle(7,3,"Pink"));
            shapes.Add(new Rectangle(8,12,"White"));
            shapes.Add(new Rectangle(7,3,"Red"));

            shapes.Add(new Circle(3,"White"));
            shapes.Add(new Circle(6,"Pink"));
            shapes.Add(new Circle(8,"Red"));



            foreach(Shape shape in shapes)
            {
                Console.WriteLine($"Color: {shape.GetColor()}  Area: {shape.GetArea()}");
            }

        

        }
    }    
}