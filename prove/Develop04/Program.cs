using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> animationstring = new List<string>();
        animationstring.Add(".         ");
        animationstring.Add(" .        ");
        animationstring.Add("  .       ");
        animationstring.Add("   .      ");
        animationstring.Add("    .     ");
        animationstring.Add("     .    ");
        animationstring.Add("      .   ");
        animationstring.Add("       .  ");
        animationstring.Add("        . ");
        animationstring.Add("         .");

        while (true){
            Console.WriteLine("what would you like to select for your mindful activities?");
            Console.WriteLine("1:Breathing activity");
            Console.WriteLine("2:Reflection activity");
            Console.WriteLine("3:A lister Activity");
            Console.WriteLine("4:Quit");
            string answer = Console.ReadLine();
            int selector = int.Parse(answer);
            if (selector == 1) {
                Console.WriteLine("How long do you want your Breathing activity in seconds? ");
                string sec = Console.ReadLine();
                int length = int.Parse(sec);
                Console.WriteLine($"Okay. You will be doing this activity for {length} seconds. ");
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(length);
                while (DateTime.Now < futureTime) {
                    Console.WriteLine("Breath in...");
                    for (int i = 5; i > 0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }
                    Console.WriteLine("Breath out...");
                    for (int i = 5; i > 0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");
                    }
                }
                foreach (string s in animationstring)
                {
                    Console.Write(s);
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b");
                }
                Console.WriteLine("You are done now with this activity.");
            };
            if (selector == 2) {
                Console.WriteLine("This is the Reflecting Activity.");
                Console.WriteLine("This activity will require you to reflect on moments in your life you have been able to over come tough chalenges. This will help you see the potential that you have to over come the chalenges that come in life. ");
                Console.WriteLine("Get ready... ");
                foreach (string s in animationstring){
                    Console.Write(s);
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b");
                }   
                Console.WriteLine("--- Consider the prompt and think deeply. ---");
                Console.WriteLine("When something in mind, input it and press enter...");
                Console.WriteLine("");
                Console.WriteLine("What occured to you that impacted you greatly? ");
                Console.ReadLine();
                foreach (string s in animationstring){
                    Console.Write(s);
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b");
                }   
                Console.WriteLine("How did you feel when it was complete? ");
                Console.ReadLine();
                foreach (string s in animationstring){
                    Console.Write(s);
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b");
                }   
                Console.WriteLine("It is good.");
            };
            if (selector == 3) {
                Console.WriteLine("This is the Listing Activity.");
                Console.WriteLine("This activity help you ponder on the good things in your life by having you list as many events that you can in certain areas. ");
                Console.WriteLine("How, long in seconds, would you like this sesion? ");
                string sec = Console.ReadLine();
                int length = int.Parse(sec);
                Random rnd = new Random();
                List<string>r_prompt = new List<string>();
                r_prompt.Add("Who are people that you appreciate?");
                r_prompt.Add("What are personal strengths of yours?");
                r_prompt.Add("Who are people that you have helped this week?");
                r_prompt.Add("When have you felt the Holy Ghost this month?");
                r_prompt.Add("Who are some of your personal heroes?");

                foreach (string s in animationstring){
                    Console.Write(s);
                    Thread.Sleep(200);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b");
                } 
                DateTime startTime = DateTime.Now;
                DateTime futureTime = startTime.AddSeconds(length);
                while (DateTime.Now < futureTime){
                    Console.WriteLine(r_prompt[rnd.Next(5)]);
                    Console.ReadLine();
                }
            };
            if (selector == 4) {
                //I am done good bye program
                Console.WriteLine("Goodbye. ;)");
                //The program has been slayen
                Environment.Exit(0);
            }
        }
    }
}