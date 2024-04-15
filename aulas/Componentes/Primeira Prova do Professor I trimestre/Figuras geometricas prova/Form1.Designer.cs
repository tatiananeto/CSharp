namespace Figuras_geometricas_prova
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.lb_titulo = new System.Windows.Forms.Label();
            this.quadrado = new System.Windows.Forms.Button();
            this.retangulo = new System.Windows.Forms.Button();
            this.triangulo = new System.Windows.Forms.Button();
            this.circlo = new System.Windows.Forms.Button();
            this.lb_quadrado = new System.Windows.Forms.Label();
            this.lb_retangulo = new System.Windows.Forms.Label();
            this.lb_triangulo = new System.Windows.Forms.Label();
            this.lb_circlo = new System.Windows.Forms.Label();
            this.lb_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(127, 25);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(219, 25);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Figuras Geometricas ";
            this.lb_titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // quadrado
            // 
            this.quadrado.Image = ((System.Drawing.Image)(resources.GetObject("quadrado.Image")));
            this.quadrado.Location = new System.Drawing.Point(61, 138);
            this.quadrado.Name = "quadrado";
            this.quadrado.Size = new System.Drawing.Size(93, 93);
            this.quadrado.TabIndex = 1;
            this.quadrado.UseVisualStyleBackColor = true;
            this.quadrado.Click += new System.EventHandler(this.quadrado_Click);
            // 
            // retangulo
            // 
            this.retangulo.Image = ((System.Drawing.Image)(resources.GetObject("retangulo.Image")));
            this.retangulo.Location = new System.Drawing.Point(266, 293);
            this.retangulo.Name = "retangulo";
            this.retangulo.Size = new System.Drawing.Size(132, 93);
            this.retangulo.TabIndex = 2;
            this.retangulo.UseVisualStyleBackColor = true;
            this.retangulo.Click += new System.EventHandler(this.retangulo_Click);
            // 
            // triangulo
            // 
            this.triangulo.Image = ((System.Drawing.Image)(resources.GetObject("triangulo.Image")));
            this.triangulo.Location = new System.Drawing.Point(61, 292);
            this.triangulo.Name = "triangulo";
            this.triangulo.Size = new System.Drawing.Size(93, 94);
            this.triangulo.TabIndex = 3;
            this.triangulo.UseVisualStyleBackColor = true;
            this.triangulo.Click += new System.EventHandler(this.triangulo_Click);
            // 
            // circlo
            // 
            this.circlo.Image = ((System.Drawing.Image)(resources.GetObject("circlo.Image")));
            this.circlo.Location = new System.Drawing.Point(289, 138);
            this.circlo.Name = "circlo";
            this.circlo.Size = new System.Drawing.Size(93, 93);
            this.circlo.TabIndex = 4;
            this.circlo.UseVisualStyleBackColor = true;
            this.circlo.Click += new System.EventHandler(this.circlo_Click);
            // 
            // lb_quadrado
            // 
            this.lb_quadrado.AutoSize = true;
            this.lb_quadrado.Location = new System.Drawing.Point(63, 234);
            this.lb_quadrado.Name = "lb_quadrado";
            this.lb_quadrado.Size = new System.Drawing.Size(91, 22);
            this.lb_quadrado.TabIndex = 5;
            this.lb_quadrado.Text = "Quadrado";
            // 
            // lb_retangulo
            // 
            this.lb_retangulo.AutoSize = true;
            this.lb_retangulo.Location = new System.Drawing.Point(290, 389);
            this.lb_retangulo.Name = "lb_retangulo";
            this.lb_retangulo.Size = new System.Drawing.Size(92, 22);
            this.lb_retangulo.TabIndex = 6;
            this.lb_retangulo.Text = "Retângulo";
            // 
            // lb_triangulo
            // 
            this.lb_triangulo.AutoSize = true;
            this.lb_triangulo.Location = new System.Drawing.Point(63, 389);
            this.lb_triangulo.Name = "lb_triangulo";
            this.lb_triangulo.Size = new System.Drawing.Size(88, 22);
            this.lb_triangulo.TabIndex = 7;
            this.lb_triangulo.Text = "Triângulo";
            // 
            // lb_circlo
            // 
            this.lb_circlo.AutoSize = true;
            this.lb_circlo.Location = new System.Drawing.Point(307, 234);
            this.lb_circlo.Name = "lb_circlo";
            this.lb_circlo.Size = new System.Drawing.Size(57, 22);
            this.lb_circlo.TabIndex = 8;
            this.lb_circlo.Text = "Circlo";
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(88, 81);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(276, 22);
            this.lb_texto.TabIndex = 9;
            this.lb_texto.Text = "Escolha uma figura para calcular:";
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 471);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.lb_circlo);
            this.Controls.Add(this.lb_triangulo);
            this.Controls.Add(this.lb_retangulo);
            this.Controls.Add(this.lb_quadrado);
            this.Controls.Add(this.circlo);
            this.Controls.Add(this.triangulo);
            this.Controls.Add(this.retangulo);
            this.Controls.Add(this.quadrado);
            this.Controls.Add(this.lb_titulo);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FIguras Geometricas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Button quadrado;
        private System.Windows.Forms.Button retangulo;
        private System.Windows.Forms.Button triangulo;
        private System.Windows.Forms.Button circlo;
        private System.Windows.Forms.Label lb_quadrado;
        private System.Windows.Forms.Label lb_retangulo;
        private System.Windows.Forms.Label lb_triangulo;
        private System.Windows.Forms.Label lb_circlo;
        private System.Windows.Forms.Label lb_texto;
    }
}

