/*using System;
class teste
{
    // Método que recebe parâmetros por valor
    public void metValor(int parametro)
    {
        parametro++;
        Console.WriteLine(parametro);
    }
    static public void Main()
    {
        int argValor = 10;
        teste class1 = new teste();
        class1.metValor(argValor);
        Console.WriteLine(argValor);
    }
}

using System;
class teste
{
    public void metRef(ref int parametro)
    {
        parametro++;
        Console.WriteLine(parametro);
    }
}
class App
{
    public static void Main()
    {
        int parRef = 10;
        teste class1 = new teste();
        class1.metRef(ref parRef);
        Console.WriteLine(parRef);
        Console.ReadLine();
    }
}


using System;
class parametro_valor{
    static void Main(){
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);
       
    }

    static void dobrar(ref int valor){
        valor *= 2;
    }
}


using System;
class parametro_valor
{
    static void Main()
    {
        int divid, divis, quoc, rest;
        divid = 10;
        divis=5;
        quoc= divide(divid, divis, out rest);
        Console.WriteLine("{0} / {1} : quoeficiente = {2} e o resto = {3}", divid, divis,quoc, rest);
      
    }

    static int divide(int dividendo, int divisor, out int resto)
    {
        int quoeficiente;
        quoeficiente= dividendo / divisor;
        resto= dividendo % divisor;
        return quoeficiente;
    }
}
*/

using System;
class Parametro_params
{
    static void Main()
    {
        soma(6, 2, 4, 3);
    }
    static void soma(params int[] n)
    {
        int res=0;
        if(n.Length < 1) {
            Console.WriteLine("não existe valores a serem somados");

        }else if(n.Length < 2) {
            Console.WriteLine("Valores insuficientes para somar: {0}", n[0]);
        }
        else
        {
            for(int i = 0; i < n.Length; i++)
            {
                res += n[i]; 
            }
            Console.WriteLine("A soma dos valores é: {0}", res);
        }
    }
}