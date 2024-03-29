// Implimentation of the circle class

public class CircleShape: Shape
{
    private double _radius;

    public CircleShape(string color, double radius): base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}