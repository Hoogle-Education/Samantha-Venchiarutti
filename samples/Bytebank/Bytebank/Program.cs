using Bytebank.Model;

namespace Bytebank; // file scoped namespace

public class Program
{
    public static Conta[] contas = new Conta[1000];
    public static int size = 0;

    // int a = 2, b = 2;

    // Console.WriteLine(a++); // 2
    // Console.WriteLine(a); // 3
    // Console.WriteLine(++b); // 3
    // Console.WriteLine(b); // 3

    // Ok: 1.1 criar uma funcao no qual gere um id aleatorio, que peca as informacoes de uma pessoa e
    // TODO: 1.2 salve em um array
    // TODO: 2. Listar todas as contas (nao vazias) presentes no array
    // TODO: 3. Deletar uma conta pelo cpf ou apresentar mensagem caso nao exista
    
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
        contas[size++] = contaParaCadastrar;
    }

    public static void Main() // entrypoint
    {
      CadastrarPessoa();
      CadastrarPessoa();
      CadastrarPessoa();
    }

}