using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_e_cadastramento
{
    public partial class F_Menu : MaterialSkin.Controls.MaterialForm
    {
        public F_Menu()
        {
            InitializeComponent();
            // Criando um material de theme manager e adicionando no formulario
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;



            // Definindo um esquema de cor para o formulario com tom azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
                );
        }

        private void funcionárosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            F_lista_Funcionarios f_Lista_Funcionarios = new F_lista_Funcionarios();
            f_Lista_Funcionarios.Show();
            
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_lista_Funcionarios f_Lista_Funcionarios = new F_lista_Funcionarios();
            f_Lista_Funcionarios.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
