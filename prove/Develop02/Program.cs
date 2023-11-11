using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //I can do this! I have an idea to put this together.
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to your journal. What is it that you would like to do?");
        Console.WriteLine("1. Write in Journal");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Erase Journal entry");
        Console.WriteLine("4. Erase Journal");
        Console.WriteLine("5. Close the Journal");
        string answer = Console.ReadLine();
        int select = int.Parse(answer);
        string filePath = "journal.txt";
        if (select == 1)
        {
            Console.WriteLine("Write to your journal here.");
            string input = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(input);
            }

            Console.WriteLine("Journal entry has been written to journal.txt");
            return;
        }
        if (select == 2)
        {
            using(StreamReader readtext = new StreamReader(filePath))
            {
              string journal_content = readtext.ReadToEnd();
              Console.WriteLine(journal_content);
            }
            return;
        }
        if (select == 3)
        {
            Console.Write("Enter the line line to delete: ");
            if (int.TryParse(Console.ReadLine(), out int lineNumber) && lineNumber >= 1)
                {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);
                    if (lineNumber <= lines.Length)
                    {
                        var updatedLines = new List<string>();
                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (i != lineNumber)
                            {
                                updatedLines.Add(lines[i]);
                            }
                        }
                        File.WriteAllLines(filePath, updatedLines);
                        Console.WriteLine($"Line {lineNumber} deleted successfully.");
                    }
                else
                {
                    Console.WriteLine("Invalid line number.");
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                }
                else
                {
                    Console.WriteLine("Invalid line number.");
                }
            return;
            
        }
        if (select == 4)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                Console.WriteLine("Journal has been erased!");
            }
            return;
        }
        if (select == 5)
        {
            Console.WriteLine("Closing Journal!");
            return;
        }
        else
        {
            Console.WriteLine("That isn't an option");
        }
    }
}