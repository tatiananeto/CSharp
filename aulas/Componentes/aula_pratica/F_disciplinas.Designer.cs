namespace aula_pratica
{
    partial class F_Disciplinas
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
            this.tb_lista_disciplinas = new System.Windows.Forms.TextBox();
            this.lb_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_lista_disciplinas
            // 
            this.tb_lista_disciplinas.Location = new System.Drawing.Point(88, 87);
            this.tb_lista_disciplinas.Multiline = true;
            this.tb_lista_disciplinas.Name = "tb_lista_disciplinas";
            this.tb_lista_disciplinas.Size = new System.Drawing.Size(332, 289);
            this.tb_lista_disciplinas.TabIndex = 0;
            this.tb_lista_disciplinas.TextChanged += new System.EventHandler(this.tb_lista_disciplinas_TextChanged_1);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.Color.Maroon;
            this.lb_texto.Location = new System.Drawing.Point(84, 46);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(106, 22);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "Disciplinas";
            // 
            // F_Disciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 455);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.tb_lista_disciplinas);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Disciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Disciplinas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Disciplinas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_texto;
        public System.Windows.Forms.TextBox tb_lista_disciplinas;
    }
}