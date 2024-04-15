namespace Figuras_geometricas_prova
{
    partial class F_Circlo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Circlo));
            this.lb_circlo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.tb_raio = new System.Windows.Forms.TextBox();
            this.lb_raio = new System.Windows.Forms.Label();
            this.lb_texto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_circlo
            // 
            this.lb_circlo.AutoSize = true;
            this.lb_circlo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_circlo.Location = new System.Drawing.Point(178, 32);
            this.lb_circlo.Name = "lb_circlo";
            this.lb_circlo.Size = new System.Drawing.Size(69, 25);
            this.lb_circlo.TabIndex = 0;
            this.lb_circlo.Text = "Circlo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "A área do círculo é a medida de sua superfície. \r\nDado um círculo de raio r, sua " +
    "área A é determinada\r\n pela expressão: (A=pi r^2) ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(172, 114);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(103, 22);
            this.lb_resultado.TabIndex = 10;
            this.lb_resultado.Text = "Resultado:";
            // 
            // tb_resultado
            // 
            this.tb_resultado.Location = new System.Drawing.Point(274, 111);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(100, 30);
            this.tb_resultado.TabIndex = 9;
            // 
            // tb_raio
            // 
            this.tb_raio.Location = new System.Drawing.Point(274, 55);
            this.tb_raio.Name = "tb_raio";
            this.tb_raio.Size = new System.Drawing.Size(100, 30);
            this.tb_raio.TabIndex = 8;
            this.tb_raio.TextChanged += new System.EventHandler(this.tb_raio_TextChanged);
            // 
            // lb_raio
            // 
            this.lb_raio.AutoSize = true;
            this.lb_raio.Location = new System.Drawing.Point(217, 55);
            this.lb_raio.Name = "lb_raio";
            this.lb_raio.Size = new System.Drawing.Size(55, 22);
            this.lb_raio.TabIndex = 7;
            this.lb_raio.Text = "Raio:";
            this.lb_raio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(12, 89);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(411, 44);
            this.lb_texto.TabIndex = 1;
            this.lb_texto.Text = "Na geometria, um círculo é o conjunto dos pontos \r\ninternos de uma circunferência" +
    ". ";
            this.lb_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lb_resultado);
            this.groupBox1.Controls.Add(this.lb_raio);
            this.groupBox1.Controls.Add(this.tb_resultado);
            this.groupBox1.Controls.Add(this.tb_raio);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.groupBox1.Location = new System.Drawing.Point(19, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 175);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo da Area do Circlo";
            // 
            // F_Circlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 467);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.lb_circlo);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "F_Circlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area do Circlo";
            this.Load += new System.EventHandler(this.F_Circlo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_circlo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.TextBox tb_raio;
        private System.Windows.Forms.Label lb_raio;
        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}