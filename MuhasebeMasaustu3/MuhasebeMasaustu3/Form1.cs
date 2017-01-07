using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhasebeMasaustu3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            dataGridView1.DataSource = from urun in ctx.Urunlers
                                       join sd in ctx.SatisDetays on urun.UrunID equals sd.UrunID 
                                       join satis in ctx.Satislars on sd.SatisID equals satis.SatisID
                                       join personel in ctx.Personellers on satis.PersonelID equals personel.PersonelID
                                       join tedarikci in ctx.Tedarikcilers on urun.TedarikciID equals tedarikci.TedarikciID
                                       join kategori in ctx.Kategorilers on urun.KategoriID equals kategori.KategoriID
                                       join musteriler in ctx.Musterilers on satis.MusteriID equals musteriler.MusteriID
                                       orderby sd.Fiyat descending
                                       select new
                                       {
                                           urun.UrunAdi,
                                           urun.Fiyat,
                                           satisFiyat=sd.Fiyat,
                                           sd.Adet,
                                           sd.Indirim,
                                           musteriler.MusteriAdi,
                                           Personel=personel.Adi+" "+personel.SoyAdi,
                                           //personel.SoyAdi,
                                           tedarikci.SirketAdi


                                       };
        }
    }
}
