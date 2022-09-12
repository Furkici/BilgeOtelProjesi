using DAL.Entity;
using DAL.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class BilgeHotelContext:DbContext
    {
        public BilgeHotelContext()
        {
            Database.Connection.ConnectionString = "Server=LAPTOP-IOIAUL56;Database=BilgOtelDB;Trusted_Connection=True;";
        }

        public DbSet<Calısan> Calısanlar { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Oda> Odalar { get; set; }
        
        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }
        public DbSet<TatilPaketi> TatilPaketleri { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CalısanMap());
            modelBuilder.Configurations.Add(new MusteriMap());
            modelBuilder.Configurations.Add(new OdaMap());
            
            modelBuilder.Configurations.Add(new RezervasyonMap());
            modelBuilder.Configurations.Add(new TatilPaketiMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
