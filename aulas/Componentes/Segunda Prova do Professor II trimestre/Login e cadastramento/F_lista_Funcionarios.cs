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
    public partial class F_lista_Funcionarios : MaterialSkin.Controls.MaterialForm
    {
        SortedDictionary<string, funcionario> ListaFuncionarios;
        public F_lista_Funcionarios()
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
        internal void ExibeFuncionarios()
        {
            if ( ListaFuncionarios.Count == 0) 
                return;
                
                lv_funcionario.Items.Clear();

                int i = 1; 
                
                foreach ( KeyValuePair<string, funcionario > kvp in ListaFuncionarios )
                {
                    ListViewItem lvfuncionarios = new ListViewItem(kvp.Key);

                    funcionario func = kvp.Value;

                    lvfuncionarios.SubItems.Add(func.nome);
                    lvfuncionarios.SubItems.Add(func.sobrenome);
                    lvfuncionarios.SubItems.Add(func.bi);
                    lvfuncionarios.SubItems.Add(func.nacionalidade);
                    lvfuncionarios.SubItems.Add(func.telefone.ToString());
                    lvfuncionarios.SubItems.Add(func.email);
                    lvfuncionarios.SubItems.Add(func.endereco);
                    lvfuncionarios.SubItems.Add(func.funcao);
                    lvfuncionarios.SubItems.Add(func.horas.ToString());
                    lvfuncionarios.SubItems.Add(func.salario.ToString());

                    if(i % 2 == 0 ) { 
                        lvfuncionarios.BackColor = Color.FromArgb(255, 128, 0); ;
                        lvfuncionarios.ForeColor = Color.White;
                    }
                    else
                    {
                        lvfuncionarios.BackColor = Color.FromArgb(128, 64, 64);
                        lvfuncionarios.ForeColor = Color.White;
                    }

                    lv_funcionario.Items.Add(lvfuncionarios);
                    
                    i++;
                }
               

            
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            lv_funcionario.Items.RemoveAt(lv_funcionario.SelectedIndices[0]);
        }
    }
}
