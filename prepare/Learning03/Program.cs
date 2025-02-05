using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction one = new Fraction();
        Fraction six = new Fraction(6);
        Fraction fraction = new Fraction(6, 7);

        Console.WriteLine($"One over One = {one.GetFractionString()}");
        Console.WriteLine($"double of one is {one.GetDecimalValue()}");
        Console.WriteLine($"six over One = {six.GetFractionString()}");
        Console.WriteLine($"double of six is {six.GetDecimalValue()}");
        Console.WriteLine($"six over seven = {fraction.GetFractionString()}");
        Console.WriteLine($"double of 6/7 is {fraction.GetDecimalValue()}");
    }
}