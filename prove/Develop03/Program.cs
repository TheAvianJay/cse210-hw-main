using System;
using System.Collections.Generic;
using System.Linq;

public class Scripturememorizer3000
{
    private string originalSentence;
    private List<string> words;
    private List<int> hiddenWordIndexes;

    public Scripturememorizer3000(string sentence)
    {
        originalSentence = sentence;
        words = originalSentence.Split(' ').ToList();
        hiddenWordIndexes = new List<int>();
    }

    public string GetProcessedScripture()
    {
        string processedSentence = "";
        for (int i = 0; i < words.Count; i++)
        {
            if (hiddenWordIndexes.Contains(i))
            {
                processedSentence += "___ ";
            }
            else
            {
                processedSentence += words[i] + " ";
            }
        }
        return processedSentence.Trim();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(count, words.Count - hiddenWordIndexes.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex;
            do
            {
                randomIndex = random.Next(words.Count);
            } while (hiddenWordIndexes.Contains(randomIndex));
            hiddenWordIndexes.Add(randomIndex);
        }
    }
}

class Program
{
    static void Main()
    {
        string Scripture = "Or in other words, yield yourselves up unto us, and unite with us and become acquainted with our asecret works, and become our brethren that ye may be like unto us—not our slaves, but our brethren and partners of all our substance.";
        Scripturememorizer3000 processor = new Scripturememorizer3000(Scripture);

        Console.WriteLine("3 Nephi 3:7");
        Console.WriteLine(Scripture);
        Console.WriteLine();

        Console.WriteLine("Press Enter to remove words:");
        Console.WriteLine();

        do
        {
            Console.ReadLine();
            processor.HideRandomWords(2); 
            Console.WriteLine("3 Nephi 3:7");
            Console.WriteLine(processor.GetProcessedScripture());
        } while (processor.GetProcessedScripture().Contains("___"));
        //Why isn't this terminating itself?
        Console.WriteLine("All words revealed. Program ending.");
        Environment.Exit(0); 
    }
}