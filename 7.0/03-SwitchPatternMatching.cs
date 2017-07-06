using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._7._0
{
    public class SwitchPatternMatching : IRunnable
    {
        public void Run()
        {
            ShapeMatching(new Circle(5));
            ShapeMatching(new Square(15, 10));
            ShapeMatching(new Square(5, 5));

        }

        public void ShapeMatching(Shape shape)
        {
            switch (shape)
            {
                case Circle c:                    
                    Console.WriteLine($"Circle radius is {c.Radius}");
                    break;
                case Square s when (s.Height != s.Width):
                    Console.WriteLine($"The shape is a rectangle with height: {s.Height} and width: {s.Width}");
                    break;
                case Square s:
                    Console.WriteLine($"The shape is a square with height: {s.Height} ");
                    break;
            }

        }
    }

    public interface Shape {}

    public class Circle : Shape
    {
        public Circle(int radius) => Radius = radius;
        public int Radius { get; set; }
    }

    public class Square : Shape
    {
        public Square(int height, int width)
        {
            Height = height;
            Width = width;
        }
        public int Height { get; set; }
        public int Width { get; set; }
    }


}
