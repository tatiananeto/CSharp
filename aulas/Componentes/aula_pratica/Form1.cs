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
    public partial class F_Principal : Form
    {
        public int num;
        public F_Principal()
        {
            InitializeComponent();
            num = 0;

        }

        private void lb_disciplina_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_disciplinas.Text == "")
            {
                MessageBox.Show("Digite uma disciplina");
                tb_disciplinas.Focus();
                return;
            }
            
            tb_lista_disciplinas.Text += tb_disciplinas.Text + ", ";
            tb_disciplinas.Clear();
            tb_disciplinas.Focus();
            
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_lista_disciplinas.Clear();
            tb_disciplinas.Clear();
            tb_disciplinas.Focus();
        }

        private void btn_mostar_disciplinas_Click(object sender, EventArgs e)
        {
            F_Disciplinas f_Disciplinas = new F_Disciplinas(tb_lista_disciplinas.Text, this);
            f_Disciplinas.ShowDialog();
            
        }

        private void btn_valor_num_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
            f_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "tsmi_fechar") {
                this.Close();
            }
            else if(e.ClickedItem.Name.ToString() == "tsmi_restaurar")
            {
                this.WindowState = FormWindowState.Normal;// para clocar os estado do windows
            }else if(e.ClickedItem.Name.ToString() == "tsmi_mensagem")
            {
                MessageBox.Show("Ola mundo em C#", "Aula Pratica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            
        }

        private void tsmi_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal; // para clicar com a parte esquerda do mouse
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.ShowDialog();
        }

        private void sQLiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_Sqlite f_Sqlite = new F_Sqlite();
            f_Sqlite.ShowDialog();
        }
    }
}
