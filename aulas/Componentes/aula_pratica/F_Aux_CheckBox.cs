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
    public partial class F_Aux_CheckBox : Form
    {
        public F_CheckBox f_CheckBox;
        public F_Aux_CheckBox()
        {
            InitializeComponent();

            f_CheckBox = Application.OpenForms["F_CheckBox"] as F_CheckBox;
            cb_tlp.Checked = f_CheckBox.cb_tlp.Checked;
            cb_tic.Checked = f_CheckBox.cb_tic.Checked;
            cb_seac.Checked = f_CheckBox.cb_seac.Checked;
            cb_oge.Checked = f_CheckBox.cb_oge.Checked;
        }

        private void cb_tlp_CheckedChanged(object sender, EventArgs e)
        {
           f_CheckBox.cb_tlp.Checked = cb_tlp.Checked;
        }

        private void cb_tic_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_tic.Checked = cb_tic.Checked;
        }

        private void cb_oge_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_oge.Checked = cb_oge.Checked;
        }

        private void cb_seac_CheckedChanged(object sender, EventArgs e)
        {
            f_CheckBox.cb_seac.Checked = cb_seac.Checked; 
        }
    }
}
