using System.Diagnostics;

public class Fraction
{
    private int _numerator;
    private int _denomenator;

    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denomenator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denomenator = bottom;
    }

    public int GetTop()
    {
        return _numerator;
    }
    public void SetTop(int top)
    {
        _numerator = top;
    }

    public int GetBottom()
    {
        return _denomenator;
    }
    public void SetBottom(int bottom)
    {
        _denomenator = bottom;
    }

    public string GetFractionString()
    {
        int top = _numerator;
        int bottom = _denomenator;
        return $"{top}/{bottom}";
    }

    public double GetDecimalValue()
    {
        int top = _numerator;
        int bottom = _denomenator;
        double dec = top / bottom;
        return dec;
    }
}