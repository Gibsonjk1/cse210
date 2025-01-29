using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquaredNumber(int number)
        {
            int squared = number * number;
            return squared;
        }
        static void DisplayResults(string name, int num)
        {
            Console.WriteLine($"Well hello {name}, it's a pleasure to meet you");
            Console.WriteLine($"did you know that if we squared your favorite number, it would equal {num}?");
            Console.WriteLine("Well, Goodbye!");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquaredNumber(number);
        DisplayResults(name, squaredNumber);
    }
}