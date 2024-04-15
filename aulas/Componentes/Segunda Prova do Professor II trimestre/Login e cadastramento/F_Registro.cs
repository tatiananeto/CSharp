using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_e_cadastramento
{
    public partial class F_Registro : MaterialSkin.Controls.MaterialForm
    {
       
        public F_Registro( )
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

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel13_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Menu f_Menu = new F_Menu();
            f_Menu.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            string strPrimeiroNome = tb_nome.Text;
            string strSobrenome = tb_sobrenome.Text;
            string strNomeCompleto;

            if (strPrimeiroNome.Length == 0)
                strNomeCompleto = strSobrenome;
            else
                strNomeCompleto = strSobrenome + ", " + strPrimeiroNome;

            tb_nome_completo.Text = strNomeCompleto;
        }

    }




}

