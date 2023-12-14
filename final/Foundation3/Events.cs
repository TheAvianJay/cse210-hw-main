using System;
using Microsoft.Win32.SafeHandles;

public abstract class Events
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Events(List<string> eventParams, Address address)
    {
        _title = eventParams[0];
        _description = eventParams[1];
        _date = eventParams[2];
        _time = eventParams[3];
        _address = address;
    }
    public void getEventStandardDetails()
    {
        List<string> normalDetails = new List<string>()
        {
            _title,
            _description,
            _date,
            _time,
        };

        foreach (string item in normalDetails)
        {
            Console.WriteLine(item);
        };

        
        Console.WriteLine($"{_address.allFields()}\n");
    }

    public void getTitleAndDate()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"{_date}\n");
    }
}