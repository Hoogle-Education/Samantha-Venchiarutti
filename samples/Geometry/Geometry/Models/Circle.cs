namespace Geometry.Models;

public class Circle : Shape
{
    public readonly static double PI = Math.PI;
    public double Radius { get; set; }

    public Circle(double thickness, double width, double radius) : base(thickness)
    {
        Radius = radius;
    }

    public Circle(Color color, double thickness, double radius) : base(color, thickness)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return PI * Radius * Radius;
    }
}
