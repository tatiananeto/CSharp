namespace aula_pratica
{
    partial class F_ListBox
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
            this.lb_disciplinas = new System.Windows.Forms.ListBox();
            this.lb_texto = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.tb_disciplina = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_disciplinas
            // 
            this.lb_disciplinas.FormattingEnabled = true;
            this.lb_disciplinas.ItemHeight = 19;
            this.lb_disciplinas.Location = new System.Drawing.Point(26, 52);
            this.lb_disciplinas.Name = "lb_disciplinas";
            this.lb_disciplinas.Size = new System.Drawing.Size(120, 251);
            this.lb_disciplinas.TabIndex = 0;
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(153, 52);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(83, 19);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "Disciplinas";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(157, 113);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(139, 29);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicioanar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(157, 152);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(139, 28);
            this.btn_remover.TabIndex = 3;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(157, 186);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(139, 28);
            this.btn_obter.TabIndex = 4;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // tb_disciplina
            // 
            this.tb_disciplina.Location = new System.Drawing.Point(157, 81);
            this.tb_disciplina.Name = "tb_disciplina";
            this.tb_disciplina.Size = new System.Drawing.Size(139, 26);
            this.tb_disciplina.TabIndex = 5;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(161, 220);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(135, 29);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(161, 256);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(135, 27);
            this.btn_resetar.TabIndex = 7;
            this.btn_resetar.Text = "Resetar";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 465);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_disciplina);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.lb_disciplinas);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.F_ListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_disciplinas;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.TextBox tb_disciplina;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetar;
    }
}