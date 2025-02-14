using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine();

        static void Menu()
        {
            Console.WriteLine("What Scripture would you like to memorize? (Press Enter for a Stock Scripture)");
            Console.Write("Book: ");
            string book = Console.ReadLine();

            if (book == "")
            {
                Scripture scripture = new Scripture();
                scripture.Display();
            }
        }
        Menu();

    }
}