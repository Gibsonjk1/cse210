using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradeStr = Console.ReadLine();
        int grade = int.Parse(gradeStr);
        string letter = "F";
        string message = "Congratulations, You've Passed the Class";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
            message = "Better Luck Next Time!";
        }
        else
        {
            letter = "F";
            message = "Try Again, You Can Do It!";
        }

        Console.WriteLine($"Your Grade is a {letter}. {message}");
    }
}