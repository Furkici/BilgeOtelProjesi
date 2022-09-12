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
using DAL.Context;

namespace Win_UI
{
    public partial class Rezervasyonlar : Form
    {
        public Rezervasyonlar()
        {
            InitializeComponent();
        }
        BaseRepository<Rezervasyon> rezervasyonRepository = new BaseRepository<Rezervasyon>();
        BaseRepository<Musteri> musteriRepository = new BaseRepository<Musteri>();
        BaseRepository<Oda> odaRepository = new BaseRepository<Oda>();
        BaseRepository<TatilPaketi> tatilPaketiRepo = new BaseRepository<TatilPaketi>();
        BilgeHotelContext db = new BilgeHotelContext();

        private void Listele()
        {
            listView1.Items.Clear();
            List<Rezervasyon> rezervasyonlars = rezervasyonRepository.GetList();
            foreach (Rezervasyon rezervasyon in rezervasyonlars)
            {
                Oda secilioda = db.Odalar.FirstOrDefault(x=>x.OdaID==rezervasyon.OdaID);
                TatilPaketi tatil = db.TatilPaketleri.FirstOrDefault(x => x.TatilPaketID == rezervasyon.TatilPaketiID);
                Musteri musteri = db.Musteriler.FirstOrDefault(x=>x.MusteriID==rezervasyon.MusteriID);
                ListViewItem lvi = new ListViewItem();
                lvi.Text = rezervasyon.RezervasyonID.ToString();
                lvi.SubItems.Add(rezervasyon.GirisTarihi.ToString());
                lvi.SubItems.Add(rezervasyon.CıkısTarihi.ToString());
                lvi.SubItems.Add(rezervasyon.GunSayısı.ToString());
                lvi.SubItems.Add(rezervasyon.RezervasyonTarihi.ToString());
                lvi.SubItems.Add(rezervasyon.TatilPaketiID.ToString());
                lvi.SubItems.Add(rezervasyon.OdaID.ToString());
                lvi.SubItems.Add(rezervasyon.MusteriID.ToString());
                lvi.SubItems.Add(rezervasyon.ToplamFiyat.ToString());
                lvi.SubItems.Add(musteri.Ad);
                lvi.SubItems.Add(musteri.Soyad);
                lvi.SubItems.Add(musteri.TCKN);
                lvi.SubItems.Add(secilioda.OdaTipiAdı.ToString());
                lvi.SubItems.Add(tatil.TatilPaketTipi);

                listView1.Items.Add(lvi);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezervasyonOlustur rezervasyonOlustur = new RezervasyonOlustur();
            rezervasyonOlustur.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RezervasyonOlustur rezervasyonOlustur = new RezervasyonOlustur();
            rezervasyonOlustur.Show();
            this.Hide();
        }
    }
}
