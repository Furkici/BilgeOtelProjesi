using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Musteri:BaseEntity
    {
        public int MusteriID { get; set; }
        public string TCKN { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public List<Rezervasyon> Rezervasyonlar { get; set; }

    }
}
