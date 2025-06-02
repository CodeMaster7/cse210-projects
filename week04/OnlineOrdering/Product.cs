using System;

public class Product
{
    // Private fields - product information is protected
    private string _name;
    private string _productId;
    private double _price; // Price per single item
    private int _quantity; // How many they're buying

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // This calculates the total cost for this product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Getters for accessing product data safely
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    // Setters - safe ways for other classes to update our private data
    // These allow controlled changes to product information
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetProductId(string productId)
    {
        _productId = productId;
    }

    public void SetPrice(double price)
    {
        _price = price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}