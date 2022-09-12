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
using DAL.Enums;


namespace Win_UI
{
    public partial class Yonetici_Modulu : Form
    {
        
        public Yonetici_Modulu()
        {
            InitializeComponent();
        }
        BaseRepository<Calısan> calısanrepository = new BaseRepository<Calısan>();
        
        
        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.WindowState = FormWindowState.Maximized;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();

            }

        }

        private void resepsiyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CalısanCRUD());
        }

       

        private void Yonetici_Modulu_Load(object sender, EventArgs e)
        {

        }

        private void hIZLIBAKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new HızlıBakış());
        }

        private void odaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new Room());
        }

        private void hızlıRezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void çalışanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rezervasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new Rezervasyonlar());
        }

        private void rezervasyonOluşturYENİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new RezervasyonOlustur());
        }

        private void müşteriKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new MusteriKayıtları());
        }
    }
}
