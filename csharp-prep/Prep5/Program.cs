using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        DisplayResults(userName, squared);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your first and last name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of the number is {square}");
    }
}