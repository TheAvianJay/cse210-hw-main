using System;

public class Orders
{
    private List<Products> _productList;
    private Customer _customer;
    public Orders(List<Products> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
    }
    public double calculateTotalCostOfOrder()
    {
        double total = 0.00;
        double oneTimeShippingCost = getShippingCost();
        foreach (Products product in _productList )
        {
            total += product.getTotalPrice();
        }
        return total + oneTimeShippingCost;
    }
    private double getShippingCost()
    {
       if  (_customer.isInUSA())
       {
        return 5.00;
       }
       return 35.00;
    }

    public string getPackagingLabel()
    {
        string packagingLabel = "";
        foreach (Products product in _productList )
        {
            packagingLabel += $"{product.getName()}: {product.getId()}\n";
        }
        return packagingLabel;
    }
    public string getShippingLabel()
    {
        return $"{_customer.getName()}\n{_customer.getAddress().allFields()}";
    }

}