using System;

public class Swim : Exercise
{
    private int _laps;

    public Swim(DateOnly date, double length, int laps) : base (date, length)
    {
        _laps = laps;   
    }

    public override double getDistance()
    {
        return Math.Round(_laps * 50 / (1000 * 0.62), 2);
    }

    public override double getSpeed()
    {
        return Math.Round(getDistance() / getLength() * 60, 2);
    }

    public override double getPace()
    {
        return Math.Round(getLength() / getDistance(), 2);
    }

        public override void getSummary()
    {
        Console.WriteLine($"Date: {getDate()}");
        Console.WriteLine("Exercise: Swimming");
        Console.WriteLine($"Distance: {getDistance()} miles");
        Console.WriteLine($"Speed: {getSpeed()} mph");
        Console.WriteLine($"Pace: {getPace()} minutes per mile\n");
    }
}