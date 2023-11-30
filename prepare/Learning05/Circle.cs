public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }
    //I forgot a step and forgot that pi was built in
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}