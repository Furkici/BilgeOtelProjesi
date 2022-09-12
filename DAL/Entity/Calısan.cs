using DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Calısan : BaseEntity
    {
        public int CalısanID { get; set; }
        public string IlkAd { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string TelefonNo { get; set; }


        public string Vardiya  { get; set; }
        public int SaatSayısı { get; set; }

        public string Gorev { get; set; }
        public decimal Ucret { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private decimal _maas;
        public decimal Maas
        {
            get

            {
                if (Gorev.Contains("Yönetici"))
                {
                    
                    SaatSayısı = 1;
                    _maas = Ucret;
                }

                else if (Gorev.Contains("Görevlisi"))
                {
                   
                   _maas = Ucret * SaatSayısı * 26;
                    
                }

                else
                {
                    _maas = Ucret * SaatSayısı;
                }
                return _maas;
            }

            set { _maas = value; }






        }
    }
}
