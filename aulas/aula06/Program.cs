internal class Program
{
    private static void Main(string[] args)
    {
        /*int n1, n2, n3;

        n1 = 10; n2 = 20; n3 = 30;

        Console.Write("\nn1=\t{0},\nn2=\t{1}, \nn3=\t{2}", n1, n2, n3); // modelo de string aonde eu nformo a posicao de cada numero entrechavetas, os indices sempre começam de 0
        // \n qurebra linha, \t cria tabulação*/

        double valorCompra = 5.50;
        double valorVenda;
        double lucro=0.1;
        string produto = "pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto.......:{0,15}", produto);
        Console.WriteLine("Val.compra....:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro.........:{0,15:p}", lucro);
        Console.WriteLine("Val.venda.....:{0,15:c}", valorVenda);
    }

}