using System;

public class Bike : Exercise
{
    private double _speed;

    public Bike(DateOnly date, double length, double speed) : base (date, length)
    {
        _speed = speed;
    }

    public override double getDistance()
    {
        double timeInHours = getLength() / 60;
        double distance = _speed * timeInHours;
        return Math.Round(distance, 2);
    }

    public override double getSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override double getPace()
    {
        return Math.Round(getLength() / getDistance(), 2);
    }

    public override void getSummary()
    {

        Console.WriteLine($"Date: {getDate()}");
        Console.WriteLine("Exercise: Biking");
        Console.WriteLine($"Distance: {getDistance()} miles");
        Console.WriteLine($"Speed: {getSpeed()} mph");
        Console.WriteLine($"Pace: {getPace()} minutes per mile\n");
    }
}