using System.Collections.Generic;

// This class represents a customer order containing multiple products.
public class Order
{
    // Putting member variables in private to store order details.
    private List<Product> _products;
    private Customer _customer;

    //Creating Constructor to start the customer and an empty product list.
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    //Creating Public method to add a product to the order.
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //Creating a Method to generate the packing label for the order.
    // Lists product names and their IDs.
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"- {product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    //Creating Method to generate the shipping label for the order.
    // Includes the customer's name and address.
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.Name}\n{_customer.Address.GetFullAddress()}";
    }

    //Creating Method to calculate the total cost of the order.
    // Includes product costs and shipping charges.
    public double CalculateTotalCost()
    {
        double total = 0;

        // Adding the total cost of all products.
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        // Adding shipping cost based on the customer's location.
        total += _customer.IsInUSA() ? 5 : 35;

        return total;
    }
}
