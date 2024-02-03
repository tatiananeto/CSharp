namespace aula_pratica
{
    partial class F_Aux_CheckBox
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
            this.lb_texto = new System.Windows.Forms.Label();
            this.cb_oge = new System.Windows.Forms.CheckBox();
            this.cb_seac = new System.Windows.Forms.CheckBox();
            this.cb_tic = new System.Windows.Forms.CheckBox();
            this.cb_tlp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_texto.ForeColor = System.Drawing.Color.Maroon;
            this.lb_texto.Location = new System.Drawing.Point(12, 44);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(524, 22);
            this.lb_texto.TabIndex = 12;
            this.lb_texto.Text = "Relacionar as disciplinas marcadas com o outro formulario";
            // 
            // cb_oge
            // 
            this.cb_oge.AutoSize = true;
            this.cb_oge.Location = new System.Drawing.Point(43, 158);
            this.cb_oge.Name = "cb_oge";
            this.cb_oge.Size = new System.Drawing.Size(53, 23);
            this.cb_oge.TabIndex = 10;
            this.cb_oge.Text = "OGI";
            this.cb_oge.UseVisualStyleBackColor = true;
            this.cb_oge.CheckedChanged += new System.EventHandler(this.cb_oge_CheckedChanged);
            // 
            // cb_seac
            // 
            this.cb_seac.AutoSize = true;
            this.cb_seac.Location = new System.Drawing.Point(43, 187);
            this.cb_seac.Name = "cb_seac";
            this.cb_seac.Size = new System.Drawing.Size(64, 23);
            this.cb_seac.TabIndex = 9;
            this.cb_seac.Text = "SEAC";
            this.cb_seac.UseVisualStyleBackColor = true;
            this.cb_seac.CheckedChanged += new System.EventHandler(this.cb_seac_CheckedChanged);
            // 
            // cb_tic
            // 
            this.cb_tic.AutoSize = true;
            this.cb_tic.Location = new System.Drawing.Point(45, 129);
            this.cb_tic.Name = "cb_tic";
            this.cb_tic.Size = new System.Drawing.Size(51, 23);
            this.cb_tic.TabIndex = 8;
            this.cb_tic.Text = "TIC";
            this.cb_tic.UseVisualStyleBackColor = true;
            this.cb_tic.CheckedChanged += new System.EventHandler(this.cb_tic_CheckedChanged);
            // 
            // cb_tlp
            // 
            this.cb_tlp.AutoSize = true;
            this.cb_tlp.Location = new System.Drawing.Point(45, 99);
            this.cb_tlp.Name = "cb_tlp";
            this.cb_tlp.Size = new System.Drawing.Size(55, 23);
            this.cb_tlp.TabIndex = 7;
            this.cb_tlp.Text = "TLP";
            this.cb_tlp.UseVisualStyleBackColor = true;
            this.cb_tlp.CheckedChanged += new System.EventHandler(this.cb_tlp_CheckedChanged);
            // 
            // F_Aux_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 451);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.cb_oge);
            this.Controls.Add(this.cb_seac);
            this.Controls.Add(this.cb_tic);
            this.Controls.Add(this.cb_tlp);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_Aux_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Aux_CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_texto;
        private System.Windows.Forms.CheckBox cb_oge;
        private System.Windows.Forms.CheckBox cb_seac;
        private System.Windows.Forms.CheckBox cb_tic;
        private System.Windows.Forms.CheckBox cb_tlp;
    }
}