// This class stands in for the customer placing an order.
public class Customer
{
    // Putting member variables in private to store customer information.
    private string _name;
    private Address _address;

    //Creating Constructor to start customer properties.
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Creating Public getter for customer name.
    public string Name
    {
        get { return _name; }
    }

    // Creating Public getter for customer address.
    public Address Address
    {
        get { return _address; }
    }

    // implementing the Method to check if the customer resides in the USA.
    public bool IsInUSA()
    {
        // Calling the Address class method to determine the country.
        return _address.IsInUSA();
    }
}
