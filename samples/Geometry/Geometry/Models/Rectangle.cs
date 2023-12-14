namespace Geometry.Models;

public class Rectangle : Shape
{

    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double thickness, double width, double height) : base(thickness)
    {
        Width = width;
        Height = height;
    }

    public Rectangle(Color color, double thickness, double width, double height) : base(color, thickness)
    {
        Width = width;
        Height = height;
    }

    public override double Area()
    {
        return Width* Height;
    }
}
