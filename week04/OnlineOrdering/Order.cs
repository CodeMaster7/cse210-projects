using System;
using System.Collections.Generic;

public class Order
{
    // Private fields - order information is protected
    private List<Product> _products; // A list to hold multiple products
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); // Start with empty cart
    }

    // Method to add products to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate total cost of entire order
    // This adds up all products + shipping cost
    public double CalculateTotalCost()
    {
        return GetProductsSubtotal() + GetShippingCost();
    }

    // Calculate just the products subtotal (without shipping)
    // Shows how much the items cost before shipping
    public double GetProductsSubtotal()
    {
        double productTotal = 0;

        // Add up cost of all products
        foreach (Product product in _products)
        {
            productTotal += product.GetTotalCost();
        }

        return productTotal;
    }

    // Calculate just the shipping cost based on customer location
    // USA customers pay $5, international customers pay $35
    public double GetShippingCost()
    {
        return _customer.LivesInUSA() ? 5.0 : 35.0;
    }

    // Create packing label
    // Lists all products with their IDs
    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";

        foreach (Product product in _products)
        {
            // Add each product name and ID to the label
            label += $"- {product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }

    // Create shipping label
    // Shows customer name and address
    public string GetShippingLabel()
    {
        string label = "SHIPPING LABEL:\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetAddressString();

        return label;
    }

    // Getter for accessing customer
    public Customer GetCustomer()
    {
        return _customer;
    }

    // Getter for accessing products list
    public List<Product> GetProducts()
    {
        return _products;
    }
}