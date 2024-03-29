using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        List<Shape> shapes = new List<Shape>();

        SquareShape s1 = new SquareShape("Red", 3);
        shapes.Add(s1);

        RectangleShape r1 = new RectangleShape("Blue", 4, 5);
        shapes.Add(r1);

        CircleShape c1 = new CircleShape("Green", 6);
        shapes.Add(c1);

        Console.WriteLine();
        foreach(Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();


            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
        Console.WriteLine();


    }
}