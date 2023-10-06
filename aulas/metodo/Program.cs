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
*/

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