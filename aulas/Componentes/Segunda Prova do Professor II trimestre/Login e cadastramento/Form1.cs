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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
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

        private void mrbtn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Menu f_Menu = new F_Menu();
            f_Menu.Show();
           
        }

        private void mlb_registrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
