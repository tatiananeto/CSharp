using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_pratica
{
    public partial class F_Disciplinas : Form
    {
        F_Principal fpr;

        public F_Disciplinas(string d, F_Principal fp)
        {
            InitializeComponent();
            tb_lista_disciplinas.Text = d;
            fpr = fp;
            fp.num = 15;  
        }

        private void F_Disciplinas_FormClosed(object sender, FormClosedEventArgs e)
        {
            fpr.tb_lista_disciplinas.Text = tb_lista_disciplinas.Text + " "; 
        }

        private void tb_lista_disciplinas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_lista_disciplinas_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
