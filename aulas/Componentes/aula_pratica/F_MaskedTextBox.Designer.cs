namespace aula_pratica
{
    partial class F_MaskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_nif = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.cb_somente_texto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(34, 62);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(160, 26);
            this.mtb_senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(34, 122);
            this.mtb_telefone.Mask = "(+244) 000 000 000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(160, 26);
            this.mtb_telefone.TabIndex = 2;
            // 
            // mtb_nif
            // 
            this.mtb_nif.Location = new System.Drawing.Point(34, 187);
            this.mtb_nif.Mask = "000000000 LA 000";
            this.mtb_nif.Name = "mtb_nif";
            this.mtb_nif.Size = new System.Drawing.Size(160, 26);
            this.mtb_nif.TabIndex = 3;
            this.mtb_nif.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NIF";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(334, 187);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 31);
            this.btn_mostrar.TabIndex = 6;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // cb_somente_texto
            // 
            this.cb_somente_texto.AutoSize = true;
            this.cb_somente_texto.Location = new System.Drawing.Point(201, 192);
            this.cb_somente_texto.Name = "cb_somente_texto";
            this.cb_somente_texto.Size = new System.Drawing.Size(127, 23);
            this.cb_somente_texto.TabIndex = 7;
            this.cb_somente_texto.Text = "Somente texto";
            this.cb_somente_texto.UseVisualStyleBackColor = true;
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 460);
            this.Controls.Add(this.cb_somente_texto);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_nif);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_senha);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "F_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.MaskedTextBox mtb_nif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.CheckBox cb_somente_texto;
    }
}