using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        Running e1 = new Running(new DateOnly(2023, 10, 22), 120, 6);
        exercises.Add(e1);

        Bike e2 = new Bike(new DateOnly(2023, 10, 23), 90, 10.5);
        exercises.Add(e2);

        Swim e3 = new Swim(new DateOnly(2023, 10, 24), 45, 25);
        exercises.Add(e3);

        foreach (Exercise exercise in exercises )
        {
            exercise.getSummary();
        }
    }
}