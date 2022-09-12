namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAL.Entity;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context.BilgeHotelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DAL.Context.BilgeHotelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            List<Oda> odalar = new List<Oda>()
            {
                new Oda
                {

                    OdaTipiAdı = Enums.OdaTipiAdı.TekKisilik,
                    OdaDurumu = Enums.OdaDurumu.Musait,
                    Fiyat=500,
                    OdaOzellik="1. kat,Minibar,wifi,saç kurutma makinesi,havlu,lcd tv"


                },
                new Oda
                {
                    OdaTipiAdı = Enums.OdaTipiAdı.CiftKisilik,
                    OdaDurumu = Enums.OdaDurumu.Musait,
                    Fiyat=650,
                    OdaOzellik="2.kat,minibar,wifi,saç kurutma,lcd tv,havlu"

                },

                new Oda
                {
                    OdaTipiAdı = Enums.OdaTipiAdı.UcKisilik,
                    OdaDurumu = Enums.OdaDurumu.Musait,
                    Fiyat=800,
                    OdaOzellik="3.kat,Balkonlu,wifi,saç kurutma,havlu,tv "


                },
                new Oda
                {
                    OdaTipiAdı = Enums.OdaTipiAdı.DortKisilik,
                    OdaDurumu = Enums.OdaDurumu.Musait,
                    Fiyat=1000,
                    OdaOzellik="4.kat,Balkonlu,wifi,saç kurutma,havlu,tv "


                },
                new Oda
                {
                    OdaTipiAdı = Enums.OdaTipiAdı.KralDairesi,
                    OdaDurumu = Enums.OdaDurumu.Musait,
                    Fiyat=1500,
                    OdaOzellik="4.kat,Balkonlu,wifi,saç kurutma,havlu,tv,masaj yatağı,özel alanlı spa "


                },


            };
            if (!context.Odalar.Any())
            {
                foreach (var oda in odalar)
                {
                    context.Odalar.Add(oda);
                    context.SaveChanges();
                }
            }
            List<Calısan> calisanlar = new List<Calısan>()
            {
                new Calısan
                {
                    CalısanID=1,
                    IlkAd="Ahmet",
                    Soyad="Güngör",
                    TelefonNo="05534539845",
                    Yas=42,
                    Ucret=5000,
                    SaatSayısı=8,
                    Vardiya="Öğlen",
                    Gorev="Resepsiyon Görevlisi"
                },
                new Calısan
                { CalısanID = 2,
                    IlkAd = "Mehmet",
                    Soyad = "Selim",
                    TelefonNo="05421237253",
                    Yas=38,
                    Ucret=5500,
                    SaatSayısı=8,
                    Vardiya = "sabah",
                    Gorev = "Resepsiyon Görevlisi"
                },
                new Calısan
                { CalısanID=3,
                    IlkAd="Esra",
                    Soyad="Çakmak",
                    TelefonNo="05346847676",
                    Yas=32,
                    Ucret=5200,
                    SaatSayısı=8,
                    Vardiya="Sabah",
                    Gorev="Resepsiyon Görevlisi"
                },
                new Calısan
                {
                CalısanID = 4,
                IlkAd = "Yavuz",
                Soyad = "Elmas",
                TelefonNo="05355687978",
                Yas=26,
                Ucret=5000,
                SaatSayısı=8,
                Vardiya ="Öğlen",
                Gorev = "Resepsiyon Görevlisi"
                },
                new Calısan
                {
                    CalısanID = 5,
                    IlkAd = "Barış",
                    Soyad = "Er",
                    TelefonNo="05326843342",
                    Yas=22,
                    Ucret= 5000,
                    SaatSayısı=8,
                    Vardiya = "Sabah",
                    Gorev = "Resepsiyon Görevlisi"

                },
                 new Calısan
                {
                    CalısanID = 6,
                    IlkAd = "Merve",
                    Soyad = "Kolcuoğlu",
                    TelefonNo="05323128656",
                    Yas= 23,
                    Ucret=5500,
                    SaatSayısı=8,
                    Vardiya = "Akşam",
                    Gorev = "Resepsiyon Görevlisi"
                },
                new Calısan
                {
                    CalısanID = 7,
                    IlkAd = "Furkan",
                    Soyad = "Güneş",
                    TelefonNo="05531426823",
                    Yas=27,
                    Ucret=5000,
                    SaatSayısı=8,
                    Vardiya = "Akşam",
                    Gorev = "Resepsiyon Görevlisi"
                }
            };


            if (!context.Calısanlar.Any())
            {
                foreach (var calisan in calisanlar)
                {
                    context.Calısanlar.Add(calisan);
                    context.SaveChanges();
                }
            }

            List<TatilPaketi> tatilPaketleri = new List<TatilPaketi>()
            {
                new TatilPaketi
                {
                    TatilPaketTipi= "Tam Pansiyon",
                    Fiyat=200,

                },
                new TatilPaketi
                {
                    TatilPaketTipi= "Her şey Dahil",
                    Fiyat=500
                }
            };

            if (!context.TatilPaketleri.Any())
            {
                foreach (var tatilPaketi in tatilPaketleri)
                {
                    context.TatilPaketleri.Add(tatilPaketi);
                    context.SaveChanges();
                }
            }

            

        }






    }
}
