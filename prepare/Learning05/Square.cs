public class Square : Shape
{
    private int _side;
    public Square(string color, int side) : base(color)
    {

    }

    public override double GetArea()
    {
        return _side * _side;
    }
}