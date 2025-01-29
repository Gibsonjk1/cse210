using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type '0' when you are finished.");
        int number = 1;

        while (number != 0)
        {
            Console.WriteLine("Enter a Number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                break;
            }
            else
            {
                numList.Add(number);
            }
        }
        int sum = numList.Sum();
        double avg = numList.Average();
        int max = numList.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The highest number is: {max}");

    }
}