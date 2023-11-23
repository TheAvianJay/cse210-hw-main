using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a1 = new Assignment("Riki Rakito", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        Mathassignment a2 = new Mathassignment("Sam Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Scarlet Red", "European History", "The Causes of World War II where an Austrian painter thought it was a great idea to invade the Soviet Union");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}