namespace WinFormKOS
{
    partial class FormEmanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmanet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltreleOkuyucu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgOkuyucular = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureProfil = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGecikmeBedeli = new System.Windows.Forms.Label();
            this.lblOkulNo = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmanet = new System.Windows.Forms.Button();
            this.btnSureUzat = new System.Windows.Forms.Button();
            this.btnDusumYap = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFiltreleKitap = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKayitNo = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.dgKitaplar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltreleOkuyucu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgOkuyucular);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okuyucu Seç";
            // 
            // txtFiltreleOkuyucu
            // 
            this.txtFiltreleOkuyucu.Location = new System.Drawing.Point(697, 158);
            this.txtFiltreleOkuyucu.Name = "txtFiltreleOkuyucu";
            this.txtFiltreleOkuyucu.Size = new System.Drawing.Size(100, 20);
            this.txtFiltreleOkuyucu.TabIndex = 3;
            this.txtFiltreleOkuyucu.TextChanged += new System.EventHandler(this.txtFiltreleOkuyucu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Filtrele:";
            // 
            // dgOkuyucular
            // 
            this.dgOkuyucular.AllowUserToAddRows = false;
            this.dgOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOkuyucular.EnableHeadersVisualStyles = false;
            this.dgOkuyucular.Location = new System.Drawing.Point(280, 23);
            this.dgOkuyucular.MultiSelect = false;
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.ReadOnly = true;
            this.dgOkuyucular.Size = new System.Drawing.Size(517, 130);
            this.dgOkuyucular.TabIndex = 1;
            this.dgOkuyucular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOkuyucular_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.pictureProfil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 110);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureProfil
            // 
            this.pictureProfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureProfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureProfil.Image")));
            this.pictureProfil.Location = new System.Drawing.Point(3, 3);
            this.pictureProfil.Name = "pictureProfil";
            this.pictureProfil.Size = new System.Drawing.Size(85, 104);
            this.pictureProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfil.TabIndex = 0;
            this.pictureProfil.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblGecikmeBedeli, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblOkulNo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblSinif, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblAdSoyad, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(94, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(163, 104);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblGecikmeBedeli
            // 
            this.lblGecikmeBedeli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGecikmeBedeli.AutoSize = true;
            this.lblGecikmeBedeli.Location = new System.Drawing.Point(3, 84);
            this.lblGecikmeBedeli.Name = "lblGecikmeBedeli";
            this.lblGecikmeBedeli.Size = new System.Drawing.Size(81, 13);
            this.lblGecikmeBedeli.TabIndex = 2;
            this.lblGecikmeBedeli.Text = "Gecikme Bedeli";
            // 
            // lblOkulNo
            // 
            this.lblOkulNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOkulNo.AutoSize = true;
            this.lblOkulNo.Location = new System.Drawing.Point(3, 58);
            this.lblOkulNo.Name = "lblOkulNo";
            this.lblOkulNo.Size = new System.Drawing.Size(46, 13);
            this.lblOkulNo.TabIndex = 1;
            this.lblOkulNo.Text = "Okul No";
            // 
            // lblSinif
            // 
            this.lblSinif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(3, 32);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(27, 13);
            this.lblSinif.TabIndex = 1;
            this.lblSinif.Text = "Sınıf";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(3, 6);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFiltreleKitap);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.dgKitaplar);
            this.groupBox2.Location = new System.Drawing.Point(12, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(797, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Seç";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnEmanet, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSureUzat, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDusumYap, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(500, 191);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(300, 30);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnEmanet
            // 
            this.btnEmanet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmanet.Location = new System.Drawing.Point(3, 3);
            this.btnEmanet.Name = "btnEmanet";
            this.btnEmanet.Size = new System.Drawing.Size(94, 24);
            this.btnEmanet.TabIndex = 0;
            this.btnEmanet.Text = "Emanet Et";
            this.btnEmanet.UseVisualStyleBackColor = true;
            this.btnEmanet.Click += new System.EventHandler(this.btnEmanet_Click);
            // 
            // btnSureUzat
            // 
            this.btnSureUzat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSureUzat.Location = new System.Drawing.Point(103, 3);
            this.btnSureUzat.Name = "btnSureUzat";
            this.btnSureUzat.Size = new System.Drawing.Size(94, 24);
            this.btnSureUzat.TabIndex = 1;
            this.btnSureUzat.Text = "Süre Uzat";
            this.btnSureUzat.UseVisualStyleBackColor = true;
            this.btnSureUzat.Click += new System.EventHandler(this.btnSureUzat_Click);
            // 
            // btnDusumYap
            // 
            this.btnDusumYap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDusumYap.Location = new System.Drawing.Point(203, 3);
            this.btnDusumYap.Name = "btnDusumYap";
            this.btnDusumYap.Size = new System.Drawing.Size(94, 24);
            this.btnDusumYap.TabIndex = 2;
            this.btnDusumYap.Text = "Düşüm Yap";
            this.btnDusumYap.UseVisualStyleBackColor = true;
            this.btnDusumYap.Click += new System.EventHandler(this.btnDusumYap_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(657, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Filtrele:";
            // 
            // txtFiltreleKitap
            // 
            this.txtFiltreleKitap.Location = new System.Drawing.Point(697, 158);
            this.txtFiltreleKitap.Name = "txtFiltreleKitap";
            this.txtFiltreleKitap.Size = new System.Drawing.Size(100, 20);
            this.txtFiltreleKitap.TabIndex = 5;
            this.txtFiltreleKitap.TextChanged += new System.EventHandler(this.txtFiltreleKitap_TextChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblKayitNo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblKitapAdi, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblYazarAdi, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(260, 110);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kayıt No";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kitabın Adı";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Yazar Adı";
            // 
            // lblKayitNo
            // 
            this.lblKayitNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKayitNo.AutoSize = true;
            this.lblKayitNo.Location = new System.Drawing.Point(94, 11);
            this.lblKayitNo.Name = "lblKayitNo";
            this.lblKayitNo.Size = new System.Drawing.Size(16, 13);
            this.lblKayitNo.TabIndex = 3;
            this.lblKayitNo.Text = "...";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(94, 47);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(16, 13);
            this.lblKitapAdi.TabIndex = 4;
            this.lblKitapAdi.Text = "...";
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYazarAdi.AutoSize = true;
            this.lblYazarAdi.Location = new System.Drawing.Point(94, 84);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(16, 13);
            this.lblYazarAdi.TabIndex = 5;
            this.lblYazarAdi.Text = "...";
            // 
            // dgKitaplar
            // 
            this.dgKitaplar.AllowUserToAddRows = false;
            this.dgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKitaplar.EnableHeadersVisualStyles = false;
            this.dgKitaplar.Location = new System.Drawing.Point(280, 23);
            this.dgKitaplar.MultiSelect = false;
            this.dgKitaplar.Name = "dgKitaplar";
            this.dgKitaplar.ReadOnly = true;
            this.dgKitaplar.Size = new System.Drawing.Size(517, 130);
            this.dgKitaplar.TabIndex = 4;
            this.dgKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKitaplar_CellClick);
            // 
            // FormEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Emanet İşlemleri";
            this.Load += new System.EventHandler(this.FormEmanet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureProfil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblGecikmeBedeli;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFiltreleOkuyucu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgOkuyucular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnEmanet;
        private System.Windows.Forms.Button btnSureUzat;
        private System.Windows.Forms.Button btnDusumYap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFiltreleKitap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKayitNo;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.DataGridView dgKitaplar;
    }
}