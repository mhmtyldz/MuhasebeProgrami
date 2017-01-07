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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            var sonuc = from urun in ctx.Urunlers
                        join satisdetay in ctx.SatisDetays
                        on urun.UrunID equals satisdetay.UrunID
                        group satisdetay by urun.UrunAdi into grup
                       
                        select new
                        {
                           ÜrünAdı=grup.Key,
                           ToplamSatis = grup.Sum(x=>x.Fiyat*x.Adet)
                        };
            dataGridView1.DataSource = sonuc;
        }
    }
}
