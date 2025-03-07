public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _length * _width;
    }
}

// using System;

// namespace PolymorphismActivity
// {
//     // Derived class representing a rectangle
//     public class Rectangle : Shape
//     {
//         private double _width;
//         private double _height;

//         public Rectangle(string color, double width, double height) : base(color)
//         {
//             _width = width;
//             _height = height;
//         }

//         // Override GetArea to compute the rectangle's area
//         public override double GetArea()
//         {
//             return _width * _height;
//         }
//     }
// }