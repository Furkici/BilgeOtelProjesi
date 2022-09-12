using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Rezervasyon:BaseEntity
    {
        BilgeHotelContext db = new BilgeHotelContext();
        public Rezervasyon()
        {
           RezervasyonTarihi= DateTime.Now;
           
        }
        public int RezervasyonID { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CıkısTarihi { get; set; }
        private int _gunsayısı;
        public int GunSayısı
        {
            get
            {
                _gunsayısı = CıkısTarihi.Day - GirisTarihi.Day;
                return _gunsayısı;
            }
            set { _gunsayısı = value; }
        }

            
        public DateTime RezervasyonTarihi { get; set; }
       
        public int TatilPaketiID { get; set; }
        public int OdaID { get; set; }

        public TatilPaketi TatilPaketi { get; set; }
        public Oda rezervasyonOda { get; set; }

        public Musteri Musteri { get; set; }
        public int MusteriID { get; set; }
        
        private decimal _toplamFiyat;

        public decimal ToplamFiyat
        {
            get
            {
                decimal toplam;
                Oda tutulanoda = db.Odalar.FirstOrDefault(x => x.OdaID == OdaID);
                TatilPaketi tatilPaketi = db.TatilPaketleri.FirstOrDefault(x => x.TatilPaketID == TatilPaketiID);
                if (GirisTarihi.Day - RezervasyonTarihi.Day >= 30 && TatilPaketiID == 2)
                {
                    toplam = (tutulanoda.Fiyat + tatilPaketi.Fiyat) * GunSayısı;
                    _toplamFiyat = toplam - (toplam * 0.18m);

                }
                else if (GirisTarihi.Day - RezervasyonTarihi.Day >= 30 && TatilPaketiID == 1)
                {
                    toplam = (tutulanoda.Fiyat + tatilPaketi.Fiyat) * GunSayısı;
                    _toplamFiyat = toplam - (toplam * 0.16m);
                }
                else if (GirisTarihi.Day - RezervasyonTarihi.Day >= 90)
                {
                    toplam = (tutulanoda.Fiyat + tatilPaketi.Fiyat) * GunSayısı;
                    _toplamFiyat = toplam -(toplam * 0.23m);
                }
                else
                {
                    _toplamFiyat = (tutulanoda.Fiyat + tatilPaketi.Fiyat) * GunSayısı;
                }
                
                return _toplamFiyat;
            }
            set { _toplamFiyat = value; }
        }


        

    }
}
