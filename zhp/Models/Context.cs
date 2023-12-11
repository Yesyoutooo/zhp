using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace zhp.Models;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Előadá> Előadás { get; set; }

    public virtual DbSet<ElőadásHelyszín> ElőadásHelyszíns { get; set; }

    public virtual DbSet<KezdésAdatok> KezdésAdatoks { get; set; }

    public virtual DbSet<OperaAdatok> OperaAdatoks { get; set; }

    public virtual DbSet<RendezésAdatok> RendezésAdatoks { get; set; }

    public virtual DbSet<Zeneszerző> Zeneszerzős { get; set; }

    public virtual DbSet<ÉvadAdatok> ÉvadAdatoks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\balazs\\source\\repos\\zhp\\zhp\\Database1.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Előadá>(entity =>
        {
            entity.HasKey(e => e.ElőadásId).HasName("PK__Előadás__7F2A1E4128E18A48");

            entity.Property(e => e.ElőadásId)
                .ValueGeneratedNever()
                .HasColumnName("ElőadásID");
            entity.Property(e => e.ElőadásokSzáma).HasColumnName("Előadások_száma");
            entity.Property(e => e.KezdésId).HasColumnName("KezdésID");
            entity.Property(e => e.OperaId).HasColumnName("OperaID");
            entity.Property(e => e.PremierDátum)
                .HasColumnType("date")
                .HasColumnName("Premier_dátum");
            entity.Property(e => e.RendezésId).HasColumnName("RendezésID");
            entity.Property(e => e.Város)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ÉvadId).HasColumnName("ÉvadID");

            entity.HasOne(d => d.Kezdés).WithMany(p => p.Előadás)
                .HasForeignKey(d => d.KezdésId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Előadás__KezdésI__4AB81AF0");

            entity.HasOne(d => d.Opera).WithMany(p => p.Előadás)
                .HasForeignKey(d => d.OperaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Előadás__OperaID__4D94879B");

            entity.HasOne(d => d.Rendezés).WithMany(p => p.Előadás)
                .HasForeignKey(d => d.RendezésId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Előadás__Rendezé__4CA06362");

            entity.HasOne(d => d.VárosNavigation).WithMany(p => p.Előadás)
                .HasForeignKey(d => d.Város)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Előadás__Város__49C3F6B7");

            entity.HasOne(d => d.Évad).WithMany(p => p.Előadás)
                .HasForeignKey(d => d.ÉvadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Előadás__ÉvadID__4BAC3F29");
        });

        modelBuilder.Entity<ElőadásHelyszín>(entity =>
        {
            entity.HasKey(e => e.Város).HasName("PK__Előadás___DD21ED614663EC06");

            entity.ToTable("Előadás_Helyszín");

            entity.Property(e => e.Város)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Iso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ISO");
            entity.Property(e => e.Ország)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<KezdésAdatok>(entity =>
        {
            entity.HasKey(e => e.KezdésId).HasName("PK__Kezdés_A__144BDAC635597E1A");

            entity.ToTable("Kezdés_Adatok");

            entity.Property(e => e.KezdésId)
                .ValueGeneratedNever()
                .HasColumnName("KezdésID");
            entity.Property(e => e.KezdésTípus)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Kezdés_típus");
        });

        modelBuilder.Entity<OperaAdatok>(entity =>
        {
            entity.HasKey(e => e.OperaId).HasName("PK__Opera_Ad__3C56D52422B9E286");

            entity.ToTable("Opera_Adatok");

            entity.HasIndex(e => e.OperaCíme, "unique_operacím").IsUnique();

            entity.Property(e => e.OperaId)
                .ValueGeneratedNever()
                .HasColumnName("OperaID");
            entity.Property(e => e.OperaCíme)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Opera_címe");
            entity.Property(e => e.ZeneszerzőId).HasColumnName("ZeneszerzőID");
            entity.Property(e => e.Éneknyelv)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('it')");
            entity.Property(e => e.ŐsbemutatóÉve)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('n. a.')")
                .HasColumnName("Ősbemutató_éve");

            entity.HasOne(d => d.Zeneszerző).WithMany(p => p.OperaAdatoks)
                .HasForeignKey(d => d.ZeneszerzőId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Opera_Ada__Zenes__403A8C7D");
        });

        modelBuilder.Entity<RendezésAdatok>(entity =>
        {
            entity.HasKey(e => e.RendezésId).HasName("PK__Rendezés__BC0FA7013C332EF6");

            entity.ToTable("Rendezés_Adatok");

            entity.Property(e => e.RendezésId)
                .ValueGeneratedNever()
                .HasColumnName("RendezésID");
            entity.Property(e => e.RendezésTípus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Rendezés_típus");
        });

        modelBuilder.Entity<Zeneszerző>(entity =>
        {
            entity.HasKey(e => e.ZenId).HasName("PK__Zeneszer__718D8835C5B2FD48");

            entity.ToTable("Zeneszerző");

            entity.HasIndex(e => e.Név, "unique_név").IsUnique();

            entity.Property(e => e.ZenId)
                .ValueGeneratedNever()
                .HasColumnName("ZenID");
            entity.Property(e => e.HalálDátum)
                .HasColumnType("date")
                .HasColumnName("Halál_dátum");
            entity.Property(e => e.Nem)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Nemzetiség)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Név)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SzületésDátum)
                .HasColumnType("date")
                .HasColumnName("Születés_dátum");
        });

        modelBuilder.Entity<ÉvadAdatok>(entity =>
        {
            entity.HasKey(e => e.ÉvadId).HasName("PK__Évad_Ada__26A0EB5948730E35");

            entity.ToTable("Évad_Adatok");

            entity.Property(e => e.ÉvadId)
                .ValueGeneratedNever()
                .HasColumnName("ÉvadID");
            entity.Property(e => e.ÉvadMegnevezése)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Évad_megnevezése");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
