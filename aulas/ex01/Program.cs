internal class Program
{
    private static void Main(string[] args)
    {
        int day;
        Console.Write("Digite o dia: ");
        day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
        var valor = int.Parse("123");
        var valor2 = bool.Parse("true");
        var valor3 = DateTime.Parse("01/01/2022");

        Console.WriteLine(valor);
        Console.WriteLine(valor2);
        Console.WriteLine(valor3);
    }
}