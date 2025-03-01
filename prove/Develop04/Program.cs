using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        void Menu()
        {
            bool finished = false;
            Console.WriteLine("Welcome to the Mindfulness App!");
            while (finished == false)
            {
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1. The Breathing Activity");
                Console.WriteLine("2. The Reflection Activity");
                Console.WriteLine("3. The Listing Activity");
                Console.Write(">");
                int choice = int.Parse(Console.ReadLine());

                string activityName;
                switch (choice)
                {
                    case 1:
                        activityName = "Breathing";
                        Breathing breathing = new Breathing(activityName);
                        breathing.BreathingActivity();
                        break;
                    case 2:
                        activityName = "Reflection";

                        Reflection reflection = new Reflection(activityName);
                        reflection.ReflectionActivity();
                        break;
                    case 3:
                        activityName = "Listing";

                        Listing listing = new Listing(activityName);
                        listing.ListingActivity();
                        break;

                }
                Console.WriteLine("Do you want to do another activity?(Y/N)");
                string continues = Console.ReadLine();
                if (continues.ToLower() != "y")
                {
                    finished = true;
                }
            }
        }

        Menu();

    }

}
