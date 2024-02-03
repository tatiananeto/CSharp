namespace aula_pratica
{
    partial class F_CheckBox
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
            this.cb_tlp = new System.Windows.Forms.CheckBox();
            this.cb_tic = new System.Windows.Forms.CheckBox();
            this.cb_seac = new System.Windows.Forms.CheckBox();
            this.cb_oge = new System.Windows.Forms.CheckBox();
            this.cb_mdsw = new System.Windows.Forms.CheckBox();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.lb_texto = new System.Windows.Forms.Label();
            this.btn_abrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_tlp
            // 
            this.cb_tlp.AutoSize = true;
            this.cb_tlp.Location = new System.Drawing.Point(33, 73);
            this.cb_tlp.Name = "cb_tlp";
            this.cb_tlp.Size = new System.Drawing.Size(55, 23);
            this.cb_tlp.TabIndex = 0;
            this.cb_tlp.Text = "TLP";
            this.cb_tlp.UseVisualStyleBackColor = true;
            // 
            // cb_tic
            // 
            this.cb_tic.AutoSize = true;
            this.cb_tic.Location = new System.Drawing.Point(33, 103);
            this.cb_tic.Name = "cb_tic";
            this.cb_tic.Size = new System.Drawing.Size(51, 23);
            this.cb_tic.TabIndex = 1;
            this.cb_tic.Text = "TIC";
            this.cb_tic.UseVisualStyleBackColor = true;
            // 
            // cb_seac
            // 
            this.cb_seac.AutoSize = true;
            this.cb_seac.Location = new System.Drawing.Point(31, 161);
            this.cb_seac.Name = "cb_seac";
            this.cb_seac.Size = new System.Drawing.Size(64, 23);
            this.cb_seac.TabIndex = 2;
            this.cb_seac.Text = "SEAC";
            this.cb_seac.UseVisualStyleBackColor = true;
            // 
            // cb_oge
            // 
            this.cb_oge.AutoSize = true;
            this.cb_oge.Location = new System.Drawing.Point(31, 132);
            this.cb_oge.Name = "cb_oge";
            this.cb_oge.Size = new System.Drawing.Size(53, 23);
            this.cb_oge.TabIndex = 3;
            this.cb_oge.Text = "OGI";
            this.cb_oge.UseVisualStyleBackColor = true;
            // 
            // cb_mdsw
            // 
            this.cb_mdsw.AutoSize = true;
            this.cb_mdsw.Location = new System.Drawing.Point(33, 242);
            this.cb_mdsw.Name = "cb_mdsw";
            this.cb_mdsw.Size = new System.Drawing.Size(75, 23);
            this.cb_mdsw.TabIndex = 4;
            this.cb_mdsw.Text = "MDSW";
            this.cb_mdsw.UseVisualStyleBackColor = true;
            this.cb_mdsw.CheckedChanged += new System.EventHandler(this.cb_mdsw_CheckedChanged);
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(270, 73);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(223, 38);
            this.btn_verificar.TabIndex = 5;
            this.btn_verificar.Text = "Verificar disciplinas marcadas";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.Color.Maroon;
            this.lb_texto.Location = new System.Drawing.Point(33, 24);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(336, 22);
            this.lb_texto.TabIndex = 6;
            this.lb_texto.Text = "Marcar as disciplinas que mais gostas";
            // 
            // btn_abrir
            // 
            this.btn_abrir.Location = new System.Drawing.Point(270, 118);
            this.btn_abrir.Name = "btn_abrir";
            this.btn_abrir.Size = new System.Drawing.Size(223, 37);
            this.btn_abrir.TabIndex = 7;
            this.btn_abrir.Text = "Abrir o formulario auxiliar";
            this.btn_abrir.UseVisualStyleBackColor = true;
            this.btn_abrir.Click += new System.EventHandler(this.btn_abrir_Click);
            // 
            // F_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 455);
            this.Controls.Add(this.btn_abrir);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.cb_mdsw);
            this.Controls.Add(this.cb_oge);
            this.Controls.Add(this.cb_seac);
            this.Controls.Add(this.cb_tic);
            this.Controls.Add(this.cb_tlp);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_mdsw;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Label lb_texto;
        public System.Windows.Forms.CheckBox cb_tlp;
        public System.Windows.Forms.CheckBox cb_tic;
        public System.Windows.Forms.CheckBox cb_seac;
        public System.Windows.Forms.CheckBox cb_oge;
        private System.Windows.Forms.Button btn_abrir;
    }
}