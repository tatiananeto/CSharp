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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_obter_data_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;
            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_setar_data_Click(object sender, EventArgs e)
        {
            int dia, mes, ano;
            dia = int.Parse(tb_dia1.Text);
            mes = int.Parse(tb_mes1.Text);
            ano = int.Parse(tb_ano1.Text);

            DateTime dt = new DateTime(ano, mes, dia);
            dtp_data.Value = dt;
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
            tb_dia1.Clear();
            tb_mes1.Clear();
            tb_ano1.Clear();
            tb_dia.Clear();
            tb_mes.Clear();
            tb_ano.Clear();
            tb_data.Clear();
        }
    }
}
