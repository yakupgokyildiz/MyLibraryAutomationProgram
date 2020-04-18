namespace WinFormKOS
{
    partial class FormOkuyucuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOkuyucuEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtnErkek = new System.Windows.Forms.RadioButton();
            this.radioBtnKadin = new System.Windows.Forms.RadioButton();
            this.txtSinif = new System.Windows.Forms.TextBox();
            this.txtOkulNo = new System.Windows.Forms.TextBox();
            this.maskedCepTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureProfil = new System.Windows.Forms.PictureBox();
            this.btnFotoSec = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtFiltrele = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyeti";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınıfı:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Okul Numarası:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cep Tel:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSoyad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSinif, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtOkulNo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.maskedCepTel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtAdres, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 141);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 240);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAd.Location = new System.Drawing.Point(90, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(157, 20);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoyad.Location = new System.Drawing.Point(90, 33);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(157, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.radioBtnErkek, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.radioBtnKadin, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(90, 61);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(157, 23);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // radioBtnErkek
            // 
            this.radioBtnErkek.AutoSize = true;
            this.radioBtnErkek.Location = new System.Drawing.Point(3, 3);
            this.radioBtnErkek.Name = "radioBtnErkek";
            this.radioBtnErkek.Size = new System.Drawing.Size(53, 17);
            this.radioBtnErkek.TabIndex = 0;
            this.radioBtnErkek.TabStop = true;
            this.radioBtnErkek.Text = "Erkek";
            this.radioBtnErkek.UseVisualStyleBackColor = true;
            // 
            // radioBtnKadin
            // 
            this.radioBtnKadin.AutoSize = true;
            this.radioBtnKadin.Location = new System.Drawing.Point(81, 3);
            this.radioBtnKadin.Name = "radioBtnKadin";
            this.radioBtnKadin.Size = new System.Drawing.Size(52, 17);
            this.radioBtnKadin.TabIndex = 1;
            this.radioBtnKadin.TabStop = true;
            this.radioBtnKadin.Text = "Kadın";
            this.radioBtnKadin.UseVisualStyleBackColor = true;
            // 
            // txtSinif
            // 
            this.txtSinif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSinif.Location = new System.Drawing.Point(90, 91);
            this.txtSinif.Name = "txtSinif";
            this.txtSinif.Size = new System.Drawing.Size(157, 20);
            this.txtSinif.TabIndex = 10;
            // 
            // txtOkulNo
            // 
            this.txtOkulNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOkulNo.Location = new System.Drawing.Point(90, 120);
            this.txtOkulNo.Name = "txtOkulNo";
            this.txtOkulNo.Size = new System.Drawing.Size(157, 20);
            this.txtOkulNo.TabIndex = 11;
            // 
            // maskedCepTel
            // 
            this.maskedCepTel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedCepTel.Location = new System.Drawing.Point(90, 149);
            this.maskedCepTel.Mask = "(999) 000-0000";
            this.maskedCepTel.Name = "maskedCepTel";
            this.maskedCepTel.Size = new System.Drawing.Size(157, 20);
            this.maskedCepTel.TabIndex = 12;
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAdres.Location = new System.Drawing.Point(90, 180);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(157, 54);
            this.txtAdres.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 100);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureProfil, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnFotoSec, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(90, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(157, 94);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pictureProfil
            // 
            this.pictureProfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureProfil.Image")));
            this.pictureProfil.Location = new System.Drawing.Point(3, 3);
            this.pictureProfil.Name = "pictureProfil";
            this.pictureProfil.Size = new System.Drawing.Size(72, 88);
            this.pictureProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfil.TabIndex = 0;
            this.pictureProfil.TabStop = false;
            // 
            // btnFotoSec
            // 
            this.btnFotoSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFotoSec.Location = new System.Drawing.Point(81, 68);
            this.btnFotoSec.Name = "btnFotoSec";
            this.btnFotoSec.Size = new System.Drawing.Size(73, 23);
            this.btnFotoSec.TabIndex = 1;
            this.btnFotoSec.Text = "Fotoğraf";
            this.btnFotoSec.UseVisualStyleBackColor = true;
            this.btnFotoSec.Click += new System.EventHandler(this.btnFotoSec_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fotoğraf";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.btnSil, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnTemizle, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnKaydet, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 387);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(250, 36);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSil.Location = new System.Drawing.Point(86, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(77, 30);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTemizle.Location = new System.Drawing.Point(169, 3);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(78, 30);
            this.btnTemizle.TabIndex = 12;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKaydet.Location = new System.Drawing.Point(3, 3);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(77, 30);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(268, 63);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(511, 360);
            this.dg.TabIndex = 18;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // txtFiltrele
            // 
            this.txtFiltrele.Location = new System.Drawing.Point(679, 29);
            this.txtFiltrele.Name = "txtFiltrele";
            this.txtFiltrele.Size = new System.Drawing.Size(100, 20);
            this.txtFiltrele.TabIndex = 16;
            this.txtFiltrele.TextChanged += new System.EventHandler(this.txtFiltrele_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(633, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Filtrele:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FormOkuyucuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txtFiltrele);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormOkuyucuEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okuyucu Ekle";
            this.Load += new System.EventHandler(this.FormOkuyucuEkle_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.RadioButton radioBtnErkek;
        private System.Windows.Forms.RadioButton radioBtnKadin;
        private System.Windows.Forms.TextBox txtSinif;
        private System.Windows.Forms.TextBox txtOkulNo;
        private System.Windows.Forms.MaskedTextBox maskedCepTel;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureProfil;
        private System.Windows.Forms.Button btnFotoSec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txtFiltrele;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}