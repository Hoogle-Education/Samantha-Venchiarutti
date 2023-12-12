using Bytebank.Model;

namespace Bytebank; // file scoped namespace

public class Program
{
    public static Conta[] contas = new Conta[1000];

    // TODO: 1. criar uma funcao no qual gere um id aleatorio, que peca as informacoes de uma pessoa e salve em um array
    // TODO: 2. Listar todas as contas (nao vazias) presentes no array

    public static void Main()
    {
        Pessoa joao = new Pessoa("Joao da Silva", "111.222.333-44", 23);
        Conta c1 = new Conta(1, joao);

        Conta c2 = new Conta(2, new Pessoa("Maria da Silva", "111.222.333-45", 26), 200);

        c1.Depositar(300);

        c1.Transferir(350, c2);

        Console.WriteLine(c1);
        Console.WriteLine("------------------------");
        Console.WriteLine(c2);
    }

}