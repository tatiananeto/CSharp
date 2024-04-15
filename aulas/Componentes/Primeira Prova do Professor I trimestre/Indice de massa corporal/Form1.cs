using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Indice_de_massa_corporal
{
    public partial class F_Principal : Form
    {
        public double imc;
        public F_Principal()
        {
            InitializeComponent();
            
        }

        private void peso_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void label24_Click(object sender, EventArgs e)
        {

        }
        private void btn_female_Click(object sender, EventArgs e)
        {
            btn_female.BackColor = Color.Coral;
            btn_male.BackColor = Color.White;
        }

        private void btn_male_Click(object sender, EventArgs e)
        {
            btn_male.BackColor = Color.Coral;
            btn_female.BackColor = Color.White;
        }

        private void btn_calcuar_Click(object sender, EventArgs e)
        {
            
            try {

                imc = Math.Round(Convert.ToDouble(tb_peso.Text.ToString()) / (Math.Pow(Convert.ToDouble(tb_altra.Text.ToString()), 2)), 2);
                lb_diferenca.Text = imc.ToString();
            }
            catch (Exception) {
                tb_peso.Text = "0";  
                tb_altra.Text = "0";
                tb_idade.Text = "0";
                MessageBox.Show("Digite  a altura e o peso" , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_altra.Clear();
                tb_peso.Clear();
                tb_idade.Clear();
                tb_idade.Focus();
            }

            if (imc > 0 && imc <= 15.9)
            {
                lb_categoria.Text = "Magreza Grave";
                lb_categoria.ForeColor = Color.Blue;
                lb_diferenca.ForeColor = Color.Blue;
                lb_magreza_grave.ForeColor = Color.White;
                lb_valor_mg.ForeColor = Color.White;
                lb_magreza_grave.BackColor = Color.Blue;
                lb_valor_mg.BackColor = Color.Blue;

            }
            else if (imc >= 16.0 && imc <= 16.9)
         
            {
                lb_categoria.Text = "Magreza Moderada";
                lb_categoria.ForeColor = Color.Blue;
                lb_diferenca.ForeColor= Color.Blue;
                lb_magreaza_moderada.ForeColor = Color.White;
                lb_valor_mm.ForeColor = Color.White;
                lb_magreaza_moderada.BackColor = Color.Blue;
                lb_valor_mm.BackColor = Color.Blue;

            }
            else if(imc >= 17.0 && imc <= 18.4)
            {
                lb_categoria.Text = "Magreza Leve";
                lb_categoria.ForeColor = Color.Blue;
                lb_diferenca.ForeColor = Color.Blue;
                lb_magreza_leve.ForeColor = Color.White;
                lb_valor_ml.ForeColor = Color.White;
                lb_magreza_leve.BackColor = Color.Blue;
                lb_valor_ml.BackColor = Color.Blue;

            }
            else if(imc >= 18.5 && imc <= 24.9)
            {
                lb_categoria.Text = "Saudável";
                lb_categoria.ForeColor = Color.Green;
                lb_diferenca.ForeColor = Color.Green;
                lb_valor_sd.BackColor = Color.Green;
                lb_saudavel.BackColor = Color.Green;
                lb_valor_sd.ForeColor = Color.White;
                lb_saudavel.ForeColor = Color.White;

            }
            else if(imc >= 25.0 && imc <= 29.9)
            {
                lb_categoria.Text = "Sobrpeso";
                lb_categoria.ForeColor = Color.Orange;
                lb_diferenca.ForeColor = Color.Orange;
                lb_sobrepeso.ForeColor = Color.White;
                lb_valor_sb.ForeColor = Color.White;
                lb_sobrepeso.BackColor = Color.Orange;
                lb_valor_sb.BackColor = Color.Orange;

            }
            else if(imc >=30.0 && imc <= 34.9)
            {
                lb_categoria.Text = "Obesidade Grau I";
                lb_categoria.ForeColor = Color.Red;
                lb_diferenca.ForeColor = Color.Red;
                lb_ob_u.ForeColor = Color.White;
                lb_obesidade_um.ForeColor = Color.White;
                lb_obesidade_um.BackColor = Color.Red;
                lb_ob_u.BackColor = Color.Red;

            }
            else if(imc >= 35.0 && imc <= 39.9)
            {
                lb_categoria.Text = "Obesidade Grau II (Severa)";
                lb_categoria.ForeColor = Color.Red;
                lb_diferenca.ForeColor = Color.Red;
                lb_obesidade_dois.ForeColor = Color.White;
                lb_valor_ob_d.ForeColor = Color.White;
                lb_valor_ob_d.BackColor = Color.Red;
                lb_obesidade_dois.BackColor = Color.Red;

            }
            else if(imc >= 40)
            {
                lb_categoria.Text = "Obesidade Grau III (Moribunda)";
                lb_categoria.ForeColor = Color.Red;
                lb_diferenca.ForeColor = Color.Red;
                lb_obesidade_tres.ForeColor = Color.White;
                lb_ob_t.ForeColor = Color.White;
                lb_ob_t.BackColor = Color.Red;
                lb_obesidade_tres.BackColor = Color.Red;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_altra.Clear();
            tb_peso.Clear();
            tb_idade.Clear();
            lb_categoria.Text = "...............";
            lb_categoria.ForeColor= Color.Black;
            lb_diferenca.Text = "...............";
            lb_diferenca.ForeColor= Color.Black;
            lb_magreza_leve.ForeColor= Color.Black;
            lb_magreza_leve.BackColor= Color.White;
            lb_valor_ml.BackColor= Color.White;
            lb_valor_ml.ForeColor= Color.Black;
            lb_magreza_grave.ForeColor = Color.Black;
            lb_magreza_grave.BackColor = Color.White;
            lb_valor_mg.BackColor = Color.White;
            lb_valor_mg.ForeColor = Color.Black;
            lb_magreaza_moderada.ForeColor = Color.Black;
            lb_magreaza_moderada.BackColor = Color.White;
            lb_valor_mm.BackColor = Color.White;
            lb_valor_mm.ForeColor = Color.Black;
            lb_saudavel.ForeColor = Color.Black;
            lb_saudavel.BackColor = Color.White;
            lb_valor_sd.BackColor = Color.White;
            lb_valor_sd.ForeColor = Color.Black;
            lb_sobrepeso.ForeColor = Color.Black;
            lb_sobrepeso.BackColor = Color.White;
            lb_valor_sb.BackColor = Color.White;
            lb_valor_sb.ForeColor = Color.Black;
            lb_obesidade_um.ForeColor = Color.Black;
            lb_obesidade_um.BackColor = Color.White;
            lb_ob_u.BackColor = Color.White;
            lb_ob_u.ForeColor = Color.Black;
            lb_obesidade_dois.ForeColor = Color.Black;
            lb_obesidade_dois.BackColor = Color.White;
            lb_valor_ob_d.BackColor = Color.White;
            lb_valor_ob_d.ForeColor = Color.Black;
            lb_obesidade_tres.ForeColor = Color.Black;
            lb_obesidade_tres.BackColor = Color.White;
            lb_ob_t.BackColor = Color.White;
            lb_ob_t.ForeColor = Color.Black;

        }

        private void btn_dicas_Click(object sender, EventArgs e)
        {
            F_Dicas f_Dicas = new F_Dicas();
            f_Dicas.ShowDialog();
        }
    }
}
