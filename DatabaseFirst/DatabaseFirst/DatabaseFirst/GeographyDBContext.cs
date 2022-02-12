using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DatabaseFirst.Model;

namespace DatabaseFirst
{
    public partial class GeographyDBContext : DbContext
    {
        public GeographyDBContext()
        {
        }

        public GeographyDBContext(DbContextOptions<GeographyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Continents> Continents { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CountriesRivers> CountriesRivers { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }
        public virtual DbSet<Mountains> Mountains { get; set; }
        public virtual DbSet<MountainsCountries> MountainsCountries { get; set; }
        public virtual DbSet<Peaks> Peaks { get; set; }
        public virtual DbSet<Rivers> Rivers { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies();
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server = 127.0.0.1; user = Maria_Kirilova; database = geography; port = 3306; pwd = 12Parola12");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continents>(entity =>
            {
                entity.HasKey(e => e.ContinentCode)
                    .HasName("PRIMARY");

                entity.ToTable("continents");

                entity.HasIndex(e => e.ContinentCode)
                    .HasName("PK_Continents")
                    .IsUnique();

                entity.Property(e => e.ContinentCode)
                    .HasColumnName("continent_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.ContinentName)
                    .IsRequired()
                    .HasColumnName("continent_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("PRIMARY");

                entity.ToTable("countries");

                entity.HasIndex(e => e.ContinentCode)
                    .HasName("fk_countries_continents");

                entity.HasIndex(e => e.CountryCode)
                    .HasName("PK_Countries")
                    .IsUnique();

                entity.HasIndex(e => e.CurrencyCode)
                    .HasName("fk_countries_currencies");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.AreInSqKm).HasColumnName("are_in_sq_km");

                entity.Property(e => e.Capital)
                    .IsRequired()
                    .HasColumnName("capital")
                    .HasMaxLength(30);

                entity.Property(e => e.ContinentCode)
                    .IsRequired()
                    .HasColumnName("continent_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name")
                    .HasMaxLength(45);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.IsoCode)
                    .IsRequired()
                    .HasColumnName("iso_code")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Population).HasColumnName("population");

                entity.HasOne(d => d.ContinentCodeNavigation)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.ContinentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_countries_continents");

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.Countries)
                    .HasForeignKey(d => d.CurrencyCode)
                    .HasConstraintName("fk_countries_currencies");
            });

            modelBuilder.Entity<CountriesRivers>(entity =>
            {
                entity.HasKey(e => new { e.RiverId, e.CountryCode })
                    .HasName("PRIMARY");

                entity.ToTable("countries_rivers");

                entity.HasIndex(e => new { e.CountryCode, e.RiverId })
                    .HasName("PK_CountriesRivers")
                    .IsUnique();

                entity.Property(e => e.RiverId).HasColumnName("river_id");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.CountriesRivers)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_countries_rivers_countries");

                entity.HasOne(d => d.River)
                    .WithMany(p => p.CountriesRivers)
                    .HasForeignKey(d => d.RiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_countries_rivers_rivers");
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode)
                    .HasName("PRIMARY");

                entity.ToTable("currencies");

                entity.HasIndex(e => e.CurrencyCode)
                    .HasName("PK_Currencies")
                    .IsUnique();

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("currency_code")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Mountains>(entity =>
            {
                entity.ToTable("mountains");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_Mountains")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MountainRange)
                    .IsRequired()
                    .HasColumnName("mountain_range")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MountainsCountries>(entity =>
            {
                entity.HasKey(e => new { e.MountainId, e.CountryCode })
                    .HasName("PRIMARY");

                entity.ToTable("mountains_countries");

                entity.HasIndex(e => e.CountryCode)
                    .HasName("fk_mountains_countries_mountains");

                entity.HasIndex(e => new { e.MountainId, e.CountryCode })
                    .HasName("PK_MountainsContinents")
                    .IsUnique();

                entity.Property(e => e.MountainId).HasColumnName("mountain_id");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.MountainsCountries)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mountains_countries_mountains");

                entity.HasOne(d => d.Mountain)
                    .WithMany(p => p.MountainsCountries)
                    .HasForeignKey(d => d.MountainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_mountains_countries_countries");
            });

            modelBuilder.Entity<Peaks>(entity =>
            {
                entity.ToTable("peaks");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_Peaks")
                    .IsUnique();

                entity.HasIndex(e => e.MountainId)
                    .HasName("fk_peaks_mountains");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Elevation).HasColumnName("elevation");

                entity.Property(e => e.MountainId).HasColumnName("mountain_id");

                entity.Property(e => e.PeakName)
                    .IsRequired()
                    .HasColumnName("peak_name")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Mountain)
                    .WithMany(p => p.Peaks)
                    .HasForeignKey(d => d.MountainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_peaks_mountains");
            });

            modelBuilder.Entity<Rivers>(entity =>
            {
                entity.ToTable("rivers");

                entity.HasIndex(e => e.Id)
                    .HasName("PK_Rivers")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AverageDischarge).HasColumnName("average_discharge");

                entity.Property(e => e.DrainageArea).HasColumnName("drainage_area");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.Outflow)
                    .IsRequired()
                    .HasColumnName("outflow")
                    .HasMaxLength(50);

                entity.Property(e => e.RiverName)
                    .IsRequired()
                    .HasColumnName("river_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tests>(entity =>
            {
                entity.ToTable("tests");

                entity.Property(e => e.Name).HasMaxLength(20);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
