// In the order, this class stands in for a product.
public class Product
{
    // Putting member variables in private to store product information.
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Creating Constructor to set up the product's the first the characteristics.
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Creating Public getter for product name (no setter needed).
    public string Name
    {
        get { return _name; }
    }

    // Creating Public getter for product ID (no setter needed).
    public string ProductId
    {
        get { return _productId; }
    }

    //Creating Public getter for price per unit (no setter needed).
    public double Price
    {
        get { return _price; }
    }

    //Creating Public getter for quantity (no setter needed).
    public int Quantity
    {
        get { return _quantity; }
    }

    // The method used to determine this product's final cost.
    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}
