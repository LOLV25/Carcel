using System;
using System.Collections.Generic;
using Carcel.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Carcel.Context;

public partial class CarcelContext : DbContext
{
    public CarcelContext()
    {
    }

    public CarcelContext(DbContextOptions<CarcelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrador> Administradors { get; set; }

    public virtual DbSet<Guia> Guias { get; set; }

    public virtual DbSet<Pabellon> Pabellons { get; set; }

    public virtual DbSet<Ppl> Ppls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DANYOLVERA\\SQLEXPRESS; Initial Catalog=Carcel; Integrated Security=True; Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__ADMINIST__91136B908CF68AF4");

            entity.ToTable("ADMINISTRADOR");

            entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONTRASENA");
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USUARIO");
        });

        modelBuilder.Entity<Guia>(entity =>
        {
            entity.HasKey(e => e.IdGuias).HasName("PK__GUIAS__1A178DDA571EF6CD");

            entity.ToTable("GUIAS");

            entity.Property(e => e.IdGuias).HasColumnName("ID_GUIAS");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Cedula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.IdPabellon).HasColumnName("ID_PABELLON");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Turno)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TURNO");

            entity.HasOne(d => d.IdPabellonNavigation).WithMany(p => p.Guia)
                .HasForeignKey(d => d.IdPabellon)
                .HasConstraintName("FK__GUIAS__ID_PABELL__3C69FB99");
        });

        modelBuilder.Entity<Pabellon>(entity =>
        {
            entity.HasKey(e => e.IdPabellon).HasName("PK__PABELLON__825E24619C0B84A1");

            entity.ToTable("PABELLON");

            entity.Property(e => e.IdPabellon).HasColumnName("ID_PABELLON");
            entity.Property(e => e.NivelSeguridad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NIVEL_SEGURIDAD");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        });

        modelBuilder.Entity<Ppl>(entity =>
        {
            entity.HasKey(e => e.IdPll).HasName("PK__PPL__20AFCA380A518F13");

            entity.ToTable("PPL");

            entity.Property(e => e.IdPll).HasColumnName("ID_PLL");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Cedula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CEDULA");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("ESTADO");
            entity.Property(e => e.FechaIngreso).HasColumnName("FECHA_INGRESO");
            entity.Property(e => e.FechaSalida).HasColumnName("FECHA_SALIDA");
            //entity.Property(e => e.Foto).HasColumnName("FOTO");
            entity.Property(e => e.IdPabellon).HasColumnName("ID_PABELLON");
            entity.Property(e => e.Motivo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("MOTIVO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            //entity.Property(e => e.Qr).HasColumnName("QR");

            entity.HasOne(d => d.IdPabellonNavigation).WithMany(p => p.Ppls)
                .HasForeignKey(d => d.IdPabellon)
                .HasConstraintName("FK__PPL__ID_PABELLON__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
