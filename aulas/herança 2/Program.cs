public class Conta //classe base
{
    public int Numero;
    public double Saldo;
}
public class ContaPoupanca : Conta
//classe derivada
{
    public int JurosMensais;
    public ContaPoupanca()
    {
        Saldo = 1200;
        Numero = 0090000;
        JurosMensais = 0;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
       ContaPoupanca c1 = new ContaPoupanca();
    
        Console.WriteLine("saldo..........: {0}", c1.Saldo);
        Console.WriteLine("numero.........: {0}", c1.Numero);
        Console.WriteLine("numero.........: {0}", c1.JurosMensais);
    }
}