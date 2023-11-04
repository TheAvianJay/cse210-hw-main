using System;

class Program
{
    static void Main(string[] args)
    {
        // hmmm
        Random randomnum = new Random();
        int magicnumber = randomnum.Next(1, 101);

        int guess = -1;

        while (guess != magicnumber)
        {
            Console.Write("What is the 'magical' number. It ranges from 0 to 100 ");
            guess = int.Parse(Console.ReadLine());
            // tried to put number doen instead of guess that led to confusion
            if (magicnumber > guess)
            {
                Console.WriteLine("The number is Higher than that. ");
            }
            else if (magicnumber < guess)
            {
                Console.WriteLine("The number is lower than that.");
            }
            else
            {
                Console.WriteLine("That is the number!!");
            }
        }
    }
}