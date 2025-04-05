public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, decimal length, int laps) : base(date, length, "Swimming")
    {
        _laps = laps;
    }

    public override decimal Distance()
    {
        return (decimal)Math.Round(_laps * 50 / 1000 * 0.62, 2);
    }
}