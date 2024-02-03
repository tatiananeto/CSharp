class Program
{
    static void Main(string[] args)
    {
        Processar();

        double preco, res,taxa;
        Console.WriteLine("Digite o preco: ");
        preco = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite a taxa: ");
        taxa = Convert.ToDouble(Console.ReadLine());
        //preco = 12.3;
        //taxa = 100.4;
        res = preco * taxa;
        Console.WriteLine( "o valor e {0}", res);


        Console.ReadKey();
    }

    private static void Processar()
    {
        int Idade;
        Console.Write("Informe a sua idade: ");
        int.TryParse(Console.ReadLine(), out Idade);

        if (Idade >= 18)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Acesso permitdo");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Acesso Negado");
        }
    }
    
}