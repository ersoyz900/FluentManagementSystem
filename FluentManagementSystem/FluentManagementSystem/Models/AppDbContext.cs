using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FluentManagementSystem.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Gorevler> Gorevlers { get; set; }
    public virtual DbSet<Kategoriler> Kategorilers { get; set; }
    public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }
    public virtual DbSet<OncelikDurumlari> OncelikDurumlaris { get; set; }
    public virtual DbSet<Projeler> Projelers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Bağlantı dizesini buradan sildik. 
        // Artık Program.cs üzerinden appsettings.json dosyasını okuyacak.
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gorevler>(entity =>
        {
            entity.HasKey(e => e.GorevNo).HasName("PK__Gorevler__2BC48AAAC4E03C20");
            entity.ToTable("Gorevler");
            entity.Property(e => e.BitisTarihi).HasColumnType("datetime");
            entity.Property(e => e.GorevBaslik).HasMaxLength(200);
            entity.Property(e => e.TamamlandiMi).HasDefaultValue(false);

            entity.HasOne(d => d.RefKategoriNoNavigation).WithMany(p => p.Gorevlers)
                .HasForeignKey(d => d.RefKategoriNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gorev_Kategori");

            entity.HasOne(d => d.RefKullaniciNoNavigation).WithMany(p => p.Gorevlers)
                .HasForeignKey(d => d.RefKullaniciNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gorev_Kullanici");

            entity.HasOne(d => d.RefOncelikNoNavigation).WithMany(p => p.Gorevlers)
                .HasForeignKey(d => d.RefOncelikNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gorev_Oncelik");

            entity.HasOne(d => d.RefProjeNoNavigation).WithMany(p => p.Gorevlers)
                .HasForeignKey(d => d.RefProjeNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Gorev_Proje");
        });

        modelBuilder.Entity<Kategoriler>(entity =>
        {
            entity.HasKey(e => e.KategoriNo).HasName("PK__Kategori__1785835D863B91A5");
            entity.ToTable("Kategoriler");
            entity.Property(e => e.KategoriAd).HasMaxLength(100);
        });

        modelBuilder.Entity<Kullanicilar>(entity =>
        {
            entity.HasKey(e => e.KullaniciNo).HasName("PK__Kullanic__E011D8E453B99FDD");
            entity.ToTable("Kullanicilar");
            entity.HasIndex(e => e.Eposta, "UQ__Kullanic__03ABA3912A29BA64").IsUnique();
            entity.Property(e => e.AdSoyad).HasMaxLength(100);
            entity.Property(e => e.Departman).HasMaxLength(50);
            entity.Property(e => e.Eposta).HasMaxLength(100);
        });

        modelBuilder.Entity<OncelikDurumlari>(entity =>
        {
            entity.HasKey(e => e.OncelikNo).HasName("PK__OncelikD__C30CDCD3E2A3616C");
            entity.ToTable("OncelikDurumlari");
            entity.Property(e => e.OncelikAd).HasMaxLength(50);
            entity.Property(e => e.RenkKodu).HasMaxLength(7);
        });

        modelBuilder.Entity<Projeler>(entity =>
        {
            entity.HasKey(e => e.ProjeNo).HasName("PK__Projeler__DDFBC54A3CD5A9D5");
            entity.ToTable("Projeler");
            entity.Property(e => e.AktifMi).HasDefaultValue(true);
            entity.Property(e => e.OlusturmaTarihi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProjeAd).HasMaxLength(200);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}