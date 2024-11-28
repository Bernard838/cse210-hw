using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Getting the Default constructor (1/1)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Getting the Constructor with one parameter (e.g., 5 becomes 5/1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    //Getting the Constructor with two parameters (e.g., 3/4)
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    //Getting the Method to return fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    //Getting the Method to return fraction as a decimal (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
