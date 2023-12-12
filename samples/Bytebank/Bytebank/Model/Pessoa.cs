namespace Bytebank.Model;

public class Pessoa
{

    private string _nome;
    public string Cpf { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, string cpf, int idade)
    {
        Nome = nome;
        Cpf = cpf;
        Idade = idade;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (value != "")
                _nome = value;
        }
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Cpf: {Cpf}, Idade: {Idade}";
    }

}
