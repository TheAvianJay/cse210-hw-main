using System;

public class Products
{
    private double _cost;
    private string _name;
    private int _quantity;
    private string _id;

    public Products(double cost, string name, int quantity, string id)
    {
        // Default to 1/1
        _cost = cost;
        _name = name;
        _quantity = quantity;
        _id = id;
    }
    
    public string getName()
    {
        return _name;
    }

    public string getId()
    {
        return _id;
    }

    public double getTotalPrice()
    {
        return Math.Round(_cost * _quantity, 2);
    }
}