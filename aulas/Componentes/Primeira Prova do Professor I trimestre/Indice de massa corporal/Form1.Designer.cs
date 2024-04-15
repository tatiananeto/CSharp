namespace Indice_de_massa_corporal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_altra = new System.Windows.Forms.TextBox();
            this.tb_peso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_female = new System.Windows.Forms.Button();
            this.btn_male = new System.Windows.Forms.Button();
            this.tb_idade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.lb_diferenca = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_magreza_grave = new System.Windows.Forms.Label();
            this.lb_magreaza_moderada = new System.Windows.Forms.Label();
            this.lb_magreza_leve = new System.Windows.Forms.Label();
            this.lb_saudavel = new System.Windows.Forms.Label();
            this.lb_sobrepeso = new System.Windows.Forms.Label();
            this.lb_obesidade_um = new System.Windows.Forms.Label();
            this.lb_obesidade_dois = new System.Windows.Forms.Label();
            this.lb_obesidade_tres = new System.Windows.Forms.Label();
            this.lb_ob_t = new System.Windows.Forms.Label();
            this.lb_valor_ob_d = new System.Windows.Forms.Label();
            this.lb_ob_u = new System.Windows.Forms.Label();
            this.lb_valor_sb = new System.Windows.Forms.Label();
            this.lb_valor_sd = new System.Windows.Forms.Label();
            this.lb_valor_ml = new System.Windows.Forms.Label();
            this.lb_valor_mm = new System.Windows.Forms.Label();
            this.lb_valor_mg = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btn_calcuar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_dicas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(172, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // tb_altra
            // 
            this.tb_altra.Location = new System.Drawing.Point(138, 89);
            this.tb_altra.Name = "tb_altra";
            this.tb_altra.Size = new System.Drawing.Size(128, 30);
            this.tb_altra.TabIndex = 3;
            this.tb_altra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_peso
            // 
            this.tb_peso.Location = new System.Drawing.Point(138, 152);
            this.tb_peso.Name = "tb_peso";
            this.tb_peso.Size = new System.Drawing.Size(128, 30);
            this.tb_peso.TabIndex = 5;
            this.tb_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_peso.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(172, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso";
            this.label3.Click += new System.EventHandler(this.peso_Click);
            // 
            // btn_female
            // 
            this.btn_female.Image = ((System.Drawing.Image)(resources.GetObject("btn_female.Image")));
            this.btn_female.Location = new System.Drawing.Point(17, 135);
            this.btn_female.Name = "btn_female";
            this.btn_female.Size = new System.Drawing.Size(36, 65);
            this.btn_female.TabIndex = 6;
            this.btn_female.UseVisualStyleBackColor = true;
            this.btn_female.Click += new System.EventHandler(this.btn_female_Click);
            // 
            // btn_male
            // 
            this.btn_male.Image = ((System.Drawing.Image)(resources.GetObject("btn_male.Image")));
            this.btn_male.Location = new System.Drawing.Point(48, 135);
            this.btn_male.Name = "btn_male";
            this.btn_male.Size = new System.Drawing.Size(36, 65);
            this.btn_male.TabIndex = 7;
            this.btn_male.UseVisualStyleBackColor = true;
            this.btn_male.Click += new System.EventHandler(this.btn_male_Click);
            // 
            // tb_idade
            // 
            this.tb_idade.Location = new System.Drawing.Point(12, 88);
            this.tb_idade.Name = "tb_idade";
            this.tb_idade.Size = new System.Drawing.Size(72, 30);
            this.tb_idade.TabIndex = 2;
            this.tb_idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(7, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categoria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 211);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(310, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Índice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 467);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 10);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_categoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_categoria.Location = new System.Drawing.Point(12, 445);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(74, 22);
            this.lb_categoria.TabIndex = 17;
            this.lb_categoria.Text = "................";
            this.lb_categoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_diferenca
            // 
            this.lb_diferenca.AutoSize = true;
            this.lb_diferenca.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diferenca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_diferenca.Location = new System.Drawing.Point(303, 445);
            this.lb_diferenca.Name = "lb_diferenca";
            this.lb_diferenca.Size = new System.Drawing.Size(74, 22);
            this.lb_diferenca.TabIndex = 18;
            this.lb_diferenca.Text = "................";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(227, 467);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 10);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // lb_magreza_grave
            // 
            this.lb_magreza_grave.AutoSize = true;
            this.lb_magreza_grave.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_magreza_grave.Location = new System.Drawing.Point(15, 494);
            this.lb_magreza_grave.Name = "lb_magreza_grave";
            this.lb_magreza_grave.Size = new System.Drawing.Size(128, 22);
            this.lb_magreza_grave.TabIndex = 20;
            this.lb_magreza_grave.Text = "Magreza grave";
            // 
            // lb_magreaza_moderada
            // 
            this.lb_magreaza_moderada.AutoSize = true;
            this.lb_magreaza_moderada.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_magreaza_moderada.Location = new System.Drawing.Point(15, 528);
            this.lb_magreaza_moderada.Name = "lb_magreaza_moderada";
            this.lb_magreaza_moderada.Size = new System.Drawing.Size(166, 22);
            this.lb_magreaza_moderada.TabIndex = 21;
            this.lb_magreaza_moderada.Text = "Magreza moderada";
            // 
            // lb_magreza_leve
            // 
            this.lb_magreza_leve.AutoSize = true;
            this.lb_magreza_leve.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_magreza_leve.Location = new System.Drawing.Point(13, 562);
            this.lb_magreza_leve.Name = "lb_magreza_leve";
            this.lb_magreza_leve.Size = new System.Drawing.Size(116, 22);
            this.lb_magreza_leve.TabIndex = 22;
            this.lb_magreza_leve.Text = "Magreza leve";
            // 
            // lb_saudavel
            // 
            this.lb_saudavel.AutoSize = true;
            this.lb_saudavel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_saudavel.Location = new System.Drawing.Point(15, 597);
            this.lb_saudavel.Name = "lb_saudavel";
            this.lb_saudavel.Size = new System.Drawing.Size(83, 22);
            this.lb_saudavel.TabIndex = 23;
            this.lb_saudavel.Text = "Saudável";
            // 
            // lb_sobrepeso
            // 
            this.lb_sobrepeso.AutoSize = true;
            this.lb_sobrepeso.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_sobrepeso.Location = new System.Drawing.Point(15, 629);
            this.lb_sobrepeso.Name = "lb_sobrepeso";
            this.lb_sobrepeso.Size = new System.Drawing.Size(94, 22);
            this.lb_sobrepeso.TabIndex = 24;
            this.lb_sobrepeso.Text = "Sobrepeso";
            // 
            // lb_obesidade_um
            // 
            this.lb_obesidade_um.AutoSize = true;
            this.lb_obesidade_um.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_obesidade_um.Location = new System.Drawing.Point(15, 664);
            this.lb_obesidade_um.Name = "lb_obesidade_um";
            this.lb_obesidade_um.Size = new System.Drawing.Size(148, 22);
            this.lb_obesidade_um.TabIndex = 25;
            this.lb_obesidade_um.Text = "Obesidade Grau I";
            // 
            // lb_obesidade_dois
            // 
            this.lb_obesidade_dois.AutoSize = true;
            this.lb_obesidade_dois.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_obesidade_dois.Location = new System.Drawing.Point(15, 696);
            this.lb_obesidade_dois.Name = "lb_obesidade_dois";
            this.lb_obesidade_dois.Size = new System.Drawing.Size(154, 22);
            this.lb_obesidade_dois.TabIndex = 26;
            this.lb_obesidade_dois.Text = "Obesidade Grau II";
            // 
            // lb_obesidade_tres
            // 
            this.lb_obesidade_tres.AutoSize = true;
            this.lb_obesidade_tres.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_obesidade_tres.Location = new System.Drawing.Point(15, 729);
            this.lb_obesidade_tres.Name = "lb_obesidade_tres";
            this.lb_obesidade_tres.Size = new System.Drawing.Size(160, 22);
            this.lb_obesidade_tres.TabIndex = 27;
            this.lb_obesidade_tres.Text = "Obesidade Grau III";
            // 
            // lb_ob_t
            // 
            this.lb_ob_t.AutoSize = true;
            this.lb_ob_t.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_ob_t.Location = new System.Drawing.Point(284, 729);
            this.lb_ob_t.Name = "lb_ob_t";
            this.lb_ob_t.Size = new System.Drawing.Size(73, 22);
            this.lb_ob_t.TabIndex = 35;
            this.lb_ob_t.Text = ">= 40.0";
            this.lb_ob_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_valor_ob_d
            // 
            this.lb_valor_ob_d.AutoSize = true;
            this.lb_valor_ob_d.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_valor_ob_d.Location = new System.Drawing.Point(271, 696);
            this.lb_valor_ob_d.Name = "lb_valor_ob_d";
            this.lb_valor_ob_d.Size = new System.Drawing.Size(98, 22);
            this.lb_valor_ob_d.TabIndex = 34;
            this.lb_valor_ob_d.Text = "35.0 - 39.9";
            this.lb_valor_ob_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ob_u
            // 
            this.lb_ob_u.AutoSize = true;
            this.lb_ob_u.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_ob_u.Location = new System.Drawing.Point(271, 664);
            this.lb_ob_u.Name = "lb_ob_u";
            this.lb_ob_u.Size = new System.Drawing.Size(98, 22);
            this.lb_ob_u.TabIndex = 33;
            this.lb_ob_u.Text = "30.0 - 34.9";
            this.lb_ob_u.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_valor_sb
            // 
            this.lb_valor_sb.AutoSize = true;
            this.lb_valor_sb.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_valor_sb.Location = new System.Drawing.Point(271, 629);
            this.lb_valor_sb.Name = "lb_valor_sb";
            this.lb_valor_sb.Size = new System.Drawing.Size(98, 22);
            this.lb_valor_sb.TabIndex = 32;
            this.lb_valor_sb.Text = "25.0 - 29.9";
            this.lb_valor_sb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_valor_sd
            // 
            this.lb_valor_sd.AutoSize = true;
            this.lb_valor_sd.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_valor_sd.Location = new System.Drawing.Point(271, 597);
            this.lb_valor_sd.Name = "lb_valor_sd";
            this.lb_valor_sd.Size = new System.Drawing.Size(98, 22);
            this.lb_valor_sd.TabIndex = 31;
            this.lb_valor_sd.Text = "18.5 - 24.9";
            this.lb_valor_sd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_valor_ml
            // 
            this.lb_valor_ml.AutoSize = true;
            this.lb_valor_ml.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_valor_ml.Location = new System.Drawing.Point(269, 562);
            this.lb_valor_ml.Name = "lb_valor_ml";
            this.lb_valor_ml.Size = new System.Drawing.Size(98, 22);
            this.lb_valor_ml.TabIndex = 30;
            this.lb_valor_ml.Text = "17.0 - 18.4";
            this.lb_valor_ml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_valor_mm
            // 
            this.lb_valor_mm.AutoSize = true;
            this.lb_valor_mm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_valor_mm.Location = new System.Drawing.Point(271, 528);
            this.lb_valor_mm.Name = "lb_valor_mm";
            this.lb_valor_mm.Size = new System.Drawing.Size(98, 22);
            this.lb_valor_mm.TabIndex = 29;
            this.lb_valor_mm.Text = "16.0 - 16.9";
            this.lb_valor_mm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_valor_mg
            // 
            this.lb_valor_mg.AutoSize = true;
            this.lb_valor_mg.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lb_valor_mg.Location = new System.Drawing.Point(280, 494);
            this.lb_valor_mg.Name = "lb_valor_mg";
            this.lb_valor_mg.Size = new System.Drawing.Size(73, 22);
            this.lb_valor_mg.TabIndex = 28;
            this.lb_valor_mg.Text = "<= 15.9";
            this.lb_valor_mg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(227, 765);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 10);
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 765);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(153, 10);
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 790);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 22);
            this.label23.TabIndex = 38;
            this.label23.Text = "Peso normal";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(296, 790);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 22);
            this.label24.TabIndex = 39;
            this.label24.Text = "Kg09";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label25.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(31, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(319, 25);
            this.label25.TabIndex = 40;
            this.label25.Text = "******* IMC Calculadora *******";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(344, 790);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(33, 22);
            this.label26.TabIndex = 41;
            this.label26.Text = "Kg";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(230, 790);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 22);
            this.label27.TabIndex = 42;
            this.label27.Text = "Kg09";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(284, 790);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 22);
            this.label28.TabIndex = 43;
            this.label28.Text = "-";
            // 
            // btn_calcuar
            // 
            this.btn_calcuar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcuar.Location = new System.Drawing.Point(273, 192);
            this.btn_calcuar.Name = "btn_calcuar";
            this.btn_calcuar.Size = new System.Drawing.Size(107, 32);
            this.btn_calcuar.TabIndex = 44;
            this.btn_calcuar.Text = "Calcular";
            this.btn_calcuar.UseVisualStyleBackColor = true;
            this.btn_calcuar.Click += new System.EventHandler(this.btn_calcuar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(276, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 22);
            this.label7.TabIndex = 45;
            this.label7.Text = "Metros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(280, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Kilogramas";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(302, 230);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 32);
            this.btn_limpar.TabIndex = 47;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_dicas
            // 
            this.btn_dicas.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dicas.Location = new System.Drawing.Point(318, 268);
            this.btn_dicas.Name = "btn_dicas";
            this.btn_dicas.Size = new System.Drawing.Size(59, 28);
            this.btn_dicas.TabIndex = 48;
            this.btn_dicas.Text = "Dicas";
            this.btn_dicas.UseVisualStyleBackColor = true;
            this.btn_dicas.Click += new System.EventHandler(this.btn_dicas_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 824);
            this.Controls.Add(this.btn_dicas);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_calcuar);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lb_ob_t);
            this.Controls.Add(this.lb_valor_ob_d);
            this.Controls.Add(this.lb_ob_u);
            this.Controls.Add(this.lb_valor_sb);
            this.Controls.Add(this.lb_valor_sd);
            this.Controls.Add(this.lb_valor_ml);
            this.Controls.Add(this.lb_valor_mm);
            this.Controls.Add(this.lb_valor_mg);
            this.Controls.Add(this.lb_obesidade_tres);
            this.Controls.Add(this.lb_obesidade_dois);
            this.Controls.Add(this.lb_obesidade_um);
            this.Controls.Add(this.lb_sobrepeso);
            this.Controls.Add(this.lb_saudavel);
            this.Controls.Add(this.lb_magreza_leve);
            this.Controls.Add(this.lb_magreaza_moderada);
            this.Controls.Add(this.lb_magreza_grave);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lb_diferenca);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_male);
            this.Controls.Add(this.btn_female);
            this.Controls.Add(this.tb_peso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_altra);
            this.Controls.Add(this.tb_idade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMC Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_altra;
        private System.Windows.Forms.TextBox tb_peso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_female;
        private System.Windows.Forms.Button btn_male;
        private System.Windows.Forms.TextBox tb_idade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.Label lb_diferenca;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_magreza_grave;
        private System.Windows.Forms.Label lb_magreaza_moderada;
        private System.Windows.Forms.Label lb_magreza_leve;
        private System.Windows.Forms.Label lb_saudavel;
        private System.Windows.Forms.Label lb_sobrepeso;
        private System.Windows.Forms.Label lb_obesidade_um;
        private System.Windows.Forms.Label lb_obesidade_dois;
        private System.Windows.Forms.Label lb_obesidade_tres;
        private System.Windows.Forms.Label lb_ob_t;
        private System.Windows.Forms.Label lb_valor_ob_d;
        private System.Windows.Forms.Label lb_ob_u;
        private System.Windows.Forms.Label lb_valor_sb;
        private System.Windows.Forms.Label lb_valor_sd;
        private System.Windows.Forms.Label lb_valor_ml;
        private System.Windows.Forms.Label lb_valor_mm;
        private System.Windows.Forms.Label lb_valor_mg;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btn_calcuar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_dicas;
    }
}

