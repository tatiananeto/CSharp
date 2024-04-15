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
    public partial class F_Rectangulo : Form
    {
        public F_Rectangulo()
        {
            InitializeComponent();
        }

        private void F_Rectangulo_Load(object sender, EventArgs e)
        {

        }

        private void areaRetangulo()
        {
            try
            {
                tb_resultado.Text = (Convert.ToDouble(tb_base.Text.ToString()) * Convert.ToDouble(tb_altura.Text.ToString())).ToString();
                return; ;
            }
            catch(Exception) 
            {
                MessageBox.Show("Digite a base e a altura!" , "Erro" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_altura.Focus();
            tb_base.Focus();
            tb_resultado.Clear();
        }

        private void tb_base_TextChanged(object sender, EventArgs e)
        {
            areaRetangulo();
        }

        private void tb_altura_TextChanged(object sender, EventArgs e)
        {
            areaRetangulo();
        }
    }
}