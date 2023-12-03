using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many times did you repent? ");
        string rep = Console.ReadLine();
        int nr = int.Parse(rep);
        int rp = 1000;
        if (nr >= 7)
        {
            rp = 1200;
            Console.WriteLine("You manage to acomplish your goal this week on repenting. Your score per tick of your goal will now be 1200. ");
        }
        Console.WriteLine("How far did you run this week? ");
        string dis = Console.ReadLine();
        int d = int.Parse(dis);
        int dp = 200;
        if (d >= 10)
        {
            dp = 300;
            Console.WriteLine("You manage to acomplish your goal this week on running. Your score per tick of your goal will now be 300. ");
        }
        
        List<Goals> goals = new List<Goals>();
        Repentance r = new Repentance(rp, nr);
        goals.Add(r);
        MorningRun mr = new MorningRun(dp, d);
        goals.Add(mr);

        //Console.WriteLine(mr.CalculatePoints());

        foreach (Goals g in goals)
        {
            Console.WriteLine(g.DisplayName() + " " + g.CalculatePoints());
        }
        int total = r.CalculatePoints() + mr.CalculatePoints();
        Console.WriteLine($"Your total score is {total}");
        Console.WriteLine("Is there a new goal you would like to set? Enter yes or no");
        string responce = Console.ReadLine();
        string yes = ("yes");
        if (responce == yes)
        {
            Console.WriteLine("Name the goal you would like to now set");
            string NewGoal = Console.ReadLine();
            Console.WriteLine("here are your goals and if they are completed");
            if (nr >= 7)
            {
                
                Console.WriteLine(r.DisplayName() + " pass");
            }
            else
            {
                Console.WriteLine(r.DisplayName());
            }
            if (d >= 7)
            {
                
                Console.WriteLine(mr.DisplayName() + " pass");
            }
            else
            {
                Console.WriteLine(mr.DisplayName());
            }
            if (responce == yes)
            {
                Console.WriteLine($"{NewGoal}");
            }
        }
        else
        {
            if (nr >= 7)
            {
                
                Console.WriteLine(r.CalculatePoints() + "pass");
            }
            else
            {
                Console.WriteLine(r.CalculatePoints());
            }
            if (d >= 7)
            {
                
                Console.WriteLine(mr.CalculatePoints() + "pass");
            }
            else
            {
                Console.WriteLine(mr.CalculatePoints());
            }
        }
        
    }
}