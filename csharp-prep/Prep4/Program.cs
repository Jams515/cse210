using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbas = new List<int>();

        int userNumba = -1;
        while (userNumba != 0)
        {
            Console.Write("Enter a number, enter 0 to quit");
            string userAnswer = Console.ReadLine();
            userNumba = int.Parse(userAnswer);

            if (userNumba != 0)
            {
                numbas.Add(userNumba);
            }
        }
        int sum = 0;
        foreach (int number in numbas)
            {
                sum += number;
            }
            Console.WriteLine($"The sum of the numbers is {sum}");

        float avg = ((float)sum) / numbas.Count;
        Console.WriteLine($"The average of all the numbers is {avg}");

        int max = 0;
        foreach (int number in numbas)
        {
            if (number > max){
                max = number;
            }
        }
        Console.WriteLine($"The biggest number was {max}");
    }
}