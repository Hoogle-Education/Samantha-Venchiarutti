using Bytebank.Model;

namespace Bytebank; // file scoped namespace

public class Program
{

    public static void Main()
    {
        Conta c1 = new Conta(1, "Joao da Silva");
        c1 = new Conta(3, "Beatriz da Silva");
        Conta c2 = new Conta(2, "Maria da Silva", 200);

        // c2.id = -3;

        

        Console.WriteLine(c2.Saldo);
    }

}