using System;

public abstract class Exercise
{
    private DateOnly _date;
    private double _length;

    public Exercise(DateOnly date, double length)
    {
        _date = date;
        _length= length;
    }

    public double getLength()
    {
        return _length;
    }

    public DateOnly getDate()
    {
        return _date;
    }

    public abstract double getDistance();
    public abstract double getSpeed();
    public abstract double getPace();
    public abstract void getSummary();

 }