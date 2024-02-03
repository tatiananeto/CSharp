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
    public partial class F_veiculos : Form
    {
        F_Principal fp;
        public F_veiculos(String v, F_Principal f)
        {
            InitializeComponent();
            tb_listaveiculo.Text = v;

            fp = f;
            f.num = 10;
        }

        private void tb_listaveiculo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void F_veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_lista_veiculo.Text = tb_listaveiculo.Text;
        }
    }
}
