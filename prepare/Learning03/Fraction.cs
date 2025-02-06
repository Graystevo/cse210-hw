using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("bottom cannot be zero.");
        }

        _top = top;
        _bottom = bottom;
    }

    // Getter for top numerator
    public int GetTop()
    {
        return _top;
    }

    // Setter for top numerator
    private void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom denominator
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom denominator
    private void SetBottom(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("bottom cannot be zero.");
        }
        _bottom = bottom;
    }

    // Method to return numbers as fraction
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return proper decimal instead of fraction 
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}