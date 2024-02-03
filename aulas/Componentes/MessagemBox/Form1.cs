using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagemBox;



namespace MessagemBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*Application.EnableVisualStyles();
            DialogResult dr = MessageBox.Show("Are you happy now?", "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    MessageBox.Show("That is Fantastic");
                    Close();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Why Not?");
                    Close();
                    break;

            }*
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Sua rotina de exclusão
                //Confirmando exclusão para o usuário
                MessageBox.Show("Registro apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }*/

        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //Define o valor das propriedades iguais, usando o maior deles como base
            if (this.Width > this.Height)
            {
                this.Height = this.Width;
            }
            else
            {
                this.Width = this.Height;
            }
        }
    }
}
