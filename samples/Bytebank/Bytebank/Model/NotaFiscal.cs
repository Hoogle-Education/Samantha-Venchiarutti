
namespace Bytebank.Model;

public class NotaFiscal
{

    public double ValorBruto { get; set; }
    public double Imposto { get; set; }

    public NotaFiscal(double valorBruto, double imposto)
    {
        ValorBruto = valorBruto;
        Imposto = imposto;
    }

    public double ValorLiquido
    {
        get { return ValorBruto - Imposto; }
    }

}
