namespace Geometry.Models;

public abstract class Shape
{
    public Color Color { get; set; }
    public double Thickness { get; set; } // espessura

    public Shape(double thickness)
    {
        Thickness = thickness;
    }

    public Shape(Color color, double thickness) : this(thickness)
    {
        Color = color;
    }

    public virtual double Area() // virtual = permite ser sobreescrito
    {
        return -1;
    }
}
