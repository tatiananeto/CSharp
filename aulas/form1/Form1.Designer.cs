namespace form1
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ang");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("taxi");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_aula1 = new System.Windows.Forms.Button();
            this.lb_link = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_aula1
            // 
            this.btn_aula1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_aula1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aula1.ForeColor = System.Drawing.Color.Black;
            this.btn_aula1.Location = new System.Drawing.Point(102, 107);
            this.btn_aula1.Margin = new System.Windows.Forms.Padding(9, 6, 8, 10);
            this.btn_aula1.Name = "btn_aula1";
            this.btn_aula1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 3);
            this.btn_aula1.Size = new System.Drawing.Size(214, 47);
            this.btn_aula1.TabIndex = 0;
            this.btn_aula1.Text = "OK";
            this.btn_aula1.UseVisualStyleBackColor = false;
            this.btn_aula1.Click += new System.EventHandler(this.btn_aula1_Click);
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(129, 173);
            this.lb_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(155, 22);
            this.lb_link.TabIndex = 1;
            this.lb_link.Text = "Ola mundo em C#";
            this.lb_link.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(102, 69);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(214, 30);
            this.tb_nome.TabIndex = 2;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 22;
            this.listbox.Items.AddRange(new object[] {
            "angola",
            "egipto",
            "franca"});
            this.listbox.Location = new System.Drawing.Point(624, 452);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(133, 92);
            this.listbox.TabIndex = 3;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(623, 327);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Nó1";
            treeNode7.Text = "ang";
            treeNode8.Name = "Nó2";
            treeNode8.Text = "taxi";
            treeNode9.Name = "Nó0";
            treeNode9.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(134, 106);
            this.treeView1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(717, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 241);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.btn_aula1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formulario 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_aula1;
        private System.Windows.Forms.Label lb_link;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

