using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class OdevContext : DbContext
    {
        public DbSet<Ogrenciler> Ogrenciler { get; set; }
        public DbSet<tblSiniflar> tblSiniflar { get; set; }
        public DbSet<tblDersler> tblDersler { get; set; }
        public DbSet<tblOgrenciDers> tblOgrenciDers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = OkulFinalProject; Integrated Security = true; TrustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<tblOgrenciDers>()
                .HasKey(od => new { od.OgrenciID, od.DersID });

            modelBuilder.Entity<tblOgrenciDers>()
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.tblOgrenciDers)
                .HasForeignKey(od => od.OgrenciID);

            modelBuilder.Entity<tblOgrenciDers>()
                .HasOne(od => od.Ders)
                .WithMany(d => d.tblOgrenciDers)
                .HasForeignKey(od => od.DersID);

            modelBuilder.Entity<Ogrenciler>()
               .HasOne(o => o.Sinif)  // her ogrencinin bir sinifi olacak
               .WithMany(s => s.Ogrenciler)  // bir sinif birden cok iliskiye saihp olabilir, bire cok.
               .HasForeignKey(o => o.SinifID); // fk var ve sinifID olacak.

            modelBuilder.Entity<tblSiniflar>().HasData(
              new tblSiniflar { SinifID = 1, SinifAd = "1.Sınıf", Kontenjan = 20 },
              new tblSiniflar { SinifID = 2, SinifAd = "2.Sınıf", Kontenjan = 20 },
              new tblSiniflar { SinifID = 3, SinifAd = "3.Sınıf", Kontenjan = 20 },
              new tblSiniflar { SinifID = 4, SinifAd = "4.Sınıf", Kontenjan = 20 }
            );

            modelBuilder.Entity<tblDersler>().HasData(
              new tblDersler { DersID = 1, DersKod = "001", DersAd = "Nesne Tabanlı Programlama" },
              new tblDersler { DersID = 2, DersKod = "002", DersAd = "Veritabanı" },
              new tblDersler { DersID = 3, DersKod = "003", DersAd = "Görsel Programlama" },
              new tblDersler { DersID = 4, DersKod = "004", DersAd = "Web Programlama" }
            );
        }
    }
}
