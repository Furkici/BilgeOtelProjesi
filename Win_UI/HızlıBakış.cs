using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Repository;
using DAL.Entity;

namespace Win_UI
{
    public partial class HızlıBakış : Form
    {   
        public HızlıBakış()
        {
            InitializeComponent();
        }
        BaseRepository<Calısan> calisanRepository = new BaseRepository<Calısan>();
        private void CalisanListele()
        {
            listView1.Items.Clear();
            List<Calısan> calisanlar = calisanRepository.GetList();


            foreach (Calısan calısan in calisanlar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = calısan.Gorev.ToString();
                lvi.SubItems.Add(calısan.CalısanID.ToString());
                lvi.SubItems.Add(calısan.IlkAd.ToString());
                lvi.SubItems.Add(calısan.Soyad.ToString());
                
                lvi.SubItems.Add(calısan.Yas.ToString());
                lvi.SubItems.Add(calısan.SaatSayısı.ToString());
                lvi.SubItems.Add(calısan.Vardiya.ToString());
                listView1.Items.Add(lvi);

                

            }
        }

        private void HızlıBakış_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalisanListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonOlustur rezervasyonOlustur = new RezervasyonOlustur();
            rezervasyonOlustur.Show();
            this.Hide();

        }
    }
}
