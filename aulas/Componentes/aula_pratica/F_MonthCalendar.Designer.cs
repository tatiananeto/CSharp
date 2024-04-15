namespace aula_pratica
{
    partial class F_MonthCalendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tb_pegardata = new System.Windows.Forms.TextBox();
            this.tb_pegardatafinal = new System.Windows.Forms.TextBox();
            this.btn_obter = new System.Windows.Forms.Button();
            this.tb_datadehoje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 30);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tb_pegardata
            // 
            this.tb_pegardata.Location = new System.Drawing.Point(267, 108);
            this.tb_pegardata.Name = "tb_pegardata";
            this.tb_pegardata.Size = new System.Drawing.Size(165, 26);
            this.tb_pegardata.TabIndex = 1;
            // 
            // tb_pegardatafinal
            // 
            this.tb_pegardatafinal.Location = new System.Drawing.Point(267, 140);
            this.tb_pegardatafinal.Name = "tb_pegardatafinal";
            this.tb_pegardatafinal.Size = new System.Drawing.Size(165, 26);
            this.tb_pegardatafinal.TabIndex = 2;
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(267, 68);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(121, 34);
            this.btn_obter.TabIndex = 3;
            this.btn_obter.Text = "Obter data";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // tb_datadehoje
            // 
            this.tb_datadehoje.Location = new System.Drawing.Point(267, 171);
            this.tb_datadehoje.Name = "tb_datadehoje";
            this.tb_datadehoje.Size = new System.Drawing.Size(165, 26);
            this.tb_datadehoje.TabIndex = 4;
            // 
            // F_MonthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 452);
            this.Controls.Add(this.tb_datadehoje);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.tb_pegardatafinal);
            this.Controls.Add(this.tb_pegardata);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "F_MonthCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tb_pegardata;
        private System.Windows.Forms.TextBox tb_pegardatafinal;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.TextBox tb_datadehoje;
    }
}