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
    public partial class F_Triangulo : Form
    {
        public F_Triangulo()
        {
            InitializeComponent();
        }

        
        private void F_Triangulo_Load(object sender, EventArgs e)
        {

        }

        private void tb_lado_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tb_resultados.Text = ((Math.Pow(Convert.ToDouble(tb_lados.Text.ToString()), 2) * Math.Sqrt(3)) / 4).ToString();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Digite os lados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_resultados.Clear();
            tb_lados.Focus();
        }

        private void area_escaleno()
        {
            try
            {
                tb_resultado.Text = ((Convert.ToDouble(tb_base.Text.ToString()) * Convert.ToDouble(tb_altura.Text.ToString())) / 2).ToString();
                return;
            } catch (Exception)
            {
                MessageBox.Show("Digite a base e a altura!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tb_resultado.Clear();
            tb_altura.Focus();
            tb_base.Focus();
        }
        

        private void tb_base_TextChanged(object sender, EventArgs e)
        {
            area_escaleno(); 
        }

        private void tb_altura_TextChanged(object sender, EventArgs e)
        {
            area_escaleno(); 
        }
    }

}
