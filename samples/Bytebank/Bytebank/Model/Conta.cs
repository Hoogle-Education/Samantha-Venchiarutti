namespace Bytebank.Model;

public class Conta
{

    public int Id { get; private set; }
    public double Saldo { get; private set; }
    public bool EstaAtiva { get; private set; }

    // tem um
    public Pessoa Pessoa { get; set; }

    public Conta(int id, Pessoa pessoa)
    {
        Id = id;
        Pessoa = pessoa;
        EstaAtiva = true;
    }

    public Conta(int id, Pessoa pessoa, double saldo) : this(id, pessoa)
    {
        Saldo = saldo;
    }
    

    public void Depositar(double quantia) {
        if (!EstaAtiva)
            return;

        Saldo += quantia;
    }

    public bool Sacar(double quantia) {
        if (quantia > Saldo)
            return false;

        if (!EstaAtiva)
            return false;

        Saldo -= quantia;
        return true;
    }
    
    public void Transferir(double quantia, Conta contaDestino) {
        if (!Sacar(quantia))
            return;

        contaDestino.Saldo += quantia;
    }

    public override string ToString()
    {
        return $"Numero da Conta: {Id}" +
            $"\nContratante{{ {Pessoa} }}" +
            $"\nSaldo: {Saldo:F2}";
    }
}

