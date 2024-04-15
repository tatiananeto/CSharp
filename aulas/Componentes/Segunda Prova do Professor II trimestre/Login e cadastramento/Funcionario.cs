using System;
namespace Login_e_cadastramento
{
    [Serializable]

    public class funcionario
    {

        public string nome;
        public string sobrenome;
        public string bi;
        public string nacionalidade;
        public int telefone;
        public string endereco;
        public string email;
        public string funcao;
        public int horas;
        public double salario;



        public string nomecompleto
        {
            get { return sobrenome + nome; }

        }

        public funcionario()
        {
            nome = "Desconhecido";
            sobrenome = "Desconhecido";
            bi = "desconhecido";
            nacionalidade = "desconhecido";
            telefone = 0;
            endereco = "desconhecido";
            email = "desconehcido";
            funcao = "desconecido";
            horas = 0;
            salario = 0.00;
        }

        public funcionario(string n, string s, string b, string nac,
            int t, string e, string mail, string f, int h, double sl)
        {
            nome = n;
            sobrenome = s;
            bi = b;
            nacionalidade = n;
            telefone = t;
            endereco = e;
            email = mail;
            funcao = f;
            horas = h;
            salario = sl;
        }
    }
}





