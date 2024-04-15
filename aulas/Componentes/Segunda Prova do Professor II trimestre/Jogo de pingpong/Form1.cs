using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_pingpong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_facil_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Jogo f_Jogo = new F_Jogo(200);
            f_Jogo.Show();
        }

        private void btn_medio_Click(object sender, EventArgs e)
        {
            F_Jogo f_Jogo = new F_Jogo(100);
            f_Jogo.Show();
        }

        private void btn_dificil_Click(object sender, EventArgs e)
        {
            F_Jogo f_Jogo = new F_Jogo(50);
            f_Jogo.Show();
        }
    }
}
