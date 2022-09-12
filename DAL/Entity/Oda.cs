using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Oda : BaseEntity
    {
        public int OdaID { get; set; }
       
        public OdaDurumu  OdaDurumu { get; set; }
        public OdaTipiAdı OdaTipiAdı { get; set; }
        public string OdaOzellik { get; set; }

        public List<Rezervasyon> Rezervasyonlar { get; set; }

        public decimal Fiyat { get; set; }
        //public decimal _fiyat { get; set; }

        //public decimal Fiyat
        //{

        //    get
        //    {
        //        switch (OdaTipiAdı)
        //        {
        //            case OdaTipiAdı.TekKisilik:
        //                _fiyat = 500;
        //                break;
        //            case OdaTipiAdı.CiftKisilik:
        //                _fiyat = 600;
        //                break;
        //            case OdaTipiAdı.UcKisilik:
        //                _fiyat = 700;
        //                break;
        //            case OdaTipiAdı.DortKisilik:
        //                _fiyat = 800;
        //                break;
        //            case OdaTipiAdı.KralDairesi:
        //                _fiyat = 1000;
        //                break;

        //        }
        //        return _fiyat;
        //    }

        //    set
        //    {
        //        _fiyat = value;
        //    }
        //}

    }
}
