using System.Data.Common;

public class Bicycle : Activity
{
    private decimal _speed;

    public Bicycle(DateTime date, decimal length, decimal speed) : base(date, length, "Bicycle")
    {
        _speed = speed;
    }

    public override decimal Speed()
    {
        return _speed;
    }
}