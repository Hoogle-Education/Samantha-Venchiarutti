using Bytebank.Model;

namespace Bytebank; // file scoped namespace

public class Program
{

  // int a = 2, b = 2;

  // Console.WriteLine(a++); // 2
  // Console.WriteLine(a); // 3
  // Console.WriteLine(++b); // 3
  // Console.WriteLine(b); // 3

  // Ok: 1.1 criar uma funcao no qual gere um id aleatorio, que peca as informacoes de uma pessoa e
  // Ok: 1.2 salve em um array
  // Ok: 2. Listar todas as contas (nao vazias) presentes no array
  // Ok: 3. Deletar uma conta pelo cpf ou apresentar mensagem caso nao exista

  public static Conta[] contas = new Conta[1000];
  public static int size = 0;

  public static void CadastrarPessoa()
  {
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

  public static void BuscarContas()
  {
    for (int i = 0; i < size; i++)
    {
      Console.WriteLine(contas[i]);
    }
  }

  public static int IndexOfContaPorCpf(string cpf) {
    for (int i = 0; i < size; i++)
    {
      if(contas[i].Pessoa.Cpf.Equals(cpf))
        return i;
    }

    return -1;
  }

  public static void DeletarConta() {
    Console.Write("Insira o cpf: ");
    string cpf = Console.ReadLine();

    int posParaDeletar = IndexOfContaPorCpf(cpf);
    
    if(posParaDeletar == -1)
      return;

    int posUltima = size - 1;

    Conta aux = contas[posParaDeletar];
    contas[posParaDeletar] = contas[posUltima];
    contas[posUltima] = aux;

    size--;
  } 

  public static void Main() // entrypoint
  {
    CadastrarPessoa();
    CadastrarPessoa();
    CadastrarPessoa();
    DeletarConta();
    BuscarContas();
  }

}

// size = 6
// c0, c1, c2, c3 , c4 , c5 , .