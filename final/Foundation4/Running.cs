using System;

public class Running : Exercise
{
    private double _distance;

    public Running(DateOnly date, double length, double distance) : base (date, length)
    {
        _distance = distance;
    }

    public override double getDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double getSpeed()
    {
        return Math.Round(_distance / getLength() * 60, 2);
    }

    public override double getPace()
    {
        return Math.Round(getLength() / _distance, 2);
    }

    public override void getSummary()
    {
        Console.WriteLine($"Date: {getDate()}");
        Console.WriteLine("Exercise: Running");
        Console.WriteLine($"Distance: {getDistance()} miles");
        Console.WriteLine($"Speed: {getSpeed()} mph");
        Console.WriteLine($"Pace: {getPace()} minutes per mile\n");
    }
}