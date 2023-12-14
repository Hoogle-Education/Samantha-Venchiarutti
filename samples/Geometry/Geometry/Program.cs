using Geometry.Models;

namespace Geometry;

public class Program
{

    // TODO: ler sobre abstract e casting

    public static void Main()
    {

        // error: abstract shape
        // Shape s1 = new Shape(Color.GREEN, 3.0);
        Circle c1 = new Circle(Color.PURPLE, 2.0, 5.0);

        // casting
        int a = 1;
        int b = 2;

        var x = (double)a / b;

        // upcasting - sempre eh seguro
        Shape s2 = new Circle(Color.BLACK, 1.0, 3.0);
        Shape s3 = new Rectangle(Color.RED, 1.0, 2.0, 3.0);

        // array = tamanho fixo, homogeneo

        Shape[] shapes = new Shape[5];

        shapes[0] = s1;
        shapes[1] = s2;
        shapes[2] = new Circle(Color.GREY, 1.0, 3.0);

        // downcasting
        Circle c3 = (Circle)s2;
        Circle c4 = (Circle)s3;

        Console.WriteLine(c3.Radius);
        Console.WriteLine(c4.Radius);

    }
}