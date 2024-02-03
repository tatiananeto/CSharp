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
    public partial class F_CheckedListBox : Form
    {
       
        public F_CheckedListBox()
        {
            InitializeComponent();

        }

        private void btn_mostrar_selecionados_Click(object sender, EventArgs e)
        {
            String texto = "";

            foreach (string t in clb_disciplinas.CheckedItems)
            {
                texto += t + ", ";
            }
            //clb_disciplinas.CheckedItems[0].ToString();
            MessageBox.Show(texto);

        }

        private void btn_limpar_lista_Click(object sender, EventArgs e)
        {
            clb_disciplinas.Items.Clear();  
        }

        private void btn_resetar_lista_Click(object sender, EventArgs e)
        {
            clb_disciplinas.Items.Clear();
            clb_disciplinas.Items.Add("TLP", false);
            clb_disciplinas.Items.Add("TIC", false);
            clb_disciplinas.Items.Add("OGE", false);
            clb_disciplinas.Items.Add("SEAC", false);

             // List <string> tr = new List<string> ();
            //clb_disciplinas.Items.AddRange(tr.ToArray);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_nova_disciplina.Text != "")
            {
                clb_disciplinas.Items.Add(tb_nova_disciplina.Text);
                tb_nova_disciplina.Clear();
                tb_nova_disciplina.Focus();
                
            }
        }
    }
}
