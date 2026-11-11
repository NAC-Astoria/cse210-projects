using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Blue", 4);
        Rectangle r1 = new Rectangle("Red", 2, 4);
        Circle c1 = new Circle("Yellow", 2);

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(s1);
        shapeList.Add(r1);
        shapeList.Add(c1);

        foreach (Shape s in shapeList)
        {
            Console.WriteLine($"Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()}");
            Console.WriteLine();
        }
    }
}