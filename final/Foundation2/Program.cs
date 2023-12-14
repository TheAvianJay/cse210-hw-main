using System;

class Program
{
    static void Main(string[] args)
    {
        Products lamp = new Products(19.37, "lamp", 1, "165873");
        Products pencils = new Products(1.09, "pencils", 13, "165240");
        Products paper = new Products(4.99, "paper", 500, "165923");
        Products pen = new Products(19.49, "pen", 10, "174932");

        List<Products> order1ProductsList = new List<Products>() {
            lamp, pencils
        };
        List<Products> order2ProductsList = new List<Products>() {
            paper, pen
        };

        Address cus1Address = new Address("19 Jump Street", "Herecy", "NY", "USA");
        Address cus2Address = new Address("21 Phone Avenue", "Kormt", "Alberta", "Canada");
        Address cus3Address = new Address("15 All Will Fall Avenue", "Booze", "FL", "USA");
        Address cus4Address = new Address("5 Sassy Street", "Death Row", "Ontario", "Canada");

        Customer cus1 = new Customer("John Smith", cus1Address);
        Customer cus2 = new Customer("Jane Doe", cus2Address);
        Customer cus3 = new Customer("Billy Jones", cus3Address);
        Customer cus4 = new Customer("Randy Johnson", cus4Address);

        Orders order1 = new Orders(order1ProductsList, cus1);
        Orders order2 = new Orders(order2ProductsList, cus2);

        string order1ShippingLabel = order1.getShippingLabel();
        string order1PackagingLabel = order1.getPackagingLabel();

        string order2ShippingLabel = order2.getShippingLabel();
        string order2PackagingLabel = order2.getPackagingLabel();

        Console.WriteLine($"Total cost for {cus1.getName()}: ${order1.calculateTotalCostOfOrder()}\nShipping label:\n{order1ShippingLabel}\n\nPackaging label:\n{order1PackagingLabel}\n");      
        Console.WriteLine($"Total cost for {cus2.getName()}: ${order2.calculateTotalCostOfOrder()}\nShipping label:\n{order2ShippingLabel}\n\nPackaging label:\n{order2PackagingLabel}\n");      
        
    }
}