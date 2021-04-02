namespace KutuphaneTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTCNO = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtSecilenKitap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kitapları Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Okuyucu Listesi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(772, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Verilen Kitaplar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 66);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kitap Teslim";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1096, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 66);
            this.button5.TabIndex = 7;
            this.button5.Text = "Programı Kapat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(880, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 66);
            this.button6.TabIndex = 6;
            this.button6.Text = "Tarihi Geçenler";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(448, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(102, 66);
            this.button8.TabIndex = 4;
            this.button8.Text = "Kitap Ekle";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1304, 435);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1298, 410);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Location = new System.Drawing.Point(556, 158);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(156, 26);
            this.txtAdSoyad.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Okuyucu Ad Soyad";
            // 
            // txtTCNO
            // 
            this.txtTCNO.Enabled = false;
            this.txtTCNO.Location = new System.Drawing.Point(394, 158);
            this.txtTCNO.Name = "txtTCNO";
            this.txtTCNO.Size = new System.Drawing.Size(156, 26);
            this.txtTCNO.TabIndex = 11;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Enabled = false;
            this.txtBarkodNo.Location = new System.Drawing.Point(70, 158);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(156, 26);
            this.txtBarkodNo.TabIndex = 13;
            // 
            // txtSecilenKitap
            // 
            this.txtSecilenKitap.Enabled = false;
            this.txtSecilenKitap.Location = new System.Drawing.Point(232, 158);
            this.txtSecilenKitap.Name = "txtSecilenKitap";
            this.txtSecilenKitap.Size = new System.Drawing.Size(156, 26);
            this.txtSecilenKitap.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Barkod NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seçilen Kitap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Okuyucu TCNO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(743, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Yap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Arama Türü:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "KitapAd",
            "TCNO",
            "Barkod NO",
            "Ad"});
            this.comboBox1.Location = new System.Drawing.Point(139, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Arama:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(411, 51);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 26);
            this.textBox5.TabIndex = 15;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(232, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 66);
            this.button7.TabIndex = 18;
            this.button7.Text = "Genel Görünüm";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(988, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(102, 66);
            this.btnAdmin.TabIndex = 20;
            this.btnAdmin.Text = "Admin Ekle";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1328, 637);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtSecilenKitap);
            this.Controls.Add(this.txtTCNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTCNO;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtSecilenKitap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdmin;
    }
}

