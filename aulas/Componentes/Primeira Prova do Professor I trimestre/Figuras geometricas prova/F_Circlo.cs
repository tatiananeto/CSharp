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
    public partial class F_Circlo : Form
    {
        public F_Circlo()
        {
            InitializeComponent();
        }

        private void F_Circlo_Load(object sender, EventArgs e)
        {

        }

        private void tb_raio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_resultado.Text = (Math.PI * Math.Pow(Convert.ToDouble(tb_raio.Text.ToString()), 2)).ToString();
                return;
            }
            catch
            {
                MessageBox.Show("Digite o raio!" , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_raio.Focus();
            tb_resultado.Clear();
        }
    }
}
