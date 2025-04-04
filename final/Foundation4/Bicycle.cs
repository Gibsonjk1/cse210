using System.Data.Common;

public class Bicycle : Activity
{
    private int _speed;

    public Bicycle(DateTime date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    public override int Distance()
    {

    }

    public override int Speed()
    {

    }

    public override int Pace()
    {

    }

    public override void Summary()
    {
        Console.Write(_date.ToString("dd:MMM:yyyy"));
    }
}