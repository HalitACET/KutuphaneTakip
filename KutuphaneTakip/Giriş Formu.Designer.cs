namespace KutuphaneTakip
{
    partial class Giriş_Formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giriş_Formu));
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(168, 121);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(159, 31);
            this.txtSifre.TabIndex = 0;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(168, 158);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(159, 38);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "TMTAL Kütüphane";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(379, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(168, 84);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(159, 31);
            this.txtKullanici.TabIndex = 7;
            // 
            // Giriş_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(601, 239);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Giriş_Formu";
            this.Text = "Giriş Formu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKullanici;
    }
}