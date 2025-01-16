using System;

class Program
{
    static void Main(string[] args)
    {
        bool again = true;

        while (again != false)
        {
            Random random = new Random();
            int magic = random.Next(1, 10);
            Console.WriteLine("Guess the magic number? ");
            bool guessed = false;


            do
            {
                Console.WriteLine("What is your guess? ");
                int guess = int.Parse(Console.ReadLine());

                if (guess < magic)
                {
                    Console.WriteLine("Higher... ");
                }
                else if (guess > magic)
                {
                    Console.WriteLine("Lower... ");
                }
                else if (guess == magic)
                {
                    Console.WriteLine("You Guessed It!");
                    guessed = true;
                }
            } while (guessed != true);

            Console.WriteLine("Want to play again? (Y/N)");
            string playAgain = Console.ReadLine();
            if (playAgain.ToLower() == "n")
            {
                again = false;
            }

        }
    }
}