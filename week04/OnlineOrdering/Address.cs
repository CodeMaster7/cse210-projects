using System;

public class Address
{
    // Private fields - only this class can directly access them (Encapsulation!)
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // Constructor - special method that runs when we create a new Address
    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    // This method checks if the address is in USA
    public bool IsInUSA()
    {
        // check if country is "USA" or "United States" (case doesn't matter)
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }

    // This method creates a nicely formatted address string
    public string GetAddressString()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{_country}";
    }

    // Getters - safe ways for other classes to read our private data
    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    // Setters - safe ways for other classes to update our private data
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
}