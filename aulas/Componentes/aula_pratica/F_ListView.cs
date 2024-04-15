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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            tb_id.Clear();
            tb_disciplinas.Clear();
            tb_turmas.Clear();
            tb_qtd_alunos.Clear();
            tb_id.Focus();
        }
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_id.Text == "")
            {
                MessageBox.Show("O Id não pode ser vazio" , "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_id.Focus();
                return;
            }
            string[] ds = new string[4];
            ds[0]=  tb_id.Text;
            ds[1] = tb_disciplinas.Text;
            ds[2] = tb_turmas.Text;
            ds[3] = tb_qtd_alunos.Text;

            ListViewItem l = new ListViewItem(ds);
            lv_disciplinas.Items.Add(l);
            limpar();


        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_disciplinas.Items.RemoveAt(lv_disciplinas.SelectedIndices[0]);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_id.Text = lv_disciplinas.SelectedItems[0].SubItems[0].Text;
            tb_disciplinas.Text = lv_disciplinas.SelectedItems[0].SubItems[1].Text;
            tb_turmas.Text = lv_disciplinas.SelectedItems[0].SubItems[2].Text;
            tb_qtd_alunos.Text = lv_disciplinas.SelectedItems[0].SubItems[3].Text;
        }
        private void obter()
        {
            tb_id.Text = lv_disciplinas.SelectedItems[0].SubItems[0].Text;
            tb_disciplinas.Text = lv_disciplinas.SelectedItems[0].SubItems[1].Text;
            tb_turmas.Text = lv_disciplinas.SelectedItems[0].SubItems[2].Text;
            tb_qtd_alunos.Text = lv_disciplinas.SelectedItems[0].SubItems[3].Text;
        }
        private void lv_disciplinas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_disciplinas.SelectedItems.Count > 0)
            {
               // MessageBox.Show(lv_disciplinas.SelectedIndices[0].ToString());
               obter();
            }
            
        }

        
    }
}
