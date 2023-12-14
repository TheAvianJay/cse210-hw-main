using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("15 All Will Fall Avenue", "Booze", "FL", "USA");
        List<string> eventParams1 = new List<string>()
        {
            "Jack's Wedding",
            "Come and see Jack Peterson get married!",
            "12-25-2025",
            "3:00pm",
            "21 North Pole Lane"
        };
        Address address2 = new Address("17 Yenton Rd", "Vici", "NY", "USA");
        List<string> eventParams2 = new List<string>()
        {
            "Russian Warlords",
            "A guide by George Bush on how to reunite Russia",
            "05-01-2457",
            "1:00pm",
            "24 South Main St."
        };
        Address address3 = new Address("1 Why Are We Here Avenue", "Noware", "Alberta", "Can");
        List<string> eventParams3 = new List<string>()
        {
            "How to be Miserible",
            "Come and hear reason on why being miserible is good",
            "12-25-2025",
            "3:00pm",
            "21 commit to folly"
        };

        OutdoorGatherings odg1 = new OutdoorGatherings(eventParams1, address1);
        odg1.getOutdoorGatheringDetails();
        odg1.getEventStandardDetails();

        Lectures l1 = new Lectures(eventParams1, "Matt Loumeau", 100, address1);
        l1.getLectureDetails();
        l1.getEventStandardDetails();

        Receptions r1 = new Receptions(eventParams1, "jpeterson@yahoo.com", address1);
        r1.getShortDescription();
        //2
        OutdoorGatherings odg2 = new OutdoorGatherings(eventParams2, address2);
        odg2.getOutdoorGatheringDetails();
        odg2.getEventStandardDetails();

        Lectures l2 = new Lectures(eventParams2, "Matt Loumeau", 100, address2);
        l2.getLectureDetails();
        l2.getEventStandardDetails();

        Receptions r2 = new Receptions(eventParams2, "jpeterson@yahoo.com", address2);
        r2.getShortDescription();
        //3
        OutdoorGatherings odg3 = new OutdoorGatherings(eventParams3, address3);
        odg3.getOutdoorGatheringDetails();
        odg3.getEventStandardDetails();

        Lectures l3 = new Lectures(eventParams3, "Matt Loumeau", 100, address3);
        l3.getLectureDetails();
        l3.getEventStandardDetails();

        Receptions r3 = new Receptions(eventParams3, "jpeterson@yahoo.com", address3);
        r3.getShortDescription();
    }
}