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
                Console.WriteLine("");
                Console.WriteLine("Please Choose an option: ");
                Console.WriteLine("");
                Console.WriteLine("1. Write a New Journal Entry");
                Console.WriteLine("2. Display Your Journal");
                Console.WriteLine("3. Save Your Journal to a File");
                Console.WriteLine("4. Load Journal From a File");
                Console.WriteLine("5. Quit");
                Console.Write(">");
                int selection = Int32.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        Entry response = Prompt.Decide();
                        if (response != null)
                        {
                            Journal.Save(response);
                        }
                        break;
                    case 2:
                        Journal.Display();
                        break;
                    case 3:
                        Journal.SaveFile();
                        break;
                    case 4:
                        Journal.Load();
                        break;
                    case 5:
                        Console.WriteLine("Do you want to save before Quitting?(Y/N): ");
                        string save = Console.ReadLine().ToLower();
                        if (save.CompareTo("y") == 0)
                        {
                            Journal.SaveFile();
                        }
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

    // "Above and Beyond: I made it so the file actually saves."
    // "I also added in better logic to decide if a new entry should go onto an existing journal, or start a new journal"
    // "Adding an option to save when you choose 'QUIT' so that you don't accidentally quit and lose your work"
}