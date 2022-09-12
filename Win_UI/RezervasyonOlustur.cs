using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using BLL.Repository;
using DAL.Entity;
using DAL.Enums;

namespace Win_UI
{
    public partial class RezervasyonOlustur : Form
    {
        public RezervasyonOlustur()
        {
            InitializeComponent();
        }
        BaseRepository<Oda> odaRepository = new BaseRepository<Oda>();
        BaseRepository<Rezervasyon> rezervasyonRepository = new BaseRepository<Rezervasyon>();
        BaseRepository<Musteri> musteriRepository = new BaseRepository<Musteri>();
        

        private void Müşterilistele()
        {
            List<Musteri> musteriler = musteriRepository.GetList();


            foreach (Musteri musteri in musteriler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = musteri.MusteriID.ToString();
                lvi.SubItems.Add(musteri.TCKN);
                lvi.SubItems.Add(musteri.Ad);
                lvi.SubItems.Add(musteri.Soyad);
                lvi.SubItems.Add(musteri.Telefon.ToString());
                lvi.SubItems.Add(musteri.Email);
                lstMüşteriler.Items.Add(lvi);
                   
               
                
               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lstMüşteriler.Items.Clear();
            try
            {
                Musteri müşteri = new Musteri();
                
                müşteri.TCKN = txtMüşteritckn.Text.ToString();
                müşteri.Ad = txtMüşteriAdı.Text.ToString();
                müşteri.Soyad = txtMüşteriSoyAD.Text.ToString();
                müşteri.Telefon = txtMüşteriTel.Text.ToString();
                müşteri.Email=txtMüşteriMail.Text.ToString();
               string result = musteriRepository.Create(müşteri);
                MessageBox.Show(result);
                
                
                
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
            Müşterilistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstRezervasyon.Items.Clear();
            List<Oda> odalar = odaRepository.GetList();
            List<OdaDurumu> odaDurumlari = Enum.GetValues(typeof(OdaDurumu)).Cast<OdaDurumu>().ToList();
            List<OdaTipiAdı> odatipleri = Enum.GetValues(typeof(OdaTipiAdı)).Cast<OdaTipiAdı>().ToList();
            foreach (Oda oda in odalar)
            {
                if (oda.OdaDurumu == OdaDurumu.Musait)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = oda.OdaID.ToString();
                    lvi.SubItems.Add(oda.OdaTipiAdı.ToString());
                    lvi.SubItems.Add(oda.OdaDurumu.ToString());
                    lvi.SubItems.Add(oda.Fiyat.ToString());
                    lvi.SubItems.Add(oda.OdaOzellik.ToString());
                    lstRezervasyon.Items.Add(lvi);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                Rezervasyon rezervasyon = new Rezervasyon();
                if(datetimepickertekgiris.Value>=DateTime.Now&&datetimepickertekgiris.Value<dateTimePickertekcıkıs.Value)
                {
                    
                    rezervasyon.MusteriID = Convert.ToInt32(txtMusteriID.Text);
                   
                    rezervasyon.GirisTarihi=datetimepickertekgiris.Value;
                    rezervasyon.CıkısTarihi = dateTimePickertekcıkıs.Value;
                    
                    rezervasyon.TatilPaketiID = Convert.ToInt32(txtTatilPaketID.Text);
                    rezervasyon.OdaID = Convert.ToInt32(txtOdaID.Text);

                   
                        string result = rezervasyonRepository.Create(rezervasyon);
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Geçerli Tarih Girin!");
                }


            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }

            
           
            



            Rezervasyonlar rezervasyonlar = new Rezervasyonlar();
            rezervasyonlar.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HızlıBakış hızlıBakış = new HızlıBakış();
            hızlıBakış.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstRezervasyon.Items.Clear();
            List<Oda> odalar = odaRepository.GetList();
            List<OdaDurumu> odaDurumlari = Enum.GetValues(typeof(OdaDurumu)).Cast<OdaDurumu>().ToList();
            List<OdaTipiAdı> odatipleri = Enum.GetValues(typeof(OdaTipiAdı)).Cast<OdaTipiAdı>().ToList();
            foreach (Oda oda in odalar)
            {
                if (oda.OdaDurumu == OdaDurumu.Dolu)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = oda.OdaID.ToString();
                    lvi.SubItems.Add(oda.OdaTipiAdı.ToString());
                    lvi.SubItems.Add(oda.OdaDurumu.ToString());
                    lvi.SubItems.Add(oda.Fiyat.ToString());
                    lvi.SubItems.Add(oda.OdaOzellik.ToString());
                    lstRezervasyon.Items.Add(lvi);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstRezervasyon.Items.Clear();
            List<Oda> odalar = odaRepository.GetList();
            List<OdaDurumu> odaDurumlari = Enum.GetValues(typeof(OdaDurumu)).Cast<OdaDurumu>().ToList();
            List<OdaTipiAdı> odatipleri = Enum.GetValues(typeof(OdaTipiAdı)).Cast<OdaTipiAdı>().ToList();
            foreach (Oda oda in odalar)
            {
                if (oda.OdaDurumu == OdaDurumu.Bakımda)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = oda.OdaID.ToString();
                    lvi.SubItems.Add(oda.OdaTipiAdı.ToString());
                    lvi.SubItems.Add(oda.OdaDurumu.ToString());
                    lvi.SubItems.Add(oda.Fiyat.ToString());
                    lvi.SubItems.Add(oda.OdaOzellik.ToString());
                    lstRezervasyon.Items.Add(lvi);
                }
            }
        }

        private void dateTimePickertekcıkıs_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void datetimepickertekgiris_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rezervasyonlar = new Rezervasyonlar();
            rezervasyonlar.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MusteriKayıtları musteriKayıtları = new MusteriKayıtları();
            musteriKayıtları.Show();
            this.Hide();
        }
    }
}
