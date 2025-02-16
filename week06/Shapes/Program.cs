using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");


        private List<Shapes> shapes = new List<Shapes>();


        shapes.Add(new Square(5,"Red"));
        shapes.Add(new Square(9,"Pink"));
        shapes.Add(new Square(2, "Blue"));



        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Color:{shape.Getcolor()}   Area:{shape.GetArea()}");


        }
    }
}