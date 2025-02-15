using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine();

        static void Menu()
        {
            string book;
            int chapter;
            int firstVerse;
            int lastVerse;
            Scripture scripture;

            Console.WriteLine("What Scripture would you like to memorize? (Press Enter for a Stock Scripture)");
            Console.Write("Book(Example: '2 Nephi'): ");
            book = Console.ReadLine();

            if (book == "")
            {
                scripture = new Scripture();
            }
            else
            {
                Console.Write("Chapter: ");
                chapter = int.Parse(Console.ReadLine());
                Console.Write("FirstVerse: ");
                firstVerse = int.Parse(Console.ReadLine());
                Console.Write("Last Verse: ");
                lastVerse = int.Parse(Console.ReadLine());
                if (firstVerse == lastVerse)
                {
                    lastVerse = 0;
                }
                scripture = new Scripture(book, chapter, firstVerse, lastVerse);
            }

            while (scripture._randoms.Count < scripture._words.Count)
            {
                scripture.Display();
                Console.ReadKey();
                scripture.RandomBlank();
            }
            scripture.Display();
            Console.ReadKey();

        }
        Menu();

    }
}