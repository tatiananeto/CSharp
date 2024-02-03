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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostar_seleccionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_disciplina.Text);
        }

        private void btn_limpar_elementos_Click(object sender, EventArgs e)
        {
            cb_disciplina.Items.Clear();
         
        }

        private void btn_resetar_elemento_Click(object sender, EventArgs e)
        {
            cb_disciplina.Items.Clear();
            cb_disciplina.Items.Add("TLP");
            cb_disciplina.Items.Add("TIC");
            cb_disciplina.Items.Add("OGE");
            cb_disciplina.Items.Add("SEAC");
            cb_disciplina.Items.Add("MDSW");
            
        }

        private void cb_disciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_texto.Text= cb_disciplina.Text;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_texto.Text != "")
            {
                if (cb_disciplina.FindString(tb_texto.Text) < 0) { 
                    cb_disciplina.Items.Add(tb_texto.Text);
                }

            }
        }
    }
}
