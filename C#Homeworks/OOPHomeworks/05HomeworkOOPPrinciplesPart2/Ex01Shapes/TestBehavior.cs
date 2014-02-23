using System;
using System.Linq;

public class TestBehavior
{
    static void Main()
    {
        Shape[] fewShapes = { new Triangle(3, 4), new Rectangle(4, 5), new Circle(6, 6) };

        foreach (var shape in fewShapes)
        {
            Console.WriteLine(shape.CalculateSurface());
        }
    }
}

