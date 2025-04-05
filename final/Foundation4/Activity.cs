public abstract class Activity
{
    protected DateTime _date;
    protected decimal _length;
    protected string _activityType;

    public Activity(DateTime date, decimal length, string activityType)
    {
        _date = date;
        _length = length;
        _activityType = activityType;
    }

    public virtual decimal Distance()
    {
        return Math.Round(_length / 60m * Speed(), 2);
    }

    public virtual decimal Speed()
    {
        return Math.Round(Distance() / _length * 60, 2);
    }

    public virtual decimal Pace()
    {
        return Math.Round(60 / Speed(), 2);
    }

    public void Summary()
    {
        Console.WriteLine();
        Console.Write(_date.ToString("dd MMM yyyy"));
        Console.Write($" {_activityType} ");
        Console.Write($"({_length} min)- ");
        Console.Write($"Distance {Distance()} miles, ");
        Console.Write($"Speed {Speed()} mph, ");
        Console.Write($"Pace: {Pace()} min per mile");
        Console.WriteLine();

        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }
}