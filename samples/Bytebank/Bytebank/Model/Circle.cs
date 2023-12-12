using Bytebank.Model;

public class Circle {


  // private = so permite acesso dentro da propria classe
  // reaonly = somente leitura
  public static readonly double PI = 3.14159265;

  public static double CalculateArea(double radius) {
    return PI*radius*radius;
  }

}