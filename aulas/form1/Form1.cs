using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_aula1_Click(object sender, EventArgs e)
        {
            /*String txt;
            txt= tb_nome.Text;
            lb_link.Text = txt;*/
 
            lb_link.Text = tb_nome.Text; ;
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = listbox.GetItemText(listbox.SelectedItem);

            MessageBox.Show(name);

        }
    }
}
