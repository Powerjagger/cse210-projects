using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int userGuess;

        do
        {
            Console.Write("Enter your guess: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess == magicNumber)
            {
                Console.WriteLine("Congratulations! You guessed it right.");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Try guessing higher next time.");
            }
            else
            {
                Console.WriteLine("Try guessing lower next time.");
            }

        } while (userGuess != magicNumber);
    }
}
