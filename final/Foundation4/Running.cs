public class Running : Activity
{
    private decimal _distance;

    public Running(DateTime date, decimal length, decimal distance) : base(date, length, "Running")
    {
        _distance = distance;
    }

    public override decimal Distance()
    {
        return _distance;
    }
}