namespace aula_pratica
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "TLP",
            "GSI10APM",
            "45"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "TIC",
            "GSI11APT",
            "37"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "SEAC",
            "GSI10BPM",
            "46"}, -1);
            this.lv_disciplinas = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_disciplinas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_turma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtd_alunos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_disciplinas = new System.Windows.Forms.TextBox();
            this.tb_turmas = new System.Windows.Forms.TextBox();
            this.tb_qtd_alunos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_disciplinas
            // 
            this.lv_disciplinas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_disciplinas,
            this.col_turma,
            this.col_qtd_alunos});
            this.lv_disciplinas.FullRowSelect = true;
            this.lv_disciplinas.HideSelection = false;
            this.lv_disciplinas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_disciplinas.Location = new System.Drawing.Point(11, 15);
            this.lv_disciplinas.MultiSelect = false;
            this.lv_disciplinas.Name = "lv_disciplinas";
            this.lv_disciplinas.Size = new System.Drawing.Size(525, 178);
            this.lv_disciplinas.TabIndex = 0;
            this.lv_disciplinas.UseCompatibleStateImageBehavior = false;
            this.lv_disciplinas.View = System.Windows.Forms.View.Details;
            this.lv_disciplinas.SelectedIndexChanged += new System.EventHandler(this.lv_disciplinas_SelectedIndexChanged);
            // 
            // col_id
            // 
            this.col_id.Text = "Id";
            this.col_id.Width = 40;
            // 
            // col_disciplinas
            // 
            this.col_disciplinas.Text = "Disciplina";
            this.col_disciplinas.Width = 200;
            // 
            // col_turma
            // 
            this.col_turma.Text = "Turmas";
            this.col_turma.Width = 150;
            // 
            // col_qtd_alunos
            // 
            this.col_qtd_alunos.Text = "Qtd de alunos";
            this.col_qtd_alunos.Width = 130;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 239);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(58, 26);
            this.tb_id.TabIndex = 1;
            // 
            // tb_disciplinas
            // 
            this.tb_disciplinas.Location = new System.Drawing.Point(75, 239);
            this.tb_disciplinas.Name = "tb_disciplinas";
            this.tb_disciplinas.Size = new System.Drawing.Size(150, 26);
            this.tb_disciplinas.TabIndex = 2;
            // 
            // tb_turmas
            // 
            this.tb_turmas.Location = new System.Drawing.Point(230, 239);
            this.tb_turmas.Name = "tb_turmas";
            this.tb_turmas.Size = new System.Drawing.Size(99, 26);
            this.tb_turmas.TabIndex = 3;
            // 
            // tb_qtd_alunos
            // 
            this.tb_qtd_alunos.Location = new System.Drawing.Point(334, 239);
            this.tb_qtd_alunos.Name = "tb_qtd_alunos";
            this.tb_qtd_alunos.Size = new System.Drawing.Size(148, 26);
            this.tb_qtd_alunos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disciplinas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Turma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Qtd de alunos";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(12, 280);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(103, 34);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(12, 320);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(103, 32);
            this.btn_remover.TabIndex = 10;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(11, 358);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(104, 29);
            this.btn_obter.TabIndex = 11;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 463);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_qtd_alunos);
            this.Controls.Add(this.tb_turmas);
            this.Controls.Add(this.tb_disciplinas);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lv_disciplinas);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_disciplinas;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_disciplinas;
        private System.Windows.Forms.ColumnHeader col_turma;
        private System.Windows.Forms.ColumnHeader col_qtd_alunos;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_disciplinas;
        private System.Windows.Forms.TextBox tb_turmas;
        private System.Windows.Forms.TextBox tb_qtd_alunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
    }
}