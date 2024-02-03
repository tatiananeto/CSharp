using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace componentes
{
    public partial class F_Principal : Form
    {
       public int num;
        public F_Principal()
        {
            InitializeComponent();
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um veiculo");
                tb_veiculo.Focus();// posicionar o cursor 
                return;// para e sai do evento e segue a pprogramaçao normal
            }

            tb_lista_veiculo.Text += tb_veiculo.Text + " , "; // adicionar os veiculos com espacamento e virgula
            //tb_lista_veiculo.Text = tb_lista_veiculo.Text + tb_veiculo.Text;
            tb_veiculo.Clear();
            tb_veiculo.Focus();

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_lista_veiculo.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            F_veiculos f_Veiculos = new F_veiculos(tb_lista_veiculo.Text, this);// criar um obscto da classe
            f_Veiculos.ShowDialog();// mostar o formulario, o show dialog nao permite escrever no formulario anterior antes de feichar o atual
        }

        private void btn_val_num_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkdBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Checkedlistbox f_Checkedlistbox = new F_Checkedlistbox();
            f_Checkedlistbox.ShowDialog();
        }
    }
}
