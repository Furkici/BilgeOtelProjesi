using BLL.Repository;
using DAL.Entity;
using DAL.Enums;
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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }
        BaseRepository<TatilPaketi> tatilpaketRepository = new BaseRepository<TatilPaketi>();
        BaseRepository<Oda> odaRepository = new BaseRepository<Oda>();
       
        private void OdaListele()
        {
            listView1.Items.Clear();
            cmbOdaDurumu.Items.Clear();
            cmbOdaTipi.Items.Clear();
            List<Oda> odalar=odaRepository.GetList();
            List<OdaDurumu> odaDurumlari = Enum.GetValues(typeof(OdaDurumu)).Cast<OdaDurumu>().ToList();
            List<OdaTipiAdı> odatipleri = Enum.GetValues(typeof(OdaTipiAdı)).Cast<OdaTipiAdı>().ToList();
            foreach (Oda oda in odalar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = oda.OdaID.ToString();
                lvi.SubItems.Add(oda.OdaTipiAdı.ToString());
                lvi.SubItems.Add(oda.OdaDurumu.ToString());
                lvi.SubItems.Add(oda.Fiyat.ToString());
                lvi.SubItems.Add(oda.OdaOzellik.ToString());
                listView1.Items.Add(lvi);
            }
            foreach(OdaDurumu odaDurumu in odaDurumlari)
            {
                cmbOdaDurumu.Items.Add(odaDurumu.ToString());
                cmbOdaDurumu.Tag = odaDurumu;
            }

            foreach (OdaTipiAdı odaTipi in odatipleri)
            {
                cmbOdaTipi.Items.Add(odaTipi.ToString());
                cmbOdaTipi.Tag = odaTipi;
            }
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {
            
            OdaListele();
        }

        private void Temizle()
        {
            foreach(Control ctrl in this.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox txt = (TextBox)ctrl;
                    txt.Text = "";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Oda oda = new Oda();
                oda.OdaTipiAdı = (OdaTipiAdı)cmbOdaTipi.SelectedIndex;
                oda.OdaDurumu = (OdaDurumu)cmbOdaDurumu.SelectedIndex;
                oda.Fiyat = Convert.ToInt32(txtFiyat.Text);
                oda.OdaOzellik = textBox1.Text;
                string result = odaRepository.Create(oda);
                MessageBox.Show(result);
               
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            OdaListele();

            Temizle();
           
        }

        private void Tatilpaketlistele()
        {
            listView2.Items.Clear();
            List<TatilPaketi> tatilpaketleri = tatilpaketRepository.GetList();
            foreach (TatilPaketi tatilPaketi in tatilpaketleri)
            {
                ListViewItem lvii = new ListViewItem();
                lvii.Text = tatilPaketi.TatilPaketID.ToString();
                lvii.SubItems.Add(tatilPaketi.Fiyat.ToString());
                lvii.SubItems.Add(tatilPaketi.TatilPaketTipi.ToString());
                listView2.Items.Add(lvii);
            }
            Temizle();
        }
        private void Room_Load(object sender, EventArgs e)
        {
            Tatilpaketlistele();
            OdaListele();
            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtOdaID.Text);
                Oda updated = odaRepository.FindById(deger);
                if (cmbOdaTipi.Text!="")
                {
                    updated.OdaTipiAdı = (OdaTipiAdı)cmbOdaTipi.SelectedIndex;
                }
                if(cmbOdaDurumu.Text!="")
                {
                    updated.OdaDurumu = (OdaDurumu)cmbOdaDurumu.SelectedIndex;
                }
                if(txtFiyat.Text!="")
                {
                    updated.Fiyat = Convert.ToInt32(txtFiyat.Text);
                }
                if(textBox1.Text!="")
                {
                    updated.OdaOzellik = textBox1.Text;
                }
                string resultupdate=odaRepository.Update(updated);
                MessageBox.Show(resultupdate);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            OdaListele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtOdaID.Text);
                string result = odaRepository.Delete(deger);
                MessageBox.Show(result);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            OdaListele();
            Temizle();
        }

        private void cmbOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTatilPaketiFiyat.Text!="")
                {
                    int id;
                    id = Convert.ToInt32(txtTatilPaketiID.Text);
                    TatilPaketi guncelli = tatilpaketRepository.FindById(id);
                    if(txtTatilPaketiFiyat.Text!="")
                    {
                        guncelli.Fiyat = Convert.ToInt32(txtTatilPaketiFiyat.Text);
                        string result = tatilpaketRepository.Update(guncelli);
                    }
                    else
                    {
                        MessageBox.Show("Lütfen fiyat giriniz");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Id giriniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Tatilpaketlistele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HızlıBakış hızlıBakış = new HızlıBakış();
            hızlıBakış.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriKayıtları musteriKayıtları = new MusteriKayıtları();
            musteriKayıtları.Show();
            this.Hide();

        }
    }
}
