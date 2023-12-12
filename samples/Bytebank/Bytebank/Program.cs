using Bytebank.Model;

namespace Bytebank; // file scoped namespace

public class Program
{
    public static Conta[] contas = new Conta[1000];

    // Ok: 1.1 criar uma funcao no qual gere um id aleatorio, que peca as informacoes de uma pessoa e
    // TODO: 1.2 salve em um array
    // TODO: 2. Listar todas as contas (nao vazias) presentes no array

    
    public static void CadastrarPessoa() {
        Console.Write("Insira o nome: ");
        string nome = Console.ReadLine();
        Console.Write("Insira o cpf: ");
        string cpf = Console.ReadLine();
        Console.Write("Insira o idade: ");
        int idade = int.Parse(Console.ReadLine());

        Random random = new Random();
        int id = random.Next(1000, 9999);

        Conta contaParaCadastrar = Conta.FromPessoa(id, nome, cpf, idade);
    }

    public static void Main() // entrypoint
    {

        // atributo estatico
        double result = Circle.PI;

        // Math.Log()
        Circle.CalculateArea(3.0);

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