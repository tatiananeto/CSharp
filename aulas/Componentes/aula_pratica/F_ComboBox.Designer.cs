namespace aula_pratica
{
    partial class F_ComboBox
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
            this.cb_disciplina = new System.Windows.Forms.ComboBox();
            this.btn_mostar_seleccionado = new System.Windows.Forms.Button();
            this.btn_limpar_elementos = new System.Windows.Forms.Button();
            this.btn_resetar_elemento = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_disciplina
            // 
            this.cb_disciplina.FormattingEnabled = true;
            this.cb_disciplina.Items.AddRange(new object[] {
            "TLP",
            "TIC",
            "OGE",
            "SEAC",
            "MDSW"});
            this.cb_disciplina.Location = new System.Drawing.Point(26, 62);
            this.cb_disciplina.Name = "cb_disciplina";
            this.cb_disciplina.Size = new System.Drawing.Size(267, 27);
            this.cb_disciplina.TabIndex = 0;
            this.cb_disciplina.SelectedIndexChanged += new System.EventHandler(this.cb_disciplina_SelectedIndexChanged);
            // 
            // btn_mostar_seleccionado
            // 
            this.btn_mostar_seleccionado.Location = new System.Drawing.Point(321, 62);
            this.btn_mostar_seleccionado.Name = "btn_mostar_seleccionado";
            this.btn_mostar_seleccionado.Size = new System.Drawing.Size(199, 27);
            this.btn_mostar_seleccionado.TabIndex = 1;
            this.btn_mostar_seleccionado.Text = "Mostrar seleccionado";
            this.btn_mostar_seleccionado.UseVisualStyleBackColor = true;
            this.btn_mostar_seleccionado.Click += new System.EventHandler(this.btn_mostar_seleccionado_Click);
            // 
            // btn_limpar_elementos
            // 
            this.btn_limpar_elementos.Location = new System.Drawing.Point(321, 112);
            this.btn_limpar_elementos.Name = "btn_limpar_elementos";
            this.btn_limpar_elementos.Size = new System.Drawing.Size(199, 29);
            this.btn_limpar_elementos.TabIndex = 2;
            this.btn_limpar_elementos.Text = "Limpar elementos";
            this.btn_limpar_elementos.UseVisualStyleBackColor = true;
            this.btn_limpar_elementos.Click += new System.EventHandler(this.btn_limpar_elementos_Click);
            // 
            // btn_resetar_elemento
            // 
            this.btn_resetar_elemento.Location = new System.Drawing.Point(321, 157);
            this.btn_resetar_elemento.Name = "btn_resetar_elemento";
            this.btn_resetar_elemento.Size = new System.Drawing.Size(199, 27);
            this.btn_resetar_elemento.TabIndex = 3;
            this.btn_resetar_elemento.Text = "Resetar elementos";
            this.btn_resetar_elemento.UseVisualStyleBackColor = true;
            this.btn_resetar_elemento.Click += new System.EventHandler(this.btn_resetar_elemento_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(321, 227);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(199, 37);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar nova disciplina";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_texto
            // 
            this.tb_texto.Location = new System.Drawing.Point(26, 233);
            this.tb_texto.Name = "tb_texto";
            this.tb_texto.Size = new System.Drawing.Size(267, 26);
            this.tb_texto.TabIndex = 5;
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 462);
            this.Controls.Add(this.tb_texto);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_resetar_elemento);
            this.Controls.Add(this.btn_limpar_elementos);
            this.Controls.Add(this.btn_mostar_seleccionado);
            this.Controls.Add(this.cb_disciplina);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_disciplina;
        private System.Windows.Forms.Button btn_mostar_seleccionado;
        private System.Windows.Forms.Button btn_limpar_elementos;
        private System.Windows.Forms.Button btn_resetar_elemento;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_texto;
    }
}