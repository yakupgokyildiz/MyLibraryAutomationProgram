﻿namespace WinFormKOS
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.btnEmanetIslemleri = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnOkuyucuEkle = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgEmanetKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgMevcutKitaplar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgOkuyucular = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetKitaplar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmanetIslemleri
            // 
            this.btnEmanetIslemleri.Image = ((System.Drawing.Image)(resources.GetObject("btnEmanetIslemleri.Image")));
            this.btnEmanetIslemleri.Location = new System.Drawing.Point(12, 12);
            this.btnEmanetIslemleri.Name = "btnEmanetIslemleri";
            this.btnEmanetIslemleri.Size = new System.Drawing.Size(100, 75);
            this.btnEmanetIslemleri.TabIndex = 0;
            this.btnEmanetIslemleri.Text = "Emanet İşlemleri";
            this.btnEmanetIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmanetIslemleri.UseVisualStyleBackColor = true;
            this.btnEmanetIslemleri.Click += new System.EventHandler(this.btnEmanetIslemleri_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnKitapEkle.Image")));
            this.btnKitapEkle.Location = new System.Drawing.Point(118, 12);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(100, 75);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnOkuyucuEkle
            // 
            this.btnOkuyucuEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnOkuyucuEkle.Image")));
            this.btnOkuyucuEkle.Location = new System.Drawing.Point(224, 12);
            this.btnOkuyucuEkle.Name = "btnOkuyucuEkle";
            this.btnOkuyucuEkle.Size = new System.Drawing.Size(100, 75);
            this.btnOkuyucuEkle.TabIndex = 2;
            this.btnOkuyucuEkle.Text = "Okuyucu Ekle";
            this.btnOkuyucuEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOkuyucuEkle.UseVisualStyleBackColor = true;
            this.btnOkuyucuEkle.Click += new System.EventHandler(this.btnOkuyucuEkle_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("btnIstatistik.Image")));
            this.btnIstatistik.Location = new System.Drawing.Point(330, 12);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(100, 75);
            this.btnIstatistik.TabIndex = 3;
            this.btnIstatistik.Text = "İstatistik";
            this.btnIstatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.Image")));
            this.btnAyarlar.Location = new System.Drawing.Point(436, 12);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(100, 75);
            this.btnAyarlar.TabIndex = 4;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisYap.Image")));
            this.btnCikisYap.Location = new System.Drawing.Point(722, 12);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(100, 75);
            this.btnCikisYap.TabIndex = 5;
            this.btnCikisYap.Text = "Çıkış Yap";
            this.btnCikisYap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikisYap.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 355);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgEmanetKitaplar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(801, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Emanet Kitaplar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgEmanetKitaplar
            // 
            this.dgEmanetKitaplar.AllowUserToAddRows = false;
            this.dgEmanetKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmanetKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgEmanetKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmanetKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEmanetKitaplar.Location = new System.Drawing.Point(3, 3);
            this.dgEmanetKitaplar.MultiSelect = false;
            this.dgEmanetKitaplar.Name = "dgEmanetKitaplar";
            this.dgEmanetKitaplar.ReadOnly = true;
            this.dgEmanetKitaplar.RowHeadersVisible = false;
            this.dgEmanetKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmanetKitaplar.Size = new System.Drawing.Size(795, 323);
            this.dgEmanetKitaplar.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgMevcutKitaplar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(801, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mevcut Kitaplar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgMevcutKitaplar
            // 
            this.dgMevcutKitaplar.AllowUserToAddRows = false;
            this.dgMevcutKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMevcutKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgMevcutKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMevcutKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMevcutKitaplar.Location = new System.Drawing.Point(3, 3);
            this.dgMevcutKitaplar.MultiSelect = false;
            this.dgMevcutKitaplar.Name = "dgMevcutKitaplar";
            this.dgMevcutKitaplar.ReadOnly = true;
            this.dgMevcutKitaplar.RowHeadersVisible = false;
            this.dgMevcutKitaplar.Size = new System.Drawing.Size(795, 323);
            this.dgMevcutKitaplar.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgOkuyucular);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(801, 329);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Okuyucular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgOkuyucular
            // 
            this.dgOkuyucular.AllowUserToAddRows = false;
            this.dgOkuyucular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOkuyucular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOkuyucular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOkuyucular.Location = new System.Drawing.Point(3, 3);
            this.dgOkuyucular.MultiSelect = false;
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.ReadOnly = true;
            this.dgOkuyucular.RowHeadersVisible = false;
            this.dgOkuyucular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOkuyucular.Size = new System.Drawing.Size(795, 323);
            this.dgOkuyucular.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnOkuyucuEkle);
            this.Controls.Add(this.btnKitapEkle);
            this.Controls.Add(this.btnEmanetIslemleri);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menuler";
            this.Activated += new System.EventHandler(this.FormHome_Activated);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmanetKitaplar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMevcutKitaplar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmanetIslemleri;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnOkuyucuEkle;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgOkuyucular;
        private System.Windows.Forms.DataGridView dgEmanetKitaplar;
        private System.Windows.Forms.DataGridView dgMevcutKitaplar;
    }
}