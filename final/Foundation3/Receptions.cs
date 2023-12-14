using System;

public class Receptions : Events
{
    private string _RSVP;

    public Receptions(List<string> eventParams, string RSVP, Address address) : base (eventParams, address)
    {
        _RSVP = RSVP;
    }

    public string getRSVPEmail()
    {
        return _RSVP;
    }

    public void getReceptionDetails()
    {
        Console.WriteLine($"RSVP email:  {_RSVP}");
    }

    public void getFullDetails()
    {
        Console.WriteLine("Receptions");
        getReceptionDetails();
        getEventStandardDetails();
    }

        public void getShortDescription()
    {
        Console.WriteLine("Receptions");
        getTitleAndDate();
    }

}