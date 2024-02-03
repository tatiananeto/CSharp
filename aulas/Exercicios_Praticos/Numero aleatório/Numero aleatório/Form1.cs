using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Numero_aleatório
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Criar número aleatório MAIOR OU IGUAL a 0 e MENOR que 1000
            Random rnd = new Random();
            tbNumeros.Text += rnd.Next(0, 1000) + Environment.NewLine;

            //Ir para a última linha do textbox
            tbNumeros.SelectionStart = tbNumeros.TextLength;
            tbNumeros.ScrollToCaret();
        }
    }
}
