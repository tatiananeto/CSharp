using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContagemRegressiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar 2 minutos ao DateTimerPicker para facilitar os testes
            dateTimePicker1.Value = dateTimePicker1.Value.AddMinutes(2);
        }

        private void btnIniciarContagem_Click(object sender, EventArgs e)
        {
            //Usuário deve escolher uma data maior que agora
            if (dateTimePicker1.Value > DateTime.Now)
            {
                Contagem contagemForm = new Contagem(dateTimePicker1.Value);
                contagemForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Escolha uma data maior que agora", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}