using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("red", 3.0);
        Rectangle r1 = new Rectangle("blue", 2.0, 4.0);
        Circle c1 = new Circle("green", 1.0);
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);
        
        foreach (Shape item in shapes)
        {
            string color = item.GetColor();
            double area = item.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
        
    }
}