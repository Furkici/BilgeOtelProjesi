using BLL.Repository;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_UI
{
    public partial class MusteriKayıtları : Form
    {
        public MusteriKayıtları()
        {
            InitializeComponent();
        }
        BaseRepository<Musteri> musteriRepository = new BaseRepository<Musteri>();
        private void MüşteriListele()
        {
            listView1.Items.Clear();
            List<Musteri> musteris = musteriRepository.GetList();
            foreach (Musteri musteri in musteris)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = musteri.MusteriID.ToString();
                lvi.SubItems.Add(musteri.TCKN.ToString());
                lvi.SubItems.Add(musteri.Ad.ToString());
                lvi.SubItems.Add(musteri.Soyad.ToString());
                lvi.SubItems.Add(musteri.Telefon.ToString());
                lvi.SubItems.Add(musteri.Email.ToString());
                listView1.Items.Add(lvi);
            }

        }
        private void MusteriKayıtları_Load(object sender, EventArgs e)
        {
            MüşteriListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtmusteriıd.Text);
                string result = musteriRepository.Delete(deger);
                MessageBox.Show(result);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            MüşteriListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonOlustur rezervasyonOlustur = new RezervasyonOlustur();
            rezervasyonOlustur.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Room room = new Room();
            room.Show();
            this.Hide();
        }
    }
}
