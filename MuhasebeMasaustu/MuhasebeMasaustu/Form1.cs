using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeMasaustu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MuhasebeDataContext ctx = new MuhasebeDataContext();
            dataGridView1.DataSource = ctx.Urunlers;
            cmbKategori.DataSource = ctx.Kategorilers;
            cmbKategori.DisplayMember = "KategoriAdi";// Git tırnak içine yazdığın kategorileri getir eğer yazmazsan system.blabla çalışıyor
            cmbKategori.ValueMember = "KategoriID"; //Valuesine de kategori Id yi yaz 
            cmbTedarikci.DataSource = ctx.Tedarikcilers;
            cmbTedarikci.DisplayMember = "SirketAdi";
            cmbTedarikci.ValueMember = "TedarikciID";


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MuhasebeDataContext ctx = new MuhasebeDataContext();
            Urunler urn = new Urunler();
            urn.UrunAdi = txtUrunAdi.Text;
            urn.Fiyat = numFiyat.Value;
            urn.Stok = (short)numStok.Value;
            urn.KategoriID = (int)cmbKategori.SelectedValue;
            urn.TedarikciID = (int)cmbTedarikci.SelectedValue;

            ctx.Urunlers.InsertOnSubmit(urn);
            ctx.SubmitChanges();//Suana kadar eklediğim ürünü contexe gönder silmişmiyim databaseden sil 

            dataGridView1.DataSource = ctx.Urunlers;
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int urunId =(int)dataGridView1.CurrentRow.Cells["UrunId"].Value; // silmek için ürününId yi yakalamam gerekiyo o yüzden de ürün Id yi buluyorum
            MuhasebeDataContext ctx = new MuhasebeDataContext();
            Urunler urn = ctx.Urunlers.SingleOrDefault(urun => urun.UrunID==urunId);//Lamda expression yaptık where UrunId yi buldu burda
            //Single or default Tekil hücre seçmeye yarar Lamdayla da koşul verdik 
            ctx.Urunlers.DeleteOnSubmit(urn);//SilveOnayla
            ctx.SubmitChanges();
            dataGridView1.DataSource = ctx.Urunlers;




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txtUrunAdi.Text = row.Cells["UrunAdi"].Value.ToString();
            txtUrunAdi.Tag = row.Cells["UrunId"].Value;
            cmbKategori.SelectedValue = row.Cells["KategoriID"].Value;
            cmbTedarikci.SelectedValue = row.Cells["TedarikciId"].Value;
            numFiyat.Value = (decimal)row.Cells["Fiyat"].Value;
            numStok.Value = (short)row.Cells["Stok"].Value;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int urunid = (int)txtUrunAdi.Tag;
            MuhasebeDataContext ctx = new MuhasebeDataContext();
            Urunler urn = ctx.Urunlers.SingleOrDefault(urun => urun.UrunID == urunid);
            urn.UrunAdi = txtUrunAdi.Text;
            urn.Fiyat = numFiyat.Value;
            urn.Stok = (short)numStok.Value;
            urn.TedarikciID = (int)cmbTedarikci.SelectedValue;
            urn.KategoriID = (int)cmbKategori.SelectedValue;
            ctx.SubmitChanges();

            dataGridView1.DataSource = ctx.Urunlers;

        }

        private void txtFiltre_TextChanged(object sender, EventArgs e)
        {
            MuhasebeDataContext ctx = new MuhasebeDataContext();
            dataGridView1.DataSource = ctx.Urunlers.Where(x=>x.UrunAdi.Contains(txtFiltre.Text));
        }

        private void rdUrunAdi_CheckedChanged(object sender, EventArgs e)
        {
            MuhasebeDataContext ctx = new MuhasebeDataContext();
            if (rdUrunAdi.Checked)
                dataGridView1.DataSource = ctx.Urunlers.OrderBy(x => x.UrunAdi);
            else if (rdStok.Checked)
                dataGridView1.DataSource = ctx.Urunlers.OrderByDescending(x => x.Stok);
            else if(rdFiyat.Checked)
                dataGridView1.DataSource = ctx.Urunlers.OrderByDescending(x => x.Fiyat);
        }
    }
}
