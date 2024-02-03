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
    public partial class Contagem : Form
    {
        private DateTime dtFimEvento;
        public Contagem(DateTime data)
        {
            InitializeComponent();
            dtFimEvento = data;
        }

        //A cada 1000 ms dar o tick to timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Se alcançou a data selecionada
            if (dtFimEvento <= DateTime.Now)
            {
                timer1.Enabled = false;
                MessageBox.Show("Fim da contagem.", "Pronto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //Se não alcançou, atualiza os labels
            else
            {
                TimeSpan tsTempoRestante = dtFimEvento.Subtract(DateTime.Now);
                lblDias.Text = tsTempoRestante.Days.ToString();
                lblHoras.Text = tsTempoRestante.Hours.ToString();
                lblMinutos.Text = tsTempoRestante.Minutes.ToString();
                lblSegundos.Text = tsTempoRestante.Seconds.ToString();
            }
        }
    }
}