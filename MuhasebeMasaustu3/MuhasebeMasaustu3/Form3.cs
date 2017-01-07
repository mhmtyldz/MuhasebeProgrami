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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Hangi personel kaç kere satış yapmıştır 
            KuzeyYeliDataContext ctx = new KuzeyYeliDataContext();
            var sonuc = from satis in ctx.Satislars
                        join personel in ctx.Personellers on satis.PersonelID equals personel.PersonelID
                        group satis by personel.Adi into grup
                        select new
                        {
                            PersonelAdı = grup.Key,
                            ToplamSatış = grup.Count()

                        };
            dataGridView1.DataSource = sonuc;

        }
    }
}
