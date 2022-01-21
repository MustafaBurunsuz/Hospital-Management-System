
namespace HastaneYönetimSistemi
{
    partial class FrmSekreterDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDuyuruOlustur = new System.Windows.Forms.Button();
            this.RchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btnkaydet = new System.Windows.Forms.Button();
            this.ChkDurum = new System.Windows.Forms.CheckBox();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtnListe = new System.Windows.Forms.Button();
            this.BtnBransPanel = new System.Windows.Forms.Button();
            this.BtnDoktorPanel = new System.Windows.Forms.Button();
            this.BtnDuyuru = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SekreterBilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(134, 75);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(106, 23);
            this.LblAdSoyad.TabIndex = 0;
            this.LblAdSoyad.Text = "NULL NULL";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(134, 41);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 0;
            this.LblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDuyuruOlustur);
            this.groupBox2.Controls.Add(this.RchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 239);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DuyuruOluştur";
            // 
            // BtnDuyuruOlustur
            // 
            this.BtnDuyuruOlustur.Location = new System.Drawing.Point(6, 202);
            this.BtnDuyuruOlustur.Name = "BtnDuyuruOlustur";
            this.BtnDuyuruOlustur.Size = new System.Drawing.Size(324, 34);
            this.BtnDuyuruOlustur.TabIndex = 1;
            this.BtnDuyuruOlustur.Text = "Oluştur";
            this.BtnDuyuruOlustur.UseVisualStyleBackColor = true;
            this.BtnDuyuruOlustur.Click += new System.EventHandler(this.BtnDuyuruOlustur_Click);
            // 
            // RchDuyuru
            // 
            this.RchDuyuru.Location = new System.Drawing.Point(6, 53);
            this.RchDuyuru.Name = "RchDuyuru";
            this.RchDuyuru.Size = new System.Drawing.Size(324, 134);
            this.RchDuyuru.TabIndex = 0;
            this.RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btnkaydet);
            this.groupBox3.Controls.Add(this.ChkDurum);
            this.groupBox3.Controls.Add(this.CmbDoktor);
            this.groupBox3.Controls.Add(this.CmbBrans);
            this.groupBox3.Controls.Add(this.MskSaat);
            this.groupBox3.Controls.Add(this.MskTC);
            this.groupBox3.Controls.Add(this.MskTarih);
            this.groupBox3.Controls.Add(this.TxtID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(382, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 386);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RandevuPaneli";
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Location = new System.Drawing.Point(92, 308);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(110, 29);
            this.Btnkaydet.TabIndex = 1;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.UseVisualStyleBackColor = true;
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // ChkDurum
            // 
            this.ChkDurum.AutoSize = true;
            this.ChkDurum.Location = new System.Drawing.Point(92, 281);
            this.ChkDurum.Name = "ChkDurum";
            this.ChkDurum.Size = new System.Drawing.Size(95, 27);
            this.ChkDurum.TabIndex = 4;
            this.ChkDurum.Text = "DURUM";
            this.ChkDurum.UseVisualStyleBackColor = true;
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(92, 207);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(170, 31);
            this.CmbDoktor.TabIndex = 3;
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(92, 167);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(170, 31);
            this.CmbBrans.TabIndex = 3;
            this.CmbBrans.SelectedIndexChanged += new System.EventHandler(this.CmbBrans_SelectedIndexChanged);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(92, 128);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(170, 31);
            this.MskSaat.TabIndex = 2;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(92, 244);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(170, 31);
            this.MskTC.TabIndex = 2;
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(92, 88);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(170, 31);
            this.MskTarih.TabIndex = 2;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(92, 51);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(170, 31);
            this.TxtID.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "TC:";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Doktor:";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Branş:";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Saat:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tarih:";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 0;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(671, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(334, 217);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(328, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(671, 235);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(334, 272);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(328, 242);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnDuyuru);
            this.groupBox6.Controls.Add(this.BtnListe);
            this.groupBox6.Controls.Add(this.BtnBransPanel);
            this.groupBox6.Controls.Add(this.BtnDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 407);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(649, 100);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // BtnListe
            // 
            this.BtnListe.Location = new System.Drawing.Point(315, 30);
            this.BtnListe.Name = "BtnListe";
            this.BtnListe.Size = new System.Drawing.Size(141, 31);
            this.BtnListe.TabIndex = 1;
            this.BtnListe.Text = "Randevu Liste";
            this.BtnListe.UseVisualStyleBackColor = true;
            this.BtnListe.Click += new System.EventHandler(this.BtnListe_Click);
            // 
            // BtnBransPanel
            // 
            this.BtnBransPanel.Location = new System.Drawing.Point(164, 30);
            this.BtnBransPanel.Name = "BtnBransPanel";
            this.BtnBransPanel.Size = new System.Drawing.Size(116, 31);
            this.BtnBransPanel.TabIndex = 1;
            this.BtnBransPanel.Text = "Branş Paneli";
            this.BtnBransPanel.UseVisualStyleBackColor = true;
            this.BtnBransPanel.Click += new System.EventHandler(this.BtnBransPanel_Click);
            // 
            // BtnDoktorPanel
            // 
            this.BtnDoktorPanel.Location = new System.Drawing.Point(6, 30);
            this.BtnDoktorPanel.Name = "BtnDoktorPanel";
            this.BtnDoktorPanel.Size = new System.Drawing.Size(130, 31);
            this.BtnDoktorPanel.TabIndex = 1;
            this.BtnDoktorPanel.Text = "Doktor Paneli";
            this.BtnDoktorPanel.UseVisualStyleBackColor = true;
            this.BtnDoktorPanel.Click += new System.EventHandler(this.BtnDoktorPanel_Click);
            // 
            // BtnDuyuru
            // 
            this.BtnDuyuru.Location = new System.Drawing.Point(503, 30);
            this.BtnDuyuru.Name = "BtnDuyuru";
            this.BtnDuyuru.Size = new System.Drawing.Size(129, 31);
            this.BtnDuyuru.TabIndex = 2;
            this.BtnDuyuru.Text = "Duyurular";
            this.BtnDuyuru.UseVisualStyleBackColor = true;
            this.BtnDuyuru.Click += new System.EventHandler(this.BtnDuyuru_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1092, 537);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDuyuruOlustur;
        private System.Windows.Forms.RichTextBox RchDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btnkaydet;
        private System.Windows.Forms.CheckBox ChkDurum;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnListe;
        private System.Windows.Forms.Button BtnBransPanel;
        private System.Windows.Forms.Button BtnDoktorPanel;
        private System.Windows.Forms.Button BtnDuyuru;
    }
}