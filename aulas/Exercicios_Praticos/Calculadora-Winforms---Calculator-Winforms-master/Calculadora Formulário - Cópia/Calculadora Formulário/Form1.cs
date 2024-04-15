using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Formulário
{
    public partial class Calculadora : Form
    {
        Double valor = 0, total=0; // para capturar o valor a calcular
        String operacao=""; // para capturar a string que corresponde ao simbolo da operação
        bool operacao_press = false, operacao_clean = false; //para saber se o botão da operação foi carregado ou nao de modo aos numeros
                                     // nao se empilharem
        public Calculadora()
        {
            InitializeComponent();
        }

private void button_click(object sender, EventArgs e)
            
        {
            
            if ((Resultado.Text == "0")  || operacao_press||operacao_clean) Resultado.Clear(); // para apagar o zero inicial da calculadora
            operacao_clean = false;
            operacao_press = false;
            Button b = (Button)sender;                      // apos a criação de um método, quando este é aplicado     //  aos butões, todos eles assumem o valor inserido e imprimem
            Equation.Text = valor + " " + operacao;
            if (b.Text == ",")
            {
                if (!Resultado.Text.Contains(","))
                    Resultado.Text = Resultado.Text + b.Text;
            }
            else Resultado.Text = Resultado.Text + b.Text;
        }
        
        private void button14_Click(object sender, EventArgs e)
        {
            Equation.Text = "0";
            Resultado.Clear();
            valor = 0;
        }


        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            if (valor != 0)
            {
                igual.PerformClick();            // para acumular valores quando pressiono um operando
                operacao_press = true;              // ex: 3+3+3
                Button b = (Button)sender;
                operacao = b.Text;
                Equation.Text = valor + " " + operacao;

            }
            else
            {
                Button b = (Button)sender;
                operacao = b.Text;                  //para capturar a operação na calculadora
                valor = Double.Parse(Resultado.Text);  //é necessário um cast pois a variavel valor é do tipo double
                operacao_press = true;
            }
            

                                                    //e queremos returnar uma string 
                                                    //Resultado.Text = "0";

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Resultado.Text = Math.Pow(Double.Parse(Resultado.Text), 2).ToString();
        }

        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
           // MessageBox.Show(e.KeyChar.ToString());
            switch (e.KeyChar.ToString())
            {
                
                case "1":
                    um.PerformClick();
                    break;
                case "2":
                    dois.PerformClick();
                    break;
                case "3":
                    tres.PerformClick();
                    break;
                case "4":
                    quatro.PerformClick();
                    break;
                case "5":
                    cinco.PerformClick();
                    break;
                case "6":
                    seis.PerformClick();
                    break;
                case "7":
                    sete.PerformClick();
                    break;
                case "8":
                    oito.PerformClick();
                    break;
                case "9":
                    nove.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case ",":
                    virgula.PerformClick();
                    break;

                case "+":
                    mais.PerformClick();
                    break;
                case "-":
                    menos.PerformClick();
                    break;
                case "*":
                    vezes.PerformClick();
                    break;
                case "/":
                    dividir.PerformClick();
                    break;
                case "=":
                    igual.PerformClick();
                    break;


            }
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            operacao_press = false;
            Equation.Text = "";
            operacao_clean = true;
            switch(operacao)
            {
                case "+":
                    Resultado.Text = (valor + Double.Parse(Resultado.Text)).ToString();
                    break;
                case "-":
                    Resultado.Text = (valor - Double.Parse(Resultado.Text)).ToString();
                    break;
                case "*":
                    Resultado.Text = (valor * Double.Parse(Resultado.Text)).ToString();
                    break;
                case "/":
                    Resultado.Text = (valor / Double.Parse(Resultado.Text)).ToString();
                    break;
                case "x^2":
                    Resultado.Text = Math.Pow (Double.Parse(Resultado.Text),2).ToString();
                    break;
                case "x^3":
                    Resultado.Text = Math.Pow(Double.Parse(Resultado.Text), 3).ToString();
                    break;
                case "x^y":
                    Resultado.Text = Math.Pow(valor, Double.Parse(Resultado.Text)).ToString();
                    break;
                case "1/x":
                    Resultado.Text = (1/ Double.Parse(Resultado.Text)).ToString();
                    break;
                case "sin":
                    Resultado.Text= Math.Sin(Math.PI * (Double.Parse(Resultado.Text))/ 180).ToString();
                    break;
                case "cos":
                    Resultado.Text = Math.Cos(Math.PI * (Double.Parse(Resultado.Text)) / 180).ToString();
                    break;
                case "tan":
                    Resultado.Text = Math.Tan(Math.PI * (Double.Parse(Resultado.Text)) / 180).ToString();
                    break;
                case "sqrt":
                    Resultado.Text = Math.Sqrt(Double.Parse(Resultado.Text)).ToString();
                    break;
                case "%":
                    Resultado.Text = (valor / Double.Parse(Resultado.Text)*100).ToString();
                    break;
                case "mod":
                    Resultado.Text = (valor % Double.Parse(Resultado.Text)).ToString();
                    break;
                case "bin":
                    Resultado.Text = Convert.ToString(Convert.ToInt32(Double.Parse(Resultado.Text)), 2);
                    operacao_press = false;
                    Equation.Text = "";
                    operacao_clean = true;
                    break;
                case "dec":
                    Resultado.Text = Convert.ToInt64((Resultado.Text),2).ToString();
                    operacao_press = false;
                    Equation.Text = "";
                    operacao_clean = true;

                    break;
                case "+-":
                    Resultado.Text = (-1 * Double.Parse(Resultado.Text)).ToString();
                    operacao_press = false;
                    Equation.Text = "";
                    operacao_clean = true;
                    break;
                case "ce":
                    Resultado.Text = "0"; //= Resultado.Text.Remove(Resultado.Text.Length - 10);
                    break;
                case "<-":
                    Resultado.Text = Resultado.Text.Remove(Resultado.Text.Length - 1);
                    break;
                case "div": 
                   Resultado.Text = ((int)(valor / (Double.Parse(Resultado.Text)))).ToString();
                    break;

                   
            }
            valor = double.Parse(Resultado.Text);    // quando sai do switch faz acumular o valor
            operacao = "";


        }

        private void button17_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
        }

    }
}
