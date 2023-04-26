using System;

namespace Learning03
{
   class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 101);
            int userGuess = -1;

            while (userGuess != magicNumber)
            {
                Console.Write("Enter your guess: ");
                userGuess = int.Parse(Console.ReadLine());

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
            Console.WriteLine("You guessed it!");
        }
    }
}