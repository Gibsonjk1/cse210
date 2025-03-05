public class Circle : Shape
{
    private int _radius;
    public Circle(string color, int radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double square = Math.Pow(_radius, 2);
        return 3.14159 * square;
    }
}