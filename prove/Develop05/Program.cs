using System;

class Program
{

    private static int GetResponse(string goalName)
    {
        Console.WriteLine($"How many times did you {goalName}?");
        string response = Console.ReadLine();
        int howManyTimes = int.Parse(response);
        return howManyTimes;
    }

    private static void UpScoreIfNecessary(Goals goal, int howManyTimes, int bonusPoints)
    {
        int newTotal = goal.GetPoints() + bonusPoints;
        if (goal.IsComplete())
        {
            goal.SetPoints(newTotal);
            Console.WriteLine($"You managed to accomplish your goal this week on {goal.DisplayName()}. Your score per tick of your goal will now be {newTotal}.");
        }
        else
        {
            Console.WriteLine($"You did not accomplish your goal this week on {goal.DisplayName()}. Your score per tick of your goal will remain {goal.GetPoints()}.");
        }
    }

    private static void DisplayGoalsWithPassingStatus(List<Goals> goals)
    {
        foreach (Goals goal in goals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"{goal.DisplayName()} pass");
            }
            else
            {
                Console.WriteLine(goal.DisplayName());
            }
        }
    }

    static void Main(string[] args)
    {
        int repentanceFrequency = GetResponse("repent");
        int runningMiles = GetResponse("run this week");
        
        Repentance repentance = new Repentance(repentanceFrequency);
        MorningRun morningRun = new MorningRun(runningMiles);

        UpScoreIfNecessary(repentance, repentanceFrequency, 200);
        UpScoreIfNecessary(morningRun, runningMiles, 100);

        
        List<Goals> goals = new List<Goals>() { repentance, morningRun };

        int total = repentance.CalculatePoints() + morningRun.CalculatePoints();

        Console.WriteLine($"Your total score is {total}");
        Console.WriteLine("Is there a new goal you would like to set? Enter yes or no");
    
        string response = Console.ReadLine();
        if (response == "yes")
        {
            Console.WriteLine("Name the goal you would like to now set");
            string NewGoal = Console.ReadLine();
            Console.WriteLine("here are your goals and if they are completed");
            DisplayGoalsWithPassingStatus(goals);
            Console.WriteLine($"{NewGoal}");
        }
        else
        {
            DisplayGoalsWithPassingStatus(goals);
        }
        
    }
}