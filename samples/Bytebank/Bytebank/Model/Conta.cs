namespace Bytebank.Model;

public class Conta
{

    // private, protected e public = modificadores de acesso
    // get e set => ferramenta de encapsulamento

    public int Id { get; private set; }
    public double Saldo { get; private set; }
    private string _nome;

    // metodo construtor
    //public Conta()
    //{
    //}

    public Conta(int id, string nome)
    {
        Id = id;
        _nome = nome;
    }

    public Conta(int id, string nome, double saldo) : this(id, nome)
    {
        Saldo = saldo;
    }


    // Property / Properties

    public string Name
    {
        get { return _nome; }
        set { 
            if (value != "") 
                _nome = value; 
        }
    }
    

    public void depositar() { }

    public void sacar() { }
    
    public void transferir() { }

   }

