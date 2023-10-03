internal class Program
{
    private static void Main(string[] args)
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };

        Console.WriteLine("Metodos para vectores");
        Console.WriteLine("metodo randon");

        // metodo que cria valores aleatorios, o lenght da a quantidade total dos valores de um vetor
        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++) { 
            vetor1[i] = random.Next(50);// o next pode ser usado sem parametro() ou pode ser usado (50) com parametro mostrando o valor maximo, ou ode ser usado (50,100) um intervalo  para o valor minimo e m,aximo 
        }

        Console.WriteLine("Elemntos do vetor 1");
        foreach (int n in vetor1){
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array, valor);
        Console.WriteLine("Busca Binaria");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado); // modo de usar o metodo para a busca binaria
        Console.WriteLine("O valor {0} está na posição {1} ",procurado,pos);
        Console.WriteLine("__________________________________");

        //public static void copy(array_origem,array_destino,qtd_elementos);
        Console.WriteLine("Copiar um vector");
        Array.Copy(vetor1, vetor2, vetor1.Length);// modo de usar o metodo para copiar
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("__________________________________");

        //public void copyTo(array_destino,apartir_da_posicao_que_quero_copiar);
        Console.WriteLine("Metodo copyTo");
        vetor1.CopyTo(vetor3, 0);// modo de usar, nao é pela calsse array e sim pelo proprio vector de origem
        foreach (int n in vetor3){
            Console.WriteLine(n); 
        }
        Console.WriteLine("__________________________________");

        //public long GetLongLegth(dimesão);
        Console.WriteLine("GetLongLegth");
        long qtdElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elemenntos {0} ", qtdElementosVetor);
        Console.WriteLine("__________________________________");


    }
}