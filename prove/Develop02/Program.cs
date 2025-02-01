using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to Rockstar Journal!");
        static void Menu()
        {
            bool stop = false;
            Prompt prompt = new Prompt();
            Journal journal = new Journal();

            while (stop == false)
            {
                Console.WriteLine("Please Choose an option: ");
                Console.WriteLine("");
                Console.WriteLine("1. Write a New Journal Entry");
                Console.WriteLine("2. Display Your Journal");
                Console.WriteLine("3. Save Your Journal to a File");
                Console.WriteLine("4. Load Journal From a File");
                Console.WriteLine("5. Quit");

                int selection = Int32.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        string[] response = prompt.Display();
                        journal.Save(response);
                        break;
                    case 2:
                        journal.Display();
                        break;
                    case 3:
                        journal.SaveFile();
                        break;
                    case 4:
                        journal.Load();
                        break;
                    case 5:
                        Console.WriteLine("Goodbye...");
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a number, 1-5: ");
                        stop = false;
                        break;
                }
            }


        }
        Menu();

    }
}