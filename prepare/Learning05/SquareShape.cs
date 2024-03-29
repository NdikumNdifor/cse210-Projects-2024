// Implimentation of the SquareShape class

public class SquareShape: Shape
{
    private double _side;

    public SquareShape(string color, double side): base(color)
    {
        _side = side;
    }
    /*
    public double GetSide()
    {
        return _side;
    }
    public void SetSide()
    {
        _side = side;
    }
        */

    // Notice the use of overide keyword here to overide the abstract overide result    
    public override double GetArea()
    {
        return _side * _side;
    }


}