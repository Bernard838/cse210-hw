public class Shape
{
    public string Color { get; set; }

    // Constructor to initialize the color of the shape
    public Shape(string color)
    {
        Color = color;
    }

    // Virtual method to calculate the area; to be overridden in derived classes
    public virtual double GetArea()
    {
        return 0;  // Default implementation (if no area calculation is provided)
    }
}
