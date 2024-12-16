public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Constructor to initialize color, length, and width of the rectangle
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override the GetArea() method to return the area of the rectangle
    public override double GetArea()
    {
        return _length * _width;
    }
}
