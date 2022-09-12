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
    public partial class GirisEkranı : Form
    {
        public GirisEkranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (txtKullanıcıAdı.Text.ToLower() == "resepsiyon" && txtSifre.Text == "1234")
            {
                RezervasyonOlustur rezervasyonOlustur = new RezervasyonOlustur();
                rezervasyonOlustur.Show();
                this.Hide();

            }
            else if (txtKullanıcıAdı.Text.ToLower() == "yönetici" && txtSifre.Text == "1234")
            {
                Yonetici_Modulu Ymodulu = new Yonetici_Modulu();
                Ymodulu.Show();
                this.Hide();
            }
            else if(txtKullanıcıAdı.Text.ToLower()=="satış"&& txtSifre.Text=="1234")
            {
                Room room = new Room();
                room.Show();
                this.Hide();
            }
            else if (txtKullanıcıAdı.Text.ToLower()=="ik"&&txtSifre.Text=="1234")
            {
                CalısanCRUD ik = new CalısanCRUD();
                ik.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yetkniz yok!");
            }
            

        }

        private void GirisEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
