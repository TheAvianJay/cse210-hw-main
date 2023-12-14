using System;

public class OutdoorGatherings : Events
{
    private string _weather = "Sunny";

    public OutdoorGatherings(List<string> eventParams, Address address) : base (eventParams, address)
    {
        // No unique properties to set
        return;
    }

    public string getWeather()
    {
        Random rnd = new Random();
        int randomNumber  = rnd.Next(1, 4);
        switch (randomNumber)
        {
            case 1:
                return "Sunny";
            case 2:
                return "Cloudy";
            case 3:
                return "Rainy";
        }

        return _weather;
    }

    public void getOutdoorGatheringDetails()
    {
        Console.WriteLine($"Weather: {getWeather()}");
    }

    public void getFullDetails()
    {
        Console.WriteLine("Outdoor Gathering");
        getOutdoorGatheringDetails();
        getEventStandardDetails();
    }

        public void getShortDescription()
    {
        Console.WriteLine("Outdoor Gathering");
        getTitleAndDate();
    }

}