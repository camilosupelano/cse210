using System;

public class Product
{
    private string _name;
    private double _price;
    private int _productID;
    private int _quantity;

    public Product (string name, double price, int productID, int quantity)
    {
        _name = name;
        _price = price;
        _productID = productID;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetProductID()
    {
        return _productID;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }



    public string GetDisplayText()
    {
        return $"{_name} (ID: {_productID}): ${_price:f2}";
    }
    
}