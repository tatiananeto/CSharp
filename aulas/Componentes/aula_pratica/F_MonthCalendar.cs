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
    public partial class F_MonthCalendar : Form
    {
        public F_MonthCalendar()
        {
            InitializeComponent();
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
           tb_pegardata.Text = monthCalendar1.SelectionStart.ToShortDateString();
           tb_pegardatafinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
           tb_datadehoje.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            tb_pegardata.Text = monthCalendar1.SelectionStart.ToShortDateString();
            tb_pegardatafinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            tb_datadehoje.Text = monthCalendar1.TodayDate.ToShortDateString();
        }
    }
}
