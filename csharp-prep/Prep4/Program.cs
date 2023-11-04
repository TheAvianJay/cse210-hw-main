using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Thought console write was first =/
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.Write("Input a group of numbers. Input 0 to stop. ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of what you input is {sum}");

        //need to learn to memorize this. Time will help if I focus
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average you input is {average}");

        //This text was writen before I atempt this.
        //atempt one max was usernumbers and numbers were forgotten. Also for each was user early
        
        int max = numbers[0];
        //Number and numbers were swaped on attempt 1
        foreach(int number in numbers)
        {
            if (number >max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max that is inputed is {max}.");

    }
}