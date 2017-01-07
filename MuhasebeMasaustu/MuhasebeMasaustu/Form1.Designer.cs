namespace MuhasebeMasaustu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.lblStok = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtFiltre = new System.Windows.Forms.TextBox();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.lblHizala = new System.Windows.Forms.Label();
            this.rdUrunAdi = new System.Windows.Forms.RadioButton();
            this.rdFiyat = new System.Windows.Forms.RadioButton();
            this.rdStok = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 476);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(36, 9);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(39, 29);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(176, 9);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(179, 27);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 4;
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(347, 27);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(121, 21);
            this.cmbTedarikci.TabIndex = 6;
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Location = new System.Drawing.Point(344, 9);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(51, 13);
            this.lblTedarikci.TabIndex = 5;
            this.lblTedarikci.Text = "Tedarikçi";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(521, 9);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat";
            // 
            // numFiyat
            // 
            this.numFiyat.Location = new System.Drawing.Point(524, 28);
            this.numFiyat.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(120, 20);
            this.numFiyat.TabIndex = 8;
            // 
            // numStok
            // 
            this.numStok.Location = new System.Drawing.Point(687, 29);
            this.numStok.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(120, 20);
            this.numStok.TabIndex = 10;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(684, 10);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(29, 13);
            this.lblStok.TabIndex = 9;
            this.lblStok.Text = "Stok";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(828, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(919, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1012, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtFiltre
            // 
            this.txtFiltre.Location = new System.Drawing.Point(113, 618);
            this.txtFiltre.Name = "txtFiltre";
            this.txtFiltre.Size = new System.Drawing.Size(100, 20);
            this.txtFiltre.TabIndex = 14;
            this.txtFiltre.TextChanged += new System.EventHandler(this.txtFiltre_TextChanged);
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Location = new System.Drawing.Point(39, 625);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(29, 13);
            this.lblFiltre.TabIndex = 15;
            this.lblFiltre.Text = "Filtre";
            // 
            // lblHizala
            // 
            this.lblHizala.AutoSize = true;
            this.lblHizala.Location = new System.Drawing.Point(39, 69);
            this.lblHizala.Name = "lblHizala";
            this.lblHizala.Size = new System.Drawing.Size(36, 13);
            this.lblHizala.TabIndex = 16;
            this.lblHizala.Text = "Hizala";
            // 
            // rdUrunAdi
            // 
            this.rdUrunAdi.AutoSize = true;
            this.rdUrunAdi.Location = new System.Drawing.Point(81, 67);
            this.rdUrunAdi.Name = "rdUrunAdi";
            this.rdUrunAdi.Size = new System.Drawing.Size(66, 17);
            this.rdUrunAdi.TabIndex = 17;
            this.rdUrunAdi.TabStop = true;
            this.rdUrunAdi.Text = "Ürün Adı";
            this.rdUrunAdi.UseVisualStyleBackColor = true;
            this.rdUrunAdi.CheckedChanged += new System.EventHandler(this.rdUrunAdi_CheckedChanged);
            // 
            // rdFiyat
            // 
            this.rdFiyat.AutoSize = true;
            this.rdFiyat.Location = new System.Drawing.Point(179, 67);
            this.rdFiyat.Name = "rdFiyat";
            this.rdFiyat.Size = new System.Drawing.Size(47, 17);
            this.rdFiyat.TabIndex = 18;
            this.rdFiyat.TabStop = true;
            this.rdFiyat.Text = "Fiyat";
            this.rdFiyat.UseVisualStyleBackColor = true;
            this.rdFiyat.CheckedChanged += new System.EventHandler(this.rdUrunAdi_CheckedChanged);
            // 
            // rdStok
            // 
            this.rdStok.AutoSize = true;
            this.rdStok.Location = new System.Drawing.Point(276, 65);
            this.rdStok.Name = "rdStok";
            this.rdStok.Size = new System.Drawing.Size(47, 17);
            this.rdStok.TabIndex = 19;
            this.rdStok.TabStop = true;
            this.rdStok.Text = "Stok";
            this.rdStok.UseVisualStyleBackColor = true;
            this.rdStok.CheckedChanged += new System.EventHandler(this.rdUrunAdi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 671);
            this.Controls.Add(this.rdStok);
            this.Controls.Add(this.rdFiyat);
            this.Controls.Add(this.rdUrunAdi);
            this.Controls.Add(this.lblHizala);
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.txtFiltre);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numStok);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.numFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.lblTedarikci);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbTedarikci;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.NumericUpDown numStok;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtFiltre;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.Label lblHizala;
        private System.Windows.Forms.RadioButton rdUrunAdi;
        private System.Windows.Forms.RadioButton rdFiyat;
        private System.Windows.Forms.RadioButton rdStok;
    }
}

