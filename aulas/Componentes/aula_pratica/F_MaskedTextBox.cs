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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            if (cb_somente_texto.Checked) {
                mtb_nif.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                mtb_nif.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            
            string msg = mtb_nif.Text;
            MessageBox.Show(msg);
        }
    }
}
