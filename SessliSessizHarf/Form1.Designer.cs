namespace _028_5_WindowsForms_SessliSessizHarf
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.cbHarf = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bGetir = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.lSonuc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime";
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(56, 12);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(366, 20);
            this.tbKelime.TabIndex = 1;
            // 
            // cbHarf
            // 
            this.cbHarf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHarf.FormattingEnabled = true;
            this.cbHarf.Items.AddRange(new object[] {
            "-- Seçiniz --",
            "Sesli Harfler",
            "Sessiz Harfler"});
            this.cbHarf.Location = new System.Drawing.Point(56, 38);
            this.cbHarf.Name = "cbHarf";
            this.cbHarf.Size = new System.Drawing.Size(156, 21);
            this.cbHarf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Harf";
            // 
            // bGetir
            // 
            this.bGetir.Location = new System.Drawing.Point(56, 65);
            this.bGetir.Name = "bGetir";
            this.bGetir.Size = new System.Drawing.Size(75, 23);
            this.bGetir.TabIndex = 4;
            this.bGetir.Text = "Getir";
            this.bGetir.UseVisualStyleBackColor = true;
            this.bGetir.Click += new System.EventHandler(this.bGetir_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(137, 65);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 5;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // lSonuc
            // 
            this.lSonuc.BackColor = System.Drawing.Color.Black;
            this.lSonuc.ForeColor = System.Drawing.Color.White;
            this.lSonuc.Location = new System.Drawing.Point(56, 100);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(366, 35);
            this.lSonuc.TabIndex = 6;
            this.lSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 150);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bGetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHarf);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sesli Sessiz Harf Bulma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKelime;
        private System.Windows.Forms.ComboBox cbHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bGetir;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Label lSonuc;
        private System.Windows.Forms.Label label3;
    }
}

