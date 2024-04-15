using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_geometricas_prova
{
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quadrado_Click(object sender, EventArgs e)
        {
            F_Quadrado f_Quadrado = new F_Quadrado();
            f_Quadrado.ShowDialog();
        }

        private void circlo_Click(object sender, EventArgs e)
        {
            F_Circlo f_Circlo = new F_Circlo();
            f_Circlo.ShowDialog();
        }

        private void retangulo_Click(object sender, EventArgs e)
        {
            F_Rectangulo f_Rectangulo = new F_Rectangulo();
            f_Rectangulo.ShowDialog();
        }

        private void triangulo_Click(object sender, EventArgs e)
        {
            F_Triangulo f_Triangulo = new F_Triangulo();
            f_Triangulo.ShowDialog();
        }
    }
}
