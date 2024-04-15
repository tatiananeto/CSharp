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
    public partial class F_Quadrado : Form
    {
        public F_Quadrado()
        {
            InitializeComponent();
        }

        private void F_Quadrado_Load(object sender, EventArgs e)
        {

        }

        private void tb_comprimento_TextChanged(object sender, EventArgs e)
        {
            if (tb_comprimento.Text == "")
            {
                MessageBox.Show("Digite o comprimento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Area do quadrado = lado ao quadrado
                tb_resultado.Text = (Math.Pow(Convert.ToDouble(tb_comprimento.Text.ToString()), 2)).ToString();
                return;
            }
            tb_comprimento.Focus();
            tb_resultado.Clear();
            
        }
    }
}
