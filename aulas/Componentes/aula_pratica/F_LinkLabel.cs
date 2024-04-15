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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplos.Links.Add(0, 6, "https://www.google.com/");// para adiconar multiplos linkes olhamos como um vector marcando a posiçao de 0 ate aonde termina o nome da palavra que sera um link
            ll_multiplos.Links.Add(9, 16, "https://www.youtube.com/");

            ll_multiplos.Links[1].Enabled = false;// desabilitar um link marco a posicao olhando como se fosse um vector

        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/?app" + tb_nome.Text);
            //ll_canal.LinkVisited = true;// apos clicado ele vai definir como link visitado
            LinkLabel ll = (LinkLabel)sender;// 0 sender é o prorio elemnto que foi passado
            ll.LinkVisited = true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_multiplos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("file:///C:/Users/LELA'S%20PC/Documents/TLP/Material/Materia%20de%20TLP(estudo)/C%23/apostila-csharp-orientacao-objetos.pdf");
        }

        private void F_LinkLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
