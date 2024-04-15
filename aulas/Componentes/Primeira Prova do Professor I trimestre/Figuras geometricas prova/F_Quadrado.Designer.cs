namespace Figuras_geometricas_prova
{
    partial class F_Quadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Quadrado));
            this.lb_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_texto = new System.Windows.Forms.Label();
            this.lb_lados = new System.Windows.Forms.Label();
            this.tb_comprimento = new System.Windows.Forms.TextBox();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.Location = new System.Drawing.Point(167, 26);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(110, 25);
            this.lb_text.TabIndex = 0;
            this.lb_text.Text = "Quadrado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(8, 66);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(435, 154);
            this.lb_texto.TabIndex = 2;
            this.lb_texto.Text = resources.GetString("lb_texto.Text");
            this.lb_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_lados
            // 
            this.lb_lados.AutoSize = true;
            this.lb_lados.Location = new System.Drawing.Point(142, 52);
            this.lb_lados.Name = "lb_lados";
            this.lb_lados.Size = new System.Drawing.Size(136, 22);
            this.lb_lados.TabIndex = 3;
            this.lb_lados.Text = "Comprimento:";
            this.lb_lados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_comprimento
            // 
            this.tb_comprimento.Location = new System.Drawing.Point(276, 49);
            this.tb_comprimento.Name = "tb_comprimento";
            this.tb_comprimento.Size = new System.Drawing.Size(100, 30);
            this.tb_comprimento.TabIndex = 4;
            this.tb_comprimento.TextChanged += new System.EventHandler(this.tb_comprimento_TextChanged);
            // 
            // tb_resultado
            // 
            this.tb_resultado.Location = new System.Drawing.Point(276, 105);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(100, 30);
            this.tb_resultado.TabIndex = 5;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(158, 108);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(103, 22);
            this.lb_resultado.TabIndex = 6;
            this.lb_resultado.Text = "Resultado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_comprimento);
            this.groupBox1.Controls.Add(this.lb_resultado);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tb_resultado);
            this.groupBox1.Controls.Add(this.lb_lados);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(24, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo da Area do Quadrado";
            // 
            // F_Quadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.lb_text);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "F_Quadrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area do Quadrado";
            this.Load += new System.EventHandler(this.F_Quadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.Label lb_lados;
        private System.Windows.Forms.TextBox tb_comprimento;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}