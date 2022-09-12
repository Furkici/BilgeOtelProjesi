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
    public partial class CalısanCRUD : Form
    {
        public CalısanCRUD()
        {
            InitializeComponent();
        }
        BaseRepository<Calısan> calisanRepository = new BaseRepository<Calısan>();
        private void CalisanListele()
        {
            lstCalısanlar.Items.Clear();
            List<Calısan> calisanlar = calisanRepository.GetList();


            foreach (Calısan calisan in calisanlar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = calisan.CalısanID.ToString();
                lvi.SubItems.Add(calisan.IlkAd);
                lvi.SubItems.Add(calisan.Soyad);
                lvi.SubItems.Add(calisan.TelefonNo);
                lvi.SubItems.Add(calisan.Yas.ToString());
                lvi.SubItems.Add(calisan.Gorev.ToString());
                lvi.SubItems.Add(calisan.Vardiya.ToString());
                lvi.SubItems.Add(calisan.Ucret.ToString());
                lvi.SubItems.Add(calisan.SaatSayısı.ToString());
                lvi.SubItems.Add(calisan.Maas.ToString());
                lstCalısanlar.Items.Add(lvi);   
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Calısan calısan = new Calısan();
                
                calısan.IlkAd = txtcalısanad.Text;
                calısan.Soyad = txtSoyadı.Text;
                calısan.TelefonNo = txtTelNo.Text;
                calısan.Yas = Convert.ToInt32(txtYas.Text);
                calısan.Gorev = textBox1.Text;
                calısan.SaatSayısı = Convert.ToInt32(txtSaatSayısı.Text);
                calısan.Ucret = Convert.ToInt32(txtUcret.Text);
                calısan.Email = txtEmail.Text;
                calısan.Password = txtSifre.Text;
                calısan.Vardiya = txtvardiyaekleme.Text;
                
                string result = calisanRepository.Create(calısan);
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString()); 
            }
            CalisanListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            CalisanListele();
        }

        private void ResepsiyonCRUD_Load(object sender, EventArgs e)
        {
            
        }

        private void lstCalısanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtIDGüncelleme.Text);

                Calısan updated = calisanRepository.FindById(deger);
                if (txtadGuncelleme.Text != "")
                {
                    updated.IlkAd = txtadGuncelleme.Text;
                }

                if (txtSoyadGuncelleme.Text != "")
                {
                    updated.Soyad = txtSoyadGuncelleme.Text;
                }

                if (txtEmailGüncelleme.Text != "")
                {
                    updated.Email = txtEmailGüncelleme.Text;


                }
                if(txtSaatSayısıgüncelleme.Text !="")
                {
                    updated.SaatSayısı = Convert.ToInt32(txtSaatSayısıgüncelleme.Text);
                }

                if (txtSifreGüncelleme.Text != "")
                {
                    updated.Password = txtSifreGüncelleme.Text;
                }
                if (txtUcretGüncelleme.Text != "")
                {

                    try
                    {
                        updated.Ucret = Convert.ToDecimal(txtUcretGüncelleme.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                if (txtGorevGüncelleme.Text != "")
                {
                    updated.Gorev = txtGorevGüncelleme.Text;
                }
                if(txtvardiyaguncelleme.Text!="")
                {
                    updated.Vardiya = txtvardiyaguncelleme.Text;
                }






                string result = calisanRepository.Update(updated);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            CalisanListele();

        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            try
            {
                int deger;
                deger = Convert.ToInt32(txtdeleted.Text);
                string result = calisanRepository.Delete(deger);
                MessageBox.Show(result);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            CalisanListele();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HızlıBakış hızlıBakış = new HızlıBakış();
            hızlıBakış.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rezervasyonlar = new Rezervasyonlar();
            rezervasyonlar.Show();
            this.Hide();

        }
    }
}

