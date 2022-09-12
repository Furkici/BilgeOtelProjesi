using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class CalısanMap:EntityTypeConfiguration<Calısan>
    {
        public CalısanMap()
        {
            ToTable("dbo.Calısanlar");
            Property(x => x.CalısanID).IsRequired();
            Property(x => x.IlkAd).HasMaxLength(40).IsRequired();
            Property(x => x.Soyad).HasMaxLength(40).IsRequired();
            Property(x => x.Email).HasMaxLength(40).IsOptional();
            Property(x => x.Password).HasMaxLength(6).IsOptional();
            Property(x => x.Vardiya).IsOptional();
            Property(x => x.Gorev).IsRequired();
            Property(x => x.Ucret).IsOptional();

        }
    }
}
