using System;

public class Customer
{
    // Private fields - customer's personal info is protected
    private string _name;
    private Address _address; // Address object

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address; // store the whole Address object
    }

    // This method asks the address if it's in USA
    public bool LivesInUSA()
    {
        return _address.IsInUSA(); // call the address's method
    }

    // Getters for accessing customer data safely
    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    // Setters
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }
}