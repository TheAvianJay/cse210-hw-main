using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        } 
        if (percent >= 80)
        {
            letter = "B";
        }
        if (percent >= 70)
        {
            letter = "C";
        }
        if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade in school is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed the class. Yay.");
        }
        else
        {
            Console.WriteLine("You loooooooose! >=)");
        }
    }
}