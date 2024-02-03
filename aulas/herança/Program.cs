class Veiculo // classe base
{
    public int velMax;
    private bool ligado;
    private int rodas;
        public void ligar()
        {
            this.ligado = true;
        }
        public void desligar()
        {
            this.ligado = false;
        }
        
        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }
        public string getligado() 
        {
        /*if(ligado)
        {
            return "sim";
    }
        else
        {
            return "não";
        }*/
        return (ligado ? "sim" : "não");
        }

        public int getrodas()
        {
             return rodas;
        }
        public void setrodas(int rodas)
        {
            if (rodas<0)
            {
                this.rodas = 0;
            }
            else if (rodas>40) 
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }    
        }
}
class Carro : Veiculo// classe derivada
{
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4) 
    {
       
        
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
        
    }
}

class CarroCombate : Carro
{
    public int monicao;

    public CarroCombate():base("Carro de combate", "Verde")
    {
        monicao = 100;
        setrodas(6);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Carro c1 = new Carro("rapidao", "vermelho");
        CarroCombate c2 = new CarroCombate();

        c1.ligar();

        Console.WriteLine("cor..........: {0}", c1.cor);
        Console.WriteLine("nome.........: {0}", c1.nome);
        Console.WriteLine("roda.........: {0}", c1.getrodas());
        Console.WriteLine("vel.Maxima...: {0}", c1.velMax);
        Console.WriteLine("ligado.......: {0}", c1.getligado());
        Console.WriteLine("..............................");

        Console.WriteLine("cor..........: {0}", c2.cor);
        Console.WriteLine("nome.........: {0}", c2.nome);
        Console.WriteLine("roda.........: {0}", c2.getrodas());
        Console.WriteLine("vel.Maxima...: {0}", c2.velMax);
        Console.WriteLine("ligado.......: {0}", c2.getligado());
        Console.WriteLine("monição......: {0}", c2.monicao);



    }
}