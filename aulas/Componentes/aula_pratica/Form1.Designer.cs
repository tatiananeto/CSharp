﻿namespace aula_pratica
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
            this.lb_disciplina = new System.Windows.Forms.Label();
            this.tb_disciplinas = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_lista_disciplinas = new System.Windows.Forms.TextBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_mostar_disciplinas = new System.Windows.Forms.Button();
            this.btn_valor_num = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_disciplina
            // 
            this.lb_disciplina.AutoSize = true;
            this.lb_disciplina.BackColor = System.Drawing.Color.Transparent;
            this.lb_disciplina.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_disciplina.Location = new System.Drawing.Point(19, 56);
            this.lb_disciplina.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_disciplina.Name = "lb_disciplina";
            this.lb_disciplina.Size = new System.Drawing.Size(152, 19);
            this.lb_disciplina.TabIndex = 0;
            this.lb_disciplina.Text = "Digite uma disciplina";
            this.lb_disciplina.Click += new System.EventHandler(this.lb_disciplina_Click);
            // 
            // tb_disciplinas
            // 
            this.tb_disciplinas.Location = new System.Drawing.Point(23, 92);
            this.tb_disciplinas.Name = "tb_disciplinas";
            this.tb_disciplinas.Size = new System.Drawing.Size(232, 26);
            this.tb_disciplinas.TabIndex = 1;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(304, 92);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(95, 26);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_lista_disciplinas
            // 
            this.tb_lista_disciplinas.Location = new System.Drawing.Point(23, 149);
            this.tb_lista_disciplinas.Multiline = true;
            this.tb_lista_disciplinas.Name = "tb_lista_disciplinas";
            this.tb_lista_disciplinas.ReadOnly = true;
            this.tb_lista_disciplinas.Size = new System.Drawing.Size(232, 178);
            this.tb_lista_disciplinas.TabIndex = 3;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(52, 335);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(184, 30);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_mostar_disciplinas
            // 
            this.btn_mostar_disciplinas.Location = new System.Drawing.Point(52, 371);
            this.btn_mostar_disciplinas.Name = "btn_mostar_disciplinas";
            this.btn_mostar_disciplinas.Size = new System.Drawing.Size(184, 31);
            this.btn_mostar_disciplinas.TabIndex = 5;
            this.btn_mostar_disciplinas.Text = "Mostrar disciplinas";
            this.btn_mostar_disciplinas.UseVisualStyleBackColor = true;
            this.btn_mostar_disciplinas.Click += new System.EventHandler(this.btn_mostar_disciplinas_Click);
            // 
            // btn_valor_num
            // 
            this.btn_valor_num.Location = new System.Drawing.Point(52, 409);
            this.btn_valor_num.Name = "btn_valor_num";
            this.btn_valor_num.Size = new System.Drawing.Size(184, 29);
            this.btn_valor_num.TabIndex = 6;
            this.btn_valor_num.Text = "Valor da variável num";
            this.btn_valor_num.UseVisualStyleBackColor = true;
            this.btn_valor_num.Click += new System.EventHandler(this.btn_valor_num_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 27);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem,
            this.listBoxToolStripMenuItem});
            this.componentesToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(116, 23);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // listBoxToolStripMenuItem
            // 
            this.listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            this.listBoxToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.listBoxToolStripMenuItem.Text = "ListBox";
            this.listBoxToolStripMenuItem.Click += new System.EventHandler(this.listBoxToolStripMenuItem_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 461);
            this.Controls.Add(this.btn_valor_num);
            this.Controls.Add(this.btn_mostar_disciplinas);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.tb_lista_disciplinas);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_disciplinas);
            this.Controls.Add(this.lb_disciplina);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplinas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_disciplina;
        private System.Windows.Forms.TextBox tb_disciplinas;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_mostar_disciplinas;
        private System.Windows.Forms.Button btn_valor_num;
        public System.Windows.Forms.TextBox tb_lista_disciplinas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBoxToolStripMenuItem;
    }
}

