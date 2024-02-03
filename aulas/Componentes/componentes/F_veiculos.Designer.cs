namespace componentes
{
    partial class F_veiculos
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
            this.tb_listaveiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_listaveiculo
            // 
            this.tb_listaveiculo.Location = new System.Drawing.Point(27, 12);
            this.tb_listaveiculo.Multiline = true;
            this.tb_listaveiculo.Name = "tb_listaveiculo";
            this.tb_listaveiculo.Size = new System.Drawing.Size(290, 426);
            this.tb_listaveiculo.TabIndex = 0;
            this.tb_listaveiculo.TextChanged += new System.EventHandler(this.tb_listaveiculo_TextChanged);
            // 
            // F_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 450);
            this.Controls.Add(this.tb_listaveiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_de_veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_listaveiculo;
    }
}