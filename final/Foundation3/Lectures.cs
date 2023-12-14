using System;

public class Lectures : Events
{
    private string _speaker;
    private int _maxCapacity;

    public Lectures(List<string> eventParams, string speaker, int maxCapacity, Address address) : base (eventParams, address)
    {
        _speaker = speaker;
        _maxCapacity = maxCapacity;
    }
    public string getSpeaker()
    {
        return _speaker;
    }

    public int getMaxCapacity()
    {
        return _maxCapacity;
    }

    public void getLectureDetails()
    {
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Max capacity: {_maxCapacity}");

    }

    public void getFullDetails()
    {
        Console.WriteLine("Lecture");
        getLectureDetails();
        getEventStandardDetails();
    }

    public void getShortDescription()
    {
        Console.WriteLine("Lecture");
        getTitleAndDate();
    }

}