// This class represents a physical address for a customer.
public class Address
{
    // Putting member variables in private to store address details.
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //creating Constructor to start address properties.
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //creating Public getter for the full address as a single string.
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    //creating Method to check if the address is in the USA.
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }
}
