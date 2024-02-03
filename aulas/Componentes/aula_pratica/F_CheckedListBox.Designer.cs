namespace aula_pratica
{
    partial class F_CheckedListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clb_disciplinas = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrar_selecionados = new System.Windows.Forms.Button();
            this.btn_limpar_lista = new System.Windows.Forms.Button();
            this.btn_resetar_lista = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_nova_disciplina = new System.Windows.Forms.TextBox();
            this.lb_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_disciplinas
            // 
            this.clb_disciplinas.FormattingEnabled = true;
            this.clb_disciplinas.Items.AddRange(new object[] {
            "TLP",
            "TIC",
            "OGE",
            "SEAC"});
            this.clb_disciplinas.Location = new System.Drawing.Point(31, 136);
            this.clb_disciplinas.Name = "clb_disciplinas";
            this.clb_disciplinas.Size = new System.Drawing.Size(184, 235);
            this.clb_disciplinas.TabIndex = 0;
            // 
            // btn_mostrar_selecionados
            // 
            this.btn_mostrar_selecionados.Location = new System.Drawing.Point(283, 136);
            this.btn_mostrar_selecionados.Name = "btn_mostrar_selecionados";
            this.btn_mostrar_selecionados.Size = new System.Drawing.Size(221, 40);
            this.btn_mostrar_selecionados.TabIndex = 1;
            this.btn_mostrar_selecionados.Text = "Mostrar seleccionados";
            this.btn_mostrar_selecionados.UseVisualStyleBackColor = true;
            this.btn_mostrar_selecionados.Click += new System.EventHandler(this.btn_mostrar_selecionados_Click);
            // 
            // btn_limpar_lista
            // 
            this.btn_limpar_lista.Location = new System.Drawing.Point(283, 182);
            this.btn_limpar_lista.Name = "btn_limpar_lista";
            this.btn_limpar_lista.Size = new System.Drawing.Size(221, 41);
            this.btn_limpar_lista.TabIndex = 2;
            this.btn_limpar_lista.Text = "Limpar lista";
            this.btn_limpar_lista.UseVisualStyleBackColor = true;
            this.btn_limpar_lista.Click += new System.EventHandler(this.btn_limpar_lista_Click);
            // 
            // btn_resetar_lista
            // 
            this.btn_resetar_lista.Location = new System.Drawing.Point(283, 229);
            this.btn_resetar_lista.Name = "btn_resetar_lista";
            this.btn_resetar_lista.Size = new System.Drawing.Size(221, 33);
            this.btn_resetar_lista.TabIndex = 3;
            this.btn_resetar_lista.Text = "Resetar lista";
            this.btn_resetar_lista.UseVisualStyleBackColor = true;
            this.btn_resetar_lista.Click += new System.EventHandler(this.btn_resetar_lista_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(283, 74);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(110, 26);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_nova_disciplina
            // 
            this.tb_nova_disciplina.Location = new System.Drawing.Point(29, 74);
            this.tb_nova_disciplina.Name = "tb_nova_disciplina";
            this.tb_nova_disciplina.Size = new System.Drawing.Size(248, 26);
            this.tb_nova_disciplina.TabIndex = 5;
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(25, 42);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(190, 19);
            this.lb_texto.TabIndex = 6;
            this.lb_texto.Text = "Digite uma nova disciplina";
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 456);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.tb_nova_disciplina);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_resetar_lista);
            this.Controls.Add(this.btn_limpar_lista);
            this.Controls.Add(this.btn_mostrar_selecionados);
            this.Controls.Add(this.clb_disciplinas);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_disciplinas;
        private System.Windows.Forms.Button btn_mostrar_selecionados;
        private System.Windows.Forms.Button btn_limpar_lista;
        private System.Windows.Forms.Button btn_resetar_lista;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_nova_disciplina;
        private System.Windows.Forms.Label lb_texto;
    }
}