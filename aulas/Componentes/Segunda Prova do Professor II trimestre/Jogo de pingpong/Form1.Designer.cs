namespace Jogo_de_pingpong
{
    partial class Form1
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
            this.btn_facil = new System.Windows.Forms.Button();
            this.btn_medio = new System.Windows.Forms.Button();
            this.btn_dificil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_facil
            // 
            this.btn_facil.BackColor = System.Drawing.Color.Lime;
            this.btn_facil.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facil.Location = new System.Drawing.Point(111, 140);
            this.btn_facil.Name = "btn_facil";
            this.btn_facil.Size = new System.Drawing.Size(180, 41);
            this.btn_facil.TabIndex = 0;
            this.btn_facil.Text = "Fácil";
            this.btn_facil.UseVisualStyleBackColor = false;
            this.btn_facil.Click += new System.EventHandler(this.btn_facil_Click);
            // 
            // btn_medio
            // 
            this.btn_medio.BackColor = System.Drawing.Color.Gold;
            this.btn_medio.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medio.Location = new System.Drawing.Point(111, 207);
            this.btn_medio.Name = "btn_medio";
            this.btn_medio.Size = new System.Drawing.Size(180, 41);
            this.btn_medio.TabIndex = 1;
            this.btn_medio.Text = "Médio";
            this.btn_medio.UseVisualStyleBackColor = false;
            this.btn_medio.Click += new System.EventHandler(this.btn_medio_Click);
            // 
            // btn_dificil
            // 
            this.btn_dificil.BackColor = System.Drawing.Color.Red;
            this.btn_dificil.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dificil.Location = new System.Drawing.Point(111, 275);
            this.btn_dificil.Name = "btn_dificil";
            this.btn_dificil.Size = new System.Drawing.Size(180, 41);
            this.btn_dificil.TabIndex = 2;
            this.btn_dificil.Text = "Díficil";
            this.btn_dificil.UseVisualStyleBackColor = false;
            this.btn_dificil.Click += new System.EventHandler(this.btn_dificil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Escolha o teu nível do jogo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 397);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_dificil);
            this.Controls.Add(this.btn_medio);
            this.Controls.Add(this.btn_facil);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Ping Pong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_facil;
        private System.Windows.Forms.Button btn_medio;
        private System.Windows.Forms.Button btn_dificil;
        private System.Windows.Forms.Label label2;
    }
}

