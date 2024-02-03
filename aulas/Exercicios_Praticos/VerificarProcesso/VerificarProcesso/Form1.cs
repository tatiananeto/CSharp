using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace VerificarProcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool verificarProcessoAtivo(string nomeProcesso)
        {
            //Cria um array de processos - Lembrar de importar o namespace System.Diagnostics
            Process[] listaProcessos = Process.GetProcesses();
            //Loop no array
            foreach (Process processo in listaProcessos)
            {
                //Se encontrar o processo enquanto está no loop retorna true
                if (processo.ProcessName == nomeProcesso)
                {
                    return true;
                }
            }
            //Se sair do loop é porque não o encontrou, retorna false
            return false;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Chamar o método passando o nome do processo digitado no TextBox
            if (verificarProcessoAtivo(tbNomeProcesso.Text))
            {
                lblRes.Text = tbNomeProcesso.Text + " está rodando";
                lblRes.ForeColor = Color.DarkGreen;
            }
            else
            {
                lblRes.Text = tbNomeProcesso.Text + " não está rodando";
                lblRes.ForeColor = Color.DarkRed;
            }
        }
    }
}