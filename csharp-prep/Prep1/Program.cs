using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"So, your name is {first} {last}. {last}, I believe I have met others with that last name. Interesting");
        Console.WriteLine("Hello Prep1 World!");
    }
}
