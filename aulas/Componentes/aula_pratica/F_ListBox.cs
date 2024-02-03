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
    public partial class F_ListBox : Form
    {
        List<string> disciplinas = new List<string>();

        public F_ListBox()
        {
            InitializeComponent();

            disciplinas.Add("TLP");
            disciplinas.Add("TIC");
            disciplinas.Add("SEAC");

            lb_disciplinas.DataSource = disciplinas; //ASSOciar esta lista ao meu listbox, uso o datasouce, para incializar o listbox
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_disciplina.Text == "")
            {
                MessageBox.Show("digite uma disciplina");
                tb_disciplina.Focus ();
            }
            else if(lb_disciplinas.FindString(tb_disciplina.Text)<0)
            {
                disciplinas.Add (tb_disciplina.Text);
                tb_disciplina.Clear();
                lb_disciplinas.DataSource = null;// para aparecer no list box
                lb_disciplinas.DataSource = disciplinas;
                tb_disciplina.Focus ();
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            disciplinas.RemoveAt(lb_disciplinas.SelectedIndex);// remove de acordo com a osicao
            lb_disciplinas.DataSource = null;
            lb_disciplinas.DataSource = disciplinas;
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_disciplina.Text = disciplinas[lb_disciplinas.SelectedIndex];
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            disciplinas.Clear();
            lb_disciplinas.DataSource = null;
            lb_disciplinas.DataSource = disciplinas;
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
           if(lb_disciplinas.Text == "") { 
            disciplinas.Add("TLP");
            disciplinas.Add("TIC");
            disciplinas.Add("SEAC");
            lb_disciplinas.DataSource = null;
            lb_disciplinas.DataSource = disciplinas;
            }
        }
    }
}
