namespace Login_e_cadastramento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msltf_usuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.msltf_senha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mcb_lembrar = new MaterialSkin.Controls.MaterialCheckBox();
            this.mrbtn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.mlb_esqueceu = new MaterialSkin.Controls.MaterialLabel();
            this.mlb_registrar = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msltf_usuario
            // 
            this.msltf_usuario.Depth = 0;
            this.msltf_usuario.Hint = "  Usuário";
            this.msltf_usuario.Location = new System.Drawing.Point(86, 90);
            this.msltf_usuario.MaxLength = 32767;
            this.msltf_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltf_usuario.Name = "msltf_usuario";
            this.msltf_usuario.PasswordChar = '\0';
            this.msltf_usuario.SelectedText = "";
            this.msltf_usuario.SelectionLength = 0;
            this.msltf_usuario.SelectionStart = 0;
            this.msltf_usuario.Size = new System.Drawing.Size(306, 23);
            this.msltf_usuario.TabIndex = 0;
            this.msltf_usuario.TabStop = false;
            this.msltf_usuario.UseSystemPasswordChar = false;
            // 
            // msltf_senha
            // 
            this.msltf_senha.Depth = 0;
            this.msltf_senha.Hint = " Senha";
            this.msltf_senha.Location = new System.Drawing.Point(86, 161);
            this.msltf_senha.MaxLength = 32767;
            this.msltf_senha.MouseState = MaterialSkin.MouseState.HOVER;
            this.msltf_senha.Name = "msltf_senha";
            this.msltf_senha.PasswordChar = '*';
            this.msltf_senha.SelectedText = "";
            this.msltf_senha.SelectionLength = 0;
            this.msltf_senha.SelectionStart = 0;
            this.msltf_senha.Size = new System.Drawing.Size(306, 23);
            this.msltf_senha.TabIndex = 1;
            this.msltf_senha.TabStop = false;
            this.msltf_senha.UseSystemPasswordChar = false;
            // 
            // mcb_lembrar
            // 
            this.mcb_lembrar.AutoSize = true;
            this.mcb_lembrar.Depth = 0;
            this.mcb_lembrar.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcb_lembrar.Location = new System.Drawing.Point(86, 227);
            this.mcb_lembrar.Margin = new System.Windows.Forms.Padding(0);
            this.mcb_lembrar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcb_lembrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcb_lembrar.Name = "mcb_lembrar";
            this.mcb_lembrar.Ripple = true;
            this.mcb_lembrar.Size = new System.Drawing.Size(105, 30);
            this.mcb_lembrar.TabIndex = 2;
            this.mcb_lembrar.Text = "Lembrar-me";
            this.mcb_lembrar.UseVisualStyleBackColor = true;
            // 
            // mrbtn_login
            // 
            this.mrbtn_login.AutoSize = true;
            this.mrbtn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mrbtn_login.Depth = 0;
            this.mrbtn_login.Icon = null;
            this.mrbtn_login.Image = ((System.Drawing.Image)(resources.GetObject("mrbtn_login.Image")));
            this.mrbtn_login.Location = new System.Drawing.Point(327, 221);
            this.mrbtn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.mrbtn_login.Name = "mrbtn_login";
            this.mrbtn_login.Primary = true;
            this.mrbtn_login.Size = new System.Drawing.Size(61, 36);
            this.mrbtn_login.TabIndex = 3;
            this.mrbtn_login.Text = "Login";
            this.mrbtn_login.UseVisualStyleBackColor = true;
            this.mrbtn_login.Click += new System.EventHandler(this.mrbtn_login_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(48, 279);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(400, 2);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // mlb_esqueceu
            // 
            this.mlb_esqueceu.AutoSize = true;
            this.mlb_esqueceu.BackColor = System.Drawing.Color.Transparent;
            this.mlb_esqueceu.Depth = 0;
            this.mlb_esqueceu.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_esqueceu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_esqueceu.Location = new System.Drawing.Point(82, 315);
            this.mlb_esqueceu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_esqueceu.Name = "mlb_esqueceu";
            this.mlb_esqueceu.Size = new System.Drawing.Size(138, 19);
            this.mlb_esqueceu.TabIndex = 5;
            this.mlb_esqueceu.Text = "Esqueceu a senha?\r\n";
            // 
            // mlb_registrar
            // 
            this.mlb_registrar.AutoSize = true;
            this.mlb_registrar.BackColor = System.Drawing.Color.Transparent;
            this.mlb_registrar.Depth = 0;
            this.mlb_registrar.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlb_registrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlb_registrar.Location = new System.Drawing.Point(319, 315);
            this.mlb_registrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlb_registrar.Name = "mlb_registrar";
            this.mlb_registrar.Size = new System.Drawing.Size(69, 19);
            this.mlb_registrar.TabIndex = 6;
            this.mlb_registrar.Text = "Registrar";
            this.mlb_registrar.Click += new System.EventHandler(this.mlb_registrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.mlb_registrar);
            this.groupBox1.Controls.Add(this.mlb_esqueceu);
            this.groupBox1.Controls.Add(this.materialDivider1);
            this.groupBox1.Controls.Add(this.mrbtn_login);
            this.groupBox1.Controls.Add(this.mcb_lembrar);
            this.groupBox1.Controls.Add(this.msltf_senha);
            this.groupBox1.Controls.Add(this.msltf_usuario);
            this.groupBox1.Location = new System.Drawing.Point(47, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 358);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "BemVindo!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(598, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField msltf_usuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField msltf_senha;
        private MaterialSkin.Controls.MaterialCheckBox mcb_lembrar;
        private MaterialSkin.Controls.MaterialRaisedButton mrbtn_login;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel mlb_esqueceu;
        private MaterialSkin.Controls.MaterialLabel mlb_registrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

