using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to Rockstar Journal!");
        static void Menu()
        {
            bool stop = false;
            while (stop == false)
            {
                Console.WriteLine("Please Choose an option: ");
                Console.WriteLine("");
                Console.WriteLine("1. Write a New Journal Entry");
                Console.WriteLine("2. Display Your Journal");
                Console.WriteLine("3. Save Your Journal to a File");
                Console.WriteLine("4. Load Journal From a File");
                Console.WriteLine("5. Quit");
            }
        }

    }
}