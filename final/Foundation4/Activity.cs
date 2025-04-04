public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual int Distance()
    {

    }

    public virtual int Speed()
    {

    }

    public virtual int Pace()
    {

    }

    public abstract void Summary();
}