/*internal class Program
{
    class Empregado
    {
        public virtual double GetSalario()
        {
            return 3;
        }
    }
    class Vendedor : Empregado
    {
        public override double GetSalario()
        {
            return 3 + 0.05 * 5;
        }
    }
    class Gerente : Empregado
    {
        public override double GetSalario()
        {
            return 3 + 5;
        }
    }

    private static void Main(string[] args)
    {
        Empregado empregado1 = new Vendedor();
        Empregado empregado2 = new Gerente();
        Console.WriteLine(empregado1.GetSalario());
        Console.WriteLine(empregado2.GetSalario());
    }
}*/

class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        B b = new B();
        C c = new C();
        a.Teste(); // saida - - > "A::Test e()"
        b.Teste(); // saida - - > "B::Test e()"
        c.Teste(); // saida - - > "C::Test e()"
                    //- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        a = new B();
        a.Teste(); // saida - - > "B::Test e()"
        b = new C();
        b.Teste(); // saida - - > "C::Test e()"
        Console.ReadKey();
    }
}
class A
{
    public virtual void Teste() { Console.WriteLine("A::Test e()"); }
}
class B : A
{
    public override void Teste() { Console.WriteLine("B::Test e()"); }
}
class C : B
{
    public override void Teste() { Console.WriteLine("C::Test e()"); }
}


