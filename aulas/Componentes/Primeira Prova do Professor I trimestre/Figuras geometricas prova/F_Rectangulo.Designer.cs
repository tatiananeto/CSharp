namespace Figuras_geometricas_prova
{
    partial class F_Rectangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Rectangulo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.tb_base = new System.Windows.Forms.TextBox();
            this.lb_base = new System.Windows.Forms.Label();
            this.tb_altura = new System.Windows.Forms.TextBox();
            this.lb_altura = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rectângulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Um retângulo é um quadrilátero que possui \r\ntodos os ângulos internos congruentes" +
    ". ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "A área do retângulo é calculada multiplicando \r\na medida da sua base pela medida " +
    "da altura.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(186, 112);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(103, 22);
            this.lb_resultado.TabIndex = 14;
            this.lb_resultado.Text = "Resultado:";
            // 
            // tb_resultado
            // 
            this.tb_resultado.Location = new System.Drawing.Point(286, 109);
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(100, 30);
            this.tb_resultado.TabIndex = 13;
            // 
            // tb_base
            // 
            this.tb_base.Location = new System.Drawing.Point(286, 37);
            this.tb_base.Name = "tb_base";
            this.tb_base.Size = new System.Drawing.Size(100, 30);
            this.tb_base.TabIndex = 12;
            this.tb_base.TextChanged += new System.EventHandler(this.tb_base_TextChanged);
            // 
            // lb_base
            // 
            this.lb_base.AutoSize = true;
            this.lb_base.Location = new System.Drawing.Point(229, 37);
            this.lb_base.Name = "lb_base";
            this.lb_base.Size = new System.Drawing.Size(56, 22);
            this.lb_base.TabIndex = 11;
            this.lb_base.Text = "Base:";
            this.lb_base.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_altura
            // 
            this.tb_altura.Location = new System.Drawing.Point(286, 73);
            this.tb_altura.Name = "tb_altura";
            this.tb_altura.Size = new System.Drawing.Size(100, 30);
            this.tb_altura.TabIndex = 16;
            this.tb_altura.TextChanged += new System.EventHandler(this.tb_altura_TextChanged);
            // 
            // lb_altura
            // 
            this.lb_altura.AutoSize = true;
            this.lb_altura.Location = new System.Drawing.Point(216, 76);
            this.lb_altura.Name = "lb_altura";
            this.lb_altura.Size = new System.Drawing.Size(70, 22);
            this.lb_altura.TabIndex = 15;
            this.lb_altura.Text = "Altura:";
            this.lb_altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tb_altura);
            this.groupBox1.Controls.Add(this.lb_base);
            this.groupBox1.Controls.Add(this.lb_altura);
            this.groupBox1.Controls.Add(this.tb_base);
            this.groupBox1.Controls.Add(this.lb_resultado);
            this.groupBox1.Controls.Add(this.tb_resultado);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox1.Location = new System.Drawing.Point(17, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 164);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculo da Area do Rectânulo";
            // 
            // F_Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 469);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "F_Rectangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ared do Rectangulo";
            this.Load += new System.EventHandler(this.F_Rectangulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_resultado;
        private System.Windows.Forms.TextBox tb_resultado;
        private System.Windows.Forms.TextBox tb_base;
        private System.Windows.Forms.Label lb_base;
        private System.Windows.Forms.TextBox tb_altura;
        private System.Windows.Forms.Label lb_altura;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}