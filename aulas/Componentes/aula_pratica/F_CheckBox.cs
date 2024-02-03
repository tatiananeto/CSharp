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
    public partial class F_CheckBox : Form
    {
        public F_CheckBox()
        {
            InitializeComponent();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            string texto = "";
            if (cb_tlp.Checked) {
                texto += cb_tlp.Text + ", ";
            
            }

            if (cb_tic.Checked)
            {
                texto += cb_tic.Text + ", ";

            }

            if (cb_seac.Checked)
            {
                texto += cb_seac.Text + ", ";

            }

            if (cb_oge.Checked)
            {
                texto += cb_oge.Text + ", ";

            }
            MessageBox.Show(texto);
        }

        private void cb_mdsw_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mdsw.Checked)
            {
                MessageBox.Show(" Metodologia de Desemvolvimento de Software");
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            F_Aux_CheckBox f_Aux_CheckBox = new F_Aux_CheckBox();
            f_Aux_CheckBox.ShowDialog();
        }
    }
}
